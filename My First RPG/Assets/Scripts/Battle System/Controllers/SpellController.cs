using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpellController : MonoBehaviour
{
    [Header("Buffs")]
    [Header("White Magic Spells")]
    public float agilityOneABMod;
    public float agilityTwoABMod;
    public float agilityThreeABMod;
    [Space(5)]
    public float strenghtOneAttackMod;
    public float strenghtTwoAttackMod;
    public float strenghtThreeAttackMod;
    [Space(5)]
    public float armorProtectionOneAttackMod;
    public float armorProtectionTwoAttackMod;
    public float armorProtectionThreeAttackMod;
    [Space(5)]
    public float magicProtectionOneAttackMod;
    public float magicProtectionTwoAttackMod;
    public float magicProtectionThreeAttackMod;
    [Space(5)]
    public float magicUpOneAttackMod;
    public float magicUpTwoAttackMod;
    public float magicUpThreeAttackMod;
    [Space(5)]
    public float higherVitalityUpOneAttackMod;
    public float higherVitalityUpTwoAttackMod;
    public float higherVitalityUpThreeAttackMod;

    [Space(5)]
    [Header("Debuffs")]

    public float clumsyOneABMod;
    public float clumsyTwoABMod;
    public float clumsyThreeABMod;
    [Space(5)]
    public float weakenOneAttackMod;
    public float weakenTwoAttackMod;
    public float weakenThreeAttackMod;
    [Space(5)]
    public float deflateArmorOneAttackMod;
    public float deflateArmorTwoAttackMod;
    public float deflateArmorThreeAttackMod;
    [Space(5)]
    public float deflateMagicProtectionOneAttackMod;
    public float deflateMagicProtectionTwoAttackMod;
    public float deflateMagicProtectionThreeAttackMod;
    [Space(5)]
    public float feeblemindOneAttackMod;
    public float feeblemindTwoAttackMod;
    public float feeblemindThreeAttackMod;
    [Space(5)]
    public int dispelOneAmount;
    public int dispelTwoAmount;
    public int dispelThreeAmount;

    [Space(5)]
    [Header("Heals")]

    public int healOneHealthMod;
    public int healTwoHealthMod;
    public int healThreeHealthMod;



    [Header("Offensive")]
    [Header("Black Magic Spells")]

    public float iceOneDamage;
    public float iceTwoDamage;
    public float iceThreeDamage;
    [Space(5)]
    public float iceFourDamage;
    public float iceFiveDamage;
    public float iceSixDamage;
    [Space(5)]
    public float fireOneDamage;
    public float fireTwoDamage;
    public float fireThreeDamage;
    [Space(5)]
    public float fireFourDamage;
    public float fireFiveDamage;
    public float fireSixDamage;
    [Space(5)]
    public float waterOneDamage;
    public float waterTwoDamage;
    public float waterThreeDamage;
    [Space(5)]
    public float waterFourDamage;
    public float waterFiveDamage;
    public float waterSixDamage;

    [Space(5)]
    [Header("Effects")]

    public float freezeOneSeconds;
    public float freezeTwoSeconds;
    public float freezeThreeSeconds;
    [Space(5)]
    public float burnOneSeconds;
    public float burnOneDamagePercentage;
    public int burnOneTimes;
    public float burnTwoSeconds;
    public float burnTwoDamagePercentage;
    public int burnTwoTimes;
    public float burnThreeSeconds;
    public float burnThreeDamagePercentage;
    public int burnThreeTimes;
    [Space(5)]
    public float silenceOnePercentage;
    public float silenceOneSeconds;
    public float silenceTwoPercentage;
    public float silenceTwoSeconds;
    public float silenceThreePercentage;
    public float silenceThreeSeconds;
    [Space(5)]
    public float blindOnePercentage;
    public float blindOneSeconds;
    public float blindTwoPercentage;
    public float blindTwoSeconds;
    public float blindThreePercentage;
    public float blindThreeSeconds;




    [Header("Paladin")]
    [Header("Spells Information")]

    [TextArea]
    public string agilityOneInformation;
    [TextArea]
    public string agilityTwoInformation;
    [TextArea]
    public string agilityThreeInformation;
    [Space(5)]

    [TextArea]
    public string strenghtOneInformation;
    [TextArea]
    public string strenghtTwoInformation;
    [TextArea]
    public string strenghtThreeInformation;
    [Space(5)]

    [TextArea]
    public string armorOneInformation;
    [TextArea]
    public string armorTwoInformation;
    [TextArea]
    public string armorThreeInformation;
    [Space(5)]

    [TextArea]
    public string magicProtectionOneInformation;
    [TextArea]
    public string magicProtectionTwoInformation;
    [TextArea]
    public string magicProtectionThreeInformation;
    [Space(5)]

    [TextArea]
    public string magicUpOneInformation;
    [TextArea]
    public string magicUpTwoInformation;
    [TextArea]
    public string magicUpThreeInformation;
    [Space(5)]

    [TextArea]
    public string higherVitalityOneInformation;
    [TextArea]
    public string higherVitalityTwoInformation;
    [TextArea]
    public string higherVitalityThreeInformation;
    [Space(5)]

    [TextArea]
    public string clumsyOneInformation;
    [TextArea]
    public string clumsyTwoInformation;
    [TextArea]
    public string clumsyThreeInformation;
    [Space(5)]

    [TextArea]
    public string weakenOneInformation;
    [TextArea]
    public string weakenTwoInformation;
    [TextArea]
    public string weakenThreeInformation;
    [Space(5)]

    [TextArea]
    public string deflateArmorOneInformation;
    [TextArea]
    public string deflateArmorTwoInformation;
    [TextArea]
    public string deflateArmorThreeInformation;
    [Space(5)]

    [TextArea]
    public string deflateMagicOneInformation;
    [TextArea]
    public string deflateMagicTwoInformation;
    [TextArea]
    public string deflateMagicThreeInformation;
    [Space(5)]

    [TextArea]
    public string feeblemindOneInformation;
    [TextArea]
    public string feeblemindTwoInformation;
    [TextArea]
    public string feeblemindThreeInformation;
    [Space(5)]

    [TextArea]
    public string dispelOneInformation;
    [TextArea]
    public string dispelTwoInformation;
    [TextArea]
    public string dispelThreeInformation;
    [Space(5)]

    [TextArea]
    public string healOneInformation;
    [TextArea]
    public string healTwoInformation;
    [TextArea]
    public string healThreeInformation;
    [Space(5)]


    [Header("Wizard")]

    [TextArea]
    public string iceOneInformation;
    [TextArea]
    public string iceTwoInformation;
    [TextArea]
    public string iceThreeInformation;
    [Space(5)]

    [TextArea]
    public string iceFourInformation;
    [TextArea]
    public string iceFiveInformation;
    [TextArea]
    public string iceSixInformation;
    [Space(5)]

    [TextArea]
    public string fireOneInformation;
    [TextArea]
    public string fireTwoInformation;
    [TextArea]
    public string fireThreeInformation;
    [Space(5)]

    [TextArea]
    public string fireFourInformation;
    [TextArea]
    public string fireFiveInformation;
    [TextArea]
    public string fireSixInformation;
    [Space(5)]

    [TextArea]
    public string waterOneInformation;
    [TextArea]
    public string waterTwoInformation;
    [TextArea]
    public string waterThreeInformation;
    [Space(5)]

    [TextArea]
    public string waterFourInformation;
    [TextArea]
    public string waterFiveInformation;
    [TextArea]
    public string waterSixInformation;
    [Space(5)]

    [TextArea]
    public string freezeOneInformation;
    [TextArea]
    public string freezeTwoInformation;
    [TextArea]
    public string freezeThreeInformation;
    [Space(5)]

    [TextArea]
    public string burnOneInformation;
    [TextArea]
    public string burnTwoInformation;
    [TextArea]
    public string burnThreeInformation;
    [Space(5)]

    [TextArea]
    public string silenceOneInformation;
    [TextArea]
    public string silenceTwoInformation;
    [TextArea]
    public string silenceThreeInformation;
    [Space(5)]

    [TextArea]
    public string blindOneInformation;
    [TextArea]
    public string blindTwoInformation;
    [TextArea]
    public string blindThreeInformation;
    [Space(5)]





    [Space(500)]
    public Paladin paladin;
    public Wizard wizard;
    public WhiteMagicController whiteMagicController;
    public BlackMagicController blackMagicController;
    public TurnPointsController turnPointsController;

    [Space(10)]
    [Header("White Magic Spells")]

    public TextMeshProUGUI agiltyOneTPFakeSlider;
    public TextMeshProUGUI agiltyTwoTPFakeSlider;
    public TextMeshProUGUI agiltyThreeTPFakeSlider;
    [Space(5)]
    public TextMeshProUGUI strenghtOneTPFakeSlider;
    public TextMeshProUGUI strenghtTwoTPFakeSlider;
    public TextMeshProUGUI strenghtThreeTPFakeSlider;
    [Space(5)]
    public TextMeshProUGUI armorProtectionOneTPFakeSlider;
    public TextMeshProUGUI armorProtectionTwoTPFakeSlider;
    public TextMeshProUGUI armorProtectionThreeTPFakeSlider;
    [Space(5)]
    public TextMeshProUGUI magicProtectionOneTPFakeSlider;
    public TextMeshProUGUI magicProtectionTwoTPFakeSlider;
    public TextMeshProUGUI magicProtectionThreeTPFakeSlider;
    [Space(5)]
    public TextMeshProUGUI magicUpOneTPFakeSlider;
    public TextMeshProUGUI magicUpTwoTPFakeSlider;
    public TextMeshProUGUI magicUpThreeTPFakeSlider;
    [Space(5)]
    public TextMeshProUGUI higherVitalityUpOneTPFakeSlider;
    public TextMeshProUGUI higherVitalityUpTwoTPFakeSlider;
    public TextMeshProUGUI higherVitalityUpThreeTPFakeSlider;


    [Space(15)]
    public TextMeshProUGUI clumsyOneTPFakeSlider;
    public TextMeshProUGUI clumsyTwoTPFakeSlider;
    public TextMeshProUGUI clumsyThreeTPFakeSlider;
    [Space(5)]
    public TextMeshProUGUI weakenOneTPFakeSlider;
    public TextMeshProUGUI weakenTwoTPFakeSlider;
    public TextMeshProUGUI weakenThreeTPFakeSlider;
    [Space(5)]
    public TextMeshProUGUI deflateArmorOneTPFakeSlider;
    public TextMeshProUGUI deflateArmorTwoTPFakeSlider;
    public TextMeshProUGUI deflateArmorThreeTPFakeSlider;
    [Space(5)]
    public TextMeshProUGUI deflateMagicProtectionOneTPFakeSlider;
    public TextMeshProUGUI deflateMagicProtectionTwoTPFakeSlider;
    public TextMeshProUGUI deflateMagicProtectionThreeTPFakeSlider;
    [Space(5)]
    public TextMeshProUGUI feeblemindOneTPFakeSlider;
    public TextMeshProUGUI feeblemindTwoTPFakeSlider;
    public TextMeshProUGUI feeblemindThreeTPFakeSlider;
    [Space(5)]
    public TextMeshProUGUI dispelOneTPFakeSlider;
    public TextMeshProUGUI dispelTwoTPFakeSlider;
    public TextMeshProUGUI dispelThreeTPFakeSlider;

    [Space(15)]
    public TextMeshProUGUI healOneTPFakeSlider;
    public TextMeshProUGUI healTwoTPFakeSlider;
    public TextMeshProUGUI healThreeTPFakeSlider;


    [Header("Black Magic Spells")]

    public TextMeshProUGUI iceOneTP;
    public TextMeshProUGUI iceTwoTP;
    public TextMeshProUGUI iceThreeTP;
    [Space(5)]
    public TextMeshProUGUI iceFourTP;
    public TextMeshProUGUI iceFiveTP;
    public TextMeshProUGUI iceSixTP;
    [Space(5)]
    public TextMeshProUGUI fireOneTP;
    public TextMeshProUGUI fireTwoTP;
    public TextMeshProUGUI fireThreeTP;
    [Space(5)]
    public TextMeshProUGUI fireFourTP;
    public TextMeshProUGUI fireFiveTP;
    public TextMeshProUGUI fireSixTP;
    [Space(5)]
    public TextMeshProUGUI waterOneTP;
    public TextMeshProUGUI waterTwoTP;
    public TextMeshProUGUI waterThreeTP;
    [Space(5)]
    public TextMeshProUGUI waterFourTP;
    public TextMeshProUGUI waterFiveTP;
    public TextMeshProUGUI waterSixTP;


    [Space(15)]
    public TextMeshProUGUI freezeOneTP;
    public TextMeshProUGUI freezeTwoTP;
    public TextMeshProUGUI freezeThreeTP;
    [Space(5)]
    public TextMeshProUGUI burnOneTP;
    public TextMeshProUGUI burnTwoTP;
    public TextMeshProUGUI burnThreeTP;
    [Space(5)]
    public TextMeshProUGUI silenceOneTP;
    public TextMeshProUGUI silenceTwoTP;
    public TextMeshProUGUI silenceThreeTP;
    [Space(5)]
    public TextMeshProUGUI blindOneTP;
    public TextMeshProUGUI blindTwoTP;
    public TextMeshProUGUI blindThreeTP;


    [Header("Buffs and Debuffs Icons")]
    [Space(10)]

    public GameObject paladinSpeedUpIcon;
    public GameObject paladinSpeedDownIcon;
    public GameObject paladinAttackUpIcon;
    public GameObject paladinAttackDownIcon;
    public GameObject paladinDefenseUpIcon;
    public GameObject paladinDefenseDownIcon;
    public GameObject paladinMagicUpIcon;
    public GameObject paladinMagicDownIcon;
    public GameObject paladinMagicDefenseUpIcon;
    public GameObject paladinMagicDefenseDownIcon;
    public GameObject paladinHealthUpIcon;
    public GameObject paladinHealthDownIcon;

    [Space(10)]

    public GameObject wizardSpeedUpIcon;
    public GameObject wizardSpeedDownIcon;
    public GameObject wizardAttackUpIcon;
    public GameObject wizardAttackDownIcon;
    public GameObject wizardDefenseUpIcon;
    public GameObject wizardDefenseDownIcon;
    public GameObject wizardMagicUpIcon;
    public GameObject wizardMagicDownIcon;
    public GameObject wizardMagicDefenseUpIcon;
    public GameObject wizardMagicDefenseDownIcon;
    public GameObject wizardHealthUpIcon;
    public GameObject wizardHealthDownIcon;








    void Start()
    {
        UpdateFakeSliderTPWhiteMagic();
        UpdateFakeSliderTPBlackMagic();
    }


    void Update()
    {

    }


    public void UpdateFakeSliderTPWhiteMagic()
    {
        agiltyOneTPFakeSlider.text = turnPointsController.agilityOneTP.ToString() + "TP";
        agiltyTwoTPFakeSlider.text = turnPointsController.agilityTwoTP.ToString() + "TP";
        agiltyThreeTPFakeSlider.text = turnPointsController.agilityThreeTP.ToString() + "TP";

        strenghtOneTPFakeSlider.text = turnPointsController.strenghtOneTP.ToString() + "TP";
        strenghtTwoTPFakeSlider.text = turnPointsController.strenghtTwoTP.ToString() + "TP";
        strenghtThreeTPFakeSlider.text = turnPointsController.strenghtThreeTP.ToString() + "TP";

        armorProtectionOneTPFakeSlider.text = turnPointsController.armorProtectionOneTP.ToString() + "TP";
        armorProtectionTwoTPFakeSlider.text = turnPointsController.armorProtectionTwoTP.ToString() + "TP";
        armorProtectionThreeTPFakeSlider.text = turnPointsController.armorProtectionThreeTP.ToString() + "TP";

        magicProtectionOneTPFakeSlider.text = turnPointsController.magicProtectionOneTP.ToString() + "TP";
        magicProtectionTwoTPFakeSlider.text = turnPointsController.magicProtectionTwoTP.ToString() + "TP";
        magicProtectionThreeTPFakeSlider.text = turnPointsController.magicProtectionThreeTP.ToString() + "TP";

        magicUpOneTPFakeSlider.text = turnPointsController.magicUpOneTP.ToString() + "TP";
        magicUpTwoTPFakeSlider.text = turnPointsController.magicUpTwoTP.ToString() + "TP";
        magicUpThreeTPFakeSlider.text = turnPointsController.magicUpThreeTP.ToString() + "TP";

        higherVitalityUpOneTPFakeSlider.text = turnPointsController.higherVitalityUpOneTP.ToString() + "TP";
        higherVitalityUpTwoTPFakeSlider.text = turnPointsController.higherVitalityUpTwoTP.ToString() + "TP";
        higherVitalityUpThreeTPFakeSlider.text = turnPointsController.higherVitalityUpThreeTP.ToString() + "TP";



        clumsyOneTPFakeSlider.text = turnPointsController.clumsyOneTP.ToString() + "TP";
        clumsyTwoTPFakeSlider.text = turnPointsController.clumsyTwoTP.ToString() + "TP";
        clumsyThreeTPFakeSlider.text = turnPointsController.clumsyThreeTP.ToString() + "TP";

        weakenOneTPFakeSlider.text = turnPointsController.weakenOneTP.ToString() + "TP";
        weakenTwoTPFakeSlider.text = turnPointsController.weakenTwoTP.ToString() + "TP";
        weakenThreeTPFakeSlider.text = turnPointsController.weakenThreeTP.ToString() + "TP";

        deflateArmorOneTPFakeSlider.text = turnPointsController.deflateArmorOneTP.ToString() + "TP";
        deflateArmorTwoTPFakeSlider.text = turnPointsController.deflateArmorTwoTP.ToString() + "TP";
        deflateArmorThreeTPFakeSlider.text = turnPointsController.deflateArmorThreeTP.ToString() + "TP";

        deflateMagicProtectionOneTPFakeSlider.text = turnPointsController.deflateMagicProtectionOneTP.ToString() + "TP";
        deflateMagicProtectionTwoTPFakeSlider.text = turnPointsController.deflateMagicProtectionTwoTP.ToString() + "TP";
        deflateMagicProtectionThreeTPFakeSlider.text = turnPointsController.deflateMagicProtectionThreeTP.ToString() + "TP";

        feeblemindOneTPFakeSlider.text = turnPointsController.feeblemindOneTP.ToString() + "TP";
        feeblemindTwoTPFakeSlider.text = turnPointsController.feeblemindTwoTP.ToString() + "TP";
        feeblemindThreeTPFakeSlider.text = turnPointsController.feeblemindThreeTP.ToString() + "TP";

        dispelOneTPFakeSlider.text = turnPointsController.dispelOneTP.ToString() + "TP";
        dispelTwoTPFakeSlider.text = turnPointsController.dispelTwoTP.ToString() + "TP";
        dispelThreeTPFakeSlider.text = turnPointsController.dispelThreeTP.ToString() + "TP";



        healOneTPFakeSlider.text = turnPointsController.healOneTP.ToString() + "TP";
        healTwoTPFakeSlider.text = turnPointsController.healTwoTP.ToString() + "TP";
        healThreeTPFakeSlider.text = turnPointsController.healThreeTP.ToString() + "TP";
    }


    public void UpdateFakeSliderTPBlackMagic()
    {
        iceOneTP.text = turnPointsController.iceOneTP.ToString() + "TP";
        iceTwoTP.text = turnPointsController.iceTwoTP.ToString() + "TP";
        iceThreeTP.text = turnPointsController.iceThreeTP.ToString() + "TP";
        iceFourTP.text = turnPointsController.iceFourTP.ToString() + "TP";
        iceFiveTP.text = turnPointsController.iceFiveTP.ToString() + "TP";
        iceSixTP.text = turnPointsController.iceSixTP.ToString() + "TP";

        fireOneTP.text = turnPointsController.fireOneTP.ToString() + "TP";
        fireTwoTP.text = turnPointsController.fireTwoTP.ToString() + "TP";
        fireThreeTP.text = turnPointsController.fireThreeTP.ToString() + "TP";
        fireFourTP.text = turnPointsController.fireFourTP.ToString() + "TP";
        fireFiveTP.text = turnPointsController.fireFiveTP.ToString() + "TP";
        fireSixTP.text = turnPointsController.fireSixTP.ToString() + "TP";

        waterOneTP.text = turnPointsController.waterOneTP.ToString() + "TP";
        waterTwoTP.text = turnPointsController.waterTwoTP.ToString() + "TP";
        waterThreeTP.text = turnPointsController.waterThreeTP.ToString() + "TP";
        waterFourTP.text = turnPointsController.waterFourTP.ToString() + "TP";
        waterFiveTP.text = turnPointsController.waterFiveTP.ToString() + "TP";
        waterSixTP.text = turnPointsController.waterSixTP.ToString() + "TP";


        freezeOneTP.text = turnPointsController.freezeOneTP.ToString() + "TP";
        freezeTwoTP.text = turnPointsController.freezeTwoTP.ToString() + "TP";
        freezeThreeTP.text = turnPointsController.freezeThreeTP.ToString() + "TP";

        burnOneTP.text = turnPointsController.burnOneTP.ToString() + "TP";
        burnTwoTP.text = turnPointsController.burnTwoTP.ToString() + "TP";
        burnThreeTP.text = turnPointsController.burnThreeTP.ToString() + "TP";

        silenceOneTP.text = turnPointsController.silenceOneTP.ToString() + "TP";
        silenceTwoTP.text = turnPointsController.silenceTwoTP.ToString() + "TP";
        silenceThreeTP.text = turnPointsController.silenceThreeTP.ToString() + "TP";

        blindOneTP.text = turnPointsController.blindOneTP.ToString() + "TP";
        blindTwoTP.text = turnPointsController.blindTwoTP.ToString() + "TP";
        blindThreeTP.text = turnPointsController.blindThreeTP.ToString() + "TP";
    }


    public void SpellEffectGeneral(string name)
    {
        if (whiteMagicController.agiltyOne == true) { AgilityOneEffects(name); }
        else if (whiteMagicController.agiltyTwo == true) { AgilityTwoEffects(name); }
        else if (whiteMagicController.agiltyThree == true) { AgilityThreeEffects(name); }

        else if (whiteMagicController.strenghtOne == true) { StrenghtOneEffects(name); }
        else if (whiteMagicController.strenghtTwo == true) { StrenghtTwoEffects(name); }
        else if (whiteMagicController.strenghtThree == true) { StrenghtThreeEffects(name); }

        else if (whiteMagicController.armorProtectionOne == true) { ArmorProtectionOneEffects(name); }
        else if (whiteMagicController.armorProtectionTwo == true) { ArmorProtectionTwoEffects(name); }
        else if (whiteMagicController.armorProtectionThree == true) { ArmorProtectionThreeEffects(name); }

        else if (whiteMagicController.magicProtectionOne == true) { MagicProtectionOneEffects(name); }
        else if (whiteMagicController.magicProtectionTwo == true) { MagicProtectionTwoEffects(name); }
        else if (whiteMagicController.magicProtectionThree == true) { MagicProtectionThreeEffects(name); }

        else if (whiteMagicController.magicUpOne == true) { MagicUpOneEffects(name); }
        else if (whiteMagicController.magicUpTwo == true) { MagicUpTwoEffects(name); }
        else if (whiteMagicController.magicUpThree == true) { MagicUpThreeEffects(name); }

        else if (whiteMagicController.higherVitalityUpOne == true) { HigherVitalityUpOneEffects(name); }
        else if (whiteMagicController.higherVitalityUpTwo == true) { HigherVitalityUpTwoEffects(name); }
        else if (whiteMagicController.higherVitalityUpThree == true) { HigherVitalityUpThreeEffects(name); }



        else if (whiteMagicController.clumsyOne == true) { ClumsyOneEffects(name); }
        else if (whiteMagicController.clumsyTwo == true) { ClumsyTwoEffects(name); }
        else if (whiteMagicController.clumsyThree == true) { ClumsyThreeEffects(name); }

        else if (whiteMagicController.weakenOne == true) { WeakenOneEffects(name); }
        else if (whiteMagicController.weakenTwo == true) { WeakenTwoEffects(name); }
        else if (whiteMagicController.weakenThree == true) { WeakenThreeEffects(name); }

        else if (whiteMagicController.deflateArmorOne == true) { DeflateArmorOneEffects(name); }
        else if (whiteMagicController.deflateArmorTwo == true) { DeflateArmorTwoEffects(name); }
        else if (whiteMagicController.deflateArmorThree == true) { DeflateArmorThreeEffects(name); }

        else if (whiteMagicController.deflateMagicProtectionOne == true) { DeflateMagicProtectionOneEffects(name); }
        else if (whiteMagicController.deflateMagicProtectionTwo == true) { DeflateMagicProtectionTwoEffects(name); }
        else if (whiteMagicController.deflateMagicProtectionThree == true) { DeflateMagicProtectionThreeEffects(name); }

        else if (whiteMagicController.feeblemindOne == true) { FeeblemindOneEffects(name); }
        else if (whiteMagicController.feeblemindTwo == true) { FeeblemindTwoEffects(name); }
        else if (whiteMagicController.feeblemindThree == true) { FeeblemindThreeEffects(name); }

        else if (whiteMagicController.dispelOne == true) { DispelOneEffects(name); }
        else if (whiteMagicController.dispelTwo == true) { DispelTwoEffects(name); }
        else if (whiteMagicController.dispelThree == true) { DispelThreeEffects(name); }



        else if (whiteMagicController.healOne == true) { HealOneEffects(name); }
        else if (whiteMagicController.healTwo == true) { HealTwoEffects(name); }
        else if (whiteMagicController.healThree == true) { HealThreeEffects(name); }


    }



    public void AgilityOneEffects(string name)
    {
        if (name == "Paladin") { paladin.abModifierPercentageTemporary = agilityOneABMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinSpeedUpIcon.SetActive(true); paladin.abUp = true;}
        else if (name == "Wizard") { wizard.abModifierPercentageTemporary = agilityOneABMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardSpeedUpIcon.SetActive(true); wizard.abUp = true;}
    }

    public void AgilityTwoEffects(string name)
    {
        if (name == "Paladin") { paladin.abModifierPercentageTemporary = agilityTwoABMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinSpeedUpIcon.SetActive(true); paladin.abUp = true;}
        else if (name == "Wizard") { wizard.abModifierPercentageTemporary = agilityTwoABMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardSpeedUpIcon.SetActive(true); wizard.abUp = true;}
    }

    public void AgilityThreeEffects(string name)
    {
        if (name == "Paladin") { paladin.abModifierPercentageTemporary = agilityThreeABMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinSpeedUpIcon.SetActive(true); paladin.abUp = true;}
        else if (name == "Wizard") { wizard.abModifierPercentageTemporary = agilityThreeABMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardSpeedUpIcon.SetActive(true); wizard.abUp = true;}
    }




    public void StrenghtOneEffects(string name)
    {
        if (name == "Paladin") { paladin.attackModifierPercentageTemporary = strenghtOneAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinAttackUpIcon.SetActive(true); paladin.attackUp = true;}
        else if (name == "Wizard") { wizard.attackModifierPercentageTemporary = strenghtOneAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardAttackUpIcon.SetActive(true); wizard.attackUp = true;}
    }

    public void StrenghtTwoEffects(string name)
    {
        if (name == "Paladin") { paladin.attackModifierPercentageTemporary = strenghtTwoAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinAttackUpIcon.SetActive(true); paladin.attackUp = true;}
        else if (name == "Wizard") { wizard.attackModifierPercentageTemporary = strenghtTwoAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardAttackUpIcon.SetActive(true); wizard.attackUp = true;}
    }

    public void StrenghtThreeEffects(string name)
    {
        if (name == "Paladin") { paladin.attackModifierPercentageTemporary = strenghtThreeAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinAttackUpIcon.SetActive(true); paladin.attackUp = true;}
        else if (name == "Wizard") { wizard.attackModifierPercentageTemporary = strenghtThreeAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardAttackUpIcon.SetActive(true); wizard.attackUp = true;}
    }




    public void ArmorProtectionOneEffects(string name)
    {
        if (name == "Paladin") { paladin.defenseModifierPercentageTemporary = armorProtectionOneAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinDefenseUpIcon.SetActive(true); paladin.defenseUp = true;}
        else if (name == "Wizard") { wizard.defenseModifierPercentageTemporary = armorProtectionOneAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardDefenseUpIcon.SetActive(true); wizard.defenseUp = true;}
    }

    public void ArmorProtectionTwoEffects(string name)
    {
        if (name == "Paladin") { paladin.defenseModifierPercentageTemporary = armorProtectionTwoAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinDefenseUpIcon.SetActive(true); paladin.defenseUp = true;}
        else if (name == "Wizard") { wizard.defenseModifierPercentageTemporary = armorProtectionTwoAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardDefenseUpIcon.SetActive(true); wizard.defenseUp = true; }
    }

    public void ArmorProtectionThreeEffects(string name)
    {
        if (name == "Paladin") { paladin.defenseModifierPercentageTemporary = armorProtectionThreeAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinDefenseUpIcon.SetActive(true); paladin.defenseUp = true;}
        else if (name == "Wizard") { wizard.defenseModifierPercentageTemporary = armorProtectionThreeAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardDefenseUpIcon.SetActive(true); wizard.defenseUp = true;}
    }





    public void MagicProtectionOneEffects(string name)
    {
        if (name == "Paladin") { paladin.magicDefenseModifierPercentageTemporary = magicProtectionOneAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinMagicDefenseUpIcon.SetActive(true); paladin.magicDefenseUp = true;}
        else if (name == "Wizard") { wizard.magicDefenseModifierPercentageTemporary = magicProtectionOneAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardMagicDefenseUpIcon.SetActive(true); wizard.magicDefenseUp = true;}
    }

    public void MagicProtectionTwoEffects(string name)
    {
        if (name == "Paladin") { paladin.magicDefenseModifierPercentageTemporary = magicProtectionTwoAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinMagicDefenseUpIcon.SetActive(true); paladin.magicDefenseUp = true; }
        else if (name == "Wizard") { wizard.magicDefenseModifierPercentageTemporary = magicProtectionTwoAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardMagicDefenseUpIcon.SetActive(true); wizard.magicDefenseUp = true;}
    }

    public void MagicProtectionThreeEffects(string name)
    {
        if (name == "Paladin") { paladin.magicDefenseModifierPercentageTemporary = magicProtectionThreeAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinMagicDefenseUpIcon.SetActive(true); paladin.magicDefenseUp = true;}
        else if (name == "Wizard") { wizard.magicDefenseModifierPercentageTemporary = magicProtectionThreeAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardMagicDefenseUpIcon.SetActive(true); wizard.magicDefenseUp = true;}
    }




    public void MagicUpOneEffects(string name)
    {
        if (name == "Paladin") { paladin.magicModifierPercentageTemporary = magicUpOneAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinMagicUpIcon.SetActive(true); paladin.magicUp = true;}
        else if (name == "Wizard") { wizard.magicModifierPercentageTemporary = magicUpOneAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardMagicUpIcon.SetActive(true); wizard.magicUp = true;}
    }

    public void MagicUpTwoEffects(string name)
    {
        if (name == "Paladin") { paladin.magicModifierPercentageTemporary = magicUpTwoAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinMagicUpIcon.SetActive(true); paladin.magicUp = true;}
        else if (name == "Wizard") { wizard.magicModifierPercentageTemporary = magicUpTwoAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardMagicUpIcon.SetActive(true); wizard.magicUp = true;}
    }

    public void MagicUpThreeEffects(string name)
    {
        if (name == "Paladin") { paladin.magicModifierPercentageTemporary = magicUpThreeAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinMagicUpIcon.SetActive(true); paladin.magicUp = true;}
        else if (name == "Wizard") { wizard.magicModifierPercentageTemporary = magicUpThreeAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardMagicUpIcon.SetActive(true); wizard.magicUp = true;}
    }


    public void HigherVitalityUpOneEffects(string name)
    {
        if (name == "Paladin") { paladin.maxHealthModifierPercentageTemporary = higherVitalityUpOneAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinHealthUpIcon.SetActive(true); paladin.maxHealthUp = true; }
        else if (name == "Wizard") { wizard.maxHealthModifierPercentageTemporary = higherVitalityUpOneAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardHealthUpIcon.SetActive(true); wizard.maxHealthUp = true; }
    }

    public void HigherVitalityUpTwoEffects(string name)
    {
        if (name == "Paladin") { paladin.maxHealthModifierPercentageTemporary = higherVitalityUpTwoAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinHealthUpIcon.SetActive(true); paladin.maxHealthUp = true; }
        else if (name == "Wizard") { wizard.maxHealthModifierPercentageTemporary = higherVitalityUpTwoAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardHealthUpIcon.SetActive(true); wizard.maxHealthUp = true; }
    }

    public void HigherVitalityUpThreeEffects(string name)
    {
        if (name == "Paladin") { paladin.maxHealthModifierPercentageTemporary = higherVitalityUpThreeAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinHealthUpIcon.SetActive(true); paladin.maxHealthUp = true; }
        else if (name == "Wizard") { wizard.maxHealthModifierPercentageTemporary = higherVitalityUpThreeAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardHealthUpIcon.SetActive(true); wizard.maxHealthUp = true; }
    }




    public void ClumsyOneEffects(string name)
    {
        if (name == "Paladin") { paladin.abModifierPercentageTemporary = clumsyOneABMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinSpeedDownIcon.SetActive(true); paladin.abDown = true;}
        else if (name == "Wizard") { wizard.abModifierPercentageTemporary = clumsyOneABMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardSpeedDownIcon.SetActive(true); wizard.abDown = true;}
    }

    public void ClumsyTwoEffects(string name)
    {
        if (name == "Paladin") { paladin.abModifierPercentageTemporary = clumsyTwoABMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinSpeedDownIcon.SetActive(true); paladin.abDown = true;}
        else if (name == "Wizard") { wizard.abModifierPercentageTemporary = clumsyTwoABMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardSpeedDownIcon.SetActive(true); wizard.abDown = true;}
    }

    public void ClumsyThreeEffects(string name)
    {
        if (name == "Paladin") { paladin.abModifierPercentageTemporary = clumsyThreeABMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinSpeedDownIcon.SetActive(true); paladin.abDown = true;}
        else if (name == "Wizard") { wizard.abModifierPercentageTemporary = clumsyThreeABMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardSpeedDownIcon.SetActive(true); wizard.abDown = true;}
    }



    public void WeakenOneEffects(string name)
    {
        if (name == "Paladin") { paladin.attackModifierPercentageTemporary = weakenOneAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinAttackDownIcon.SetActive(true); paladin.attackDown = true;}
        else if (name == "Wizard") { wizard.attackModifierPercentageTemporary = weakenOneAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardAttackDownIcon.SetActive(true); wizard.attackDown = true;}
    }

    public void WeakenTwoEffects(string name)
    {
        if (name == "Paladin") { paladin.attackModifierPercentageTemporary = weakenTwoAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinAttackDownIcon.SetActive(true); paladin.attackDown = true;}
        else if (name == "Wizard") { wizard.attackModifierPercentageTemporary = weakenTwoAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardAttackDownIcon.SetActive(true); wizard.attackDown = true;}
    }

    public void WeakenThreeEffects(string name)
    {
        if (name == "Paladin") { paladin.attackModifierPercentageTemporary = weakenThreeAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinAttackDownIcon.SetActive(true); paladin.attackDown = true;}
        else if (name == "Wizard") { wizard.attackModifierPercentageTemporary = weakenThreeAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardAttackDownIcon.SetActive(true); wizard.attackDown = true;}
    }




    public void DeflateArmorOneEffects(string name)
    {
        if (name == "Paladin") { paladin.defenseModifierPercentageTemporary = deflateArmorOneAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinDefenseDownIcon.SetActive(true); paladin.defenseDown = true;}
        else if (name == "Wizard") { wizard.defenseModifierPercentageTemporary = deflateArmorOneAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardDefenseDownIcon.SetActive(true); wizard.defenseDown = true;}
    }

    public void DeflateArmorTwoEffects(string name)
    {
        if (name == "Paladin") { paladin.defenseModifierPercentageTemporary = deflateArmorTwoAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinDefenseDownIcon.SetActive(true); paladin.defenseDown = true;}
        else if (name == "Wizard") { wizard.defenseModifierPercentageTemporary = deflateArmorTwoAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardDefenseDownIcon.SetActive(true); wizard.defenseDown = true;}
    }

    public void DeflateArmorThreeEffects(string name)
    {
        if (name == "Paladin") { paladin.defenseModifierPercentageTemporary = deflateArmorThreeAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinDefenseDownIcon.SetActive(true); paladin.defenseDown = true;}
        else if (name == "Wizard") { wizard.defenseModifierPercentageTemporary = deflateArmorThreeAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardDefenseDownIcon.SetActive(true); wizard.defenseDown = true;}
    }
    


    public void DeflateMagicProtectionOneEffects(string name)
    {
        if (name == "Paladin") { paladin.magicDefenseModifierPercentageTemporary = deflateMagicProtectionOneAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinMagicDefenseDownIcon.SetActive(true); paladin.magicDefenseDown = true;}
        else if (name == "Wizard") { wizard.magicDefenseModifierPercentageTemporary = deflateMagicProtectionOneAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardMagicDefenseDownIcon.SetActive(true); wizard.magicDefenseDown = true;}
    }

    public void DeflateMagicProtectionTwoEffects(string name)
    {
        if (name == "Paladin") { paladin.magicDefenseModifierPercentageTemporary = deflateMagicProtectionTwoAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinMagicDefenseDownIcon.SetActive(true); paladin.magicDefenseDown = true;}
        else if (name == "Wizard") { wizard.magicDefenseModifierPercentageTemporary = deflateMagicProtectionTwoAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardMagicDefenseDownIcon.SetActive(true); wizard.magicDefenseDown = true;}
    }

    public void DeflateMagicProtectionThreeEffects(string name)
    {
        if (name == "Paladin") { paladin.magicDefenseModifierPercentageTemporary = deflateMagicProtectionThreeAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinMagicDefenseDownIcon.SetActive(true); paladin.magicDefenseDown = true;}
        else if (name == "Wizard") { wizard.magicDefenseModifierPercentageTemporary = deflateMagicProtectionThreeAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardMagicDefenseDownIcon.SetActive(true); wizard.magicDefenseDown = true;}
    }



    public void FeeblemindOneEffects(string name)
    {
        if (name == "Paladin") { paladin.magicModifierPercentageTemporary = feeblemindOneAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinMagicDownIcon.SetActive(true); paladin.magicDown = true;}
        else if (name == "Wizard") { wizard.magicModifierPercentageTemporary = feeblemindOneAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardMagicDownIcon.SetActive(true); wizard.magicDown = true;}
    }

    public void FeeblemindTwoEffects(string name)
    {
        if (name == "Paladin") { paladin.magicModifierPercentageTemporary = feeblemindTwoAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinMagicDownIcon.SetActive(true); paladin.magicDown = true;}
        else if (name == "Wizard") { wizard.magicModifierPercentageTemporary = feeblemindTwoAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardMagicDownIcon.SetActive(true); wizard.magicDown = true;}
    }

    public void FeeblemindThreeEffects(string name)
    {
        if (name == "Paladin") { paladin.magicModifierPercentageTemporary = feeblemindThreeAttackMod; paladin.TemporaryBuffsAndDebuffs();
                                 paladinMagicDownIcon.SetActive(true); paladin.magicDown = true;}
        else if (name == "Wizard") { wizard.magicModifierPercentageTemporary = feeblemindThreeAttackMod; wizard.TemporaryBuffsAndDebuffs();
                                     wizardMagicDownIcon.SetActive(true); wizard.magicDown = true;}
    }

    public void DispelOneEffects(string name)
    {
        if (name == "Paladin")
        {
            for (int number = 0; number < dispelOneAmount; number++)
            {
                DispelEffectsPaladin();
            }
        }

        else if (name == "Wizard")
        {
            for (int number = 0; number < dispelOneAmount; number++)
            {
                DispelEffectsWizard();
            }
        }
    }

    public void DispelTwoEffects(string name)
    {
        if (name == "Paladin")
        {
            for (int number = 0; number < dispelTwoAmount; number++)
            {
                DispelEffectsPaladin();
            }
        }

        else if (name == "Wizard")
        {
            for (int number = 0; number < dispelTwoAmount; number++)
            {
                DispelEffectsWizard();
            }
        }
    }

    public void DispelThreeEffects(string name)
    {
        if (name == "Paladin")
        {
            for (int number = 0; number < dispelThreeAmount; number++)
            {
                DispelEffectsPaladin();
            }
        }

        else if (name == "Wizard")
        {
            for (int number = 0; number < dispelThreeAmount; number++)
            {
                DispelEffectsWizard();
            }
        }
    }


    void DispelEffectsPaladin()
    { 
        if (paladin.attackUp == false && paladin.attackUp == false && paladin.magicUp == false && paladin.magicDown == false &&
            paladin.defenseUp == false && paladin.defenseDown == false && paladin.magicDefenseUp == false && paladin.magicDefenseDown == false &&
            paladin.abUp == false && paladin.abDown == false && paladin.maxHealthUp == false && paladin.maxHealthDown == false)
        {
            return;
        }

        var randomNumber = Random.Range(0, 5);

        bool toContinue = false;

        if (randomNumber == 0)
        {
            if (paladin.magicUp == true || paladin.magicDown == true)
            {
                paladin.magicModifierPercentageTemporary = 0; paladin.TemporaryBuffsAndDebuffs();
                paladinMagicDownIcon.SetActive(false);
                paladinMagicUpIcon.SetActive(false);

                paladin.magicUp = false;
                paladin.magicDown = false;

                toContinue = true;
            }
        }

        else if (randomNumber == 1)
        {
            if (paladin.magicDefenseUp == true || paladin.magicDefenseDown == true)
            {
                paladin.magicDefenseModifierPercentageTemporary = 0; paladin.TemporaryBuffsAndDebuffs();
                paladinMagicDefenseDownIcon.SetActive(false);
                paladinMagicDefenseUpIcon.SetActive(false);

                paladin.magicDefenseUp = false;
                paladin.magicDefenseDown = false;

                toContinue = true;
            }
        }

        else if (randomNumber == 2)
        {
            if (paladin.defenseUp == true || paladin.defenseDown == true)
            {
                paladin.defenseModifierPercentageTemporary = 0; paladin.TemporaryBuffsAndDebuffs();
                paladinDefenseUpIcon.SetActive(false);
                paladinDefenseDownIcon.SetActive(false);

                paladin.defenseUp = false;
                paladin.defenseDown = false;

                toContinue = true;
            }
        }

        else if (randomNumber == 3)
        {
            if (paladin.attackUp == true || paladin.attackDown == true)
            {
                paladin.attackModifierPercentageTemporary = 0; paladin.TemporaryBuffsAndDebuffs();
                paladinAttackUpIcon.SetActive(false);
                paladinAttackDownIcon.SetActive(false);

                paladin.attackUp = false;
                paladin.attackDown = false;

                toContinue = true;
            }
        }


        else if (randomNumber == 4)
        {
            if(paladin.abUp == true || paladin.abDown == true)
            {
                paladin.abModifierPercentageTemporary = 0; paladin.TemporaryBuffsAndDebuffs();
                paladinSpeedUpIcon.SetActive(false);
                paladinSpeedDownIcon.SetActive(false);

                paladin.abUp = false;
                paladin.abDown = false;

                toContinue = true;
            }
        }

        if (toContinue == false)
        {
            DispelEffectsPaladin();
            Debug.Log("It's going to Repeat");
        }

        Debug.Log("Max Health Buff to Add");
    }

    void DispelEffectsWizard()
    {
        if (wizard.attackUp == false && wizard.attackUp == false && wizard.magicUp == false && wizard.magicDown == false &&
            wizard.defenseUp == false && wizard.defenseDown == false && wizard.magicDefenseUp == false && wizard.magicDefenseDown == false &&
            wizard.abUp == false && wizard.abDown == false && wizard.maxHealthUp == false && wizard.maxHealthDown == false)
        {
            return;
        }

        var randomNumber = Random.Range(0, 5);

        bool toContinue = false;


        if (randomNumber == 0)
        {
            if (wizard.magicUp == true || wizard.magicDown == true)
            {
                wizard.magicModifierPercentageTemporary = 0; wizard.TemporaryBuffsAndDebuffs();
                wizardMagicDownIcon.SetActive(false);
                wizardMagicUpIcon.SetActive(false);

                wizard.magicUp = false;
                wizard.magicDown = false;

                toContinue = true;
            }
        }

        else if (randomNumber == 1)
        {
            if (wizard.magicDefenseUp == true || wizard.magicDefenseDown == true)
            {
                wizard.magicDefenseModifierPercentageTemporary = 0; wizard.TemporaryBuffsAndDebuffs();
                wizardMagicDefenseDownIcon.SetActive(false);
                wizardMagicDefenseUpIcon.SetActive(false);

                wizard.magicDefenseUp = false;
                wizard.magicDefenseDown = false;

                toContinue = true;
            }
        }

        else if (randomNumber == 2)
        {
            if (wizard.defenseUp == true || wizard.defenseDown == true)
            {
                wizard.defenseModifierPercentageTemporary = 0; wizard.TemporaryBuffsAndDebuffs();
                wizardDefenseUpIcon.SetActive(false);
                wizardDefenseDownIcon.SetActive(false);

                wizard.defenseUp = false;
                wizard.defenseDown = false;

                toContinue = true;
            }
        }

        else if (randomNumber == 3)
        {
            if (wizard.attackUp == true || wizard.attackDown == true)
            {
                wizard.attackModifierPercentageTemporary = 0; wizard.TemporaryBuffsAndDebuffs();
                wizardAttackUpIcon.SetActive(false);
                wizardAttackDownIcon.SetActive(false);

                wizard.attackUp = false;
                wizard.attackDown = false;

                toContinue = true;
            }
        }


        else if (randomNumber == 4)
        {
            if (wizard.abUp == true || wizard.abDown == true)
            {
                wizard.abModifierPercentageTemporary = 0; wizard.TemporaryBuffsAndDebuffs();
                wizardSpeedUpIcon.SetActive(false);
                wizardSpeedDownIcon.SetActive(false);

                wizard.abUp = false;
                wizard.abDown = false;

                toContinue = true;
            }
        }

        if (toContinue == false)
        {
            DispelEffectsWizard();
            Debug.Log("It's going to Repeat");
        }

        Debug.Log("Max Health Buff to Add");
    }



    public void HealOneEffects(string name)
    {
        if (name == "Paladin") { paladin.currentHealthModifierPercentageTemporary = healOneHealthMod; paladin.isHealing = true;
                                 paladin.TemporaryBuffsAndDebuffs(); }
        else if (name == "Wizard") { wizard.currentHealthModifierPercentageTemporary = healOneHealthMod; wizard.isHealing = true;
                                     wizard.TemporaryBuffsAndDebuffs(); }
    }

    public void HealTwoEffects(string name)
    {
        if (name == "Paladin") { paladin.currentHealthModifierPercentageTemporary = healTwoHealthMod; paladin.isHealing = true;
                                 paladin.TemporaryBuffsAndDebuffs(); }
        else if (name == "Wizard") { wizard.currentHealthModifierPercentageTemporary = healTwoHealthMod; wizard.isHealing = true;
                                     wizard.TemporaryBuffsAndDebuffs(); }
    }

    public void HealThreeEffects(string name)
    {
        if (name == "Paladin") { paladin.currentHealthModifierPercentageTemporary = healThreeHealthMod; paladin.isHealing = true;
                                 paladin.TemporaryBuffsAndDebuffs(); }
        else if (name == "Wizard") { wizard.currentHealthModifierPercentageTemporary = healThreeHealthMod; wizard.isHealing = true;
                                     wizard.TemporaryBuffsAndDebuffs(); }
    }
}
