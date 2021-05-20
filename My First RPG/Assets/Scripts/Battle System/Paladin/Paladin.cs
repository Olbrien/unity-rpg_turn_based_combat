using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Paladin : MonoBehaviour
{   
    [Header("Stats")]

    public int attack;    
    public float attackModifierPercentage;
    public int magic;
    public float magicModifierPercentage;
    public int defense;    
    public float defenseModifierPercentage;    
    public int magicDefense;    
    public float magicDefenseModifierPercentage;    
    public int maxHealth;
    public float maxHealthModifierPercentage;
    public int currentHealth;
    public float currentHealthModifierPercentage;
    public float ab;    
    public float abModifierPercentage;
    public float iceResistance;
    public float fireResistance;
    public float waterResistance;


    [Header("Skills")]

    public int magicResistance;
    public int attackResistance;



    [Header("Buffs and Debuffs")]

    public bool attackUp;
    public bool magicUp;
    public bool defenseUp;
    public bool magicDefenseUp;
    public bool abUp;
    public bool maxHealthUp;
    [Space(5)]
    public bool attackDown;
    public bool magicDown;
    public bool defenseDown;
    public bool magicDefenseDown;
    public bool abDown;
    public bool maxHealthDown;


    [HideInInspector]
    public int bubbleNumber;

    [HideInInspector]
    public float attackModifierPercentageTemporary;
    [HideInInspector]
    public float magicModifierPercentageTemporary;
    [HideInInspector]
    public float defenseModifierPercentageTemporary;
    [HideInInspector]
    public float magicDefenseModifierPercentageTemporary;
    [HideInInspector]
    public float maxHealthModifierPercentageTemporary;
    [HideInInspector]
    public float currentHealthModifierPercentageTemporary;
    [HideInInspector]
    public float abModifierPercentageTemporary;

    [HideInInspector]
    public float attackModifierPercentageTemporaryStore;
    [HideInInspector]
    public float magicModifierPercentageTemporaryStore;
    [HideInInspector]
    public float defenseModifierPercentageTemporaryStore;
    [HideInInspector]
    public float magicDefenseModifierPercentageTemporaryStore;
    [HideInInspector]
    public float maxHealthModifierTemporaryStore;
    [HideInInspector]
    public float currentHealthModifierTemporaryStore;
    [HideInInspector]
    public float abModifierPercentageTemporaryStore;


    [HideInInspector]
    public int attackTemporary;
    [HideInInspector]
    public int magicTemporary;
    [HideInInspector]
    public int defenseTemporary;
    [HideInInspector]
    public int magicDefenseTemporary;
    [HideInInspector]
    public int maxHealthTemporary;
    [HideInInspector]
    public int currentHealthTemporary;

    [HideInInspector]
    public int attackTemporaryStore;
    [HideInInspector]
    public int magicTemporaryStore;
    [HideInInspector]
    public int defenseTemporaryStore;
    [HideInInspector]
    public int magicDefenseTemporaryStore;
    [HideInInspector]
    public int maxHealthTemporaryStore;
    [HideInInspector]
    public int currentHealthTemporaryStore;


    bool storeModifiers;

    [HideInInspector]
    public bool moveToEnemy;
    [HideInInspector]
    public bool moveToStart;
    [HideInInspector]
    public Vector3 enemyPosition;

    [HideInInspector]
    public bool isHealing;


    [HideInInspector]
    public bool startAB;

    [HideInInspector]
    public string gettingAttackedBy;

    [HideInInspector]
    public int turnPoints;

    [HideInInspector]
    public bool dead;

    [HideInInspector]
    public bool usingAnAction;



    [Space(500)]

    public GameController gameController;
    public TurnPointsController turnPointsController;

    public PaladinController paladinController;
    Enemy enemy;

    public TextMeshProUGUI paladinHealthTxt;
    public Image paladinHealthBar;

    public TextMeshProUGUI paladinABTxt;
    public Image paladinABBar;

    public Wizard wizard;

    public List<Canvas> floatDamage;


    void Start()
    {    
        storeModifiers = true;
        UpdatePaladinController();
        UpdatePaladinLive();
        HealthBarAndTxt();
        //ABBarAndTxt();
        TemporaryBuffsAndDebuffs();
    }


    void FixedUpdate()
    {
        if (startAB == true && dead == true)
        {
            ab = 0;

            paladinABBar.fillAmount = 0;

            paladinABTxt.text = "0%";

            startAB = false;
        }

        if (startAB == true && dead == false)
        {
            ab += (0.15f + ((abModifierPercentage / 350))) * Time.deltaTime;

            paladinABBar.fillAmount = ab;

            //paladinABTxt.text = Mathf.RoundToInt(ab * 100).ToString() + "%";

            if (ab >= 1)
            {
                paladinABBar.fillAmount = 1;

                //paladinABTxt.text = "100%";

                gameController.turnsPassed += 1;

                startAB = false;
            }
        }

        
        if (moveToEnemy)
        {
            var startPosition = transform.position;
            float speedOfMovement = 25f * Time.deltaTime;

            transform.localPosition = Vector3.Lerp(startPosition, new Vector3 (enemyPosition.x - 0.7f, enemyPosition.y + 0.05f, enemyPosition.z), speedOfMovement);
        }

        if (moveToStart)
        {
            var startPosition = new Vector3(-2.3f, 0.12f, 0);
            float speedOfMovement = 25f * Time.deltaTime;

            transform.localPosition = Vector3.MoveTowards(transform.position, startPosition, speedOfMovement);
        }


    }


    private void UpdatePaladinController()
    {
        attack = paladinController.attack;
        attackModifierPercentage = paladinController.attackModifierPercentage;

        attack += Mathf.RoundToInt((attack * attackModifierPercentage / 100));

        magic = paladinController.magic;
        magicModifierPercentage = paladinController.magicModifierPercentage;

        magic += Mathf.RoundToInt((magic * magicModifierPercentage / 100));

        defense = paladinController.defense;
        defenseModifierPercentage = paladinController.defenseModifier;

        defense += Mathf.RoundToInt((defense * defenseModifierPercentage / 100));

        magicDefense = paladinController.magicDefense;
        magicDefenseModifierPercentage = paladinController.magicDefenseModifier;

        magicDefense += Mathf.RoundToInt((magicDefense * magicDefenseModifierPercentage / 100));

        maxHealth = paladinController.maxHealth;
        maxHealthModifierPercentage = paladinController.maxHealthModifierPercentage;

        maxHealth += Mathf.RoundToInt((maxHealth * maxHealthModifierPercentage / 100));

        currentHealth = paladinController.currentHealth;
        currentHealthModifierPercentage = paladinController.currentHealthModifierPercentage;

        currentHealth += Mathf.RoundToInt((currentHealth * currentHealthModifierPercentage / 100));

        abModifierPercentage = paladinController.abModifierPercentage;

        iceResistance = paladinController.iceResistancePercentage;
        fireResistance = paladinController.fireResistancePercentage;
        waterResistance = paladinController.waterResistancePercentage;

        bubbleNumber = paladinController.bubbleNumber;
    }

    public void UpdatePaladinTurnPoints()
    {
        turnPoints = turnPointsController.turnPointsPaladin;
    }
    

    public void UpdatePaladinLive()
    {
        HealthBarAndTxt();
    }


    void HealthBarAndTxt()
    {
        gameController.UpdatePaladinAndWizardTab();

        if (currentHealth <= 0)
        {
            paladinHealthTxt.text = 0 + "/" + maxHealth.ToString();

            paladinHealthBar.fillAmount = 0;
            return;
        }

        if (currentHealth > 0)
        {
            float ratio = (float)currentHealth / (float)maxHealth;

            ratio = Mathf.Clamp01(ratio);
            paladinHealthBar.fillAmount = ratio;

            paladinHealthTxt.text = currentHealth.ToString() + "/" + maxHealth.ToString();
        }         
    }
    


    void ABBarAndTxt()
    {
        paladinABBar.fillAmount = 0;

        paladinABTxt.text = "0%";
    }



    public void TemporaryBuffsAndDebuffs()
    {
        if (storeModifiers)
        {
            attackModifierPercentageTemporaryStore = attackModifierPercentage;
            magicModifierPercentageTemporaryStore = magicModifierPercentage;
            defenseModifierPercentageTemporaryStore = defenseModifierPercentage;
            magicDefenseModifierPercentageTemporaryStore = magicDefenseModifierPercentage;
            abModifierPercentageTemporaryStore = abModifierPercentage;
            maxHealthModifierTemporaryStore = maxHealthModifierPercentage;
            currentHealthModifierTemporaryStore = currentHealthModifierPercentage;

            attackTemporaryStore = attack;
            magicTemporaryStore = magic;
            defenseTemporaryStore = defense;
            magicDefenseTemporaryStore = magicDefense;
            maxHealthTemporaryStore = maxHealth;

            storeModifiers = false;
        }

        else
        {
            attackModifierPercentage = attackModifierPercentageTemporaryStore;
            magicModifierPercentage = magicModifierPercentageTemporaryStore;
            defenseModifierPercentage = defenseModifierPercentageTemporaryStore;
            magicDefenseModifierPercentage = magicDefenseModifierPercentageTemporaryStore;
            abModifierPercentage = abModifierPercentageTemporaryStore;
            maxHealthModifierPercentage = maxHealthModifierTemporaryStore;
            currentHealthModifierPercentage = currentHealthModifierTemporaryStore;

            attack = attackTemporaryStore;
            defense = defenseTemporaryStore;
            magicDefense = magicDefenseTemporaryStore;
            magic = magicTemporaryStore;
            maxHealth = maxHealthTemporaryStore;

            attackModifierPercentage += attackModifierPercentageTemporary;
            magicModifierPercentage += magicModifierPercentageTemporary;
            defenseModifierPercentage += defenseModifierPercentageTemporary;
            magicDefenseModifierPercentage += magicDefenseModifierPercentageTemporary;           
            abModifierPercentage += abModifierPercentageTemporary;
            maxHealthModifierPercentage = maxHealthModifierPercentageTemporary;
            currentHealthModifierPercentage = currentHealthModifierPercentageTemporary;

            attack += Mathf.RoundToInt((attack * attackModifierPercentage / 100));
            defense += Mathf.RoundToInt((defense * defenseModifierPercentage / 100));
            magicDefense += Mathf.RoundToInt((magicDefense * magicDefenseModifierPercentage / 100));
            magic += Mathf.RoundToInt((magic * magicModifierPercentage / 100));
            maxHealth += Mathf.RoundToInt((maxHealth * maxHealthModifierPercentage / 100));

            if (isHealing)
            {
                currentHealth += Mathf.RoundToInt((maxHealth * currentHealthModifierPercentage / 100));
                isHealing = false;

                if (currentHealth > maxHealth)
                {
                    currentHealth = maxHealth;
                }
            }

            if (maxHealth <= 0)
            {
                maxHealth = 1;
            }

            HealthBarAndTxt();
        }
    }


    public float Attack()
    {
        return attack;        
    }


    public void GettingHitByEnemy(int enemyAttack, int enemyLevel)
    {
        float levelDifference = (gameController.level - enemyLevel) * 2;

        if (levelDifference < 0)
        {
            levelDifference = levelDifference * 8;
        }

        float theCalculation = enemyAttack - (enemyAttack * ((defense + levelDifference) / 100));

        if (theCalculation <= 0)
        {
            //int randomValue = Random.Range(0, 4);
            //currentHealth -= randomValue;
            //gameController.damageSaverFromAttacks = randomValue;

            currentHealth -= 0;
            gameController.damageSaverFromAttacks = 0;
        }

        else
        {
            currentHealth -= Mathf.RoundToInt(theCalculation);

            gameController.damageSaverFromAttacks = Mathf.RoundToInt(theCalculation);
        }

        paladinController.currentHealth = currentHealth;

        HealthBarAndTxt();

        if (currentHealth <= 0)
        {
            Debug.Log("Dead");
            paladinController.currentHealth = 0;

            HealthBarAndTxt();

            gameController.CloseAllPaladinsActionsWhenDead();
        }
    }

    public void DamageFloatOnPaladin()
    {
        foreach (var damageFloat in floatDamage)
        {
            if (damageFloat.enabled == false)
            {
                damageFloat.enabled = true;
                damageFloat.GetComponentInChildren<DamageFloat>().OnTheStart();
                break;
            }
        }
    }

    public void PaladinDefendAttackOn()
    {
        transform.position = new Vector3(-2.60f, transform.position.y, transform.position.z);
    }

    public void PaladinDefendAttackOff()
    {
        transform.position = new Vector3(-2.3f, transform.position.y, transform.position.z);
    }
}
