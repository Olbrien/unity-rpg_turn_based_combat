using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStats : MonoBehaviour
{
    public int currentLevel;

    [Header("Paladin Base Stats at CurrentLevel")]

    public int paladinAttack;
    public int paladinMagic;

    public int paladinDefense;
    public int paladinMagicDefense;

    public int paladinMaxHealth;

    public float paladinSpeed;

    public float paladinIceResistance = 0;
    public float paladinFireResistance = 0;
    public float paladinWaterResistance = 0;

    [Header("Wizard Base Stats at CurrentLevel")]

    public int wizardAttack;
    public int wizardMagic;

    public int wizardDefense;
    public int wizardMagicDefense;

    public int wizardMaxHealth;

    public float wizardSpeed;

    public float wizardIceResistance = 0;
    public float wizardFireResistance = 0;
    public float wizardWaterResistance = 0;



    public EntireGameControllerCollector entireGameControllerCollector;
    public MainMenuController mainMenuController;
    public ItemStats itemStats;
    bool start = true;


    void Update()
    {
        if (start)
        {
            if (entireGameControllerCollector.level == 0) { currentLevel = 1; }
            else if (entireGameControllerCollector.level >= 1) { currentLevel = entireGameControllerCollector.level; }

            UpdateBaseStats();
            AddBaseStatsToEntireGameControllerCollector();
            itemStats.UpdateAllItems();
            mainMenuController.UpdatePlayerText();

            start = false;
        }
    }

    public void UpdateBaseStats()
    {
        if (currentLevel == 1)
        {
            paladinAttack = 20;
            paladinMagic = 5;
            paladinDefense = 20;
            paladinMagicDefense = 10;
            paladinMaxHealth = 350;
            paladinSpeed = 50;

            wizardAttack = 5;
            wizardMagic = 20;
            wizardDefense = 10;
            wizardMagicDefense = 20;
            wizardMaxHealth = 150;
            wizardSpeed = 30;
        }

        else if (currentLevel == 2)
        {
            paladinAttack = 30; // <--
            paladinMagic = 5;
            paladinDefense = 20;
            paladinMagicDefense = 10;
            paladinMaxHealth = 350;
            paladinSpeed = 50;

            wizardAttack = 5;
            wizardMagic = 30; // <--
            wizardDefense = 10;
            wizardMagicDefense = 20;
            wizardMaxHealth = 150;
            wizardSpeed = 30;
        }

        else if (currentLevel == 3)
        {
            paladinAttack = 30; 
            paladinMagic = 15; // <--
            paladinDefense = 20;
            paladinMagicDefense = 10;
            paladinMaxHealth = 450; // <-- 
            paladinSpeed = 50;

            wizardAttack = 12; // <--
            wizardMagic = 30; 
            wizardDefense = 10;
            wizardMagicDefense = 20;
            wizardMaxHealth = 250; // <-- 
            wizardSpeed = 30;
        }

        else if (currentLevel == 4)
        {
            paladinAttack = 50; // <--
            paladinMagic = 15; 
            paladinDefense = 20;
            paladinMagicDefense = 10;
            paladinMaxHealth = 500; // <-- 
            paladinSpeed = 60; // <-- 

            wizardAttack = 22; // <--
            wizardMagic = 60; // <--
            wizardDefense = 10;
            wizardMagicDefense = 30;  // <--
            wizardMaxHealth = 250; 
            wizardSpeed = 40; // <--
        }

        else if (currentLevel == 5)
        {
            paladinAttack = 50; 
            paladinMagic = 30; // <--
            paladinDefense = 30; // <--
            paladinMagicDefense = 20;  // <--
            paladinMaxHealth = 500;  
            paladinSpeed = 60; 

            wizardAttack = 32; // <--
            wizardMagic = 60; 
            wizardDefense = 20; // <--
            wizardMagicDefense = 40;  // <--
            wizardMaxHealth = 250;
            wizardSpeed = 40; 
        }


        else if (currentLevel == 6)
        {
            paladinAttack = 50;
            paladinMagic = 30; 
            paladinDefense = 70; // <--
            paladinMagicDefense = 40;  // <--
            paladinMaxHealth = 800; // <-- 
            paladinSpeed = 60;

            wizardAttack = 32; 
            wizardMagic = 60;
            wizardDefense = 40;  // <--
            wizardMagicDefense = 70;   // <--
            wizardMaxHealth = 500; // <-- 
            wizardSpeed = 40;
        }
    }



    public void AddBaseStatsToEntireGameControllerCollector()
    {
        entireGameControllerCollector.paladinAttack = paladinAttack;
        entireGameControllerCollector.paladinMagic = paladinMagic;
        entireGameControllerCollector.paladinDefense = paladinDefense;
        entireGameControllerCollector.paladinMagicDefense = paladinMagicDefense;
        entireGameControllerCollector.paladinMaxHealth = paladinMaxHealth;
        entireGameControllerCollector.paladinSpeed = paladinSpeed;
        entireGameControllerCollector.paladinIceResistance = paladinIceResistance;
        entireGameControllerCollector.paladinFireResistance = paladinFireResistance;
        entireGameControllerCollector.paladinWaterResistance = paladinWaterResistance;

        entireGameControllerCollector.wizardAttack = wizardAttack;
        entireGameControllerCollector.wizardMagic = wizardMagic;
        entireGameControllerCollector.wizardDefense = wizardDefense;
        entireGameControllerCollector.wizardMagicDefense = wizardMagicDefense;
        entireGameControllerCollector.wizardMaxHealth = wizardMaxHealth;
        entireGameControllerCollector.wizardSpeed = wizardSpeed;
        entireGameControllerCollector.wizardIceResistance = wizardIceResistance;
        entireGameControllerCollector.wizardFireResistance = wizardFireResistance;
        entireGameControllerCollector.wizardWaterResistance = wizardWaterResistance;
    }

}
