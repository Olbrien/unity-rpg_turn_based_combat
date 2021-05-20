using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    public GameController gameController;
    public ClickController clickController;
    public EventsChatController eventsChatController;

    [Header("Enemy Pools")]
    public List<GameObject> poolBoar;
    public List<GameObject> poolDarkBoar;
    public List<GameObject> poolThree;
    public List<GameObject> poolFour;
    public List<GameObject> poolFive;
    public List<GameObject> poolSix;
    public List<GameObject> poolSeven;
    public List<GameObject> poolEight;
    public List<GameObject> poolNine;
    public List<GameObject> poolTen;


    [Header("Enemy Prefabs")]

    public GameObject boarPrefab;
    int quantityBoar;
    public EnemyBoar boarStats;
    [Space(10)]

    public GameObject darkBoarPrefab;
    int quantityDarkBoar;
    public EnemyDarkBoar darkBoarStats;


    [Header("---- Area 1 ----")]

    public bool a1Spawn1Boar;
    public bool a1Spawn2Boar;
    public bool a1Spawn3Boar;

    public bool a1Spawn1DarkBoar;
    public bool a1Spawn2DarkBoar;

    public bool a1Spawn3Boar1DarkBoar;
    public bool a1Spawn3Boar2DarkBoar;





    [HideInInspector]
    public int maxHealth;
    [HideInInspector]
    public int currentHealth;
    [HideInInspector]
    public int maxMP;
    [HideInInspector]
    public int currentMP;
    [HideInInspector]
    public int attack;
    [HideInInspector]
    public int attackModifierPercentage;

    GameObject[] findAllEnemyClick;

    List<Vector3> spawnPositionsVectors;
    List<int> spawnNumberInPosition;

    int numberOfTotalSpawns;
    




    void Awake()
    {


    }

    void Start()
    {
        SpawnEnemies();

        //clickController.RefreshOnClickOnEnemies();

    }


    void Update()
    {
        
    }    



    public void SpawnEnemies()
    {
        StartCoroutine(SpawnEnemiesCoroutine());
    }

    IEnumerator SpawnEnemiesCoroutine()
    {
        ////////////
        // AREA 1 //
        ////////////        


        if (a1Spawn1Boar)
        {
            gameController.numberOfEnemies += 1;

            yield return new WaitForSeconds(4.5f);

            var position = new Vector3(2, 0.1f, 0);
            BoarStats(position);

            gameController.numberOfEnemies -= 1;
        }

        else if (a1Spawn2Boar)
        {
            gameController.numberOfEnemies += 1;

            yield return new WaitForSeconds(1f);

            var position = new Vector3(1.5f, 0.4f, 0);
            BoarStats(position);

            gameController.numberOfEnemies -= 1;

            //////////////////////////////////////////

            gameController.numberOfEnemies += 1;

            yield return new WaitForSeconds(1f);

            var positionTwo = new Vector3(2.5f, -0.2f, 0);
            BoarStats(positionTwo);

            gameController.numberOfEnemies -= 1;


        }

        else if (a1Spawn3Boar)
        {
            gameController.numberOfEnemies += 1;
            yield return new WaitForSeconds(1f);

            var position = new Vector3(1.761f, 0.522f, 0);
            BoarStats(position);

            gameController.numberOfEnemies -= 1;

            //////////////////////////////////////////

            gameController.numberOfEnemies += 1;
            yield return new WaitForSeconds(1f);

            var positionTwo = new Vector3(1.069f, 0.056f, 0);
            BoarStats(positionTwo);

            gameController.numberOfEnemies -= 1;

            //////////////////////////////////////////      
            
            gameController.numberOfEnemies += 1;
            yield return new WaitForSeconds(1f);

            var positionThree = new Vector3(2.304f, -0.32f, 0);
            BoarStats(positionThree);

            gameController.numberOfEnemies -= 1;

        }

        else if (a1Spawn1DarkBoar)
        {
            gameController.numberOfEnemies += 1;
            yield return new WaitForSeconds(1f);

            var position = new Vector3(2, 0.1f, 0);
            DarkBoarStats(position);

            gameController.numberOfEnemies -= 1;
        }

        else if (a1Spawn2DarkBoar)
        {
            gameController.numberOfEnemies += 1;
            yield return new WaitForSeconds(1f);

            var position = new Vector3(1.5f, 0.4f, 0);
            DarkBoarStats(position);

            gameController.numberOfEnemies -= 1;

            //////////////////////////////////////////

            gameController.numberOfEnemies += 1;
            yield return new WaitForSeconds(1f);

            var positionTwo = new Vector3(2.5f, -0.2f, 0);
            DarkBoarStats(positionTwo);

            gameController.numberOfEnemies -= 1;
        }

        else if (a1Spawn3Boar1DarkBoar)
        {
            gameController.numberOfEnemies += 1;
            yield return new WaitForSeconds(1f);

            var position = new Vector3(1.93f, -0.456f, 0);
            BoarStats(position);

            gameController.numberOfEnemies -= 1;

            //////////////////////////////////////////

            gameController.numberOfEnemies += 1;
            yield return new WaitForSeconds(1f);

            var positionTwo = new Vector3(1.111f, 0.196f, 0);
            BoarStats(positionTwo);

            gameController.numberOfEnemies -= 1;

            //////////////////////////////////////////      

            gameController.numberOfEnemies += 1;
            yield return new WaitForSeconds(1f);

            var positionThree = new Vector3(2.039f, 0.512f, 0);
            BoarStats(positionThree);

            gameController.numberOfEnemies -= 1;

            //////////////////////////////////////////
            
            gameController.numberOfEnemies += 1;
            yield return new WaitForSeconds(1f);

            var positionFour = new Vector3(2.844f, -0.136f, 0);
            DarkBoarStats(positionFour);

            gameController.numberOfEnemies -= 1;
        }


        else if (a1Spawn3Boar2DarkBoar)
        {
            gameController.numberOfEnemies += 1;
            yield return new WaitForSeconds(1f);

            var position = new Vector3(1.37f, 0.082f, 0);
            BoarStats(position);

            gameController.numberOfEnemies -= 1;

            //////////////////////////////////////////

            gameController.numberOfEnemies += 1;
            yield return new WaitForSeconds(1f);

            var positionTwo = new Vector3(0.842f, 0.623f, 0);
            BoarStats(positionTwo);

            gameController.numberOfEnemies -= 1;

            //////////////////////////////////////////      

            gameController.numberOfEnemies += 1;
            yield return new WaitForSeconds(1f);

            var positionThree = new Vector3(1.98f, -0.459f, 0);
            BoarStats(positionThree);

            gameController.numberOfEnemies -= 1;

            //////////////////////////////////////////
            
            gameController.numberOfEnemies += 1;
            yield return new WaitForSeconds(1f);

            var positionFour = new Vector3(3.07f, -0.207f, 0);
            DarkBoarStats(positionFour);

            gameController.numberOfEnemies -= 1;

            //////////////////////////////////////////
            
            gameController.numberOfEnemies += 1;
            yield return new WaitForSeconds(1f);

            var positionFive = new Vector3(2.37f, 0.473f, 0);
            DarkBoarStats(positionFive);

            gameController.numberOfEnemies -= 1;
        }
    }



    void BoarStats(Vector3 position)
    {
        foreach (var enemy in poolBoar)
        {
            if (enemy.GetComponent<SpriteRenderer>().enabled == false)
            {
                enemy.transform.position = position;

                var theEnemy = enemy.GetComponent<Enemy>();

                theEnemy.enabled = true;

                theEnemy.maxHealth = boarStats.maxHealth;
                theEnemy.maxHealthModifierPercentage = boarStats.maxHealthModifierPercentage;

                theEnemy.currentHealth = boarStats.currentHealth;
                theEnemy.currentHealthModifierPercentage = boarStats.currentHealthModifierPercentage;

                theEnemy.attack = boarStats.attack;
                theEnemy.attackModifierPercentage = boarStats.attackModifierPercentage;

                theEnemy.magic = boarStats.magic;
                theEnemy.magicModifierPercentage = boarStats.magicModifierPercentage;

                theEnemy.defense = boarStats.defense;
                theEnemy.defenseModifierPercentage = boarStats.defenseModifierPercentage;

                theEnemy.magicDefense = boarStats.magicDefense;
                theEnemy.magicDefenseModifierPercentage = boarStats.magicDefenseModifierPercentage;

                theEnemy.abModifierPercentage = boarStats.abModifierPercentage;

                theEnemy.iceResistance = boarStats.iceResistancePercentage;
                theEnemy.fireResistance = boarStats.fireResistancePercentage;
                theEnemy.waterResistance = boarStats.waterResistancePercentage;

                theEnemy.level = UnityEngine.Random.Range(boarStats.levelMin, boarStats.levelMax + 1);

                theEnemy.experience = boarStats.experience;

                theEnemy.EnableTheGameObjectWithoutEnablingIt();

                //boarOneEnemy.HealthBar();
                //boarOneEnemy.ABBar();

                break;
            }
        }
    }

    void DarkBoarStats(Vector3 position)
    {
        foreach (var enemy in poolDarkBoar)
        {
            if (enemy.GetComponent<SpriteRenderer>().enabled == false)
            {
                enemy.transform.position = position;

                var theEnemy = enemy.GetComponent<Enemy>();

                theEnemy.enabled = true;

                theEnemy.maxHealth = darkBoarStats.maxHealth;
                theEnemy.maxHealthModifierPercentage = darkBoarStats.maxHealthModifierPercentage;

                theEnemy.currentHealth = darkBoarStats.currentHealth;
                theEnemy.currentHealthModifierPercentage = darkBoarStats.currentHealthModifierPercentage;


                theEnemy.attack = darkBoarStats.attack;
                theEnemy.attackModifierPercentage = darkBoarStats.attackModifierPercentage;

                theEnemy.magic = darkBoarStats.magic;
                theEnemy.magicModifierPercentage = darkBoarStats.magicModifierPercentage;

                theEnemy.defense = darkBoarStats.defense;
                theEnemy.defenseModifierPercentage = darkBoarStats.defenseModifierPercentage;

                theEnemy.magicDefense = darkBoarStats.magicDefense;
                theEnemy.magicDefenseModifierPercentage = darkBoarStats.magicDefenseModifierPercentage;

                theEnemy.abModifierPercentage = darkBoarStats.abModifierPercentage;

                theEnemy.iceResistance = darkBoarStats.iceResistancePercentage;
                theEnemy.fireResistance = darkBoarStats.fireResistancePercentage;
                theEnemy.waterResistance = darkBoarStats.waterResistancePercentage;

                theEnemy.level = UnityEngine.Random.Range(darkBoarStats.levelMin, darkBoarStats.levelMax + 1);

                theEnemy.experience = darkBoarStats.experience;

                theEnemy.EnableTheGameObjectWithoutEnablingIt();

                //theEnemy.HealthBar();
                //theEnemy.ABBar();

                break;
            }
        }
    }
}



[System.Serializable]
public class EnemyBoar
{
    public int maxHealth;
    public float maxHealthModifierPercentage; 

    public int currentHealth;
    public float currentHealthModifierPercentage;

    public int attack;
    public float attackModifierPercentage;

    public int magic;
    public float magicModifierPercentage;

    public int defense;
    public float defenseModifierPercentage;

    public int magicDefense;
    public float magicDefenseModifierPercentage;

    public float abModifierPercentage;

    public float iceResistancePercentage;
    public float fireResistancePercentage;
    public float waterResistancePercentage;

    public int levelMin;
    public int levelMax;

    public int experience;


    public EnemyBoar(float iceResistancePercentageStats, float fireResistancePercentageStats, float waterResistancePercentageStats, int maxHealthStats, float maxHealthModifierPercentageStats, int currentHealthStats, float currentHealthModifierPercentageStats, int magicStats, float magicModifierPercentageStats, int attackStats, float attackModifierPercentageStats, int defenseStats, float defenseModifierStats, int magicDefenseStats, float magicDefenseModifierStats, float abModifierStats, int levelMinStats, int levelMaxStats, int experienceStats)
    {
        this.maxHealth = maxHealthStats;
        this.maxHealthModifierPercentage = maxHealthModifierPercentageStats;

        this.currentHealth = currentHealthStats;
        this.currentHealthModifierPercentage = currentHealthModifierPercentageStats;

        this.attack = attackStats;
        this.attackModifierPercentage = attackModifierPercentageStats;

        this.magic = magicStats;
        this.magicModifierPercentage = magicModifierPercentageStats;

        this.defense = defenseStats;
        this.defenseModifierPercentage = defenseModifierStats;

        this.magicDefense = magicDefenseStats;
        this.magicDefenseModifierPercentage = magicDefenseModifierStats;

        this.abModifierPercentage = abModifierStats;

        this.iceResistancePercentage = iceResistancePercentageStats;
        this.fireResistancePercentage = fireResistancePercentageStats;
        this.waterResistancePercentage = waterResistancePercentageStats;

        this.levelMin = levelMinStats;
        this.levelMax = levelMaxStats;

        this.experience = experienceStats;
    }
}



[System.Serializable]
public class EnemyDarkBoar
{
    public int maxHealth;
    public float maxHealthModifierPercentage;

    public int currentHealth;
    public float currentHealthModifierPercentage;

    public int attack;
    public float attackModifierPercentage;

    public int magic;
    public float magicModifierPercentage;

    public int defense;
    public float defenseModifierPercentage;

    public int magicDefense;
    public float magicDefenseModifierPercentage;

    public float abModifierPercentage;

    public float iceResistancePercentage;
    public float fireResistancePercentage;
    public float waterResistancePercentage;

    public int levelMin;
    public int levelMax;

    public int experience;

    public EnemyDarkBoar(float iceResistancePercentageStats, float fireResistancePercentageStats, float waterResistancePercentageStats, int maxHealthStats, float maxHealthModifierPercentageStats, int currentHealthStats, float currentHealthModifierPercentageStats, int magicStats, float magicModifierPercentageStats, int attackStats, float attackModifierPercentageStats, int defenseStats, float defenseModifierStats, int magicDefenseStats, float magicDefenseModifierStats, float abModifierStats, int levelMinStats, int levelMaxStats, int experienceStats)
    {
        this.maxHealth = maxHealthStats;
        this.maxHealthModifierPercentage = maxHealthModifierPercentageStats;

        this.currentHealth = currentHealthStats;
        this.currentHealthModifierPercentage = currentHealthModifierPercentageStats;

        this.attack = attackStats;
        this.attackModifierPercentage = attackModifierPercentageStats;

        this.defense = defenseStats;
        this.defenseModifierPercentage = defenseModifierStats;

        this.magicDefense = magicDefenseStats;
        this.magicDefenseModifierPercentage = magicDefenseModifierStats;

        this.iceResistancePercentage = iceResistancePercentageStats;
        this.fireResistancePercentage = fireResistancePercentageStats;
        this.waterResistancePercentage = waterResistancePercentageStats;

        this.abModifierPercentage = abModifierStats;

        this.levelMin = levelMinStats;
        this.levelMax = levelMaxStats;

        this.experience = experienceStats;
    }
}