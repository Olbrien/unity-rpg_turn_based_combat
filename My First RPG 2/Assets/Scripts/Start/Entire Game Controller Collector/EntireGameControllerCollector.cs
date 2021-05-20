using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EntireGameControllerCollector : MonoBehaviour
{
    [Header("Global")]

    public int level;
    public int experience;
    public int gold;


    [Header("Main Menu")]

    public int completedLevels;
    public int selectedLevel;


    [Header("Paladin Spells")]

    public bool thePaladinSpecialAttack;

    public bool thePaladinSpellHealOne;
    public bool thePaladinSpellHealTwo;
    public bool thePaladinSpellHealThree;

    public bool thePaladinSpellStrenghtOne;
    public bool thePaladinSpellStrenghtTwo;
    public bool thePaladinSpellStrenghtThree;

    public bool thePaladinSpellArmorProtectOne;
    public bool thePaladinSpellArmorProtectTwo;
    public bool thePaladinSpellArmorProtectThree;


    [Header("Wizard Spells")]

    public bool theWizardSpecialAttack;

    public bool theWizardSpellIceOne;
    public bool theWizardSpellIceTwo;
    public bool theWizardSpellIceThree;

    public bool theWizardSpellFireOne;
    public bool theWizardSpellFireTwo;
    public bool theWizardSpellFireThree;

    public bool theWizardSpellWaterOne;
    public bool theWizardSpellWaterTwo;
    public bool theWizardSpellWaterThree;



    [Header("Paladin Stats")]

    public int paladinAttack;
    public int paladinMagic;

    public int paladinDefense;
    public int paladinMagicDefense;

    public int paladinMaxHealth;

    public float paladinSpeed;

    public float paladinIceResistance;
    public float paladinFireResistance;
    public float paladinWaterResistance;

    [Header("Wizard Stats")]

    public int wizardAttack;
    public int wizardMagic;

    public int wizardDefense;
    public int wizardMagicDefense;

    public int wizardMaxHealth;

    public float wizardSpeed;

    public float wizardIceResistance;
    public float wizardFireResistance;
    public float wizardWaterResistance;



    [Header("Paladin Items")]

    public int copperSabre;
    public int ironSabre;
    public int bronzeSabre;
    public int silverSabre;
    public int goldSabre;
    public int agapiteSabre;
    public int shadowSabre;
    public int strongholdSabre;
    public int verminardSabre;
    public int adamantineSabre;
    public int blackrockSabre;
    public int imperialSabre;

    public int apprenticePaladinBookVol1;
    public int apprenticePaladinBookVol2;
    public int journeymanPaladinBookVol1;
    public int journeymanPaladinBookVol2;
    public int lostPaladinBookVol1;
    public int lostPaladinBookVol2;
    public int expertPaladinBookVol1;
    public int grandmasterPaladinBookVol1;
    public int grandmasterPaladinBookVol2;
    public int imperialPaladinBookVol1;

    public int rustyCombatBoots;
    public int poorCombatBoots;
    public int fineCombatBoots;
    public int decentCombatBoots;
    public int excellentCombatBoots;
    public int imperialCombatBoots;

    public int rustyPlatemailArmor;
    public int poorPlatemailArmor;
    public int finePlatemailArmor;
    public int decentPlatemailArmor;
    public int excellentPlatemailArmor;
    public int imperialPlatemailArmor;

    public int amberTiara;
    public int rubyTiara;
    public int emeraldTiara;
    public int diamondTiara;
    public int citrineTiara;
    public int imperialStarSapphireTiara;


    [Header("Paladin Equiped Items")]

    public bool copperSabreEquiped;
    public bool ironSabreEquiped;
    public bool bronzeSabreEquiped;
    public bool silverSabreEquiped;
    public bool goldSabreEquiped;
    public bool agapiteSabreEquiped;
    public bool shadowSabreEquiped;
    public bool strongholdSabreEquiped;
    public bool verminardSabreEquiped;
    public bool adamantineSabreEquiped;
    public bool blackrockSabreEquiped;
    public bool imperialSabreEquiped;

    public bool apprenticePaladinBookVol1Equiped;
    public bool apprenticePaladinBookVol2Equiped;
    public bool journeymanPaladinBookVol1Equiped;
    public bool journeymanPaladinBookVol2Equiped;
    public bool lostPaladinBookVol1Equiped;
    public bool lostPaladinBookVol2Equiped;
    public bool expertPaladinBookVol1Equiped;
    public bool grandmasterPaladinBookVol1Equiped;
    public bool grandmasterPaladinBookVol2Equiped;
    public bool imperialPaladinBookVol1Equiped;

    public bool rustyCombatBootsEquiped;
    public bool poorCombatBootsEquiped;
    public bool fineCombatBootsEquiped;
    public bool decentCombatBootsEquiped;
    public bool excellentCombatBootsEquiped;
    public bool imperialCombatBootsEquiped;

    public bool rustyPlatemailArmorEquiped;
    public bool poorPlatemailArmorEquiped;
    public bool finePlatemailArmorEquiped;
    public bool decentPlatemailArmorEquiped;
    public bool excellentPlatemailArmorEquiped;
    public bool imperialPlatemailArmorEquiped;

    public bool amberTiaraEquiped;
    public bool rubyTiaraEquiped;
    public bool emeraldTiaraEquiped;
    public bool diamondTiaraEquiped;
    public bool citrineTiaraEquiped;
    public bool imperialStarSapphireTiaraEquiped;



    EntireGameController entireGameController;



    void Start()
    {
        Debug.Log(Application.persistentDataPath);

        entireGameController = GameObject.FindGameObjectWithTag("EntireGameController").GetComponent<EntireGameController>();

        UpdateMenuStuff();
        UpdatePaladinStats();
        UpdateWizardStats();
        UpdateGlobalStuff();
        UpdateSpells();

        UpdatePaladinItems();
        UpdatePaladinEquipedItems();
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            UpdateToSave();
            entireGameController.SaveGame();
        }
    }


    public void UpdateToSave()
    {
        entireGameController.level = level;
        entireGameController.experience = experience;
        entireGameController.gold = gold;



        entireGameController.completedLevels = completedLevels;
        entireGameController.selectedLevel = selectedLevel;



        entireGameController.paladinAttack = paladinAttack;
        entireGameController.paladinMagic = paladinMagic;
        entireGameController.paladinDefense = paladinDefense;
        entireGameController.paladinMagicDefense = paladinMagicDefense;
        entireGameController.paladinMaxHealth = paladinMaxHealth;
        entireGameController.paladinSpeed = paladinSpeed;
        entireGameController.paladinIceResistance = paladinIceResistance;
        entireGameController.paladinFireResistance = paladinFireResistance;
        entireGameController.paladinWaterResistance = paladinWaterResistance;

        entireGameController.wizardAttack = wizardAttack;
        entireGameController.wizardMagic = wizardMagic;
        entireGameController.wizardDefense = wizardDefense;
        entireGameController.wizardMagicDefense = wizardMagicDefense;
        entireGameController.wizardMaxHealth = wizardMaxHealth;
        entireGameController.wizardSpeed = wizardSpeed;
        entireGameController.wizardIceResistance = wizardIceResistance;
        entireGameController.wizardFireResistance = wizardFireResistance;
        entireGameController.wizardWaterResistance = wizardWaterResistance;



        entireGameController.thePaladinSpecialAttack = thePaladinSpecialAttack;
        entireGameController.thePaladinSpellHealOne = thePaladinSpellHealOne;
        entireGameController.thePaladinSpellHealTwo = thePaladinSpellHealTwo;
        entireGameController.thePaladinSpellHealThree = thePaladinSpellHealThree;
        entireGameController.thePaladinSpellStrenghtOne = thePaladinSpellStrenghtOne;
        entireGameController.thePaladinSpellStrenghtTwo = thePaladinSpellStrenghtTwo;
        entireGameController.thePaladinSpellStrenghtThree = thePaladinSpellStrenghtThree; 
        entireGameController.thePaladinSpellArmorProtectOne = thePaladinSpellArmorProtectOne;
        entireGameController.thePaladinSpellArmorProtectTwo = thePaladinSpellArmorProtectTwo;
        entireGameController.thePaladinSpellArmorProtectThree = thePaladinSpellArmorProtectThree;

        entireGameController.theWizardSpecialAttack = theWizardSpecialAttack;
        entireGameController.theWizardSpellIceOne = theWizardSpellIceOne;
        entireGameController.theWizardSpellIceTwo = theWizardSpellIceTwo;
        entireGameController.theWizardSpellIceThree = theWizardSpellIceThree;
        entireGameController.theWizardSpellFireOne = theWizardSpellFireOne;
        entireGameController.theWizardSpellFireTwo = theWizardSpellFireTwo;
        entireGameController.theWizardSpellFireThree = theWizardSpellFireThree;
        entireGameController.theWizardSpellWaterOne = theWizardSpellWaterOne;
        entireGameController.theWizardSpellWaterTwo = theWizardSpellWaterTwo;
        entireGameController.theWizardSpellWaterThree = theWizardSpellWaterThree;



        entireGameController.copperSabre = copperSabre;
        entireGameController.ironSabre = ironSabre;
        entireGameController.bronzeSabre = bronzeSabre;
        entireGameController.silverSabre = silverSabre;
        entireGameController.goldSabre = goldSabre;
        entireGameController.agapiteSabre = agapiteSabre;
        entireGameController.shadowSabre = shadowSabre;
        entireGameController.strongholdSabre = strongholdSabre;
        entireGameController.verminardSabre = verminardSabre;
        entireGameController.adamantineSabre = adamantineSabre;
        entireGameController.blackrockSabre = blackrockSabre;
        entireGameController.imperialSabre = imperialSabre;

        entireGameController.copperSabreEquiped = copperSabreEquiped;
        entireGameController.ironSabreEquiped = ironSabreEquiped;
        entireGameController.bronzeSabreEquiped = bronzeSabreEquiped;
        entireGameController.silverSabreEquiped = silverSabreEquiped;
        entireGameController.goldSabreEquiped = goldSabreEquiped;
        entireGameController.agapiteSabreEquiped = agapiteSabreEquiped;
        entireGameController.shadowSabreEquiped = shadowSabreEquiped;
        entireGameController.strongholdSabreEquiped = strongholdSabreEquiped;
        entireGameController.verminardSabreEquiped = verminardSabreEquiped;
        entireGameController.adamantineSabreEquiped = adamantineSabreEquiped;
        entireGameController.blackrockSabreEquiped = blackrockSabreEquiped;
        entireGameController.imperialSabreEquiped = imperialSabreEquiped;



        entireGameController.apprenticePaladinBookVol1 = apprenticePaladinBookVol1;
        entireGameController.apprenticePaladinBookVol2 = apprenticePaladinBookVol2;
        entireGameController.journeymanPaladinBookVol1 = journeymanPaladinBookVol1;
        entireGameController.journeymanPaladinBookVol2 = journeymanPaladinBookVol2;
        entireGameController.lostPaladinBookVol1 = lostPaladinBookVol1;
        entireGameController.lostPaladinBookVol2 = lostPaladinBookVol2;
        entireGameController.expertPaladinBookVol1 = expertPaladinBookVol1;
        entireGameController.grandmasterPaladinBookVol1 = grandmasterPaladinBookVol1;
        entireGameController.grandmasterPaladinBookVol2 = grandmasterPaladinBookVol2;
        entireGameController.imperialPaladinBookVol1 = imperialPaladinBookVol1;

        entireGameController.apprenticePaladinBookVol1Equiped = apprenticePaladinBookVol1Equiped;
        entireGameController.apprenticePaladinBookVol2Equiped = apprenticePaladinBookVol2Equiped;
        entireGameController.journeymanPaladinBookVol1Equiped = journeymanPaladinBookVol1Equiped;
        entireGameController.journeymanPaladinBookVol2Equiped = journeymanPaladinBookVol2Equiped;
        entireGameController.lostPaladinBookVol1Equiped = lostPaladinBookVol1Equiped;
        entireGameController.lostPaladinBookVol2Equiped = lostPaladinBookVol2Equiped;
        entireGameController.expertPaladinBookVol1Equiped = expertPaladinBookVol1Equiped;
        entireGameController.grandmasterPaladinBookVol1Equiped = grandmasterPaladinBookVol1Equiped;
        entireGameController.grandmasterPaladinBookVol2Equiped = grandmasterPaladinBookVol2Equiped;
        entireGameController.imperialPaladinBookVol1Equiped = imperialPaladinBookVol1Equiped;
                


        entireGameController.rustyCombatBoots = rustyCombatBoots;
        entireGameController.poorCombatBoots = poorCombatBoots;
        entireGameController.fineCombatBoots = fineCombatBoots;
        entireGameController.decentCombatBoots = decentCombatBoots;
        entireGameController.excellentCombatBoots = excellentCombatBoots;
        entireGameController.imperialCombatBoots = imperialCombatBoots;

        entireGameController.rustyCombatBootsEquiped = rustyCombatBootsEquiped;
        entireGameController.poorCombatBootsEquiped = poorCombatBootsEquiped;
        entireGameController.fineCombatBootsEquiped = fineCombatBootsEquiped;
        entireGameController.decentCombatBootsEquiped = decentCombatBootsEquiped;
        entireGameController.excellentCombatBootsEquiped = excellentCombatBootsEquiped;
        entireGameController.imperialCombatBootsEquiped = imperialCombatBootsEquiped;



        entireGameController.rustyPlatemailArmor = rustyPlatemailArmor;
        entireGameController.poorPlatemailArmor = poorPlatemailArmor;
        entireGameController.finePlatemailArmor = finePlatemailArmor;
        entireGameController.decentPlatemailArmor = decentPlatemailArmor;
        entireGameController.excellentPlatemailArmor = excellentPlatemailArmor;
        entireGameController.imperialPlatemailArmor = imperialPlatemailArmor;

        entireGameController.rustyPlatemailArmorEquiped = rustyPlatemailArmorEquiped;
        entireGameController.poorPlatemailArmorEquiped = poorPlatemailArmorEquiped;
        entireGameController.finePlatemailArmorEquiped = finePlatemailArmorEquiped;
        entireGameController.decentPlatemailArmorEquiped = decentPlatemailArmorEquiped;
        entireGameController.excellentPlatemailArmorEquiped = excellentPlatemailArmorEquiped;
        entireGameController.imperialPlatemailArmorEquiped = imperialPlatemailArmorEquiped;



        entireGameController.amberTiara = amberTiara;
        entireGameController.rubyTiara = rubyTiara;
        entireGameController.emeraldTiara = emeraldTiara;
        entireGameController.diamondTiara = diamondTiara;
        entireGameController.citrineTiara = citrineTiara;
        entireGameController.imperialStarSapphireTiara = imperialStarSapphireTiara;

        entireGameController.amberTiaraEquiped = amberTiaraEquiped;
        entireGameController.rubyTiaraEquiped = rubyTiaraEquiped;
        entireGameController.emeraldTiaraEquiped = emeraldTiaraEquiped;
        entireGameController.diamondTiaraEquiped = diamondTiaraEquiped;
        entireGameController.citrineTiaraEquiped = citrineTiaraEquiped;
        entireGameController.imperialStarSapphireTiaraEquiped = imperialStarSapphireTiaraEquiped;

    }


    public void UpdatePaladinStats()
    {
        paladinAttack = entireGameController.paladinAttack;
        paladinMagic = entireGameController.paladinMagic;

        paladinDefense = entireGameController.paladinDefense;
        paladinMagicDefense = entireGameController.paladinMagicDefense;

        paladinMaxHealth = entireGameController.paladinMaxHealth;

        paladinSpeed = entireGameController.paladinSpeed;

        paladinIceResistance = entireGameController.paladinIceResistance;
        paladinFireResistance = entireGameController.paladinFireResistance;
        paladinWaterResistance = entireGameController.paladinWaterResistance;
    }

    public void UpdateWizardStats()
    {
        wizardAttack = entireGameController.wizardAttack;
        wizardMagic = entireGameController.wizardMagic;

        wizardDefense = entireGameController.wizardDefense;
        wizardMagicDefense = entireGameController.wizardMagicDefense;

        wizardMaxHealth = entireGameController.wizardMaxHealth;

        wizardSpeed = entireGameController.wizardSpeed;

        wizardIceResistance = entireGameController.wizardIceResistance;
        wizardFireResistance = entireGameController.wizardFireResistance;
        wizardWaterResistance = entireGameController.wizardWaterResistance;
    }


    public void UpdateMenuStuff()
    {
        completedLevels = entireGameController.completedLevels;
        selectedLevel = entireGameController.selectedLevel;
    }


    public void UpdateSelectedLevel(int selectedNumber)
    {
        selectedLevel = selectedNumber;
        entireGameController.selectedLevel = selectedNumber;
    }


    public void UpdateGlobalStuff()
    {
        level = entireGameController.level;
        experience = entireGameController.experience;
        gold = entireGameController.gold;
    }


    public void UpdateSpells()
    {
        thePaladinSpecialAttack = entireGameController.thePaladinSpecialAttack;
        thePaladinSpellHealOne = entireGameController.thePaladinSpellHealOne;
        thePaladinSpellHealTwo = entireGameController.thePaladinSpellHealTwo;
        thePaladinSpellHealThree = entireGameController.thePaladinSpellHealThree;
        thePaladinSpellStrenghtOne = entireGameController.thePaladinSpellStrenghtOne;
        thePaladinSpellStrenghtTwo = entireGameController.thePaladinSpellStrenghtTwo;
        thePaladinSpellStrenghtThree = entireGameController.thePaladinSpellStrenghtThree;
        thePaladinSpellArmorProtectOne = entireGameController.thePaladinSpellArmorProtectOne;
        thePaladinSpellArmorProtectTwo = entireGameController.thePaladinSpellArmorProtectTwo;
        thePaladinSpellArmorProtectThree = entireGameController.thePaladinSpellArmorProtectThree;

        theWizardSpecialAttack = entireGameController.theWizardSpecialAttack;
        theWizardSpellIceOne = entireGameController.theWizardSpellIceOne;
        theWizardSpellIceTwo = entireGameController.theWizardSpellIceTwo;
        theWizardSpellIceThree = entireGameController.theWizardSpellIceThree;
        theWizardSpellFireOne = entireGameController.theWizardSpellFireOne;
        theWizardSpellFireTwo = entireGameController.theWizardSpellFireTwo;
        theWizardSpellFireThree = entireGameController.theWizardSpellFireThree;
        theWizardSpellWaterOne = entireGameController.theWizardSpellWaterOne;
        theWizardSpellWaterTwo = entireGameController.theWizardSpellWaterTwo;
        theWizardSpellWaterThree = entireGameController.theWizardSpellWaterThree;
    }



    public void UpdatePaladinItems()
    {
        copperSabre = entireGameController.copperSabre;
        ironSabre = entireGameController.ironSabre;
        bronzeSabre = entireGameController.bronzeSabre;
        silverSabre = entireGameController.silverSabre;
        goldSabre = entireGameController.goldSabre;
        agapiteSabre = entireGameController.agapiteSabre;
        shadowSabre = entireGameController.shadowSabre;
        strongholdSabre = entireGameController.strongholdSabre;
        verminardSabre = entireGameController.verminardSabre;
        adamantineSabre = entireGameController.adamantineSabre;
        blackrockSabre = entireGameController.blackrockSabre;
        imperialSabre = entireGameController.imperialSabre;

        apprenticePaladinBookVol1 = entireGameController.apprenticePaladinBookVol1;
        apprenticePaladinBookVol2 = entireGameController.apprenticePaladinBookVol2;
        journeymanPaladinBookVol1 = entireGameController.journeymanPaladinBookVol1;
        journeymanPaladinBookVol2 = entireGameController.journeymanPaladinBookVol2;
        lostPaladinBookVol1 = entireGameController.lostPaladinBookVol1;
        lostPaladinBookVol2 = entireGameController.lostPaladinBookVol2;
        expertPaladinBookVol1 = entireGameController.expertPaladinBookVol1;
        grandmasterPaladinBookVol1 = entireGameController.grandmasterPaladinBookVol1;
        grandmasterPaladinBookVol2 = entireGameController.grandmasterPaladinBookVol2;
        imperialPaladinBookVol1 = entireGameController.imperialPaladinBookVol1;

        rustyCombatBoots = entireGameController.rustyCombatBoots;
        poorCombatBoots = entireGameController.poorCombatBoots;
        fineCombatBoots = entireGameController.fineCombatBoots;
        decentCombatBoots = entireGameController.decentCombatBoots;
        excellentCombatBoots = entireGameController.excellentCombatBoots;
        imperialCombatBoots = entireGameController.imperialCombatBoots;

        rustyPlatemailArmor = entireGameController.rustyPlatemailArmor;
        poorPlatemailArmor = entireGameController.poorPlatemailArmor;
        finePlatemailArmor = entireGameController.finePlatemailArmor;
        decentPlatemailArmor = entireGameController.decentPlatemailArmor;
        excellentPlatemailArmor = entireGameController.excellentPlatemailArmor;
        imperialPlatemailArmor = entireGameController.imperialPlatemailArmor;

        amberTiara = entireGameController.amberTiara;
        rubyTiara = entireGameController.rubyTiara;
        emeraldTiara = entireGameController.emeraldTiara;
        diamondTiara = entireGameController.diamondTiara;
        citrineTiara = entireGameController.citrineTiara;
        imperialStarSapphireTiara = entireGameController.imperialStarSapphireTiara;
    }






    public void UpdatePaladinEquipedItems()
    {
        copperSabreEquiped = entireGameController.copperSabreEquiped;
        ironSabreEquiped = entireGameController.ironSabreEquiped;
        bronzeSabreEquiped = entireGameController.bronzeSabreEquiped;
        silverSabreEquiped = entireGameController.silverSabreEquiped;
        goldSabreEquiped = entireGameController.goldSabreEquiped;
        agapiteSabreEquiped = entireGameController.agapiteSabreEquiped;
        shadowSabreEquiped = entireGameController.shadowSabreEquiped;
        strongholdSabreEquiped = entireGameController.strongholdSabreEquiped;
        verminardSabreEquiped = entireGameController.verminardSabreEquiped;
        adamantineSabreEquiped = entireGameController.adamantineSabreEquiped;
        blackrockSabreEquiped = entireGameController.blackrockSabreEquiped;
        imperialSabreEquiped = entireGameController.imperialSabreEquiped;

        apprenticePaladinBookVol1Equiped = entireGameController.apprenticePaladinBookVol1Equiped;
        apprenticePaladinBookVol2Equiped = entireGameController.apprenticePaladinBookVol2Equiped;
        journeymanPaladinBookVol1Equiped = entireGameController.journeymanPaladinBookVol1Equiped;
        journeymanPaladinBookVol2Equiped = entireGameController.journeymanPaladinBookVol2Equiped;
        lostPaladinBookVol1Equiped = entireGameController.lostPaladinBookVol1Equiped;
        lostPaladinBookVol2Equiped = entireGameController.lostPaladinBookVol2Equiped;
        expertPaladinBookVol1Equiped = entireGameController.expertPaladinBookVol1Equiped;
        grandmasterPaladinBookVol1Equiped = entireGameController.grandmasterPaladinBookVol1Equiped;
        grandmasterPaladinBookVol2Equiped = entireGameController.grandmasterPaladinBookVol2Equiped;
        imperialPaladinBookVol1Equiped = entireGameController.imperialPaladinBookVol1Equiped;

        rustyCombatBootsEquiped = entireGameController.rustyCombatBootsEquiped;
        poorCombatBootsEquiped = entireGameController.poorCombatBootsEquiped;
        fineCombatBootsEquiped = entireGameController.fineCombatBootsEquiped;
        decentCombatBootsEquiped = entireGameController.decentCombatBootsEquiped;
        excellentCombatBootsEquiped = entireGameController.excellentCombatBootsEquiped;
        imperialCombatBootsEquiped = entireGameController.imperialCombatBootsEquiped;

        rustyPlatemailArmorEquiped = entireGameController.rustyPlatemailArmorEquiped;
        poorPlatemailArmorEquiped = entireGameController.poorPlatemailArmorEquiped;
        finePlatemailArmorEquiped = entireGameController.finePlatemailArmorEquiped;
        decentPlatemailArmorEquiped = entireGameController.decentPlatemailArmorEquiped;
        excellentPlatemailArmorEquiped = entireGameController.excellentPlatemailArmorEquiped;
        imperialPlatemailArmorEquiped = entireGameController.imperialPlatemailArmorEquiped;

        amberTiaraEquiped = entireGameController.amberTiaraEquiped;
        rubyTiaraEquiped = entireGameController.rubyTiaraEquiped;
        emeraldTiaraEquiped = entireGameController.emeraldTiaraEquiped;
        diamondTiaraEquiped = entireGameController.diamondTiaraEquiped;
        citrineTiaraEquiped = entireGameController.citrineTiaraEquiped;
        imperialStarSapphireTiaraEquiped = entireGameController.imperialStarSapphireTiaraEquiped;
    }





    public void SaveGameToMain()
    {
        UpdateToSave();
        entireGameController.SaveGame();
    }

    public void LoadGameToMain()
    {
        entireGameController.LoadGame();
    }


}
