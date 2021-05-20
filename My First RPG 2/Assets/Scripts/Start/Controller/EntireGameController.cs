using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntireGameController : MonoBehaviour
{

    [Header("Main Menu")]

    public int completedLevels;
    public int selectedLevel;

    [Header("Global")]

    public int level;
    public int experience;
    public int gold;


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





    int[] loadedStatsInt;
    float[] loadedStatsFloat;
    bool[] loadedStatsBool;




    void Awake()
    {
        //GameObject[] objs = GameObject.FindGameObjectsWithTag("EntireGameController"); // Apagar Isto!!!
        //// Apagar Isto!!!
        //if (objs.Length > 1)   // Apagar Isto!!!
        //{  // Apagar Isto!!!
        //    Destroy(this.gameObject);  // Apagar Isto!!!
        //}   // Apagar Isto!!!
        //    // Apagar Isto!!!   Isto é só para testar duplicados.

        DontDestroyOnLoad(gameObject);        

        SceneManager.activeSceneChanged += SceneManager_activeSceneChanged;     // Isto é para ler o Method abaixo sempre que 
                                                                                // muda a scene.     
    }
    

    private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
    {
        LoadGame();
        Quality();        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadGame();
        }
    }


    void Quality()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 30;
    }

    public void SaveGame()
    {
        SaveLoadManager.SavePlayerInt(this);
        SaveLoadManager.SavePlayerFloat(this);
        SaveLoadManager.SavePlayerBool(this);
        Debug.Log("Saving Game (Isto = Garbage. Apaga.)");
    }

    public void LoadGame()
    {
        Debug.Log("Loading Game (Isto = Garbage. Apaga.)");

        loadedStatsInt = SaveLoadManager.LoadPlayerInt();

        paladinAttack = loadedStatsInt[0];
        paladinMagic = loadedStatsInt[1];
        paladinDefense = loadedStatsInt[2];
        paladinMagicDefense = loadedStatsInt[3];
        paladinMaxHealth = loadedStatsInt[4];

        wizardAttack = loadedStatsInt[5];
        wizardMagic = loadedStatsInt[6];
        wizardDefense = loadedStatsInt[7];
        wizardMagicDefense = loadedStatsInt[8];
        wizardMaxHealth = loadedStatsInt[9];

        completedLevels = loadedStatsInt[10];
        selectedLevel = loadedStatsInt[11];

        level = loadedStatsInt[12];
        experience = loadedStatsInt[13];

        gold = loadedStatsInt[14];

        copperSabre = loadedStatsInt[15];
        ironSabre = loadedStatsInt[16];
        bronzeSabre = loadedStatsInt[17];
        silverSabre = loadedStatsInt[18];
        goldSabre = loadedStatsInt[19];
        agapiteSabre = loadedStatsInt[20];
        shadowSabre = loadedStatsInt[21];
        strongholdSabre = loadedStatsInt[22];
        verminardSabre = loadedStatsInt[23];
        adamantineSabre = loadedStatsInt[24];
        blackrockSabre = loadedStatsInt[25];
        imperialSabre = loadedStatsInt[26];

        apprenticePaladinBookVol1 = loadedStatsInt[27];
        apprenticePaladinBookVol2 = loadedStatsInt[28];
        journeymanPaladinBookVol1 = loadedStatsInt[29];
        journeymanPaladinBookVol2 = loadedStatsInt[30];
        lostPaladinBookVol1 = loadedStatsInt[31];
        lostPaladinBookVol2 = loadedStatsInt[32];
        expertPaladinBookVol1 = loadedStatsInt[33];
        grandmasterPaladinBookVol1 = loadedStatsInt[34];
        grandmasterPaladinBookVol2 = loadedStatsInt[35];
        imperialPaladinBookVol1 = loadedStatsInt[36];

        rustyCombatBoots = loadedStatsInt[37];
        poorCombatBoots = loadedStatsInt[38];
        fineCombatBoots = loadedStatsInt[39];
        decentCombatBoots = loadedStatsInt[40];
        excellentCombatBoots = loadedStatsInt[41];
        imperialCombatBoots = loadedStatsInt[42];

        rustyPlatemailArmor = loadedStatsInt[43];
        poorPlatemailArmor = loadedStatsInt[44];
        finePlatemailArmor = loadedStatsInt[45];
        decentPlatemailArmor = loadedStatsInt[46];
        excellentPlatemailArmor = loadedStatsInt[47];
        imperialPlatemailArmor = loadedStatsInt[48];

        amberTiara = loadedStatsInt[49];
        rubyTiara = loadedStatsInt[50];
        emeraldTiara = loadedStatsInt[51];
        diamondTiara = loadedStatsInt[52];
        citrineTiara = loadedStatsInt[53];
        imperialStarSapphireTiara = loadedStatsInt[54];




        loadedStatsFloat = SaveLoadManager.LoadPlayerFloat();

        paladinSpeed = loadedStatsFloat[0];
        paladinIceResistance = loadedStatsFloat[1];
        paladinFireResistance = loadedStatsFloat[2];
        paladinWaterResistance = loadedStatsFloat[3];

        wizardSpeed = loadedStatsFloat[4];
        wizardIceResistance = loadedStatsFloat[5];
        wizardFireResistance = loadedStatsFloat[6];
        wizardWaterResistance = loadedStatsFloat[7];


        loadedStatsBool = SaveLoadManager.LoadPlayerBool();


        thePaladinSpecialAttack = loadedStatsBool[0];
        thePaladinSpellHealOne = loadedStatsBool[1];
        thePaladinSpellHealTwo = loadedStatsBool[2];
        thePaladinSpellHealThree = loadedStatsBool[3];
        thePaladinSpellStrenghtOne = loadedStatsBool[4];
        thePaladinSpellStrenghtTwo = loadedStatsBool[5];
        thePaladinSpellStrenghtThree = loadedStatsBool[6];
        thePaladinSpellArmorProtectOne = loadedStatsBool[7];
        thePaladinSpellArmorProtectTwo = loadedStatsBool[8];
        thePaladinSpellArmorProtectThree = loadedStatsBool[9];

        theWizardSpecialAttack = loadedStatsBool[10];
        theWizardSpellIceOne = loadedStatsBool[11];
        theWizardSpellIceTwo = loadedStatsBool[12];
        theWizardSpellIceThree = loadedStatsBool[13];
        theWizardSpellFireOne = loadedStatsBool[14];
        theWizardSpellFireTwo = loadedStatsBool[15];
        theWizardSpellFireThree = loadedStatsBool[16];
        theWizardSpellWaterOne = loadedStatsBool[17];
        theWizardSpellWaterTwo = loadedStatsBool[18];
        theWizardSpellWaterThree = loadedStatsBool[19];


        copperSabreEquiped = loadedStatsBool[20];
        ironSabreEquiped = loadedStatsBool[21];
        bronzeSabreEquiped = loadedStatsBool[22];
        silverSabreEquiped = loadedStatsBool[23];
        goldSabreEquiped = loadedStatsBool[24];
        agapiteSabreEquiped = loadedStatsBool[25];
        shadowSabreEquiped = loadedStatsBool[26];
        strongholdSabreEquiped = loadedStatsBool[27];
        verminardSabreEquiped = loadedStatsBool[28];
        adamantineSabreEquiped = loadedStatsBool[29];
        blackrockSabreEquiped = loadedStatsBool[30];
        imperialSabreEquiped = loadedStatsBool[31];

        apprenticePaladinBookVol1Equiped = loadedStatsBool[32];
        apprenticePaladinBookVol2Equiped = loadedStatsBool[33];
        journeymanPaladinBookVol1Equiped = loadedStatsBool[34];
        journeymanPaladinBookVol2Equiped = loadedStatsBool[35];
        lostPaladinBookVol1Equiped = loadedStatsBool[36];
        lostPaladinBookVol2Equiped = loadedStatsBool[37];
        expertPaladinBookVol1Equiped = loadedStatsBool[38];
        grandmasterPaladinBookVol1Equiped = loadedStatsBool[39];
        grandmasterPaladinBookVol2Equiped = loadedStatsBool[40];
        imperialPaladinBookVol1Equiped = loadedStatsBool[41];

        rustyCombatBootsEquiped = loadedStatsBool[42];
        poorCombatBootsEquiped = loadedStatsBool[43];
        fineCombatBootsEquiped = loadedStatsBool[44];
        decentCombatBootsEquiped = loadedStatsBool[45];
        excellentCombatBootsEquiped = loadedStatsBool[46];
        imperialCombatBootsEquiped = loadedStatsBool[47];

        rustyPlatemailArmorEquiped = loadedStatsBool[48];
        poorPlatemailArmorEquiped = loadedStatsBool[49];
        finePlatemailArmorEquiped = loadedStatsBool[50];
        decentPlatemailArmorEquiped = loadedStatsBool[51];
        excellentPlatemailArmorEquiped = loadedStatsBool[52];
        imperialPlatemailArmorEquiped = loadedStatsBool[53];

        amberTiaraEquiped = loadedStatsBool[54];
        rubyTiaraEquiped = loadedStatsBool[55];
        emeraldTiaraEquiped = loadedStatsBool[56];
        diamondTiaraEquiped = loadedStatsBool[57];
        citrineTiaraEquiped = loadedStatsBool[58];
        imperialStarSapphireTiaraEquiped = loadedStatsBool[59];
    }
}

