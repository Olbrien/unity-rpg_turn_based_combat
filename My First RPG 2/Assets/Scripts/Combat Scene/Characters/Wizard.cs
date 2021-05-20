using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Wizard : MonoBehaviour
{
    [Header("Stats")]

    public int attack;
    public int magic;

    public int defense;
    public int magicDefense;

    public int maxHealth;
    public int currentHealth;

    public float speed;

    public float iceResistance;
    public float fireResistance;
    public float waterResistance;


    [Header("Speed")]

    [HideInInspector]
    public bool startSpeed;
    public float speedTimer = 0;


    [Header("Move Around")]

    public bool moveToTarget;
    public bool moveToTargetAtTarget;

    public bool moveToStart;
    public bool moveToStartAtStart;

    public bool moveToGrid;
    public bool moveToGridAtGrid;

    Vector3 rotateRight = new Vector3(0, 0, 0);
    Vector3 rotateLeft = new Vector3(0, -180, 0);

    public bool facingRight;
    public bool facingLeft;
    
    public float speedOfMovement;    
    Vector3 startPosition;
    public Vector3 targetPosition;
    public Vector3 gridPosition;

    float xFactor = 1f;
    //float yFactor = 0.1f;


    [Header("State")]

    public bool isDead;

    public bool disappear;
    public bool appear;

    float appearTime;
    float disappearTime = 1;

    bool start = true;


    [Header("Being Attacked Stuff")]

    float levelDifference;
    float theCalculation;


    [Header("Elemental")]

    public bool gettingHitWithIce;
    public bool gettingHitWithFire;
    public bool gettingHitWithWater;


    int temporarySpell;
    float temporaryPercentage;


    [Space(500)]

    public Paladin paladin;
    public GlobalController globalController;

    [Space(20)]

    public Image healthBar;
    public TextMeshProUGUI healthText;
    public Image speedBar;

    [Space(20)]

    public Canvas selectArrowCanvasAndClick;

    [Space(20)]

    public Animator wizardAnimator;

    [Space(20)]

    public FloatController floatController;
    public Transform damageFloatLocation;

    [Space(20)]

    public CanvasGroup thisCanvasGroup;
    public EntireGameControllerCollector entireGameControllerCollector;
    public GridController gridController;

    [Space(20)]

    public Transform shadow;


    void Start()
    {
        // Debug.Log(Animator.StringToHash("AttackOne"));   -       1403048155
        // Debug.Log(Animator.StringToHash("CastSpell"));   -      -2017977412
        // Debug.Log(Animator.StringToHash("GettingHit"));  -      -1946994015
        // Debug.Log(Animator.StringToHash("CastSpell"));   -      -2017977412


        thisCanvasGroup.alpha = 0;
        appear = true;        
    }


    void Update() 
    {
        if (start)
        {
            UpdateWizardStats();
            UpdateHealthBar();
            speedBar.fillAmount = 0;
            start = false;
        }

        if (startSpeed)
        {
            speedTimer += (0.15f + ((speed / 350))) * Time.deltaTime;

            speedBar.fillAmount = speedTimer;

            if (speedTimer >= 1)
            {
                speedBar.fillAmount = 1;

                startSpeed = false;

                globalController.wizardIsReady = true;
                globalController.CharactersAreReady();
                //globalController.StopAllSpeedTime();
            }
        }

        if (moveToTarget)
        {
            startPosition = transform.localPosition;

            if (facingRight)
            {
                transform.localPosition = Vector3.Lerp(startPosition, new Vector3(targetPosition.x + xFactor, targetPosition.y, targetPosition.z), speedOfMovement);
            }

            else if (facingLeft)
            {
                transform.localPosition = Vector3.Lerp(startPosition, new Vector3(targetPosition.x + 2.5f + xFactor, targetPosition.y, targetPosition.z), speedOfMovement);
            }
            

            if (transform.localPosition.x >= (targetPosition.x + xFactor - 0.2f))
            {
                moveToTargetAtTarget = true;
                moveToTarget = false;
            }

            else if (transform.localPosition.x >= (targetPosition.x + xFactor - 0.2f))
            {
                moveToTargetAtTarget = true;
                moveToTarget = false;
            }
        }

        if (moveToStart)
        {
            transform.localPosition = Vector3.Lerp(transform.position, gridPosition, speedOfMovement);

            if (transform.localPosition.x <= gridPosition.x + 0.2f)
            {
                moveToStartAtStart = true;
                moveToStart = false;
            }
        }


        if (moveToGrid)
        {
            startPosition = transform.localPosition;

            transform.localPosition = Vector3.MoveTowards(startPosition, gridPosition, speedOfMovement);

            if (transform.localPosition == new Vector3(gridPosition.x, gridPosition.y, gridPosition.z))
            {
                moveToGridAtGrid = true;
                moveToGrid = false;
            }
        }


        if (appear)
        {
            appearTime += (Time.deltaTime * 0.5f);

            thisCanvasGroup.alpha = appearTime;

            if (appearTime >= 1)
            {
                thisCanvasGroup.alpha = 1;
                appear = false;
                appearTime = 0;
                StartOverSpeedBar();
            }
        }

        if (disappear)
        {
            disappearTime -= (Time.deltaTime * 0.7f);

            thisCanvasGroup.alpha = disappearTime;

            if (disappearTime <= 0)
            {
                thisCanvasGroup.alpha = 0;
                disappear = false;
                disappearTime = 1;
            }
        }
    }


    public void UpdateWizardStats()
    {
        attack = entireGameControllerCollector.wizardAttack;
        magic = entireGameControllerCollector.wizardMagic;

        defense = entireGameControllerCollector.wizardDefense;
        magicDefense = entireGameControllerCollector.wizardMagicDefense;

        maxHealth = entireGameControllerCollector.wizardMaxHealth;
        currentHealth = maxHealth;

        speed = entireGameControllerCollector.wizardSpeed;

        iceResistance = entireGameControllerCollector.wizardIceResistance;
        fireResistance = entireGameControllerCollector.wizardFireResistance;
        waterResistance = entireGameControllerCollector.wizardWaterResistance;
    }



    public void GettingHitFromAttack(int attackerLevel, int attackDamage)
    {
        levelDifference = (globalController.level - attackerLevel) * 2;

        if (levelDifference < 0)
        {
            levelDifference = levelDifference * 8;
        }

        theCalculation = attackDamage - (attackDamage * ((defense + levelDifference) / 100));

        if (theCalculation <= 0 && gettingHitWithIce == false && gettingHitWithFire == false && gettingHitWithWater == false)
        {
            currentHealth -= 0;
            globalController.globalFloatDamage = 0;

            gridController.FlipIfWizardIsAtackingRightOrLeft(); // Also works for getting attacked.

            floatController.DamageFloatPopUpLeftSide(damageFloatLocation.TransformPoint(damageFloatLocation.position));
        }

        else if (theCalculation <= 0 && gettingHitWithIce == true ||
                 theCalculation <= 0 && gettingHitWithFire == true ||
                 theCalculation <= 0 && gettingHitWithWater == true)
        {
            currentHealth -= Mathf.RoundToInt(theCalculation);

            globalController.globalFloatDamage = Mathf.RoundToInt(theCalculation);

            gettingHitWithIce = false;
            gettingHitWithFire = false;
            gettingHitWithWater = false;

            gridController.FlipIfWizardIsAtackingRightOrLeft(); // Also works for getting attacked.

            floatController.DamageFloatPopUpLeftSide(damageFloatLocation.TransformPoint(damageFloatLocation.position));

            UpdateHealthBar();
        }


        if (theCalculation > 0)
        {
            currentHealth -= Mathf.RoundToInt(theCalculation);

            globalController.globalFloatDamage = Mathf.RoundToInt(theCalculation);

            gettingHitWithIce = false;
            gettingHitWithFire = false;
            gettingHitWithWater = false;

            gridController.FlipIfWizardIsAtackingRightOrLeft(); // Also works for getting attacked.

            floatController.DamageFloatPopUpLeftSide(damageFloatLocation.TransformPoint(damageFloatLocation.position));

            UpdateHealthBar();
        }

        if (currentHealth <= 0)
        {
            UpdateHealthBar();

            isDead = true;
            disappear = true;

            startSpeed = false;
            speedTimer = 0;

            //gameController.numberOfEnemies -= 1;
            //gameController.experience += experience;

            //enemyDisappear = true;

            ////MessageOnEventsDead();
            //MessageExperience();
            //gameController.GainingExperience();

            //EnemyLoot();

        }
    }




    public void UpdateHealthBar()
    {
        if (currentHealth <= 0)
        {
            healthText.text = "HP: " + 0.ToString();

            healthBar.fillAmount = 0;
            return;
        }

        if (currentHealth > 0)
        {
            float ratio = (float)currentHealth / (float)maxHealth;

            ratio = Mathf.Clamp01(ratio);
            healthBar.fillAmount = ratio;

            healthText.text = "HP: " + currentHealth.ToString();
        }
    }

    public void StartOverSpeedBar()
    {
        speedTimer = 0;
        startSpeed = true;
        speedBar.fillAmount = speedTimer;
    }


    public void AnimationAttackOneTrue() { wizardAnimator.SetBool(1403048155, true); }
    public void AnimationAttackOneFalse() { wizardAnimator.SetBool(1403048155, false); }
    public void AnimationGettingHitTrue() { wizardAnimator.SetBool(-1946994015, true); }
    public void AnimationGettingHitFalse() { wizardAnimator.SetBool(-1946994015, false); }

    public void AnimationCastSpellTrue() { wizardAnimator.SetBool(-2017977412, true); }
    public void AnimationCastSpellFalse() { wizardAnimator.SetBool(-2017977412, false); }

    public void FlipCharacterToTheRight() { shadow.rotation = Quaternion.Euler(rotateRight.x, rotateRight.y, rotateRight.z);
                                            facingRight = true; facingLeft = false; }
    public void FlipCharacterToTheLeft() { shadow.rotation = Quaternion.Euler(rotateLeft.x, rotateLeft.y, rotateLeft.z);
                                           facingLeft = true; facingRight = false; }





    public int SpellIceOne()
    {
        temporaryPercentage = magic / 100;
        temporaryPercentage = temporaryPercentage * globalController.wizardSpellIceOne;
        temporarySpell = Mathf.RoundToInt(globalController.wizardSpellIceOne + temporaryPercentage);

        Debug.Log(temporarySpell);

        return temporarySpell;
    }

    public int SpellIceTwo()
    {
        temporaryPercentage = magic / 100;
        temporaryPercentage = temporaryPercentage * globalController.wizardSpellIceTwo;
        temporarySpell = Mathf.RoundToInt(globalController.wizardSpellIceTwo + temporaryPercentage);

        Debug.Log(temporarySpell);

        return temporarySpell;
    }

    public int SpellIceThree()
    {
        temporaryPercentage = magic / 100;
        temporaryPercentage = temporaryPercentage * globalController.wizardSpellIceThree;
        temporarySpell = Mathf.RoundToInt(globalController.wizardSpellIceThree + temporaryPercentage);

        Debug.Log(temporarySpell);

        return temporarySpell;
    }

    public int SpellFireOne()
    {
        temporaryPercentage = magic / 100;
        temporaryPercentage = temporaryPercentage * globalController.wizardSpellFireOne;
        temporarySpell = Mathf.RoundToInt(globalController.wizardSpellFireOne + temporaryPercentage);

        return temporarySpell;
    }

    public int SpellFireTwo()
    {
        temporaryPercentage = magic / 100;
        temporaryPercentage = temporaryPercentage * globalController.wizardSpellFireTwo;
        temporarySpell = Mathf.RoundToInt(globalController.wizardSpellFireTwo + temporaryPercentage);

        return temporarySpell;
    }

    public int SpellFireThree()
    {
        temporaryPercentage = magic / 100;
        temporaryPercentage = temporaryPercentage * globalController.wizardSpellFireThree;
        temporarySpell = Mathf.RoundToInt(globalController.wizardSpellFireThree + temporaryPercentage);

        return temporarySpell;
    }

    public int SpellWaterOne()
    {
        temporaryPercentage = magic / 100;
        temporaryPercentage = temporaryPercentage * globalController.wizardSpellWaterOne;
        temporarySpell = Mathf.RoundToInt(globalController.wizardSpellWaterOne + temporaryPercentage);

        return temporarySpell;
    }

    public int SpellWaterTwo()
    {
        temporaryPercentage = magic / 100;
        temporaryPercentage = temporaryPercentage * globalController.wizardSpellWaterTwo;
        temporarySpell = Mathf.RoundToInt(globalController.wizardSpellWaterTwo + temporaryPercentage);

        return temporarySpell;
    }

    public int SpellWaterThree()
    {
        temporaryPercentage = magic / 100;
        temporaryPercentage = temporaryPercentage * globalController.wizardSpellWaterThree;
        temporarySpell = Mathf.RoundToInt(globalController.wizardSpellWaterThree + temporaryPercentage);

        return temporarySpell;
    }
}
