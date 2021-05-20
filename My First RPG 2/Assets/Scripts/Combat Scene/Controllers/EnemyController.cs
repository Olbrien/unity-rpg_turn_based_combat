using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public List<Enemy> slimesPool;
    public Slime slime;

    int randomLevel;
    float randomSpeed;
    float randomExperience;


    public void SlimeStats()
    {
        foreach (var theEnemy in slimesPool)
        {
            theEnemy.isSlime = true;

            theEnemy.StartMethods();

            theEnemy.maxHealth = slime.maxHealth;
            theEnemy.currentHealth = slime.currentHealth;

            theEnemy.attack = slime.attack;
            theEnemy.magic = slime.magic;

            theEnemy.defense = slime.defense;
            theEnemy.magicDefense = slime.magicDefense;

            theEnemy.speed = slime.speed;

            //randomSpeed = Random.Range(slime.speed + 2f, slime.speed - 2f);
            //randomSpeed = (Mathf.Round(randomSpeed * 100)) / 100;
            //theEnemy.speed = randomSpeed;

            theEnemy.iceResistance = slime.iceResistance;
            theEnemy.fireResistance = slime.fireResistance;
            theEnemy.waterResistance = slime.waterResistance;

            randomLevel = Random.Range(slime.levelMin, slime.levelMax);
            theEnemy.level = randomLevel;

            theEnemy.UpdateLevelText();

            if (randomLevel == slime.levelMax - 1)
            {
                theEnemy.experience = slime.maxExperience;
            }

            else if (randomLevel < slime.levelMax - 1)
            {
                randomExperience = slime.levelMax - 1 - randomLevel;

                if (randomExperience == 1) { theEnemy.experience = Mathf.RoundToInt(slime.maxExperience * 0.95f); }
                else if (randomExperience == 2) { theEnemy.experience = Mathf.RoundToInt(slime.maxExperience * 0.9f); }
                else if (randomExperience == 3) { theEnemy.experience = Mathf.RoundToInt(slime.maxExperience * 0.85f); }
                else if (randomExperience >= 4) { theEnemy.experience = Mathf.RoundToInt(slime.maxExperience * 0.8f); }
            }


            theEnemy.UpdateHealthBar();
        }
    }


}











[System.Serializable]

public class Slime
{
    public int maxHealth;
    public int currentHealth;

    public int attack;
    public int magic;

    public int defense;
    public int magicDefense;

    public float speed;

    public float iceResistance;
    public float fireResistance;
    public float waterResistance;

    public int levelMin;
    public int levelMax;

    public int maxExperience;


    public Slime(float iceResistancePercentageStats, float fireResistancePercentageStats, float waterResistancePercentageStats, int maxHealthStats, int currentHealthStats, int magicStats, int attackStats, int defenseStats, int magicDefenseStats, float speedStats, int levelMinStats, int levelMaxStats, int experienceStats)
    {
        this.maxHealth = maxHealthStats;
        this.currentHealth = currentHealthStats;

        this.attack = attackStats;
        this.magic = magicStats;

        this.defense = defenseStats;
        this.magicDefense = magicDefenseStats;

        this.speed = speedStats;

        this.iceResistance = iceResistancePercentageStats;
        this.fireResistance = fireResistancePercentageStats;
        this.waterResistance = waterResistancePercentageStats;

        this.levelMin = levelMinStats;
        this.levelMax = levelMaxStats;

        this.maxExperience = experienceStats;
    }
}

