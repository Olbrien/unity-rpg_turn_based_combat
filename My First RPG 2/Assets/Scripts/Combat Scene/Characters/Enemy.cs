using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Enemy : MonoBehaviour
{
    [Header("Enemy")]

    public bool isSlime;

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

    public int level;
    public int experience;


    [Header("Speed")]

    [HideInInspector]
    public bool startSpeed = true;

    public float speedTimer = 0;


    [Header("Grid")]

    public int grid; // 1 2 3 4
    public int gridLocation; // 1 2 3
    public Vector3 gridPosition;

    public bool onMovingToPaladin;
    public bool onMovingToWizard;

    int gridInitialPosition;
    int gridFinalPosition;


    [Header("State")]

    public bool isDead;
    public bool beingAttacked;

    public bool disappear;
    public bool appear;

    float appearTime;
    float disappearTime = 1;

    [Header("Elemental")]

    public bool gettingHitWithIce;
    public bool gettingHitWithFire;
    public bool gettingHitWithWater;


    [Header("Being Attacked Stuff")]

    float levelDifference;
    float theCalculation;


    [Header("Doing an Action")]

    public bool isWaiting;

    public bool stopDoingAnAction;

    int randomNumber;

    float actionTimer;
    int section;


    [Header("Move Around")]
    public bool moveToPaladin;
    public bool moveToPaladinAtTarget;

    public bool moveToWizard;
    public bool moveToWizardAtTarget;

    public bool moveToStart;
    public bool moveToStartAtStart;

    public bool moveToGrid;
    public bool moveToGridAtGrid;

    Vector3 rotateRight = new Vector3(0, 0, 0);
    Vector3 rotateLeft = new Vector3(0, -180, 0);

    public bool facingRight;
    public bool facingLeft;

    
    public float speedOfMovement;    
    Vector3 definiteStartPosition;
    public Vector3 startPosition;    
    float distanceXFromPaladin;
    float distanceYFromPaladin;
    float distanceXFromWizard;
    float distanceYFromWizard;


    [Header("Slime")]

    bool startSlimeAttackOnPaladin;
    bool startSlimeAttackOnWizard;





    float effectDamage;
    float effectResistanceCalculation;

    [Space(500)]

    public Image healthBar;

    public Paladin paladin;
    public Wizard wizard;
    public GlobalController globalController;
    public ClickController clickController;

    public Canvas selectArrowCanvasAndClick;

    public Animator enemyAnimator;

    public FloatController floatController;
    public Transform damageFloatLocation;
    public Transform experienceFloatLocation;

    public ShakingCamera shakingCamera;

    public CanvasGroup thisCanvasGroup;

    public TextMeshProUGUI levelTxt;

    public GridController gridController;

    public EntireGameControllerCollector entireGameControllerCollector;

    [Space(20)]

    public Transform shadow;


    void Start()
    {
        thisCanvasGroup.alpha = 0;
    }

    void Update() 
    {  
        if (onMovingToPaladin)
        { 
            OnMovingToPaladin();
        }

        if (onMovingToWizard)
        {
            OnMovingToWizard();
        }

        if (stopDoingAnAction)
        {
            globalController.enemyUsingAnAction = false;
            globalController.enemyIsReady = false;

            StartOverSpeedBar();

            isWaiting = false;

            globalController.RestartAllSpeedTime();            

            stopDoingAnAction = false;
        }

        if (startSpeed && !isDead)
        {
            speedTimer += (0.15f + ((speed / 350))) * Time.deltaTime;

            if (speedTimer >= 1)
            {
                startSpeed = false;
                isWaiting = true;
            }
        }

        else if (!startSpeed && speedTimer >= 1 && isWaiting && !globalController.enemyIsReady && !globalController.enemyUsingAnAction 
                 && !globalController.paladinUsingAnAction && !globalController.wizardUsingAnAction && !isDead)
        {
            globalController.enemyUsingAnAction = true;
            globalController.enemyIsReady = true;            
            isWaiting = false;
            OnEnemyUsingAnAction();
        }


        if (moveToPaladin)
        {
            startPosition = transform.localPosition;

            if (facingLeft)
            {
                transform.localPosition = Vector3.Lerp(startPosition, new Vector3(paladin.transform.position.x + distanceXFromPaladin, paladin.transform.position.y + distanceYFromPaladin, paladin.transform.position.z), speedOfMovement);
            }

            else if (facingRight)
            {
                transform.localPosition = Vector3.Lerp(startPosition, new Vector3(paladin.transform.position.x - 1 + distanceXFromPaladin, paladin.transform.position.y + distanceYFromPaladin, paladin.transform.position.z), speedOfMovement);
            }
            

            if (transform.localPosition.x <= (paladin.transform.position.x + distanceXFromPaladin + 0.2f))
            {
                moveToPaladinAtTarget = true;
                moveToPaladin = false;
            }

            else if (transform.localPosition.x <= (paladin.transform.position.x - 1 + distanceXFromPaladin + 0.2f))
            {
                moveToPaladinAtTarget = true;
                moveToPaladin = false;
            }
        }

        if (moveToWizard)
        {
            startPosition = transform.localPosition;

            if (facingLeft)
            {
                transform.localPosition = Vector3.Lerp(startPosition, new Vector3(wizard.transform.position.x + distanceXFromWizard, wizard.transform.position.y + distanceYFromWizard, wizard.transform.position.z), speedOfMovement);
            }

            else if (facingRight)
            {
                transform.localPosition = Vector3.Lerp(startPosition, new Vector3(wizard.transform.position.x - 1 + distanceXFromWizard, wizard.transform.position.y + distanceYFromWizard, wizard.transform.position.z), speedOfMovement);
            }


            if (transform.localPosition.x <= (wizard.transform.position.x + distanceXFromWizard + 0.2f))
            {
                moveToWizardAtTarget = true;
                moveToWizard = false;
            }

            else if (transform.localPosition.x <= (wizard.transform.position.x - 1 + distanceXFromWizard + 0.2f))
            {
                moveToWizardAtTarget = true;
                moveToWizard = false;
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



        if (moveToStart)
        {
            transform.localPosition = Vector3.Lerp(transform.position, gridPosition, speedOfMovement);

            if (transform.localPosition.x >= gridPosition.x - 0.2f)
            {
                moveToStartAtStart = true;
                moveToStart = false;
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
            }
        }

        if (disappear)
        {
            disappearTime -= (Time.deltaTime * 0.5f);

            thisCanvasGroup.alpha = disappearTime;

            if (disappearTime <= 0)
            {
                thisCanvasGroup.alpha = 0;
                disappear = false;
                disappearTime = 1;
            }
        }



    }

    void FixedUpdate()
    {
        SlimeAttackPaladinUpdate();
        SlimeAttackWizardUpdate();
    }


    public void StartMethods()
    {
        startPosition = transform.position;
        definiteStartPosition = transform.position;        
    }

    public void UpdateHealthBar()
    {
        if (currentHealth <= 0)
        {
            healthBar.fillAmount = 0;
            return;
        }

        if (currentHealth > 0)
        {
            float ratio = (float)currentHealth / (float)maxHealth;

            ratio = Mathf.Clamp01(ratio);
            healthBar.fillAmount = ratio;
        }
    }


    public void StartOverSpeedBar()
    {
        speedTimer = 0;
        startSpeed = true;        
    }

    public void EnableSelectArrowAndClickButton() { selectArrowCanvasAndClick.enabled = true; }
    public void DisableSelectArrowAndClickButton() { selectArrowCanvasAndClick.enabled = false; }

    public void OnClickClickButton()
    {
        if (globalController.paladinUsingAnAction || globalController.wizardUsingAnAction || globalController.enemyUsingAnAction)
        {
            return;
        }

        gridController.enemyGridLocationTemporary = grid;        

        if (globalController.paladinUsingAttack)
        {
            gridController.CheckDistancePaladin();

            if (gridController.distance > 1)
            {
                Debug.Log("Distance is " + gridController.distance);
                return;
            }
        }

        else if (globalController.wizardUsingAttack)
        {
            gridController.CheckDistanceWizard();

            if (gridController.distance > 1)
            {
                Debug.Log("Distance is " + gridController.distance);
                return;
            }
        }

        beingAttacked = true;
        clickController.OnClickControllerButton(transform.position);
    }


    public void AnimationAttackOneTrue() { enemyAnimator.SetBool(1403048155, true); }
    public void AnimationAttackOneFalse() { enemyAnimator.SetBool(1403048155, false); }
    public void AnimationGettingHitTrue() { enemyAnimator.SetBool(-1946994015, true); }
    public void AnimationGettingHitFalse() { enemyAnimator.SetBool(-1946994015, false); }




    public void GettingHit(int attackerLevel, int damage)
    {
        levelDifference = (level - attackerLevel) * 2;

        if (levelDifference < 0)
        {
            levelDifference = levelDifference * 8;
        }

        if (globalController.wizardUsingAttack)
        {
            theCalculation = damage - (damage * ((defense + levelDifference) / 100));            
        }

        else if (globalController.paladinUsingAttack && entireGameControllerCollector.bronzeSabreEquiped)
        {
            effectDamage = 50;
            effectResistanceCalculation = Mathf.RoundToInt((effectDamage * fireResistance / 100));

            effectDamage -= effectResistanceCalculation;

            theCalculation = effectDamage - (effectDamage * ((magicDefense + levelDifference) / 100));

            theCalculation = theCalculation + (damage - (damage * ((defense + levelDifference) / 100)));
        }

        else if (globalController.paladinUsingAttack && entireGameControllerCollector.silverSabreEquiped)
        {
            effectDamage = 50;
            effectResistanceCalculation = Mathf.RoundToInt((effectDamage * iceResistance / 100));

            effectDamage -= effectResistanceCalculation;

            theCalculation = effectDamage - (effectDamage * ((magicDefense + levelDifference) / 100));

            theCalculation = theCalculation + (damage - (damage * ((defense + levelDifference) / 100)));
        }

        else if (globalController.paladinUsingAttack && entireGameControllerCollector.goldSabreEquiped)
        {
            effectDamage = 50;
            effectResistanceCalculation = Mathf.RoundToInt((effectDamage * waterResistance / 100));

            effectDamage -= effectResistanceCalculation;

            theCalculation = effectDamage - (effectDamage * ((magicDefense + levelDifference) / 100));

            theCalculation = theCalculation + (damage - (damage * ((defense + levelDifference) / 100)));
        }



        else if (globalController.paladinUsingAttack && entireGameControllerCollector.strongholdSabreEquiped)
        {
            effectDamage = 200;
            effectResistanceCalculation = Mathf.RoundToInt((effectDamage * fireResistance / 100));

            effectDamage -= effectResistanceCalculation;

            theCalculation = effectDamage - (effectDamage * ((magicDefense + levelDifference) / 100));

            theCalculation = theCalculation + (damage - (damage * ((defense + levelDifference) / 100)));
        }

        else if (globalController.paladinUsingAttack && entireGameControllerCollector.verminardSabreEquiped)
        {
            effectDamage = 200;
            effectResistanceCalculation = Mathf.RoundToInt((effectDamage * iceResistance / 100));

            effectDamage -= effectResistanceCalculation;

            theCalculation = effectDamage - (effectDamage * ((magicDefense + levelDifference) / 100));

            theCalculation = theCalculation + (damage - (damage * ((defense + levelDifference) / 100)));
        }

        else if (globalController.paladinUsingAttack && entireGameControllerCollector.adamantineSabreEquiped)
        {
            effectDamage = 200;
            effectResistanceCalculation = Mathf.RoundToInt((effectDamage * waterResistance / 100));

            effectDamage -= effectResistanceCalculation;

            theCalculation = effectDamage - (effectDamage * ((magicDefense + levelDifference) / 100));

            theCalculation = theCalculation + (damage - (damage * ((defense + levelDifference) / 100)));
        }


        else if (globalController.paladinUsingAttack && entireGameControllerCollector.bronzeSabreEquiped == false &&
                                                        entireGameControllerCollector.silverSabreEquiped == false &&
                                                        entireGameControllerCollector.goldSabreEquiped == false &&
                                                        entireGameControllerCollector.strongholdSabreEquiped == false &&
                                                        entireGameControllerCollector.verminardSabreEquiped == false &&
                                                        entireGameControllerCollector.adamantineSabreEquiped == false)
        {
            theCalculation = damage - (damage * ((defense + levelDifference) / 100));
        }


        else if (globalController.wizardUsingSpell && gettingHitWithIce ||
                 globalController.wizardUsingSpell && gettingHitWithFire || globalController.wizardUsingSpell && gettingHitWithWater)
        {
            if (gettingHitWithIce)
            {
                effectDamage = damage;
                effectResistanceCalculation = Mathf.RoundToInt((effectDamage * iceResistance / 100));

                effectDamage -= effectResistanceCalculation;

                theCalculation = effectDamage - (effectDamage * ((magicDefense + levelDifference) / 100));
            }

            else if (gettingHitWithFire)
            {
                effectDamage = damage;
                effectResistanceCalculation = Mathf.RoundToInt((effectDamage * fireResistance / 100));

                effectDamage -= effectResistanceCalculation;

                theCalculation = effectDamage - (effectDamage * ((magicDefense + levelDifference) / 100));
            }

            else if (gettingHitWithWater)
            {
                effectDamage = damage;
                effectResistanceCalculation = Mathf.RoundToInt((effectDamage * waterResistance / 100));

                effectDamage -= effectResistanceCalculation;

                theCalculation = effectDamage - (effectDamage * ((magicDefense + levelDifference) / 100));
            }
        }

        else if (globalController.paladinUsingSpell || globalController.wizardUsingSpell && gettingHitWithIce == false
            && gettingHitWithFire == false && gettingHitWithWater == false)
        {
            theCalculation = damage - (damage * ((magicDefense + levelDifference) / 100));
        }

        if (theCalculation <= 0 && gettingHitWithIce == false && gettingHitWithFire == false && gettingHitWithWater == false)
        {
            currentHealth -= 0;
            globalController.globalFloatDamage = 0;

            floatController.DamageFloatPopUpRightSide(damageFloatLocation.TransformPoint(damageFloatLocation.position));
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

            floatController.DamageFloatPopUpRightSide(damageFloatLocation.TransformPoint(damageFloatLocation.position));

            UpdateHealthBar();
        }


        if (theCalculation > 0)
        {
            currentHealth -= Mathf.RoundToInt(theCalculation);

            globalController.globalFloatDamage = Mathf.RoundToInt(theCalculation);

            gettingHitWithIce = false;
            gettingHitWithFire = false;
            gettingHitWithWater = false;

            floatController.DamageFloatPopUpRightSide(damageFloatLocation.TransformPoint(damageFloatLocation.position));

            UpdateHealthBar();
        }

        if (currentHealth <= 0)
        {
            UpdateHealthBar();

            EnemyDied();

            //MessageOnEventsDead();
            //MessageExperience();
            //gameController.GainingExperience();

            //EnemyLoot();
        }
    }


    public void FlipCharacterToTheRight() { shadow.rotation = Quaternion.Euler(rotateRight.x, rotateRight.y, rotateRight.z);
                                            facingRight = true; facingLeft = false; }
    public void FlipCharacterToTheLeft() { shadow.rotation = Quaternion.Euler(rotateLeft.x, rotateLeft.y, rotateLeft.z);
                                           facingLeft = true; facingRight = false; }

    public void UpdateLevelText()
    {
        levelTxt.text = level.ToString();
    }


    public void EnemyDied()
    {
        isDead = true;
        disappear = true;

        startSpeed = false;
        speedTimer = 0;

        globalController.enemiesInGame -= 1;
        globalController.UpdateStageController();

        DisableInTheGrid();

        floatController.ExperienceFloatPopUp(experience);

        entireGameControllerCollector.experience += experience;
        globalController.UpdateLevelAndExperience();
    }


    void DisableInTheGrid()
    {
        if (grid == 1 && gridLocation == 1) { gridController.gridOneEnemyLocationOne = false; }
        else if (grid == 1 && gridLocation == 2) { gridController.gridOneEnemyLocationTwo = false; }
        else if (grid == 1 && gridLocation == 3) { gridController.gridOneEnemyLocationThree = false; }

        else if (grid == 2 && gridLocation == 1) { gridController.gridTwoEnemyLocationOne = false; }
        else if (grid == 2 && gridLocation == 2) { gridController.gridTwoEnemyLocationTwo = false; }
        else if (grid == 2 && gridLocation == 3) { gridController.gridTwoEnemyLocationThree = false; }

        else if (grid == 3 && gridLocation == 1) { gridController.gridThreeEnemyLocationOne = false; }
        else if (grid == 3 && gridLocation == 2) { gridController.gridThreeEnemyLocationTwo = false; }
        else if (grid == 3 && gridLocation == 3) { gridController.gridThreeEnemyLocationThree = false; }

        else if (grid == 4 && gridLocation == 1) { gridController.gridFourEnemyLocationOne = false; }
        else if (grid == 4 && gridLocation == 2) { gridController.gridFourEnemyLocationTwo = false; }
        else if (grid == 4 && gridLocation == 3) { gridController.gridFourEnemyLocationThree = false; }
    }


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////                                                                                        ///////////////////
    //////////                                        Enemy Attack Controller                                       ////////////
    /////////////////                                                                                        ///////////////////
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    public void MoveCloserToPaladin()
    {
        if (grid == 1 && gridController.gridThreePaladinLocationOne)
        {
            gridInitialPosition = 1;

            if (gridController.gridTwoWizardLocationOne)
            {
                Debug.Log("Wizard is in position 2");
                stopDoingAnAction = true;
                return;
            }

            else if (gridController.gridTwoEnemyLocationOne && gridController.gridTwoEnemyLocationTwo &&
                gridController.gridTwoEnemyLocationThree)
            {
                Debug.Log("All locations filled on position 2");
                stopDoingAnAction = true;
                return;
            }

            else if (!gridController.gridTwoEnemyLocationTwo)
            {
                DisableInTheGrid();
                gridController.gridTwoEnemyLocationTwo = true;
                grid = 2;
                gridLocation = 2;

                gridFinalPosition = 2;

                FlipCharacterToTheRight();

                gridPosition = gridController.gridTwoEnemyLocationTwoPosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToPaladin = true;
            }

            else if (!gridController.gridTwoEnemyLocationOne)
            {
                DisableInTheGrid();
                gridController.gridTwoEnemyLocationOne = true;
                grid = 2;
                gridLocation = 1;

                gridFinalPosition = 2;

                FlipCharacterToTheRight();

                gridPosition = gridController.gridTwoEnemyLocationOnePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToPaladin = true;
            }

            else if (!gridController.gridTwoEnemyLocationThree)
            {
                DisableInTheGrid();
                gridController.gridTwoEnemyLocationThree = true;
                grid = 2;
                gridLocation = 3;

                gridFinalPosition = 2;

                FlipCharacterToTheRight();

                gridPosition = gridController.gridTwoEnemyLocationThreePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToPaladin = true;
            }

            return;
        }

        else if (grid == 1 && gridController.gridFourPaladinLocationOne)
        {
            gridInitialPosition = 1;

            if (gridController.gridTwoWizardLocationOne)
            {
                Debug.Log("Wizard is in position 2");
                stopDoingAnAction = true;
                return;
            }

            else if (gridController.gridTwoEnemyLocationOne && gridController.gridTwoEnemyLocationTwo &&
                gridController.gridTwoEnemyLocationThree)
            {
                Debug.Log("All locations filled on position 2");
                stopDoingAnAction = true;
                return;
            }

            else if (!gridController.gridTwoEnemyLocationTwo)
            {
                DisableInTheGrid();
                gridController.gridTwoEnemyLocationTwo = true;

                grid = 2;
                gridLocation = 2;

                gridFinalPosition = 2;

                FlipCharacterToTheRight();

                gridPosition = gridController.gridTwoEnemyLocationTwoPosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToPaladin = true;
            }

            else if (!gridController.gridTwoEnemyLocationOne)
            {
                DisableInTheGrid();
                gridController.gridTwoEnemyLocationOne = true;

                grid = 2;
                gridLocation = 1;

                gridFinalPosition = 2;

                FlipCharacterToTheRight();

                gridPosition = gridController.gridTwoEnemyLocationOnePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToPaladin = true;
            }

            else if (!gridController.gridTwoEnemyLocationThree)
            {
                DisableInTheGrid();
                gridController.gridTwoEnemyLocationThree = true;

                grid = 2;
                gridLocation = 3;

                gridFinalPosition = 2;

                FlipCharacterToTheRight();

                gridPosition = gridController.gridTwoEnemyLocationThreePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToPaladin = true;
            }

            return;
        }

        else if (grid == 2 && gridController.gridFourPaladinLocationOne)
        {
            gridInitialPosition = 2;

            if (gridController.gridThreeWizardLocationOne)
            {
                Debug.Log("Wizard is in position 3");
                stopDoingAnAction = true;

                return;
            }

            else if (gridController.gridThreeEnemyLocationOne && gridController.gridThreeEnemyLocationTwo &&
                gridController.gridThreeEnemyLocationThree)
            {
                Debug.Log("All locations filled on position 3");
                stopDoingAnAction = true;

                return;
            }

            else if (!gridController.gridThreeEnemyLocationTwo)
            {
                DisableInTheGrid();
                gridController.gridThreeEnemyLocationTwo = true;

                grid = 3;
                gridLocation = 2;

                gridFinalPosition = 3;

                FlipCharacterToTheRight();

                gridPosition = gridController.gridThreeEnemyLocationTwoPosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToPaladin = true;
            }

            else if (!gridController.gridThreeEnemyLocationOne)
            {
                DisableInTheGrid();
                gridController.gridThreeEnemyLocationOne = true;

                grid = 3;
                gridLocation = 1;

                gridFinalPosition = 3;

                FlipCharacterToTheRight();

                gridPosition = gridController.gridThreeEnemyLocationOnePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToPaladin = true;
            }

            else if (!gridController.gridThreeEnemyLocationThree)
            {
                DisableInTheGrid();
                gridController.gridThreeEnemyLocationThree = true;

                grid = 3;
                gridLocation = 3;

                gridFinalPosition = 3;

                FlipCharacterToTheRight();

                gridPosition = gridController.gridThreeEnemyLocationThreePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToPaladin = true;
            }

            return;
        }

        else if (grid == 3 && gridController.gridOnePaladinLocationOne)
        {
            gridInitialPosition = 3;

            if (gridController.gridTwoWizardLocationOne)
            {
                Debug.Log("Wizard is in position 2");
                stopDoingAnAction = true;
                return;
            }

            else if (gridController.gridTwoEnemyLocationOne && gridController.gridTwoEnemyLocationTwo &&
                gridController.gridTwoEnemyLocationThree)
            {
                Debug.Log("All locations filled on position 2");
                stopDoingAnAction = true;
                return;
            }

            else if (!gridController.gridTwoEnemyLocationTwo)
            {
                DisableInTheGrid();
                gridController.gridTwoEnemyLocationTwo = true;

                grid = 2;
                gridLocation = 2;

                gridFinalPosition = 2;

                FlipCharacterToTheLeft();

                gridPosition = gridController.gridTwoEnemyLocationTwoPosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToPaladin = true;
            }

            else if (!gridController.gridTwoEnemyLocationOne)
            {
                DisableInTheGrid();
                gridController.gridTwoEnemyLocationOne = true;

                grid = 2;
                gridLocation = 1;

                gridFinalPosition = 2;

                FlipCharacterToTheLeft();

                gridPosition = gridController.gridTwoEnemyLocationOnePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToPaladin = true;
            }

            else if (!gridController.gridTwoEnemyLocationThree)
            {
                DisableInTheGrid();
                gridController.gridTwoEnemyLocationThree = true;

                grid = 2;
                gridLocation = 3;

                gridFinalPosition = 2;

                FlipCharacterToTheLeft();

                gridPosition = gridController.gridTwoEnemyLocationThreePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToPaladin = true;
            }

            return;
        }

        else if (grid == 4 && gridController.gridTwoPaladinLocationOne)
        {
            gridInitialPosition = 4;

            if (gridController.gridThreeWizardLocationOne)
            {
                Debug.Log("Wizard is in position 3");
                stopDoingAnAction = true;
                return;
            }

            else if (gridController.gridThreeEnemyLocationOne && gridController.gridThreeEnemyLocationTwo &&
                gridController.gridThreeEnemyLocationThree)
            {
                Debug.Log("All locations filled on position 3");
                stopDoingAnAction = true;
                return;
            }

            else if (!gridController.gridThreeEnemyLocationTwo)
            {
                DisableInTheGrid();
                gridController.gridThreeEnemyLocationTwo = true;

                grid = 3;
                gridLocation = 2;

                gridFinalPosition = 3;

                FlipCharacterToTheLeft();

                gridPosition = gridController.gridThreeEnemyLocationTwoPosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToPaladin = true;
            }

            else if (!gridController.gridThreeEnemyLocationOne)
            {
                DisableInTheGrid();
                gridController.gridThreeEnemyLocationOne = true;

                grid = 3;
                gridLocation = 1;

                gridFinalPosition = 3;

                FlipCharacterToTheLeft();

                gridPosition = gridController.gridThreeEnemyLocationOnePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToPaladin = true;
            }

            else if (!gridController.gridThreeEnemyLocationThree)
            {
                DisableInTheGrid();
                gridController.gridThreeEnemyLocationThree = true;

                grid = 3;
                gridLocation = 3;

                gridFinalPosition = 3;

                FlipCharacterToTheLeft();

                gridPosition = gridController.gridThreeEnemyLocationThreePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToPaladin = true;
            }
        }

        else if (grid == 4 && gridController.gridOnePaladinLocationOne)
        {
            gridInitialPosition = 4;

            if (gridController.gridThreeWizardLocationOne)
            {
                Debug.Log("Wizard is in position 3");
                stopDoingAnAction = true;
                return;
            }

            else if (gridController.gridThreeEnemyLocationOne && gridController.gridThreeEnemyLocationTwo &&
                gridController.gridThreeEnemyLocationThree)
            {
                Debug.Log("All locations filled on position 3");
                stopDoingAnAction = true;
                return;
            }

            else if (!gridController.gridThreeEnemyLocationTwo)
            {
                DisableInTheGrid();
                gridController.gridThreeEnemyLocationTwo = true;

                grid = 3;
                gridLocation = 2;

                gridFinalPosition = 3;

                FlipCharacterToTheLeft();

                gridPosition = gridController.gridThreeEnemyLocationTwoPosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToPaladin = true;
            }

            else if (!gridController.gridThreeEnemyLocationOne)
            {
                DisableInTheGrid();
                gridController.gridThreeEnemyLocationOne = true;

                grid = 3;
                gridLocation = 1;

                gridFinalPosition = 3;

                FlipCharacterToTheLeft();

                gridPosition = gridController.gridThreeEnemyLocationOnePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToPaladin = true;
            }

            else if (!gridController.gridThreeEnemyLocationThree)
            {
                DisableInTheGrid();
                gridController.gridThreeEnemyLocationThree = true;

                grid = 3;
                gridLocation = 3;

                gridFinalPosition = 3;

                FlipCharacterToTheLeft();

                gridPosition = gridController.gridThreeEnemyLocationThreePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToPaladin = true;
            }
        }

    }




    public void MoveCloserToWizard()
    {
        if (grid == 1 && gridController.gridThreeWizardLocationOne)
        {
            gridInitialPosition = 1;

            if (gridController.gridTwoPaladinLocationOne)
            {
                Debug.Log("Paladin is in position 2");
                stopDoingAnAction = true;
                return;
            }

            else if (gridController.gridTwoEnemyLocationOne && gridController.gridTwoEnemyLocationTwo &&
                gridController.gridTwoEnemyLocationThree)
            {
                Debug.Log("All locations filled on position 2");
                stopDoingAnAction = true;
                return;
            }

            else if (!gridController.gridTwoEnemyLocationTwo)
            {
                DisableInTheGrid();
                gridController.gridTwoEnemyLocationTwo = true;
                grid = 2;
                gridLocation = 2;

                gridFinalPosition = 2;

                FlipCharacterToTheRight();

                gridPosition = gridController.gridTwoEnemyLocationTwoPosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToWizard = true;
            }

            else if (!gridController.gridTwoEnemyLocationOne)
            {
                DisableInTheGrid();
                gridController.gridTwoEnemyLocationOne = true;
                grid = 2;
                gridLocation = 1;

                gridFinalPosition = 2;

                FlipCharacterToTheRight();

                gridPosition = gridController.gridTwoEnemyLocationOnePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToWizard = true;
            }

            else if (!gridController.gridTwoEnemyLocationThree)
            {
                DisableInTheGrid();
                gridController.gridTwoEnemyLocationThree = true;
                grid = 2;
                gridLocation = 3;

                gridFinalPosition = 2;

                FlipCharacterToTheRight();

                gridPosition = gridController.gridTwoEnemyLocationThreePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToWizard = true;
            }

            return;
        }

        else if (grid == 1 && gridController.gridFourWizardLocationOne)
        {
            gridInitialPosition = 1;

            if (gridController.gridTwoPaladinLocationOne)
            {
                Debug.Log("Paladin is in position 2");
                stopDoingAnAction = true;
                return;
            }

            else if (gridController.gridTwoEnemyLocationOne && gridController.gridTwoEnemyLocationTwo &&
                gridController.gridTwoEnemyLocationThree)
            {
                Debug.Log("All locations filled on position 2");
                stopDoingAnAction = true;
                return;
            }

            else if (!gridController.gridTwoEnemyLocationTwo)
            {
                DisableInTheGrid();
                gridController.gridTwoEnemyLocationTwo = true;

                grid = 2;
                gridLocation = 2;

                gridFinalPosition = 2;

                FlipCharacterToTheRight();

                gridPosition = gridController.gridTwoEnemyLocationTwoPosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToWizard = true;
            }

            else if (!gridController.gridTwoEnemyLocationOne)
            {
                DisableInTheGrid();
                gridController.gridTwoEnemyLocationOne = true;

                grid = 2;
                gridLocation = 1;

                gridFinalPosition = 2;

                FlipCharacterToTheRight();

                gridPosition = gridController.gridTwoEnemyLocationOnePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToWizard = true;
            }

            else if (!gridController.gridTwoEnemyLocationThree)
            {
                DisableInTheGrid();
                gridController.gridTwoEnemyLocationThree = true;

                grid = 2;
                gridLocation = 3;

                gridFinalPosition = 2;

                FlipCharacterToTheRight();

                gridPosition = gridController.gridTwoEnemyLocationThreePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToWizard = true;
            }

            return;
        }

        else if (grid == 2 && gridController.gridFourWizardLocationOne)
        {
            gridInitialPosition = 2;

            if (gridController.gridThreePaladinLocationOne)
            {
                Debug.Log("Paladin is in position 3");
                stopDoingAnAction = true;

                return;
            }

            else if (gridController.gridThreeEnemyLocationOne && gridController.gridThreeEnemyLocationTwo &&
                gridController.gridThreeEnemyLocationThree)
            {
                Debug.Log("All locations filled on position 3");
                stopDoingAnAction = true;

                return;
            }

            else if (!gridController.gridThreeEnemyLocationTwo)
            {
                DisableInTheGrid();
                gridController.gridThreeEnemyLocationTwo = true;

                grid = 3;
                gridLocation = 2;

                gridFinalPosition = 3;

                FlipCharacterToTheRight();

                gridPosition = gridController.gridThreeEnemyLocationTwoPosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToWizard = true;
            }

            else if (!gridController.gridThreeEnemyLocationOne)
            {
                DisableInTheGrid();
                gridController.gridThreeEnemyLocationOne = true;

                grid = 3;
                gridLocation = 1;

                gridFinalPosition = 3;

                FlipCharacterToTheRight();

                gridPosition = gridController.gridThreeEnemyLocationOnePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToWizard = true;
            }

            else if (!gridController.gridThreeEnemyLocationThree)
            {
                DisableInTheGrid();
                gridController.gridThreeEnemyLocationThree = true;

                grid = 3;
                gridLocation = 3;

                gridFinalPosition = 3;

                FlipCharacterToTheRight();

                gridPosition = gridController.gridThreeEnemyLocationThreePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToWizard = true;
            }

            return;
        }

        else if (grid == 3 && gridController.gridOneWizardLocationOne)
        {
            gridInitialPosition = 3;

            if (gridController.gridTwoPaladinLocationOne)
            {
                Debug.Log("Paladin is in position 2");
                stopDoingAnAction = true;
                return;
            }

            else if (gridController.gridTwoEnemyLocationOne && gridController.gridTwoEnemyLocationTwo &&
                gridController.gridTwoEnemyLocationThree)
            {
                Debug.Log("All locations filled on position 2");
                stopDoingAnAction = true;
                return;
            }

            else if (!gridController.gridTwoEnemyLocationTwo)
            {
                DisableInTheGrid();
                gridController.gridTwoEnemyLocationTwo = true;

                grid = 2;
                gridLocation = 2;

                gridFinalPosition = 2;

                FlipCharacterToTheLeft();

                gridPosition = gridController.gridTwoEnemyLocationTwoPosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToWizard = true;
            }

            else if (!gridController.gridTwoEnemyLocationOne)
            {
                DisableInTheGrid();
                gridController.gridTwoEnemyLocationOne = true;

                grid = 2;
                gridLocation = 1;

                gridFinalPosition = 2;

                FlipCharacterToTheLeft();

                gridPosition = gridController.gridTwoEnemyLocationOnePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToWizard = true;
            }

            else if (!gridController.gridTwoEnemyLocationThree)
            {
                DisableInTheGrid();
                gridController.gridTwoEnemyLocationThree = true;

                grid = 2;
                gridLocation = 3;

                gridFinalPosition = 2;

                FlipCharacterToTheLeft();

                gridPosition = gridController.gridTwoEnemyLocationThreePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToWizard = true;
            }

            return;
        }

        else if (grid == 4 && gridController.gridTwoWizardLocationOne)
        {
            gridInitialPosition = 4;

            if (gridController.gridThreePaladinLocationOne)
            {
                Debug.Log("Paladin is in position 3");
                stopDoingAnAction = true;
                return;
            }

            else if (gridController.gridThreeEnemyLocationOne && gridController.gridThreeEnemyLocationTwo &&
                gridController.gridThreeEnemyLocationThree)
            {
                Debug.Log("All locations filled on position 3");
                stopDoingAnAction = true;
                return;
            }

            else if (!gridController.gridThreeEnemyLocationTwo)
            {
                DisableInTheGrid();
                gridController.gridThreeEnemyLocationTwo = true;

                grid = 3;
                gridLocation = 2;

                gridFinalPosition = 3;

                FlipCharacterToTheLeft();

                gridPosition = gridController.gridThreeEnemyLocationTwoPosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToWizard = true;
            }

            else if (!gridController.gridThreeEnemyLocationOne)
            {
                DisableInTheGrid();
                gridController.gridThreeEnemyLocationOne = true;

                grid = 3;
                gridLocation = 1;

                gridFinalPosition = 3;

                FlipCharacterToTheLeft();

                gridPosition = gridController.gridThreeEnemyLocationOnePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToWizard = true;
            }

            else if (!gridController.gridThreeEnemyLocationThree)
            {
                DisableInTheGrid();
                gridController.gridThreeEnemyLocationThree = true;

                grid = 3;
                gridLocation = 3;

                gridFinalPosition = 3;

                FlipCharacterToTheLeft();

                gridPosition = gridController.gridThreeEnemyLocationThreePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToWizard = true;
            }
        }

        else if (grid == 4 && gridController.gridOneWizardLocationOne)
        {
            gridInitialPosition = 4;

            if (gridController.gridThreePaladinLocationOne)
            {
                Debug.Log("Paladin is in position 3");
                stopDoingAnAction = true;
                return;
            }

            else if (gridController.gridThreeEnemyLocationOne && gridController.gridThreeEnemyLocationTwo &&
                gridController.gridThreeEnemyLocationThree)
            {
                Debug.Log("All locations filled on position 3");
                stopDoingAnAction = true;
                return;
            }

            else if (!gridController.gridThreeEnemyLocationTwo)
            {
                DisableInTheGrid();
                gridController.gridThreeEnemyLocationTwo = true;

                grid = 3;
                gridLocation = 2;

                gridFinalPosition = 3;

                FlipCharacterToTheLeft();

                gridPosition = gridController.gridThreeEnemyLocationTwoPosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToWizard = true;
            }

            else if (!gridController.gridThreeEnemyLocationOne)
            {
                DisableInTheGrid();
                gridController.gridThreeEnemyLocationOne = true;

                grid = 3;
                gridLocation = 1;

                gridFinalPosition = 3;

                FlipCharacterToTheLeft();

                gridPosition = gridController.gridThreeEnemyLocationOnePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToWizard = true;
            }

            else if (!gridController.gridThreeEnemyLocationThree)
            {
                DisableInTheGrid();
                gridController.gridThreeEnemyLocationThree = true;

                grid = 3;
                gridLocation = 3;

                gridFinalPosition = 3;

                FlipCharacterToTheLeft();

                gridPosition = gridController.gridThreeEnemyLocationThreePosition;
                moveToGrid = true;

                globalController.enemyUsingAnAction = true;
                globalController.enemyIsReady = false;

                onMovingToWizard = true;
            }
        }

    }



    void OnMovingToPaladin()
    {
        if (moveToGridAtGrid)
        {            
            globalController.enemyUsingAnAction = false;

            StartOverSpeedBar();

            globalController.RestartAllSpeedTime();

            moveToGridAtGrid = false;
            onMovingToPaladin = false;

            if (gridFinalPosition == 1) { FlipCharacterToTheRight(); return; }

            else if (gridFinalPosition == 2)
            {
                if (gridController.gridOnePaladinLocationOne)
                {
                    FlipCharacterToTheLeft();
                    return;
                }

                else  
                {
                    FlipCharacterToTheRight();
                    return;
                }
            }

            else if (gridFinalPosition == 3)
            {
                if (gridController.gridFourPaladinLocationOne)
                {
                    FlipCharacterToTheRight();
                    return;
                }

                else 
                {
                    FlipCharacterToTheLeft();
                    return;
                }
            }

            else if (gridFinalPosition == 4) { FlipCharacterToTheLeft(); return; }

        }

        else if (!moveToGridAtGrid)
        {
            globalController.StopAllSpeedTime();
        }
    }



    void OnMovingToWizard()
    {
        if (moveToGridAtGrid)
        {
            globalController.enemyUsingAnAction = false;

            StartOverSpeedBar();

            globalController.RestartAllSpeedTime();

            moveToGridAtGrid = false;
            onMovingToWizard = false;

            if (gridFinalPosition == 1) { FlipCharacterToTheRight(); return; }

            else if (gridFinalPosition == 2)
            {
                if (gridController.gridOneWizardLocationOne)
                {
                    FlipCharacterToTheLeft();
                    return;
                }

                else
                {
                    FlipCharacterToTheRight();
                    return;
                }
            }

            else if (gridFinalPosition == 3)
            {
                if (gridController.gridFourWizardLocationOne)
                {
                    FlipCharacterToTheRight();
                    return;
                }

                else
                {
                    FlipCharacterToTheLeft();
                    return;
                }
            }

            else if (gridFinalPosition == 4) { FlipCharacterToTheLeft(); return; }

        }

        else if (!moveToGridAtGrid)
        {
            globalController.StopAllSpeedTime();
        }
    }







    public void OnEnemyUsingAnAction()
    {
        if (isSlime)
        {
            randomNumber = Random.Range(0, 2);

            if (paladin.isDead) { randomNumber = 1; }
            if (wizard.isDead) { randomNumber = 0; }
            if (paladin.isDead && wizard.isDead) { stopDoingAnAction = true; return; }


            if (randomNumber == 0) // Paladin
            {
                gridController.enemyGridLocationTemporary = grid;
                gridController.CheckDistancePaladin();
                Debug.Log("Distance is " + gridController.distance);

                if (gridController.distance > 1)
                {
                    Debug.Log("Too Far Cant Attack");
                    stopDoingAnAction = true;
                    return;
                }
            }

            else if (randomNumber == 1) // Wizard
            {
                gridController.enemyGridLocationTemporary = grid;
                gridController.CheckDistanceWizard();
                Debug.Log("Distance is " + gridController.distance);

                if (gridController.distance > 1)
                {
                    Debug.Log("Too Far Cant Attack");
                    stopDoingAnAction = true;
                    return;
                }
            }


            distanceXFromPaladin = -2f;
            distanceYFromPaladin = 0.7f;
            distanceXFromWizard = -1.8f;
            distanceYFromWizard = -0.2f;


            if (currentHealth <= 0)
            {
                globalController.enemyIsReady = false;
                globalController.enemyUsingAnAction = false;
                globalController.RestartAllSpeedTime();
                startSpeed = false;
                isDead = true;

                return;
            }

            if (randomNumber == 0) // Attack Paladin
            {
                actionTimer = 0;
                section = 0;
                startSlimeAttackOnPaladin = true;
            }

            if (randomNumber == 1) // Attack Wizard
            {
                actionTimer = 0;
                section = 0;
                startSlimeAttackOnWizard = true;
            }
        }
    }

    

    void SlimeAttackPaladinUpdate()
    {
        if (startSlimeAttackOnPaladin)
        {
            actionTimer += Time.deltaTime;

            if (actionTimer >= 0 && section == 0)
            {
                globalController.StopAllSpeedTime();

                moveToPaladin = true;

                actionTimer = 0;

                section += 1;
            }

            else if (actionTimer >= 0.22f && section == 1 && moveToPaladinAtTarget)
            {
                moveToPaladinAtTarget = false;

                AnimationAttackOneTrue();

                actionTimer = 0;

                section += 1;
            }

            else if (actionTimer >= 0.32f && section == 2)
            {
                paladin.GettingHitFromAttack(level, attack);
                paladin.AnimationGettingHitTrue();
                shakingCamera.ShakeCamera();

                actionTimer = 0;

                section += 1;
            }

            else if (actionTimer >= 0.32f && section == 3)
            {
                if (paladin.currentHealth > 0)
                {
                    paladin.AnimationGettingHitFalse();
                }

                moveToStart = true;

                actionTimer = 0;

                section += 1;
            }

            else if (actionTimer >= 0f && section == 4 && moveToStartAtStart)
            {
                moveToStartAtStart = false;
                AnimationAttackOneFalse();

                globalController.enemyIsReady = false;
                globalController.enemyUsingAnAction = false;

                StartOverSpeedBar();

                globalController.RestartAllSpeedTime();

                startSlimeAttackOnPaladin = false;
                actionTimer = 0;
                section = 0;
            }
        }
    }




    void SlimeAttackWizardUpdate()
    {
        if (startSlimeAttackOnWizard)
        {
            actionTimer += Time.deltaTime;

            if (actionTimer >= 0 && section == 0)
            {
                globalController.StopAllSpeedTime();

                moveToWizard = true;

                actionTimer = 0;

                section += 1;
            }

            else if (actionTimer >= 0.22f && section == 1 && moveToWizardAtTarget)
            {
                moveToWizardAtTarget = false;

                AnimationAttackOneTrue();

                actionTimer = 0;

                section += 1;
            }

            else if (actionTimer >= 0.32f && section == 2)
            {
                wizard.GettingHitFromAttack(level, attack);
                wizard.AnimationGettingHitTrue();
                shakingCamera.ShakeCamera();

                actionTimer = 0;

                section += 1;
            }

            else if (actionTimer >= 0.32f && section == 3)
            {
                if (wizard.currentHealth > 0)
                {
                    wizard.AnimationGettingHitFalse();
                }

                moveToStart = true;

                actionTimer = 0;

                section += 1;
            }

            else if (actionTimer >= 0f && section == 4 && moveToStartAtStart)
            {
                moveToStartAtStart = false;
                AnimationAttackOneFalse();

                globalController.enemyIsReady = false;
                globalController.enemyUsingAnAction = false;

                StartOverSpeedBar();

                globalController.RestartAllSpeedTime();

                startSlimeAttackOnWizard = false;
                actionTimer = 0;
                section = 0;
            }
        }
    }
}