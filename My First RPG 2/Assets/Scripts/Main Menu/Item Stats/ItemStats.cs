using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemStats : MonoBehaviour
{
    [Header("Paladin Items")]

    [TextArea]
    public string copperSabre;
    [TextArea]
    public string ironSabre;
    [TextArea]
    public string bronzeSabre;
    [TextArea]
    public string silverSabre;
    [TextArea]
    public string goldSabre;
    [TextArea]
    public string agapiteSabre;
    [TextArea]
    public string shadowSabre;
    [TextArea]
    public string strongholdSabre;
    [TextArea]
    public string verminardSabre;
    [TextArea]
    public string adamantineSabre;
    [TextArea]
    public string blackrockSabre;
    [TextArea]
    public string imperialSabre;


    public TextMeshProUGUI copperSabreDescription;
    public TextMeshProUGUI ironSabreDescription;
    public TextMeshProUGUI bronzeSabreDescription;
    public TextMeshProUGUI silverSabreDescription;
    public TextMeshProUGUI goldSabreDescription;
    public TextMeshProUGUI agapiteSabreDescription;
    public TextMeshProUGUI shadowSabreDescription;
    public TextMeshProUGUI strongholdSabreDescription;
    public TextMeshProUGUI verminardSabreDescription;
    public TextMeshProUGUI adamantineSabreDescription;
    public TextMeshProUGUI blackrockSabreDescription;
    public TextMeshProUGUI imperialSabreDescription;


    [Space(20)]

    [TextArea]
    public string apprenticePaladinBookVol1;
    [TextArea]
    public string apprenticePaladinBookVol2;
    [TextArea]
    public string journeymanPaladinBookVol1;
    [TextArea]
    public string journeymanPaladinBookVol2;
    [TextArea]
    public string lostPaladinBookVol1;
    [TextArea]
    public string lostPaladinBookVol2;
    [TextArea]
    public string expertPaladinBookVol1;
    [TextArea]
    public string grandmasterPaladinBookVol1;
    [TextArea]
    public string grandmasterPaladinBookVol2;
    [TextArea]
    public string imperialPaladinBookVol1;


    public TextMeshProUGUI apprenticePaladinBookVol1Description;
    public TextMeshProUGUI apprenticePaladinBookVol2Description;
    public TextMeshProUGUI journeymanPaladinBookVol1Description;
    public TextMeshProUGUI journeymanPaladinBookVol2Description;
    public TextMeshProUGUI lostPaladinBookVol1Description;
    public TextMeshProUGUI lostPaladinBookVol2Description;
    public TextMeshProUGUI expertPaladinBookVol1Description;
    public TextMeshProUGUI grandmasterPaladinBookVol1Description;
    public TextMeshProUGUI grandmasterPaladinBookVol2Description;
    public TextMeshProUGUI imperialPaladinBookVol1Description;


    [Space(20)]

    [TextArea]
    public string rustyCombatBoots;
    [TextArea]
    public string poorCombatBoots;
    [TextArea]
    public string fineCombatBoots;
    [TextArea]
    public string decentCombatBoots;
    [TextArea]
    public string excellentCombatBoots;
    [TextArea]
    public string imperialCombatBoots;


    public TextMeshProUGUI rustyCombatBootsDescription;
    public TextMeshProUGUI poorCombatBootsDescription;
    public TextMeshProUGUI fineCombatBootsDescription;
    public TextMeshProUGUI decentCombatBootsDescription;
    public TextMeshProUGUI excellentCombatBootsDescription;
    public TextMeshProUGUI imperialCombatBootsDescription;



    [Space(20)]

    [TextArea]
    public string rustyPlatemailArmor;
    [TextArea]
    public string poorPlatemailArmor;
    [TextArea]
    public string finePlatemailArmor;
    [TextArea]
    public string decentPlatemailArmor;
    [TextArea]
    public string excellentPlatemailArmor;
    [TextArea]
    public string imperialPlatemailArmor;


    public TextMeshProUGUI rustyPlatemailArmorDescription;
    public TextMeshProUGUI poorPlatemailArmorDescription;
    public TextMeshProUGUI finePlatemailArmorDescription;
    public TextMeshProUGUI decentPlatemailArmorDescription;
    public TextMeshProUGUI excellentPlatemailArmorDescription;
    public TextMeshProUGUI imperialPlatemailArmorDescription;


    [Space(20)]

    [TextArea]
    public string amberTiara;
    [TextArea]
    public string rubyTiara;
    [TextArea]
    public string emeraldTiara;
    [TextArea]
    public string diamondTiara;
    [TextArea]
    public string citrineTiara;
    [TextArea]
    public string imperialStarSapphireTiara;


    public TextMeshProUGUI amberTiaraDescription;
    public TextMeshProUGUI rubyTiaraDescription;
    public TextMeshProUGUI emeraldTiaraDescription;
    public TextMeshProUGUI diamondTiaraDescription;
    public TextMeshProUGUI citrineTiaraDescription;
    public TextMeshProUGUI imperialStarSapphireTiaraDescription;










    [Space(40)]
    public EntireGameControllerCollector entireGameControllerCollector;
    public BaseStats baseStats;



    void Start()
    {
        UpdateAllItemDescriptions();
    }




    void UpdateAllItemDescriptions()
    {
        copperSabreDescription.text = copperSabre;
        ironSabreDescription.text = ironSabre;
        bronzeSabreDescription.text = bronzeSabre;
        silverSabreDescription.text = silverSabre;
        goldSabreDescription.text = goldSabre;
        agapiteSabreDescription.text = agapiteSabre;
        shadowSabreDescription.text = shadowSabre;
        strongholdSabreDescription.text = strongholdSabre;
        verminardSabreDescription.text = verminardSabre;
        adamantineSabreDescription.text = adamantineSabre;
        blackrockSabreDescription.text = blackrockSabre;
        imperialSabreDescription.text = imperialSabre;

        apprenticePaladinBookVol1Description.text = apprenticePaladinBookVol1;
        apprenticePaladinBookVol2Description.text = apprenticePaladinBookVol2;
        journeymanPaladinBookVol1Description.text = journeymanPaladinBookVol1;
        journeymanPaladinBookVol2Description.text = journeymanPaladinBookVol2;
        lostPaladinBookVol1Description.text = lostPaladinBookVol1;
        lostPaladinBookVol2Description.text = lostPaladinBookVol2;
        expertPaladinBookVol1Description.text = expertPaladinBookVol1;
        grandmasterPaladinBookVol1Description.text = grandmasterPaladinBookVol1;
        grandmasterPaladinBookVol2Description.text = grandmasterPaladinBookVol2;
        imperialPaladinBookVol1Description.text = imperialPaladinBookVol1;

        rustyCombatBootsDescription.text = rustyCombatBoots;
        poorCombatBootsDescription.text = poorCombatBoots;
        fineCombatBootsDescription.text = fineCombatBoots;
        decentCombatBootsDescription.text = decentCombatBoots;
        excellentCombatBootsDescription.text = excellentCombatBoots;
        imperialCombatBootsDescription.text = imperialCombatBoots;

        rustyPlatemailArmorDescription.text = rustyPlatemailArmor;
        poorPlatemailArmorDescription.text = poorPlatemailArmor;
        finePlatemailArmorDescription.text = finePlatemailArmor;
        decentPlatemailArmorDescription.text = decentPlatemailArmor;
        excellentPlatemailArmorDescription.text = excellentPlatemailArmor;
        imperialPlatemailArmorDescription.text = imperialPlatemailArmor;

        amberTiaraDescription.text = amberTiara;
        rubyTiaraDescription.text = rubyTiara;
        emeraldTiaraDescription.text = emeraldTiara;
        diamondTiaraDescription.text = diamondTiara;
        citrineTiaraDescription.text = citrineTiara;
        imperialStarSapphireTiaraDescription.text = imperialStarSapphireTiara;
    }


    public void UpdateAllItems()
    {
        UpdatePaladinAttackItems();
        UpdatePaladinMagicItems();
        UpdatePaladinSpeedItems();
        UpdatePaladinDefenseItems();
        UpdatePaladinMagicDefenseItems();

        // Adicionar todos à lista.
    }




    public void UpdatePaladinAttackItems()
    {
        if (entireGameControllerCollector.copperSabreEquiped)
        {
            entireGameControllerCollector.paladinAttack = baseStats.paladinAttack + 5;
            entireGameControllerCollector.thePaladinSpecialAttack = false;
        }
        else if (entireGameControllerCollector.ironSabreEquiped)
        {
            entireGameControllerCollector.paladinAttack = baseStats.paladinAttack + 15;
            entireGameControllerCollector.thePaladinSpecialAttack = false;
        }
        else if (entireGameControllerCollector.bronzeSabreEquiped)
        {
            entireGameControllerCollector.paladinAttack = baseStats.paladinAttack + 35;
            entireGameControllerCollector.thePaladinSpecialAttack = false;
        }
        else if (entireGameControllerCollector.silverSabreEquiped)
        {
            entireGameControllerCollector.paladinAttack = baseStats.paladinAttack + 35;
            entireGameControllerCollector.thePaladinSpecialAttack = false;
        }
        else if (entireGameControllerCollector.goldSabreEquiped)
        {
            entireGameControllerCollector.paladinAttack = baseStats.paladinAttack + 35;
            entireGameControllerCollector.thePaladinSpecialAttack = false;
        }
        else if (entireGameControllerCollector.agapiteSabreEquiped)
        {
            entireGameControllerCollector.paladinAttack = baseStats.paladinAttack + 100;
            entireGameControllerCollector.thePaladinSpecialAttack = false;
        }
        else if (entireGameControllerCollector.shadowSabreEquiped)
        {
            entireGameControllerCollector.paladinAttack = baseStats.paladinAttack + 125;
            entireGameControllerCollector.thePaladinSpecialAttack = false;
        }
        else if (entireGameControllerCollector.strongholdSabreEquiped)
        {
            entireGameControllerCollector.paladinAttack = baseStats.paladinAttack + 60;
            entireGameControllerCollector.thePaladinSpecialAttack = false;
        }
        else if (entireGameControllerCollector.verminardSabreEquiped)
        {
            entireGameControllerCollector.paladinAttack = baseStats.paladinAttack + 60;
            entireGameControllerCollector.thePaladinSpecialAttack = false;
        }
        else if (entireGameControllerCollector.adamantineSabreEquiped)
        {
            entireGameControllerCollector.paladinAttack = baseStats.paladinAttack + 60;
            entireGameControllerCollector.thePaladinSpecialAttack = false;
        }
        else if (entireGameControllerCollector.blackrockSabreEquiped)
        {
            entireGameControllerCollector.paladinAttack = baseStats.paladinAttack + 600;
            entireGameControllerCollector.thePaladinSpecialAttack = false;
        }
        else if (entireGameControllerCollector.imperialSabreEquiped)
        {
            entireGameControllerCollector.paladinAttack = baseStats.paladinAttack + 1200;
            entireGameControllerCollector.thePaladinSpecialAttack = true;
        }

    }
    public void UpdatePaladinMagicItems()
    {
        if (entireGameControllerCollector.apprenticePaladinBookVol1Equiped)
        {
            entireGameControllerCollector.paladinMagic = baseStats.paladinMagic + 5;
        }

        else if (entireGameControllerCollector.apprenticePaladinBookVol2Equiped)
        {
            entireGameControllerCollector.paladinMagic = baseStats.paladinMagic + 12;
            DisableAllPaladinMagicSpells(); entireGameControllerCollector.thePaladinSpellArmorProtectOne = true;
        }

        else if (entireGameControllerCollector.journeymanPaladinBookVol1Equiped)
        {
            entireGameControllerCollector.paladinMagic = baseStats.paladinMagic + 15;
            DisableAllPaladinMagicSpells(); entireGameControllerCollector.thePaladinSpellStrenghtOne = true;
            entireGameControllerCollector.thePaladinSpellArmorProtectOne = true;
        }

        else if (entireGameControllerCollector.journeymanPaladinBookVol2Equiped)
        {
            entireGameControllerCollector.paladinMagic = baseStats.paladinMagic + 15;
            DisableAllPaladinMagicSpells(); entireGameControllerCollector.thePaladinSpellHealOne = true;
        }

        else if (entireGameControllerCollector.lostPaladinBookVol1Equiped)
        {
            entireGameControllerCollector.paladinMagic = baseStats.paladinMagic + 45;
            DisableAllPaladinMagicSpells(); entireGameControllerCollector.thePaladinSpellHealOne = true;
            entireGameControllerCollector.thePaladinSpellStrenghtOne = true;
            entireGameControllerCollector.thePaladinSpellArmorProtectOne = true;
        }

        else if (entireGameControllerCollector.lostPaladinBookVol2Equiped)
        {
            entireGameControllerCollector.paladinMagic = baseStats.paladinMagic + 45;
            DisableAllPaladinMagicSpells(); entireGameControllerCollector.thePaladinSpellHealTwo = true;
        }

        else if (entireGameControllerCollector.expertPaladinBookVol1Equiped)
        {
            entireGameControllerCollector.paladinMagic = baseStats.paladinMagic + 50;
            DisableAllPaladinMagicSpells(); entireGameControllerCollector.thePaladinSpellStrenghtTwo = true;
            entireGameControllerCollector.thePaladinSpellArmorProtectTwo = true;
        }

        else if (entireGameControllerCollector.grandmasterPaladinBookVol1Equiped)
        {
            entireGameControllerCollector.paladinMagic = baseStats.paladinMagic + 150;
            DisableAllPaladinMagicSpells(); entireGameControllerCollector.thePaladinSpellHealThree = true;
            entireGameControllerCollector.thePaladinSpellStrenghtThree = true;
        }

        else if (entireGameControllerCollector.grandmasterPaladinBookVol2Equiped)
        {
            entireGameControllerCollector.paladinMagic = baseStats.paladinMagic + 150;
            DisableAllPaladinMagicSpells(); entireGameControllerCollector.thePaladinSpellHealThree = true;
            entireGameControllerCollector.thePaladinSpellArmorProtectThree = true;
        }

        else if (entireGameControllerCollector.imperialPaladinBookVol1Equiped)
        {
            entireGameControllerCollector.paladinMagic = baseStats.paladinMagic + 400;
            DisableAllPaladinMagicSpells(); entireGameControllerCollector.thePaladinSpellHealThree = true;
            entireGameControllerCollector.thePaladinSpellStrenghtThree = true;
            entireGameControllerCollector.thePaladinSpellArmorProtectThree = true;
        }
    }


    public void UpdatePaladinSpeedItems()
    {
        if (entireGameControllerCollector.rustyCombatBootsEquiped)
        {
            entireGameControllerCollector.paladinSpeed = baseStats.paladinSpeed + 5;
        }

        else if (entireGameControllerCollector.poorCombatBootsEquiped)
        {
            entireGameControllerCollector.paladinSpeed = baseStats.paladinSpeed + 12;
        }

        else if (entireGameControllerCollector.fineCombatBootsEquiped)
        {
            entireGameControllerCollector.paladinSpeed = baseStats.paladinSpeed + 20;
        }

        else if (entireGameControllerCollector.decentCombatBootsEquiped)
        {
            entireGameControllerCollector.paladinSpeed = baseStats.paladinSpeed + 20;
        }

        else if (entireGameControllerCollector.excellentCombatBootsEquiped)
        {
            entireGameControllerCollector.paladinSpeed = baseStats.paladinSpeed + 40;
        }

        else if (entireGameControllerCollector.imperialCombatBootsEquiped)
        {
            entireGameControllerCollector.paladinSpeed = baseStats.paladinSpeed + 66;
        }
    }



    public void UpdatePaladinDefenseItems()
    {
        if (entireGameControllerCollector.rustyPlatemailArmorEquiped)
        {
            entireGameControllerCollector.paladinDefense = baseStats.paladinDefense + 3;
        }

        else if (entireGameControllerCollector.poorPlatemailArmorEquiped)
        {
            entireGameControllerCollector.paladinDefense = baseStats.paladinDefense + 9;
        }

        else if (entireGameControllerCollector.finePlatemailArmorEquiped)
        {
            entireGameControllerCollector.paladinDefense = baseStats.paladinDefense + 25;
        }

        else if (entireGameControllerCollector.decentPlatemailArmorEquiped)
        {
            entireGameControllerCollector.paladinDefense = baseStats.paladinDefense + 35;
        }

        else if (entireGameControllerCollector.excellentPlatemailArmorEquiped)
        {
            entireGameControllerCollector.paladinDefense = baseStats.paladinDefense + 55;
        }

        else if (entireGameControllerCollector.imperialPlatemailArmorEquiped)
        {
            entireGameControllerCollector.paladinDefense = baseStats.paladinDefense + 100;
        }
    }



    public void UpdatePaladinMagicDefenseItems()
    {
        if (entireGameControllerCollector.amberTiaraEquiped)
        {
            entireGameControllerCollector.paladinMagicDefense = baseStats.paladinMagicDefense + 10;
            entireGameControllerCollector.paladinFireResistance = baseStats.paladinFireResistance - 100;
            entireGameControllerCollector.paladinIceResistance = baseStats.paladinIceResistance - 100;
            entireGameControllerCollector.paladinWaterResistance = baseStats.paladinWaterResistance;
        }

        else if (entireGameControllerCollector.rubyTiaraEquiped)
        {
            entireGameControllerCollector.paladinMagicDefense = baseStats.paladinMagicDefense + 10;
            entireGameControllerCollector.paladinFireResistance = baseStats.paladinFireResistance - 100;
            entireGameControllerCollector.paladinIceResistance = baseStats.paladinIceResistance;
            entireGameControllerCollector.paladinWaterResistance = baseStats.paladinWaterResistance - 100;
        }

        else if (entireGameControllerCollector.emeraldTiaraEquiped)
        {
            entireGameControllerCollector.paladinMagicDefense = baseStats.paladinMagicDefense + 21;
            entireGameControllerCollector.paladinFireResistance = baseStats.paladinFireResistance - 50;
            entireGameControllerCollector.paladinIceResistance = baseStats.paladinIceResistance + 10;
            entireGameControllerCollector.paladinWaterResistance = baseStats.paladinWaterResistance - 50;
        }

        else if (entireGameControllerCollector.diamondTiaraEquiped)
        {
            entireGameControllerCollector.paladinMagicDefense = baseStats.paladinMagicDefense + 21;
            entireGameControllerCollector.paladinFireResistance = baseStats.paladinFireResistance + 15;
            entireGameControllerCollector.paladinIceResistance = baseStats.paladinIceResistance - 50;
            entireGameControllerCollector.paladinWaterResistance = baseStats.paladinWaterResistance + 15;
        }

        else if (entireGameControllerCollector.citrineTiaraEquiped)
        {
            entireGameControllerCollector.paladinMagicDefense = baseStats.paladinMagicDefense + 45;
            entireGameControllerCollector.paladinFireResistance = baseStats.paladinFireResistance + 20;
            entireGameControllerCollector.paladinIceResistance = baseStats.paladinIceResistance + 20;
            entireGameControllerCollector.paladinWaterResistance = baseStats.paladinWaterResistance + 20;
        }

        else if (entireGameControllerCollector.imperialStarSapphireTiaraEquiped)
        {
            entireGameControllerCollector.paladinMagicDefense = baseStats.paladinMagicDefense + 82;
            entireGameControllerCollector.paladinFireResistance = baseStats.paladinFireResistance + 45;
            entireGameControllerCollector.paladinIceResistance = baseStats.paladinIceResistance + 45;
            entireGameControllerCollector.paladinWaterResistance = baseStats.paladinWaterResistance + 45;
        }
    }






    void DisableAllPaladinMagicSpells()
    {        
        entireGameControllerCollector.thePaladinSpellHealOne = false;
        entireGameControllerCollector.thePaladinSpellHealTwo = false;
        entireGameControllerCollector.thePaladinSpellHealThree = false;

        entireGameControllerCollector.thePaladinSpellStrenghtOne = false;
        entireGameControllerCollector.thePaladinSpellStrenghtTwo = false;
        entireGameControllerCollector.thePaladinSpellStrenghtThree = false;

        entireGameControllerCollector.thePaladinSpellArmorProtectOne = false;
        entireGameControllerCollector.thePaladinSpellArmorProtectTwo = false;
        entireGameControllerCollector.thePaladinSpellArmorProtectThree = false;
    }


}
