using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class SaveLoadManager
{
    public static void SavePlayerInt(EntireGameController entireGameController)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream stream = new FileStream(Application.persistentDataPath + "//playerInt.sav", FileMode.Create);

        PlayerDataInt data = new PlayerDataInt(entireGameController);

        bf.Serialize(stream, data);
        stream.Close();
    }

    public static int[] LoadPlayerInt()
    {
        if (File.Exists(Application.persistentDataPath + "//playerInt.sav"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream(Application.persistentDataPath + "//playerInt.sav", FileMode.Open);

            PlayerDataInt data = bf.Deserialize(stream) as PlayerDataInt;
            stream.Close();
            return data.stats;
        }

        else
        {
            var standard = new int[55];
            standard[0] = 20; // entireGameController.paladinAttack;
            standard[1] =  5; // entireGameController.paladinMagic;
            standard[2] = 20; // entireGameController.paladinDefense;
            standard[3] = 10; // entireGameController.paladinMagicDefense;
            standard[4] = 350; // entireGameController.paladinMaxHealth;

            standard[5] =  5; // entireGameController.wizardAttack;
            standard[6] = 20; // entireGameController.wizardMagic;
            standard[7] = 10; // entireGameController.wizardDefense;
            standard[8] = 20; // entireGameController.wizardMagicDefense;
            standard[9] = 150; // entireGameController.wizardMaxHealth;

            standard[10] = 0; // entireGameController.completedLevels;
            standard[11] = 0; // entireGameController.selectedLevel;

            standard[12] = 0; // entireGameController.level;
            standard[13] = 0; // entireGameController.experience;       

            standard[14] = 0; // entireGameController.gold;

            standard[15] = 1; // entireGameController.copperSabre; Põe 1 neste e 0 nos outros.
            standard[16] = 1; // entireGameController.ironSabre;
            standard[17] = 1; // entireGameController.bronzeSabre;
            standard[18] = 1; // entireGameController.silverSabre;
            standard[19] = 1; // entireGameController.goldSabre;
            standard[20] = 1; // entireGameController.agapiteSabre;
            standard[21] = 1; // entireGameController.shadowSabre;
            standard[22] = 1; // entireGameController.strongholdSabre;
            standard[23] = 1; // entireGameController.verminardSabre;
            standard[24] = 1; // entireGameController.adamantineSabre;
            standard[25] = 1; // entireGameController.blackrockSabre;
            standard[26] = 1; // entireGameController.imperialSabre;

            standard[27] = 1; // entireGameController.apprenticePaladinBookVol1;
            standard[28] = 1; // entireGameController.apprenticePaladinBookVol2;
            standard[29] = 1; // entireGameController.journeymanPaladinBookVol1;
            standard[30] = 1; // entireGameController.journeymanPaladinBookVol2;
            standard[31] = 1; // entireGameController.lostPaladinBookVol1;
            standard[32] = 1; // entireGameController.lostPaladinBookVol2;
            standard[33] = 1; // entireGameController.expertPaladinBookVol1;
            standard[34] = 1; // entireGameController.grandmasterPaladinBookVol1;
            standard[35] = 1; // entireGameController.grandmasterPaladinBookVol2;
            standard[36] = 1; // entireGameController.imperialPaladinBookVol1;

            standard[37] = 1; // entireGameController.rustyCombatBoots;
            standard[38] = 1; // entireGameController.poorCombatBoots;
            standard[39] = 1; // entireGameController.fineCombatBoots;
            standard[40] = 1; // entireGameController.decentCombatBoots;
            standard[41] = 1; // entireGameController.excellentCombatBoots;
            standard[42] = 1; // entireGameController.imperialCombatBoots;

            standard[43] = 1; // entireGameController.rustyPlatemailArmor;
            standard[44] = 1; // entireGameController.poorPlatemailArmor;
            standard[45] = 1; // entireGameController.finePlatemailArmor;
            standard[46] = 1; // entireGameController.decentPlatemailArmor;
            standard[47] = 1; // entireGameController.excellentPlatemailArmor;
            standard[48] = 1; // entireGameController.imperialPlatemailArmor;

            standard[49] = 1; // entireGameController.amberTiara;
            standard[50] = 1; // entireGameController.rubyTiara;
            standard[51] = 1; // entireGameController.emeraldTiara;
            standard[52] = 1; // entireGameController.diamondTiara;
            standard[53] = 1; // entireGameController.citrineTiara;
            standard[54] = 1; // entireGameController.imperialStarSapphireTiara;





            Debug.Log("No Loading File, Standard Stats (Isto = Garbage. Apaga.)");
            return standard;
        }
    }





    public static void SavePlayerFloat(EntireGameController entireGameController)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream stream = new FileStream(Application.persistentDataPath + "//playerFloat.sav", FileMode.Create);

        PlayerDataFloat data = new PlayerDataFloat(entireGameController);

        bf.Serialize(stream, data);
        stream.Close();
    }


    public static float[] LoadPlayerFloat()
    {
        if (File.Exists(Application.persistentDataPath + "//playerFloat.sav"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream(Application.persistentDataPath + "//playerFloat.sav", FileMode.Open);

            PlayerDataFloat data = bf.Deserialize(stream) as PlayerDataFloat;
            stream.Close();
            return data.stats;
        }

        else
        {
            var standard = new float[8];
            standard[0] = 50; // entireGameController.paladinSpeed;
            standard[1] = 50; // entireGameController.paladinIceResistance;
            standard[2] = -50; // entireGameController.paladinFireResistance;
            standard[3] = -50; // entireGameController.paladinWaterResistance;

            standard[4] = 30; // entireGameController.wizardSpeed;
            standard[5] = 43.9f; // entireGameController.wizardIceResistance;
            standard[6] = -100; // entireGameController.wizardFireResistance;
            standard[7] = -5.9f; // entireGameController.wizardWaterResistance;


            Debug.Log("No Loading File. (Isto = Garbage. Apaga.)");
            return standard;
        }
    }




    public static void SavePlayerBool(EntireGameController entireGameController)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream stream = new FileStream(Application.persistentDataPath + "//playerBool.sav", FileMode.Create);

        PlayerDataBool data = new PlayerDataBool(entireGameController);

        bf.Serialize(stream, data);
        stream.Close();
    }


    public static bool[] LoadPlayerBool()
    {
        if (File.Exists(Application.persistentDataPath + "//playerBool.sav"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream(Application.persistentDataPath + "//playerBool.sav", FileMode.Open);

            PlayerDataBool data = bf.Deserialize(stream) as PlayerDataBool;
            stream.Close();
            return data.stats;
        }

        else
        {
            var standard = new bool[60];

            standard[0] = false; //entireGameController.thePaladinSpecialAttack;
            standard[1] = false; //entireGameController.thePaladinSpellHealOne;
            standard[2] = false; //entireGameController.thePaladinSpellHealTwo;
            standard[3] = false; //entireGameController.thePaladinSpellHealThree;
            standard[4] = false; //entireGameController.thePaladinSpellStrenghtOne;
            standard[5] = false; //entireGameController.thePaladinSpellStrenghtTwo;
            standard[6] = false; //entireGameController.thePaladinSpellStrenghtThree;
            standard[7] = false; //entireGameController.thePaladinSpellArmorProtectOne;
            standard[8] = false; //entireGameController.thePaladinSpellArmorProtectTwo;
            standard[9] = false; //entireGameController.thePaladinSpellArmorProtectThree;

            standard[10] = false; //entireGameController.theWizardSpecialAttack;
            standard[11] = false; //entireGameController.theWizardSpellIceOne;
            standard[12] = false; //entireGameController.theWizardSpellIceTwo;
            standard[13] = false; //entireGameController.theWizardSpellIceThree;
            standard[14] = false; //entireGameController.theWizardSpellFireOne;
            standard[15] = false; //entireGameController.theWizardSpellFireTwo;
            standard[16] = false; //entireGameController.theWizardSpellFireThree;
            standard[17] = false; //entireGameController.theWizardSpellWaterOne;
            standard[18] = false; //entireGameController.theWizardSpellWaterTwo;
            standard[19] = false; //entireGameController.theWizardSpellWaterThree;


            standard[20] = true; // entireGameController.copperSabreEquiped;
            standard[21] = false; // entireGameController.ironSabreEquiped;
            standard[22] = false; // entireGameController.bronzeSabreEquiped;
            standard[23] = false; // entireGameController.silverSabreEquiped;
            standard[24] = false; // entireGameController.goldSabreEquiped;
            standard[25] = false; // entireGameController.agapiteSabreEquiped;
            standard[26] = false; // entireGameController.shadowSabreEquiped;
            standard[27] = false; // entireGameController.strongholdSabreEquiped;
            standard[28] = false; // entireGameController.verminardSabreEquiped;
            standard[29] = false; // entireGameController.adamantineSabreEquiped;
            standard[30] = false; // entireGameController.blackrockSabreEquiped;
            standard[31] = false; // entireGameController.imperialSabreEquiped;

            standard[32] = true; // entireGameController.apprenticePaladinBookVol1Equiped;
            standard[33] = false; // entireGameController.apprenticePaladinBookVol2Equiped;
            standard[34] = false; // entireGameController.journeymanPaladinBookVol1Equiped;
            standard[35] = false; // entireGameController.journeymanPaladinBookVol2Equiped;
            standard[36] = false; // entireGameController.lostPaladinBookVol1Equiped;
            standard[37] = false; // entireGameController.lostPaladinBookVol2Equiped;
            standard[38] = false; // entireGameController.expertPaladinBookVol1Equiped;
            standard[39] = false; // entireGameController.grandmasterPaladinBookVol1Equiped;
            standard[40] = false; // entireGameController.grandmasterPaladinBookVol2Equiped;
            standard[41] = false; // entireGameController.imperialPaladinBookVol1Equiped;

            standard[42] = true; // entireGameController.rustyCombatBootsEquiped;
            standard[43] = false; // entireGameController.poorCombatBootsEquiped;
            standard[44] = false; // entireGameController.fineCombatBootsEquiped;
            standard[45] = false; // entireGameController.decentCombatBootsEquiped;
            standard[46] = false; // entireGameController.excellentCombatBootsEquiped;
            standard[47] = false; // entireGameController.imperialCombatBootsEquiped;

            standard[48] = true; // entireGameController.rustyPlatemailArmorEquiped;
            standard[49] = false; // entireGameController.poorPlatemailArmorEquiped;
            standard[50] = false; // entireGameController.finePlatemailArmorEquiped;
            standard[51] = false; // entireGameController.decentPlatemailArmorEquiped;
            standard[52] = false; // entireGameController.excellentPlatemailArmorEquiped;
            standard[53] = false; // entireGameController.imperialPlatemailArmorEquiped;

            standard[54] = true; // entireGameController.amberTiaraEquiped;
            standard[55] = false; // entireGameController.rubyTiaraEquiped;
            standard[56] = false; // entireGameController.emeraldTiaraEquiped;
            standard[57] = false; // entireGameController.diamondTiaraEquiped;
            standard[58] = false; // entireGameController.citrineTiaraEquiped;
            standard[59] = false; // entireGameController.imperialStarSapphireTiaraEquiped;



            Debug.Log("No Loading File.");
            return standard;
        }
    }
}




[Serializable]
public class PlayerDataInt
{

    public int[] stats;

    public PlayerDataInt(EntireGameController entireGameController)
    {
        stats = new int[55];
        stats[0] = entireGameController.paladinAttack;
        stats[1] = entireGameController.paladinMagic;
        stats[2] = entireGameController.paladinDefense;
        stats[3] = entireGameController.paladinMagicDefense;
        stats[4] = entireGameController.paladinMaxHealth;

        stats[5] = entireGameController.wizardAttack;
        stats[6] = entireGameController.wizardMagic;
        stats[7] = entireGameController.wizardDefense;
        stats[8] = entireGameController.wizardMagicDefense;
        stats[9] = entireGameController.wizardMaxHealth;

        stats[10] = entireGameController.completedLevels;
        stats[11] = entireGameController.selectedLevel;

        stats[12] = entireGameController.level;
        stats[13] = entireGameController.experience;

        stats[14] = entireGameController.gold;

        stats[15] = entireGameController.copperSabre;
        stats[16] = entireGameController.ironSabre;
        stats[17] = entireGameController.bronzeSabre;
        stats[18] = entireGameController.silverSabre;
        stats[19] = entireGameController.goldSabre;
        stats[20] = entireGameController.agapiteSabre;
        stats[21] = entireGameController.shadowSabre;
        stats[22] = entireGameController.strongholdSabre;
        stats[23] = entireGameController.verminardSabre;
        stats[24] = entireGameController.adamantineSabre;
        stats[25] = entireGameController.blackrockSabre;
        stats[26] = entireGameController.imperialSabre;

        stats[27] = entireGameController.apprenticePaladinBookVol1;
        stats[28] = entireGameController.apprenticePaladinBookVol2;
        stats[29] = entireGameController.journeymanPaladinBookVol1;
        stats[30] = entireGameController.journeymanPaladinBookVol2;
        stats[31] = entireGameController.lostPaladinBookVol1;
        stats[32] = entireGameController.lostPaladinBookVol2;
        stats[33] = entireGameController.expertPaladinBookVol1;
        stats[34] = entireGameController.grandmasterPaladinBookVol1;
        stats[35] = entireGameController.grandmasterPaladinBookVol2;
        stats[36] = entireGameController.imperialPaladinBookVol1;

        stats[37] = entireGameController.rustyCombatBoots;
        stats[38] = entireGameController.poorCombatBoots;
        stats[39] = entireGameController.fineCombatBoots;
        stats[40] = entireGameController.decentCombatBoots;
        stats[41] = entireGameController.excellentCombatBoots;
        stats[42] = entireGameController.imperialCombatBoots;

        stats[43] = entireGameController.rustyPlatemailArmor;
        stats[44] = entireGameController.poorPlatemailArmor;
        stats[45] = entireGameController.finePlatemailArmor;
        stats[46] = entireGameController.decentPlatemailArmor;
        stats[47] = entireGameController.excellentPlatemailArmor;
        stats[48] = entireGameController.imperialPlatemailArmor;

        stats[49] = entireGameController.amberTiara;
        stats[50] = entireGameController.rubyTiara;
        stats[51] = entireGameController.emeraldTiara;
        stats[52] = entireGameController.diamondTiara;
        stats[53] = entireGameController.citrineTiara;
        stats[54] = entireGameController.imperialStarSapphireTiara;
    }
}

[Serializable]
public class PlayerDataFloat
{

    public float[] stats;

    public PlayerDataFloat(EntireGameController entireGameController)
    {
        stats = new float[8];
        stats[0] = entireGameController.paladinSpeed;
        stats[1] = entireGameController.paladinIceResistance;
        stats[2] = entireGameController.paladinFireResistance;
        stats[3] = entireGameController.paladinWaterResistance;

        stats[4] = entireGameController.wizardSpeed;
        stats[5] = entireGameController.wizardIceResistance;
        stats[6] = entireGameController.wizardFireResistance;
        stats[7] = entireGameController.wizardWaterResistance;
    }

}

[Serializable]
public class PlayerDataBool
{

    public bool[] stats;
    public PlayerDataBool(EntireGameController entireGameController)
    {
        stats = new bool[60];

        stats[0] = entireGameController.thePaladinSpecialAttack;
        stats[1] = entireGameController.thePaladinSpellHealOne;
        stats[2] = entireGameController.thePaladinSpellHealTwo;
        stats[3] = entireGameController.thePaladinSpellHealThree;
        stats[4] = entireGameController.thePaladinSpellStrenghtOne;
        stats[5] = entireGameController.thePaladinSpellStrenghtTwo;
        stats[6] = entireGameController.thePaladinSpellStrenghtThree;
        stats[7] = entireGameController.thePaladinSpellArmorProtectOne;
        stats[8] = entireGameController.thePaladinSpellArmorProtectTwo;
        stats[9] = entireGameController.thePaladinSpellArmorProtectThree;

        stats[10] = entireGameController.theWizardSpecialAttack;
        stats[11] = entireGameController.theWizardSpellIceOne;
        stats[12] = entireGameController.theWizardSpellIceTwo;
        stats[13] = entireGameController.theWizardSpellIceThree;
        stats[14] = entireGameController.theWizardSpellFireOne;
        stats[15] = entireGameController.theWizardSpellFireTwo;
        stats[16] = entireGameController.theWizardSpellFireThree;
        stats[17] = entireGameController.theWizardSpellWaterOne;
        stats[18] = entireGameController.theWizardSpellWaterTwo;
        stats[19] = entireGameController.theWizardSpellWaterThree;        

        stats[20] = entireGameController.copperSabreEquiped;
        stats[21] = entireGameController.ironSabreEquiped;
        stats[22] = entireGameController.bronzeSabreEquiped;
        stats[23] = entireGameController.silverSabreEquiped;
        stats[24] = entireGameController.goldSabreEquiped;
        stats[25] = entireGameController.agapiteSabreEquiped;
        stats[26] = entireGameController.shadowSabreEquiped;
        stats[27] = entireGameController.strongholdSabreEquiped;
        stats[28] = entireGameController.verminardSabreEquiped;
        stats[29] = entireGameController.adamantineSabreEquiped;
        stats[30] = entireGameController.blackrockSabreEquiped;
        stats[31] = entireGameController.imperialSabreEquiped;

        stats[32] = entireGameController.apprenticePaladinBookVol1Equiped;
        stats[33] = entireGameController.apprenticePaladinBookVol2Equiped;
        stats[34] = entireGameController.journeymanPaladinBookVol1Equiped;
        stats[35] = entireGameController.journeymanPaladinBookVol2Equiped;
        stats[36] = entireGameController.lostPaladinBookVol1Equiped;
        stats[37] = entireGameController.lostPaladinBookVol2Equiped;
        stats[38] = entireGameController.expertPaladinBookVol1Equiped;
        stats[39] = entireGameController.grandmasterPaladinBookVol1Equiped;
        stats[40] = entireGameController.grandmasterPaladinBookVol2Equiped;
        stats[41] = entireGameController.imperialPaladinBookVol1Equiped;

        stats[42] = entireGameController.rustyCombatBootsEquiped;
        stats[43] = entireGameController.poorCombatBootsEquiped;
        stats[44] = entireGameController.fineCombatBootsEquiped;
        stats[45] = entireGameController.decentCombatBootsEquiped;
        stats[46] = entireGameController.excellentCombatBootsEquiped;
        stats[47] = entireGameController.imperialCombatBootsEquiped;

        stats[48] = entireGameController.rustyPlatemailArmorEquiped;
        stats[49] = entireGameController.poorPlatemailArmorEquiped;
        stats[50] = entireGameController.finePlatemailArmorEquiped;
        stats[51] = entireGameController.decentPlatemailArmorEquiped;
        stats[52] = entireGameController.excellentPlatemailArmorEquiped;
        stats[53] = entireGameController.imperialPlatemailArmorEquiped;

        stats[54] = entireGameController.amberTiaraEquiped;
        stats[55] = entireGameController.rubyTiaraEquiped;
        stats[56] = entireGameController.emeraldTiaraEquiped;
        stats[57] = entireGameController.diamondTiaraEquiped;
        stats[58] = entireGameController.citrineTiaraEquiped;
        stats[59] = entireGameController.imperialStarSapphireTiaraEquiped;
    }
}
