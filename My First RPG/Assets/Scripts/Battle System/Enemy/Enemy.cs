using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Enemy : MonoBehaviour
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

    [Space(10)]
    public int level;
    public int experience;

    [Header("Buffs")]

    public bool attackUp;
    public bool magicUp;
    public bool defenseUp;
    public bool magicDefenseUp;
    public bool abUp;
    public bool maxHealthUp;

    [Header("Debuffs")]

    public bool attackDown;
    public bool magicDown;
    public bool defenseDown;
    public bool magicDefenseDown;
    public bool abDown;
    public bool maxHealthDown;


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


    [HideInInspector]
    public bool startAB;
    [HideInInspector]
    public bool isHealing;

    [HideInInspector]
    string enemyName;

    Vector3 initialPosition;


    [HideInInspector]
    public bool moveToPaladin;
    [HideInInspector]
    public bool moveToWizard;
    [HideInInspector]
    public bool moveToStart;
    [HideInInspector]
    public Vector3 enemyPosition;

    bool storeModifiers;
    [Header("Monster")]
    public bool isBoar;
    public bool isDarkBoar;




    [HideInInspector]
    public string gettingAttackedBy;
    int randomNumber;

    bool enemyAppear;
    bool enemyDisappear;

    bool gettingHitWithIce;
    bool gettingHitWithFire;
    bool gettingHitWithWater;


    [Header("Effects")]
    public bool isFreezing;
    public float freezingTime;
    [Space(5)]
    public bool isBurning;
    public float burningTime;
    float burningTimeSave;
    public float burningPercentageDamage;
    public int burningTimes;
    bool burningFirstTime;
    [Space(5)]
    public bool isSilenced;
    public bool isSilencedTemporary;
    public float silenceTime;
    public float silencePercentage;
    [Space(5)]
    public bool isBlinded;
    public bool isBlindedTemporary;
    public float blindTime;
    public float blindPercentage;



    public bool isDead = true;


    [Space(500)]
    public List<Canvas> floatDamage;

    public GameObject shadow;
    public GameObject canvasGameObject;
    public Enemy thisScript;
    public GameObject clickGameObject;
    public Canvas clickCanvas;
    public Canvas selectArrow;
    public Canvas defendAttackOn;
    public Canvas defendAttackOff;

    //public Image enemyHealthBar;
    //public Image enemyABBar;

    public EnemyController enemyController;
    public Paladin paladin;
    public Wizard wizard;
    public ShakingCamera shakingCamera;
    public EventsChatController eventsChatController;
    public LootController lootController;
    public AllClickTarget allClickTarget;
    public FindAllSelectArrow findAllSelectArrow;
    public WhiteMagicController whiteMagicController;
    public BlackMagicController blackMagicController;
    public SpellController spellController;
    public GameController gameController;
    public ClickController clickController;

    public Animator enemyAnimator;
    public Animator paladinAnimator;
    public Animator wizardAnimator;


    public SpriteRenderer spriteRenderer;
    public SpriteRenderer shadowSpriteRenderer;
    public Canvas canvasComponent;





    void Awake()
    {

    }

    //void OnEnable()
    //{
    //    storeModifiers = true;

    //    initialPosition = transform.position;

    //    var canvasAlpha = canvasGameObject.GetComponent<CanvasGroup>();
    //    canvasAlpha.alpha = 0;

    //    var aa = shadow.GetComponent<SpriteRenderer>();
    //    aa.color = new Color(1, 1, 1, 0);

    //    var aaa = this.GetComponent<SpriteRenderer>();
    //    aaa.color = new Color(1, 1, 1, 0);

    //    initialPosition = transform.localPosition;
    //    EnemyLayerPosition();

    //    gameController.numberOfEnemies += 1;

    //    ab = 0.9f;

    //    InvokeRepeating("RefreshTargetEnemy", 1f, 1f);

    //    enemyDisappear = false;
    //    enemyAppear = true;

    //    Invoke("UpdateEnemyController", 0.2f);
    //    Invoke("TemporaryBuffsAndDebuffs", 0.2f);

    //    //MessageOnEventsSpawn();
    //    //UpdateEnemy();
    //}

    public void EnableTheGameObjectWithoutEnablingIt()
    {
        isDead = false;

        spriteRenderer.enabled = true;
        shadowSpriteRenderer.enabled = true;
        canvasComponent.enabled = true;

        clickCanvas.enabled = true;

        storeModifiers = true;

        initialPosition = transform.position;

        var canvasAlpha = canvasGameObject.GetComponent<CanvasGroup>();
        canvasAlpha.alpha = 0;

        var aa = shadow.GetComponent<SpriteRenderer>();
        aa.color = new Color(1, 1, 1, 0);

        var aaa = this.GetComponent<SpriteRenderer>();
        aaa.color = new Color(1, 1, 1, 0);

        initialPosition = transform.localPosition;
        EnemyLayerPosition();

        gameController.numberOfEnemies += 1;

        ab = 0.9f;

        InvokeRepeating("RefreshTargetEnemy", 1f, 1f);

        enemyDisappear = false;
        enemyAppear = true;

        Invoke("UpdateEnemyController", 0.2f);
        Invoke("TemporaryBuffsAndDebuffs", 0.2f);

        //MessageOnEventsSpawn();
        //UpdateEnemy();
    }


    void FixedUpdate()
    {
        if (isSilenced) { IsSilencedMethod(); }
        if (isBlinded) { IsBlindedMethod(); }
        if (isBurning) { IsBurningMethod(); }
        if (isFreezing) { IsFreezingMethod(); }


        if (startAB) { StartABMethod(); }

        if (enemyAppear) { EnemyAppearMethod(); }
        if (enemyDisappear) { EnemyDisappearMethod(); }


        if (moveToPaladin)
        {
            var startPosition = transform.position;
            float speedOfMovement = 25f * Time.deltaTime;

            transform.localPosition = Vector3.Lerp(startPosition, new Vector3(paladin.transform.position.x + 0.7f, paladin.transform.position.y - 0.07f, paladin.transform.position.z), speedOfMovement);
        }

        if (moveToWizard)
        {
            var startPosition = transform.position;
            float speedOfMovement = 25f * Time.deltaTime;

            transform.localPosition = Vector3.Lerp(startPosition, new Vector3(wizard.transform.position.x + 0.7f, wizard.transform.position.y - 0.02f, wizard.transform.position.z), speedOfMovement);
        }

        if (moveToStart)
        {
            float speedOfMovement = 25f * Time.deltaTime;

            transform.localPosition = Vector3.MoveTowards(transform.position, initialPosition, speedOfMovement);
        }
    }


    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////


    void StartABMethod()
    {
        ab += (0.15f + ((abModifierPercentage / 350))) * Time.deltaTime;

        //enemyABBar.fillAmount = ab;

        if (ab >= 1)
        {
            //enemyABBar.fillAmount = 1;

            EnemyAttackSequence();

            gameController.turnsPassed += 1;

            startAB = false;
        }
    }


    void EnemyAppearMethod()
    {
        var canvasAlpha = canvasGameObject.GetComponent<CanvasGroup>();
        canvasAlpha.alpha += Time.deltaTime;

        var aa = shadow.GetComponent<SpriteRenderer>();
        aa.color += new Color(1, 1, 1, Time.deltaTime);

        var aaa = this.GetComponent<SpriteRenderer>();
        aaa.color += new Color(1, 1, 1, Time.deltaTime);

        if (canvasAlpha.alpha == 1)
        {
            enemyAppear = false;
        }
    }


    void EnemyDisappearMethod()
    {
        var canvasAlpha = canvasGameObject.GetComponent<CanvasGroup>();
        canvasAlpha.alpha -= Time.deltaTime;

        var aa = shadow.GetComponent<SpriteRenderer>();
        aa.color -= new Color(1, 1, 1, Time.deltaTime);

        var aaa = this.GetComponent<SpriteRenderer>();
        aaa.color -= new Color(1, 1, 1, Time.deltaTime);

        if (canvasAlpha.alpha == 0)
        {
            enemyDisappear = false;
        }
    }

    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////

    void IsSilencedMethod()
    {
        silenceTime -= Time.deltaTime;

        if (silenceTime <= 0)
        {
            IsSilencedMethodStop();
        }
    }

    void IsSilencedMethodStop()
    {
        isSilenced = false;
    }


    void IsBlindedMethod()
    {
        blindTime -= Time.deltaTime;

        if (blindTime <= 0)
        {
            IsBlindedMethodStop();
        }
    }

    void IsBlindedMethodStop()
    {
        isBlinded = false;
    }


    void IsBurningMethod()
    {
        burningTime -= Time.deltaTime;

        if (burningTimes <= 0)
        {
            IsBurningMethodStop();
            return;
        }

        if (burningFirstTime)
        {
            if (gameController.someoneDoingAnAction == false)
            {
                gameController.someoneDoingAnAction = true;
                gameController.StopAllAB();
                GettingHitFromBurn();

                burningTime = burningTimeSave;
                burningTimes -= 1;

                burningFirstTime = false;
            }
        }

        if (burningTime <= 0)
        {
            if (!isFreezing && gameController.someoneDoingAnAction == false)
            {
                gameController.someoneDoingAnAction = true;
                gameController.StopAllAB();
                GettingHitFromBurn();

                burningTime = burningTimeSave;
                burningTimes -= 1;
            }
        }
    }

    void IsBurningMethodStop()
    {
        isBurning = false;
    }


    void IsFreezingMethod()
    {
        freezingTime -= Time.deltaTime;

        if (freezingTime <= 0)
        {
            IsFreezingMethodStop();
        }

        return;
    }

    void IsFreezingMethodStop()
    {
        isFreezing = false;
        enemyAnimator.speed = 1;
    }


    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////



    void UpdateEnemyController()
    {
        attack += Mathf.RoundToInt((attack * attackModifierPercentage / 100));
        magic += Mathf.RoundToInt((magic * magicModifierPercentage / 100));
        defense += Mathf.RoundToInt((defense * defenseModifierPercentage / 100));
        magicDefense += Mathf.RoundToInt((magicDefense * magicDefenseModifierPercentage / 100));
    }




    void TemporaryBuffsAndDebuffs()
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
            }

            if (maxHealth <= 0)
            {
                maxHealth = 1;
            }

            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }
        }
    }


    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////


    void RefreshTargetEnemy()
    {
        if (clickController.paladinIsAttacking)
        {
            allClickTarget.AllClicksEnemiesEnabled();
            //clickController.RefreshOnClickOnEnemies();
            findAllSelectArrow.SelectOnlyEnemyArrowTrue();
        }

        if (clickController.wizardIsAttacking)
        {
            allClickTarget.AllClicksEnemiesEnabled();
            //clickController.RefreshOnClickOnEnemies();
            findAllSelectArrow.SelectOnlyEnemyArrowTrue();
        }
    }

    void EnemyLayerPosition()
    {
        if (transform.position.y > 0.8f)
        {
            spriteRenderer.sortingOrder = 2;
            canvasComponent.sortingOrder = 2;
        }

        else if (transform.position.y > 0.6f)
        {
            spriteRenderer.sortingOrder = 3;
            canvasComponent.sortingOrder = 3;
        }

        else if (transform.position.y > 0.4f)
        {
            spriteRenderer.sortingOrder = 4;
            canvasComponent.sortingOrder = 4;
        }

        else if (transform.position.y > 0.2f)
        {
            spriteRenderer.sortingOrder = 5;
            canvasComponent.sortingOrder = 5;
        }


        else if (transform.position.y > 0f)
        {
            spriteRenderer.sortingOrder = 6;
            canvasComponent.sortingOrder = 6;
        }

        else if (transform.position.y > -0.2f)
        {
            spriteRenderer.sortingOrder = 7;
            canvasComponent.sortingOrder = 7;
        }

        else if (transform.position.y > -0.4f)
        {
            spriteRenderer.sortingOrder = 8;
            canvasComponent.sortingOrder = 8;
        }

        else if (transform.position.y > -0.6f)
        {
            spriteRenderer.sortingOrder = 9;
            canvasComponent.sortingOrder = 9;
        }
    }


    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////


    //private void UpdateEnemy()
    //{
    //    ABBar();

    //    HealthBar();
    //}





    //public void HealthBar()
    //{
    //    if (currentHealth <= 0)
    //    {
    //        enemyHealthBar.fillAmount = 0;
    //        return;
    //    }

    //    if (currentHealth > 0)
    //    {
    //        float ratio = (float)currentHealth / (float)maxHealth;

    //        ratio = Mathf.Clamp01(ratio);
    //        enemyHealthBar.fillAmount = ratio;
    //    }
    //}


    //public void ABBar()
    //{
    //    enemyABBar.fillAmount = 0;
    //}


    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////



    public void GettingHitFromPaladinAttack()
    {
        float levelDifference = (level - gameController.level) * 2;

        if (levelDifference < 0)
        {
            levelDifference = levelDifference * 8;
        }

        float theCalculation = paladin.attack - (paladin.attack * ((defense + levelDifference) / 100));

        if (theCalculation <= 0 && gettingHitWithIce == false && gettingHitWithFire == false && gettingHitWithWater == false)
        {
            //int randomValue = Random.Range(0, 4);
            //currentHealth -= randomValue;
            //gameController.damageSaverFromAttacks = randomValue;

            currentHealth -= 0;
            gameController.damageSaverFromAttacks = 0;
        }

        else if (theCalculation <= 0 && gettingHitWithIce == true ||
                 theCalculation <= 0 && gettingHitWithFire == true ||
                 theCalculation <= 0 && gettingHitWithWater == true)
        {
            Debug.Log("Here");

            currentHealth -= Mathf.RoundToInt(theCalculation);

            gameController.damageSaverFromAttacks = Mathf.RoundToInt(theCalculation);

            gettingHitWithIce = false;
            gettingHitWithFire = false;
            gettingHitWithWater = false;
        }



        if (theCalculation > 0)
        {
            currentHealth -= Mathf.RoundToInt(theCalculation);

            gameController.damageSaverFromAttacks = Mathf.RoundToInt(theCalculation);

            gettingHitWithIce = false;
            gettingHitWithFire = false;
            gettingHitWithWater = false;
        }

        //HealthBar();

        if (currentHealth <= 0)
        {
            gameController.numberOfEnemies -= 1;
            gameController.experience += experience;

            enemyDisappear = true;

            //MessageOnEventsDead();
            MessageExperience();
            gameController.GainingExperience();

            EnemyLoot();

            StartCoroutine(DisableGameObject());
        }
    }

    public void GettingHitFromWizardAttack()
    {
        float levelDifference = (level - gameController.level) * 2;

        if (levelDifference < 0)
        {
            levelDifference = levelDifference * 8;
        }

        float theCalculation = wizard.attack - (wizard.attack * ((defense + levelDifference) / 100));

        if (theCalculation <= 0 && gettingHitWithIce == false && gettingHitWithFire == false && gettingHitWithWater == false)
        {
            //int randomValue = Random.Range(0, 4);
            //currentHealth -= randomValue;
            //gameController.damageSaverFromAttacks = randomValue;

            currentHealth -= 0;
            gameController.damageSaverFromAttacks = 0;
        }

        else if (theCalculation <= 0 && gettingHitWithIce == true ||
                 theCalculation <= 0 && gettingHitWithFire == true ||
                 theCalculation <= 0 && gettingHitWithWater == true)
        {
            Debug.Log("Here");

            currentHealth -= Mathf.RoundToInt(theCalculation);

            gameController.damageSaverFromAttacks = Mathf.RoundToInt(theCalculation);

            gettingHitWithIce = false;
            gettingHitWithFire = false;
            gettingHitWithWater = false;
        }



        if (theCalculation > 0)
        {
            currentHealth -= Mathf.RoundToInt(theCalculation);

            gameController.damageSaverFromAttacks = Mathf.RoundToInt(theCalculation);

            gettingHitWithIce = false;
            gettingHitWithFire = false;
            gettingHitWithWater = false;
        }

        //HealthBar();

        if (currentHealth <= 0)
        {
            gameController.numberOfEnemies -= 1;
            gameController.experience += experience;

            enemyDisappear = true;

            //MessageOnEventsDead();
            MessageExperience();
            gameController.GainingExperience();

            EnemyLoot();

            StartCoroutine(DisableGameObject());
        }
    }


    public void GettingHitFromWizardSpell(float spellDamage)
    {
        float levelDifference = (level - gameController.level) * 2;

        if (levelDifference < 0)
        {
            levelDifference = levelDifference * 8;
        }

        float spellDamageVar = spellDamage;

        spellDamageVar += Mathf.RoundToInt((spellDamageVar * wizard.magic / 100));

        float theCalculation = spellDamageVar - (spellDamageVar * ((magicDefense + levelDifference) / 100));


        if (theCalculation <= 0 && gettingHitWithIce == false && gettingHitWithFire == false && gettingHitWithWater == false)
        {
            //int randomValue = Random.Range(0, 4);
            //currentHealth -= randomValue;
            //gameController.damageSaverFromAttacks = randomValue;

            currentHealth -= 0;
            gameController.damageSaverFromAttacks = 0;
        }

        else if (theCalculation <= 0 && gettingHitWithIce == true ||
                 theCalculation <= 0 && gettingHitWithFire == true ||
                 theCalculation <= 0 && gettingHitWithWater == true)
        {
            currentHealth -= Mathf.RoundToInt(theCalculation);

            gameController.damageSaverFromAttacks = Mathf.RoundToInt(theCalculation);

            gettingHitWithIce = false;
            gettingHitWithFire = false;
            gettingHitWithWater = false;
        }



        if (theCalculation > 0)
        {
            currentHealth -= Mathf.RoundToInt(theCalculation);

            gameController.damageSaverFromAttacks = Mathf.RoundToInt(theCalculation);

            gettingHitWithIce = false;
            gettingHitWithFire = false;
            gettingHitWithWater = false;
        }

        //HealthBar();

        if (currentHealth <= 0)
        {
            gameController.numberOfEnemies -= 1;
            gameController.experience += experience;

            enemyDisappear = true;

            //MessageOnEventsDead();
            MessageExperience();
            gameController.GainingExperience();

            EnemyLoot();

            StartCoroutine(DisableGameObject());
        }
    }


    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////
    ///

    public void GettingHitFromBurn()
    {
        gettingHitWithFire = true;

        float theCalculation = Mathf.RoundToInt((maxHealth * burningPercentageDamage / 100));

        float fireResistanceCalculation = Mathf.RoundToInt((theCalculation * fireResistance / 100));

        theCalculation -= fireResistanceCalculation;

        if (theCalculation <= 0 && gettingHitWithIce == false && gettingHitWithFire == false && gettingHitWithWater == false)
        {
            //int randomValue = Random.Range(0, 4);
            //currentHealth -= randomValue;
            //gameController.damageSaverFromAttacks = randomValue;

            currentHealth -= 0;
            gameController.damageSaverFromAttacks = 0;
        }

        else if (theCalculation <= 0 && gettingHitWithIce == true ||
                 theCalculation <= 0 && gettingHitWithFire == true ||
                 theCalculation <= 0 && gettingHitWithWater == true)
        {

            currentHealth -= Mathf.RoundToInt(theCalculation);

            gameController.damageSaverFromAttacks = Mathf.RoundToInt(theCalculation);

            StartCoroutine(GettingHitFromBurnCoroutine());

            gettingHitWithIce = false;
            gettingHitWithFire = false;
            gettingHitWithWater = false;
        }




            if (theCalculation > 0)
        {
            currentHealth -= Mathf.RoundToInt(theCalculation);

            gameController.damageSaverFromAttacks = Mathf.RoundToInt(theCalculation);

            StartCoroutine(GettingHitFromBurnCoroutine());

            gettingHitWithIce = false;
            gettingHitWithFire = false;
            gettingHitWithWater = false;
        }

        //HealthBar();

        if (currentHealth <= 0)
        {
            gameController.numberOfEnemies -= 1;
            gameController.experience += experience;

            enemyDisappear = true;

            //MessageOnEventsDead();
            MessageExperience();
            gameController.GainingExperience();

            EnemyLoot();

            StartCoroutine(DisableGameObject());
        }


        gameController.ContinueAllAB();
        gameController.someoneDoingAnAction = false;
    }


    IEnumerator GettingHitFromBurnCoroutine()
    {
        DamageFloatOnEnemy();

        if (currentHealth > 0)
        {
            enemyAnimator.SetBool("GetHit", true);
        }

        else if (currentHealth <= 0)
        {
            enemyAnimator.SetBool("Dying", true);
        }

        yield return new WaitForSeconds(0.2f);

        if (currentHealth > 0)
        {
            enemyAnimator.SetBool("GetHit", false);
        }
    }


    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////


    IEnumerator DisableGameObject()
    {
        clickCanvas.enabled = false;
        selectArrow.enabled = false;
        yield return new WaitForSeconds(3f);
        DisableTheGameObjectWithoutDisablingIt();
    }


    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////


    void MessageExperience()
    {
        eventsChatController.SendMessageToChatFromOtherScripts(ChatMessageExperience());
    }

    string ChatMessageExperience()
    {
        float theTime = Time.timeSinceLevelLoad;

        int minutes = Mathf.FloorToInt(theTime / 60F);
        int seconds = Mathf.FloorToInt(theTime - minutes * 60);
        string niceTime = string.Format("{00:00}:{01:00}", minutes, seconds);

        return "You've gained " + "<color=#FFDE92>" + "<b>" + experience.ToString() + "</b>" + "</color> exp.";

    }


    //void MessageOnEventsSpawn()
    //{
    //    eventsChatController.SendMessageToChatFromOtherScripts(ChatColorEnemyEventSpawn());
    //}


    string ChatColorEnemyEventSpawn()
    {
        if (isBoar)
        {
            enemyName = "Boar";
        }

        else if (isDarkBoar)
        {
            enemyName = "Dark Boar";
        }


        if (level >= gameController.level + 4)
        {
            //float theTime = Time.timeSinceLevelLoad;

            //int minutes = Mathf.FloorToInt(theTime / 60F);
            //int seconds = Mathf.FloorToInt(theTime - minutes * 60);
            //string niceTime = string.Format("{00:00}:{01:00}", minutes, seconds);

            //return "(" + niceTime + ")" + "<color=#D75050>" + enemyName + "</color> - Level " + level;

            return "<color=#D75050>" + enemyName + "</color> - Level " + level;
        }

        else if (level >= gameController.level + 2)
        {
            //float theTime = Time.timeSinceLevelLoad;

            //int minutes = Mathf.FloorToInt(theTime / 60F);
            //int seconds = Mathf.FloorToInt(theTime - minutes * 60);
            //string niceTime = string.Format("{00:00}:{01:00}", minutes, seconds);

            //return "(" + niceTime + ")" + "<color=#DDFF13>" + enemyName + "</color> - Level " + level;

            return "<color=#DDFF13>" + enemyName + "</color> - Level " + level;
        }

        else
        {
            //float theTime = Time.timeSinceLevelLoad;

            //int minutes = Mathf.FloorToInt(theTime / 60F);
            //int seconds = Mathf.FloorToInt(theTime - minutes * 60);
            //string niceTime = string.Format("{00:00}:{01:00}", minutes, seconds);

            //return "(" + niceTime + ")" + "<color=#7CFF92>" + enemyName + "</color> - Level " + level;

            return "<color=#7CFF92>" + enemyName + "</color> - Level " + level;
        }
    }


    //void MessageOnEventsDead()
    //{
    //    eventsChatController.SendMessageToChatFromOtherScripts(ChatColorEnemyEventDead());
    //}

    //string ChatColorEnemyEventDead()
    //{
    //    if (isBoar)
    //    {
    //        enemyName = "Boar";
    //    }

    //    else if (isDarkBoar)
    //    {
    //        enemyName = "Dark Boar";
    //    }


    //    if (level >= gameController.level + 4)
    //    {
    //        //float theTime = Time.timeSinceLevelLoad;

    //        //int minutes = Mathf.FloorToInt(theTime / 60F);
    //        //int seconds = Mathf.FloorToInt(theTime - minutes * 60);
    //        //string niceTime = string.Format("{00:00}:{01:00}", minutes, seconds);

    //        //return "(" + niceTime+ ")" + "<color=#D75050>" + enemyName + "</color> - <color=#000000>Killed </color>";

    //        return "<color=#D75050>" + enemyName + "</color> - <color=#000000>Killed </color>";
    //    }

    //    else if (level >= gameController.level + 2)
    //    {
    //        //float theTime = Time.timeSinceLevelLoad;

    //        //int minutes = Mathf.FloorToInt(theTime / 60F);
    //        //int seconds = Mathf.FloorToInt(theTime - minutes * 60);
    //        //string niceTime = string.Format("{00:00}:{01:00}", minutes, seconds);

    //        //return "(" + niceTime + ")" + "<color=#DDFF13>" + enemyName + "</color> - <color=#000000>Killed </color>";

    //        return "<color=#DDFF13>" + enemyName + "</color> - <color=#000000>Killed </color>";
    //    }

    //    else
    //    {
    //        //float theTime = Time.timeSinceLevelLoad;

    //        //int minutes = Mathf.FloorToInt(theTime / 60F);
    //        //int seconds = Mathf.FloorToInt(theTime - minutes * 60);
    //        //string niceTime = string.Format("{00:00}:{01:00}", minutes, seconds);

    //        //return "(" + niceTime + ")" + "<color=#7CFF92>" + enemyName + "</color> - <color=#000000>Killed </color>";

    //        return "<color=#7CFF92>" + enemyName + "</color> - <color=#000000>Killed </color>";
    //    }
    //}


    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////


    void EnemyLoot()
    {
        if (isBoar)
        {
            lootController.boarLoot();
        }

        else if (isDarkBoar)
        {
            lootController.darkBoarLoot();
        }
    }


    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////



    public void EnemyAttackSequence()
    {
        if (isBoar)
        {
            StartCoroutine(EnemyAttackSequenceCoroutineBoar());
        }

        if (isDarkBoar)
        {
            StartCoroutine(EnemyAttackSequenceCoroutineDarkBoar());
        }
    }


    IEnumerator EnemyAttackSequenceCoroutineBoar()
    {
        isBlindedTemporary = false;
        isSilencedTemporary = false;

        if (isFreezing)
        {
            ab = 0;
            yield break;
        }

        if (isBoar)
        {
            if (currentHealth <= 0)
            {
                yield break;
            }

            if (gameController.someoneDoingAnAction == true)
            {
                yield break;
            }

            gameController.damageSaverFromAttacks = attack;

            gameController.someoneDoingAnAction = true;

            gameController.StopAllAB();



            int randomNumberGenerator = Random.Range(0, 2);

            randomNumber = randomNumberGenerator;

            if (paladin.dead)
            {
                randomNumber = 1;
            }

            if (wizard.dead)
            {
                randomNumber = 0;
            }

            if (wizard.dead && paladin.dead)
            {
                randomNumber = 2;
            }


            float blindOdds = Random.Range(0, 101);
            float silenceOdds = Random.Range(0, 101);


            if (isBlinded)
            {
                if (blindOdds <= blindPercentage)
                {
                    isBlindedTemporary = true;
                }

                else if (blindOdds > blindPercentage)
                {
                    isBlindedTemporary = false;
                }
            }

            if (isSilenced)
            {
                if (silenceOdds <= silencePercentage)
                {
                    isSilencedTemporary = true;
                }

                else if (silenceOdds > silencePercentage)
                {
                    isSilencedTemporary = false;
                }
            }

            ////////////////////////////////////////////////////////
            /////////////////// Physical Attack ////////////////////
            ////////////////////////////////////////////////////////


            if (randomNumber == 0) // Attack Paladin
            {
                spriteRenderer.sortingOrder = 5;
                canvasComponent.sortingOrder = 5;

                //var enemyPositionTotal = new Vector3(paladin.transform.localPosition.x + 0.75f, paladin.transform.localPosition.y - 0.08f, 0);

                //transform.localPosition = enemyPositionTotal;

                moveToPaladin = true;
                yield return new WaitForSeconds(0.22f);
                moveToPaladin = false;


                paladinAnimator.SetBool("GetHit", false);
                enemyAnimator.ResetTrigger("Attack");
                enemyAnimator.SetTrigger("Attack");


                yield return new WaitForSeconds(0.6f);

                if (!isBlindedTemporary)
                {
                    defendAttackOn.enabled = true;
                }

                yield return new WaitForSeconds(0.2f);

                if (!isBlindedTemporary)
                {
                    defendAttackOn.enabled = false;
                    defendAttackOff.enabled = false;
                }

                if (gameController.defendingAnAttack == true)
                {
                    paladin.PaladinDefendAttackOn();
                    paladin.GettingHitByEnemy(attack / 2, level);
                }

                else if (gameController.defendingAnAttack == false && !isBlindedTemporary)
                {
                    paladin.GettingHitByEnemy(attack, level);
                }


                if (!isBlindedTemporary)
                {
                    paladin.DamageFloatOnPaladin();

                    shakingCamera.ShakeCamera();
                }


                if (paladin.currentHealth > 0 && !isBlindedTemporary)
                {
                    paladinAnimator.SetBool("GetHit", true);
                }

                else if (paladin.currentHealth <= 0)
                {
                    paladinAnimator.SetBool("Dying", true);
                    gameController.PaladinDied();
                }

                yield return new WaitForSeconds(0.4f);

                moveToStart = true;
                yield return new WaitForSeconds(0.22f);
                moveToStart = false;

                //transform.rotation = Quaternion.Euler(0, 0, 0);

                if (paladin.currentHealth > 0 && !isBlindedTemporary)
                {
                    paladinAnimator.SetBool("GetHit", false);
                }

                //transform.localPosition = initialPosition;

                EnemyLayerPosition();

                ab = 0;

                gameController.ContinueAllAB();

                gameController.someoneDoingAnAction = false;
                gameController.defendingAnAttack = false;
                paladin.PaladinDefendAttackOff();

            }

            if (randomNumber == 1) // Attack Wizard
            {
                spriteRenderer.sortingOrder = 5;
                canvasComponent.sortingOrder = 5;

                //var enemyPositionTotal = new Vector3(wizard.transform.localPosition.x + 0.75f, wizard.transform.localPosition.y - 0.04f, 0);

                //transform.localPosition = enemyPositionTotal;

                moveToWizard = true;
                yield return new WaitForSeconds(0.22f);
                moveToWizard = false;

                wizardAnimator.SetBool("GetHit", false);
                enemyAnimator.ResetTrigger("Attack");
                enemyAnimator.SetTrigger("Attack");

                yield return new WaitForSeconds(0.6f);

                if (!isBlindedTemporary)
                {
                    defendAttackOn.enabled = true;
                }

                yield return new WaitForSeconds(0.2f);

                if (!isBlindedTemporary)
                {
                    defendAttackOn.enabled = false;
                    defendAttackOff.enabled = false;
                }

                if (gameController.defendingAnAttack == true)
                {
                    wizard.WizardDefendAttackOn();
                    wizard.GettingHitByEnemy(attack / 2, level);
                }

                else if (gameController.defendingAnAttack == false && !isBlindedTemporary)
                {
                    wizard.GettingHitByEnemy(attack, level);
                }

                if (!isBlindedTemporary)
                {
                    wizard.DamageFloatOnWizard();

                    shakingCamera.ShakeCamera();
                }



                if (wizard.currentHealth > 0 && !isBlindedTemporary)
                {
                    wizardAnimator.SetBool("GetHit", true);
                }

                else if (wizard.currentHealth <= 0)
                {
                    wizardAnimator.SetBool("Dying", true);
                    gameController.WizardDied();
                }

                yield return new WaitForSeconds(0.4f);

                moveToStart = true;
                yield return new WaitForSeconds(0.22f);
                moveToStart = false;

                //transform.rotation = Quaternion.Euler(0, 0, 0);

                if (wizard.currentHealth > 0 && !isBlindedTemporary)
                {
                    wizardAnimator.SetBool("GetHit", false);
                }

                //transform.localPosition = initialPosition;

                EnemyLayerPosition();

                ab = 0;

                gameController.ContinueAllAB();

                gameController.someoneDoingAnAction = false;
                gameController.defendingAnAttack = false;
                wizard.WizardDefendAttackOff();

            }
        }
    }

    IEnumerator EnemyAttackSequenceCoroutineDarkBoar()
    {
        isBlindedTemporary = false;
        isSilencedTemporary = false;

        if (isFreezing)
        {
            ab = 0;
            yield break;
        }

        if (isDarkBoar)
        {
            if (currentHealth <= 0)
            {
                yield break;
            }

            if (gameController.someoneDoingAnAction == true)
            {
                yield break;
            }

            gameController.damageSaverFromAttacks = attack;

            gameController.someoneDoingAnAction = true;

            gameController.StopAllAB();



            int randomNumberGenerator = Random.Range(0, 2);

            randomNumber = randomNumberGenerator;

            if (paladin.dead)
            {
                randomNumber = 1;
            }

            if (wizard.dead)
            {
                randomNumber = 0;
            }

            if (wizard.dead && paladin.dead)
            {
                randomNumber = 2;
            }


            float blindOdds = Random.Range(0, 101);
            float silenceOdds = Random.Range(0, 101);


            if (isBlinded)
            {
                if (blindOdds <= blindPercentage)
                {
                    isBlindedTemporary = true;
                }

                else if (blindOdds > blindPercentage)
                {
                    isBlindedTemporary = false;
                }
            }

            if (isSilenced)
            {
                if (silenceOdds <= silencePercentage)
                {
                    isSilencedTemporary = true;
                }

                else if (silenceOdds > silencePercentage)
                {
                    isSilencedTemporary = false;
                }
            }

            ////////////////////////////////////////////////////////
            /////////////////// Physical Attack ////////////////////
            ////////////////////////////////////////////////////////


            if (randomNumber == 0) // Attack Paladin
            {
                spriteRenderer.sortingOrder = 5;
                canvasComponent.sortingOrder = 5;

                //var enemyPositionTotal = new Vector3(paladin.transform.localPosition.x + 0.75f, paladin.transform.localPosition.y - 0.08f, 0);

                //transform.localPosition = enemyPositionTotal;

                moveToPaladin = true;
                yield return new WaitForSeconds(0.22f);
                moveToPaladin = false;


                paladinAnimator.SetBool("GetHit", false);
                enemyAnimator.ResetTrigger("Attack");
                enemyAnimator.SetTrigger("Attack");


                yield return new WaitForSeconds(0.6f);

                if (!isBlindedTemporary)
                {
                    defendAttackOn.enabled = true;
                }

                yield return new WaitForSeconds(0.2f);

                if (!isBlindedTemporary)
                {
                    defendAttackOn.enabled = false;
                    defendAttackOff.enabled = false;
                }

                if (gameController.defendingAnAttack == true)
                {
                    paladin.PaladinDefendAttackOn();
                    paladin.GettingHitByEnemy(attack / 2, level);
                }

                else if (gameController.defendingAnAttack == false && !isBlindedTemporary)
                {
                    paladin.GettingHitByEnemy(attack, level);
                }


                if (!isBlindedTemporary)
                {
                    paladin.DamageFloatOnPaladin();

                    shakingCamera.ShakeCamera();
                }


                if (paladin.currentHealth > 0 && !isBlindedTemporary)
                {
                    paladinAnimator.SetBool("GetHit", true);
                }

                else if (paladin.currentHealth <= 0)
                {
                    paladinAnimator.SetBool("Dying", true);
                    gameController.PaladinDied();
                }

                yield return new WaitForSeconds(0.4f);

                moveToStart = true;
                yield return new WaitForSeconds(0.22f);
                moveToStart = false;

                //transform.rotation = Quaternion.Euler(0, 0, 0);

                if (paladin.currentHealth > 0 && !isBlindedTemporary)
                {
                    paladinAnimator.SetBool("GetHit", false);
                }

                //transform.localPosition = initialPosition;

                EnemyLayerPosition();

                ab = 0;

                gameController.ContinueAllAB();

                gameController.someoneDoingAnAction = false;
                gameController.defendingAnAttack = false;
                paladin.PaladinDefendAttackOff();

            }

            if (randomNumber == 1) // Attack Wizard
            {
                spriteRenderer.sortingOrder = 5;
                canvasComponent.sortingOrder = 5;

                //var enemyPositionTotal = new Vector3(wizard.transform.localPosition.x + 0.75f, wizard.transform.localPosition.y - 0.04f, 0);

                //transform.localPosition = enemyPositionTotal;

                moveToWizard = true;
                yield return new WaitForSeconds(0.22f);
                moveToWizard = false;

                wizardAnimator.SetBool("GetHit", false);
                enemyAnimator.ResetTrigger("Attack");
                enemyAnimator.SetTrigger("Attack");

                yield return new WaitForSeconds(0.6f);

                if (!isBlindedTemporary)
                {
                    defendAttackOn.enabled = true;
                }

                yield return new WaitForSeconds(0.2f);

                if (!isBlindedTemporary)
                {
                    defendAttackOn.enabled = false;
                    defendAttackOff.enabled = false;
                }

                if (gameController.defendingAnAttack == true)
                {
                    wizard.WizardDefendAttackOn();
                    wizard.GettingHitByEnemy(attack / 2, level);
                }

                else if (gameController.defendingAnAttack == false && !isBlindedTemporary)
                {
                    wizard.GettingHitByEnemy(attack, level);
                }

                if (!isBlindedTemporary)
                {
                    wizard.DamageFloatOnWizard();

                    shakingCamera.ShakeCamera();
                }



                if (wizard.currentHealth > 0 && !isBlindedTemporary)
                {
                    wizardAnimator.SetBool("GetHit", true);
                }

                else if (wizard.currentHealth <= 0)
                {
                    wizardAnimator.SetBool("Dying", true);
                    gameController.WizardDied();
                }

                yield return new WaitForSeconds(0.4f);

                moveToStart = true;
                yield return new WaitForSeconds(0.22f);
                moveToStart = false;

                //transform.rotation = Quaternion.Euler(0, 0, 0);

                if (wizard.currentHealth > 0 && !isBlindedTemporary)
                {
                    wizardAnimator.SetBool("GetHit", false);
                }

                //transform.localPosition = initialPosition;

                EnemyLayerPosition();

                ab = 0;

                gameController.ContinueAllAB();

                gameController.someoneDoingAnAction = false;
                gameController.defendingAnAttack = false;
                wizard.WizardDefendAttackOff();

            }
        }
    }





    public void DamageFloatOnEnemy()
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



    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////
    


    public void DefendAttackButtonOn()
    {
        gameController.defendingAnAttack = true;
        defendAttackOn.enabled = false;
        defendAttackOff.enabled = true;
    }

    public void DefendAttackButtonOff()
    {
        gameController.defendingAnAttack = false;
    }



    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////




    public void SpellEffectGeneral()
    {
        if (whiteMagicController.clumsyOne == true) { ClumsyOneEffects(); }
        else if (whiteMagicController.clumsyTwo == true) { ClumsyTwoEffects(); }
        else if (whiteMagicController.clumsyThree == true) { ClumsyThreeEffects(); }

        else if (whiteMagicController.weakenOne == true) { WeakenOneEffects(); }
        else if (whiteMagicController.weakenTwo == true) { WeakenTwoEffects(); }
        else if (whiteMagicController.weakenThree == true) { WeakenThreeEffects(); }

        else if (whiteMagicController.deflateArmorOne == true) { DeflateArmorOneEffects(); }
        else if (whiteMagicController.deflateArmorTwo == true) { DeflateArmorTwoEffects(); }
        else if (whiteMagicController.deflateArmorThree == true) { DeflateArmorThreeEffects(); }

        else if (whiteMagicController.deflateMagicProtectionOne == true) { DeflateMagicProtectionOneEffects(); }
        else if (whiteMagicController.deflateMagicProtectionTwo == true) { DeflateMagicProtectionTwoEffects(); }
        else if (whiteMagicController.deflateMagicProtectionThree == true) { DeflateMagicProtectionThreeEffects(); }

        else if (whiteMagicController.feeblemindOne == true) { FeeblemindOneEffects(); }
        else if (whiteMagicController.feeblemindTwo == true) { FeeblemindTwoEffects(); }
        else if (whiteMagicController.feeblemindThree == true) { FeeblemindThreeEffects(); }


        else if (whiteMagicController.dispelOne == true) { DispelOneEffects(); }
        else if (whiteMagicController.dispelTwo == true) { DispelTwoEffects(); }
        else if (whiteMagicController.dispelThree == true) { DispelThreeEffects(); }



        if (blackMagicController.iceOne == true) { IceOneEffects(spellController.iceOneDamage); }
        else if (blackMagicController.iceTwo == true) { IceTwoEffects(spellController.iceTwoDamage); }
        else if (blackMagicController.iceThree == true) { IceThreeEffects(spellController.iceThreeDamage); }

        else if (blackMagicController.iceFour == true) { IceFourEffects(spellController.iceFourDamage); }
        else if (blackMagicController.iceFive == true) { IceFiveEffects(spellController.iceFiveDamage); }
        else if (blackMagicController.iceSix == true) { IceSixEffects(spellController.iceSixDamage); }

        else if (blackMagicController.fireOne == true) { FireOneEffects(spellController.fireOneDamage); }
        else if (blackMagicController.fireTwo == true) { FireTwoEffects(spellController.fireTwoDamage); }
        else if (blackMagicController.fireThree == true) { FireThreeEffects(spellController.fireThreeDamage); }

        else if (blackMagicController.fireFour == true) { FireFourEffects(spellController.fireFourDamage); }
        else if (blackMagicController.fireFive == true) { FireFiveEffects(spellController.fireFiveDamage); }
        else if (blackMagicController.fireSix == true) { FireSixEffects(spellController.fireSixDamage); }

        else if (blackMagicController.waterOne == true) { WaterOneEffects(spellController.waterOneDamage); }
        else if (blackMagicController.waterTwo == true) { WaterTwoEffects(spellController.waterTwoDamage); }
        else if (blackMagicController.waterThree == true) { WaterThreeEffects(spellController.waterThreeDamage); }

        else if (blackMagicController.waterFour == true) { WaterFourEffects(spellController.waterFourDamage); }
        else if (blackMagicController.waterFive == true) { WaterFiveEffects(spellController.waterFiveDamage); }
        else if (blackMagicController.waterSix == true) { WaterSixEffects(spellController.waterSixDamage); }



        else if (blackMagicController.freezeOne == true) { FreezeOneEffects(spellController.freezeOneSeconds); }
        else if (blackMagicController.freezeTwo == true) { FreezeTwoEffects(spellController.freezeTwoSeconds); }
        else if (blackMagicController.freezeThree == true) { FreezeThreeEffects(spellController.freezeThreeSeconds); }

        else if (blackMagicController.burnOne == true) { BurnOneEffects(spellController.burnOneSeconds, spellController.burnOneDamagePercentage, spellController.burnOneTimes); }
        else if (blackMagicController.burnTwo == true) { BurnTwoEffects(spellController.burnTwoSeconds, spellController.burnTwoDamagePercentage, spellController.burnTwoTimes); }
        else if (blackMagicController.burnThree == true) { BurnThreeEffects(spellController.burnThreeSeconds, spellController.burnThreeDamagePercentage, spellController.burnThreeTimes); }

        else if (blackMagicController.silenceOne == true) { SilenceOneEffects(spellController.silenceOnePercentage, spellController.silenceOneSeconds); }
        else if (blackMagicController.silenceTwo == true) { SilenceTwoEffects(spellController.silenceTwoPercentage, spellController.silenceTwoSeconds); }
        else if (blackMagicController.silenceThree == true) { SilenceThreeEffects(spellController.silenceThreePercentage, spellController.silenceThreeSeconds); }

        else if (blackMagicController.blindOne == true) { BlindOneEffects(spellController.blindOnePercentage, spellController.blindOneSeconds); }
        else if (blackMagicController.blindTwo == true) { BlindTwoEffects(spellController.blindTwoPercentage, spellController.blindTwoSeconds); }
        else if (blackMagicController.blindThree == true) { BlindThreeEffects(spellController.blindThreePercentage, spellController.blindThreeSeconds); }
    }




    public void ClumsyOneEffects()
    {
        abModifierPercentageTemporary = spellController.clumsyOneABMod; TemporaryBuffsAndDebuffs();
        abDown = true;
    }

    public void ClumsyTwoEffects()
    {
        abModifierPercentageTemporary = spellController.clumsyTwoABMod; TemporaryBuffsAndDebuffs();
        abDown = true;
    }

    public void ClumsyThreeEffects()
    {
        abModifierPercentageTemporary = spellController.clumsyThreeABMod; TemporaryBuffsAndDebuffs();
        abDown = true;
    }




    public void WeakenOneEffects()
    {
        attackModifierPercentageTemporary = spellController.weakenOneAttackMod; TemporaryBuffsAndDebuffs();
        attackDown = true;
    }

    public void WeakenTwoEffects()
    {
        attackModifierPercentageTemporary = spellController.weakenTwoAttackMod; TemporaryBuffsAndDebuffs();
        attackDown = true;
    }

    public void WeakenThreeEffects()
    {
        attackModifierPercentageTemporary = spellController.weakenThreeAttackMod; TemporaryBuffsAndDebuffs();
        attackDown = true;
    }



    public void DeflateArmorOneEffects()
    {
        defenseModifierPercentageTemporary = spellController.deflateArmorOneAttackMod; TemporaryBuffsAndDebuffs();
        defenseDown = true;
    }

    public void DeflateArmorTwoEffects()
    {
        defenseModifierPercentageTemporary = spellController.deflateArmorTwoAttackMod; TemporaryBuffsAndDebuffs();
        defenseDown = true;
    }

    public void DeflateArmorThreeEffects()
    {
        defenseModifierPercentageTemporary = spellController.deflateArmorThreeAttackMod; TemporaryBuffsAndDebuffs();
        defenseDown = true;
    }



    public void DeflateMagicProtectionOneEffects()
    {
        magicDefenseModifierPercentageTemporary = spellController.deflateMagicProtectionOneAttackMod; TemporaryBuffsAndDebuffs();
        magicDefenseDown = true;
    }

    public void DeflateMagicProtectionTwoEffects()
    {
        magicDefenseModifierPercentageTemporary = spellController.deflateMagicProtectionTwoAttackMod; TemporaryBuffsAndDebuffs();
        magicDefenseDown = true;
    }

    public void DeflateMagicProtectionThreeEffects()
    {
        magicDefenseModifierPercentageTemporary = spellController.deflateMagicProtectionThreeAttackMod; TemporaryBuffsAndDebuffs();
        magicDefenseDown = true;
    }



    public void FeeblemindOneEffects()
    {
        magicModifierPercentageTemporary = spellController.feeblemindOneAttackMod; TemporaryBuffsAndDebuffs();
        magicDown = true;
    }

    public void FeeblemindTwoEffects()
    {
        magicModifierPercentageTemporary = spellController.feeblemindTwoAttackMod; TemporaryBuffsAndDebuffs();
        magicDown = true;
    }

    public void FeeblemindThreeEffects()
    {
        magicModifierPercentageTemporary = spellController.feeblemindThreeAttackMod; TemporaryBuffsAndDebuffs();
        magicDown = true;
    }


   

    public void DispelOneEffects()
    {
        for (int number = 0; number < spellController.dispelOneAmount; number++)
        {
            DispelEffects();
        }
    }

    public void DispelTwoEffects()
    {
        for (int number = 0; number < spellController.dispelTwoAmount; number++)
        {
            DispelEffects();
        }
    }

    public void DispelThreeEffects()
    {
        for (int number = 0; number < spellController.dispelThreeAmount; number++)
        {
            DispelEffects();
        }
    }

    void DispelEffects()
    {
        if (attackUp == false && attackUp == false && magicUp == false && magicDown == false &&
            defenseUp == false && defenseDown == false && magicDefenseUp == false && magicDefenseDown == false &&
            abUp == false && abDown == false && maxHealthUp == false && maxHealthDown == false)
        {
            Debug.Log("no nothing");
            return;
        }
        Debug.Log("yes anything");

        var randomNumber = Random.Range(0, 5);

        bool toContinue = false;

        if (randomNumber == 0)
        {
            if (magicUp == true || magicDown == true)
            {
                magicModifierPercentageTemporary = 0; TemporaryBuffsAndDebuffs();

                magicUp = false;
                magicDown = false;

                toContinue = true;
            }
        }

        else if (randomNumber == 1)
        {
            if (magicDefenseUp == true || magicDefenseDown == true)
            {
                magicDefenseModifierPercentageTemporary = 0; TemporaryBuffsAndDebuffs();

                magicDefenseUp = false;
                magicDefenseDown = false;

                toContinue = true;
            }
        }

        else if (randomNumber == 2)
        {
            if (defenseUp == true || defenseDown == true)
            {
                defenseModifierPercentageTemporary = 0; TemporaryBuffsAndDebuffs();

                defenseUp = false;
                defenseDown = false;

                toContinue = true;
            }
        }

        else if (randomNumber == 3)
        {
            if (attackUp == true || attackDown == true)
            {
                attackModifierPercentageTemporary = 0; TemporaryBuffsAndDebuffs();

                attackUp = false;
                attackDown = false;

                toContinue = true;
            }
        }


        else if (randomNumber == 4)
        {
            if (abUp == true || abDown == true)
            {
                abModifierPercentageTemporary = 0; TemporaryBuffsAndDebuffs();

                abUp = false;
                abDown = false;

                toContinue = true;
            }
        }

        if (toContinue == false)
        {
            DispelEffects();
            Debug.Log("It's going to Repeat");
        }

        Debug.Log("Max Health Buff to Add");
    }




    ////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////
    


    public void IceOneEffects(float spellName)
    {
        float iceDamage = spellName;
        float iceResistanceCalculation = Mathf.RoundToInt((iceDamage * iceResistance / 100));

        iceDamage -= iceResistanceCalculation;

        gettingHitWithIce = true;

        GettingHitFromWizardSpell(iceDamage);
    }

    public void IceTwoEffects(float spellName)
    {
        float iceDamage = spellName;
        float iceResistanceCalculation = Mathf.RoundToInt((iceDamage * iceResistance / 100));

        iceDamage -= iceResistanceCalculation;

        gettingHitWithIce = true;

        GettingHitFromWizardSpell(iceDamage);
    }

    public void IceThreeEffects(float spellName)
    {
        float iceDamage = spellName;
        float iceResistanceCalculation = Mathf.RoundToInt((iceDamage * iceResistance / 100));

        iceDamage -= iceResistanceCalculation;

        gettingHitWithIce = true;

        GettingHitFromWizardSpell(iceDamage);
    }



    public void IceFourEffects(float spellName)
    {
        float iceDamage = spellName;
        float iceResistanceCalculation = Mathf.RoundToInt((iceDamage * iceResistance / 100));

        iceDamage -= iceResistanceCalculation;

        gettingHitWithIce = true;

        GettingHitFromWizardSpell(iceDamage);
    }

    public void IceFiveEffects(float spellName)
    {
        float iceDamage = spellName;
        float iceResistanceCalculation = Mathf.RoundToInt((iceDamage * iceResistance / 100));

        iceDamage -= iceResistanceCalculation;

        gettingHitWithIce = true;

        GettingHitFromWizardSpell(iceDamage);
    }

    public void IceSixEffects(float spellName)
    {
        float iceDamage = spellName;
        float iceResistanceCalculation = Mathf.RoundToInt((iceDamage * iceResistance / 100));

        iceDamage -= iceResistanceCalculation;

        gettingHitWithIce = true;

        GettingHitFromWizardSpell(iceDamage);
    }


    public void FireOneEffects(float spellName)
    {
        float fireDamage = spellName;
        float fireResistanceCalculation = Mathf.RoundToInt((fireDamage * fireResistance / 100));

        fireDamage -= fireResistanceCalculation;

        gettingHitWithFire = true;

        GettingHitFromWizardSpell(fireDamage);
    }

    public void FireTwoEffects(float spellName)
    {
        float fireDamage = spellName;
        float fireResistanceCalculation = Mathf.RoundToInt((fireDamage * fireResistance / 100));

        fireDamage -= fireResistanceCalculation;

        gettingHitWithFire = true;

        GettingHitFromWizardSpell(fireDamage);
    }

    public void FireThreeEffects(float spellName)
    {
        float fireDamage = spellName;
        float fireResistanceCalculation = Mathf.RoundToInt((fireDamage * fireResistance / 100));

        fireDamage -= fireResistanceCalculation;

        gettingHitWithFire = true;

        GettingHitFromWizardSpell(fireDamage);
    }



    public void FireFourEffects(float spellName)
    {
        float fireDamage = spellName;
        float fireResistanceCalculation = Mathf.RoundToInt((fireDamage * fireResistance / 100));

        fireDamage -= fireResistanceCalculation;

        gettingHitWithFire = true;

        GettingHitFromWizardSpell(fireDamage);
    }

    public void FireFiveEffects(float spellName)
    {
        float fireDamage = spellName;
        float fireResistanceCalculation = Mathf.RoundToInt((fireDamage * fireResistance / 100));

        fireDamage -= fireResistanceCalculation;

        gettingHitWithFire = true;

        GettingHitFromWizardSpell(fireDamage);
    }

    public void FireSixEffects(float spellName)
    {
        float fireDamage = spellName;
        float fireResistanceCalculation = Mathf.RoundToInt((fireDamage * fireResistance / 100));

        fireDamage -= fireResistanceCalculation;

        gettingHitWithFire = true;

        GettingHitFromWizardSpell(fireDamage);
    }


    public void WaterOneEffects(float spellName)
    {
        float waterDamage = spellName;
        float waterResistanceCalculation = Mathf.RoundToInt((waterDamage * waterResistance / 100));

        waterDamage -= waterResistanceCalculation;

        gettingHitWithWater = true;

        GettingHitFromWizardSpell(waterDamage);
    }

    public void WaterTwoEffects(float spellName)
    {
        float waterDamage = spellName;
        float waterResistanceCalculation = Mathf.RoundToInt((waterDamage * waterResistance / 100));

        waterDamage -= waterResistanceCalculation;

        gettingHitWithWater = true;

        GettingHitFromWizardSpell(waterDamage);
    }

    public void WaterThreeEffects(float spellName)
    {
        float waterDamage = spellName;
        float waterResistanceCalculation = Mathf.RoundToInt((waterDamage * waterResistance / 100));

        waterDamage -= waterResistanceCalculation;

        gettingHitWithWater = true;

        GettingHitFromWizardSpell(waterDamage);
    }



    public void WaterFourEffects(float spellName)
    {
        float waterDamage = spellName;
        float waterResistanceCalculation = Mathf.RoundToInt((waterDamage * waterResistance / 100));

        waterDamage -= waterResistanceCalculation;

        gettingHitWithWater = true;

        GettingHitFromWizardSpell(waterDamage);
    }

    public void WaterFiveEffects(float spellName)
    {
        float waterDamage = spellName;
        float waterResistanceCalculation = Mathf.RoundToInt((waterDamage * waterResistance / 100));

        waterDamage -= waterResistanceCalculation;

        gettingHitWithWater = true;

        GettingHitFromWizardSpell(waterDamage);
    }

    public void WaterSixEffects(float spellName)
    {
        float waterDamage = spellName;
        float waterResistanceCalculation = Mathf.RoundToInt((waterDamage * waterResistance / 100));

        waterDamage -= waterResistanceCalculation;

        gettingHitWithWater = true;

        GettingHitFromWizardSpell(waterDamage);
    }



    public void FreezeOneEffects(float spellName)
    {
        if (isBurning)
        {
            isBurning = false;
        }

        isFreezing = true;
        freezingTime = spellName;
        enemyAnimator.speed = 0;
    }

    public void FreezeTwoEffects(float spellName)
    {
        if (isBurning)
        {
            isBurning = false;
        }

        isFreezing = true;
        freezingTime = spellName;
        enemyAnimator.speed = 0;
    }

    public void FreezeThreeEffects(float spellName)
    {
        if (isBurning)
        {
            isBurning = false;
        }

        isFreezing = true;
        freezingTime = spellName;
        enemyAnimator.speed = 0;
    }



    public void BurnOneEffects(float spellSeconds, float damagePercentage, int times)
    {
        if (isFreezing)
        {
            isFreezing = false;
            enemyAnimator.speed = 1;
        }

        isBurning = true;
        burningTime = spellSeconds;
        burningPercentageDamage = damagePercentage;
        burningTimes = times;
        burningTimeSave = spellSeconds;
        burningFirstTime = true;
    }

    public void BurnTwoEffects(float spellSeconds, float damagePercentage, int times)
    {
        if (isFreezing)
        {
            isFreezing = false;
            enemyAnimator.speed = 1;
        }

        isBurning = true;
        burningTime = spellSeconds;
        burningPercentageDamage = damagePercentage;
        burningTimes = times;
        burningTimeSave = spellSeconds;
        burningFirstTime = true;
    }

    public void BurnThreeEffects(float spellSeconds, float damagePercentage, int times)
    {
        if (isFreezing)
        {
            isFreezing = false;
            enemyAnimator.speed = 1;
        }

        isBurning = true;
        burningTime = spellSeconds;
        burningPercentageDamage = damagePercentage;
        burningTimes = times;
        burningTimeSave = spellSeconds;
        burningFirstTime = true;
    }


    public void SilenceOneEffects(float spellName, float time)
    {
        isSilenced = true;
        silenceTime = time;
        silencePercentage = spellName;      
    }

    public void SilenceTwoEffects(float spellName, float time)
    {
        isSilenced = true;
        silenceTime = time;
        silencePercentage = spellName;
    }

    public void SilenceThreeEffects(float spellName, float time)
    {
        isSilenced = true;
        silenceTime = time;
        silencePercentage = spellName;
    }


    public void BlindOneEffects(float spellName, float time)
    {
        isBlinded = true;
        blindTime = time;
        blindPercentage = spellName;
    }

    public void BlindTwoEffects(float spellName, float time)
    {
        isBlinded = true;
        blindTime = time;
        blindPercentage = spellName;
    }

    public void BlindThreeEffects(float spellName, float time)
    {
        isBlinded = true;
        blindTime = time;
        blindPercentage = spellName;
    }
















    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////


    public void DisableTheGameObjectWithoutDisablingIt()
    {
        isDead = true;

        enemyAnimator.Rebind();

        spriteRenderer.enabled = false;
        shadowSpriteRenderer.enabled = false;
        canvasComponent.enabled = false;
        clickCanvas.enabled = false;

        enemyDisappear = false;
        enemyAppear = false;

        IsSilencedMethodStop();
        IsBlindedMethodStop();
        IsBurningMethodStop();
        IsFreezingMethodStop();

        attackUp = false;
        attackDown = false;
        magicUp = false;
        magicDown = false;
        defenseUp = false;
        defenseDown = false;
        magicDefenseUp = false;
        magicDefenseDown = false;
        abUp = false;
        abDown = false;
        maxHealthUp = false;
        maxHealthDown = false;

        thisScript.enabled = false;
    }

    //private void OnDisable()
    //{
    //    enemyDisappear = false;
    //    enemyAppear = false;

    //    IsSilencedMethodStop();
    //    IsBlindedMethodStop();
    //    IsBurningMethodStop();
    //    IsFreezingMethodStop();

    //    attackUp = false;
    //    attackDown = false;
    //    magicUp = false;
    //    magicDown = false;
    //    defenseUp = false;
    //    defenseDown = false;
    //    magicDefenseUp = false;
    //    magicDefenseDown = false;
    //    abUp = false;
    //    abDown = false;
    //    maxHealthUp = false;
    //    maxHealthDown = false;
    //}
}
