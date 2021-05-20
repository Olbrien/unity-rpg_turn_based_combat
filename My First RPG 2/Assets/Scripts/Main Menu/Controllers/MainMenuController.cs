using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainMenuController : MonoBehaviour
{
    [Header("Level")]

    public int selectedLevel;

    bool start = true;   





    [Space(40)]        

    public Sky sky;
    public TextMeshProUGUI mapName;

    public EntireGameControllerCollector entireGameControllerCollector;
    public StartingAnimationController startingAnimationController;
    public ItemStats itemStats;

    public Canvas canvasSettingsMenu;
    public CanvasGroup canvasGroupSettingsMenu;

    public Canvas canvasPlayerMenu;
    public CanvasGroup canvasGroupPlayerMenu;
    public Canvas canvasPaladinPlayerMenu;
    public Canvas canvasWizardPlayerMenu;


    public Canvas canvasWorldMapMenu;
    public CanvasGroup canvasGroupWorldMapMenu;


    [Space(40)]

    public TextMeshProUGUI paladinAttackText;
    public TextMeshProUGUI paladinMagicText;
    public TextMeshProUGUI paladinSpeedText;
    public TextMeshProUGUI paladinDefenseText;
    public TextMeshProUGUI paladinMagicDefenseText;
    public TextMeshProUGUI paladinHealthText;
    public TextMeshProUGUI paladinIceResistanceText;
    public TextMeshProUGUI paladinFireResistanceText;
    public TextMeshProUGUI paladinWaterResistanceText;

    public TextMeshProUGUI wizardAttackText;
    public TextMeshProUGUI wizardMagicText;
    public TextMeshProUGUI wizardSpeedText;
    public TextMeshProUGUI wizardDefenseText;
    public TextMeshProUGUI wizardMagicDefenseText;
    public TextMeshProUGUI wizardHealthText;
    public TextMeshProUGUI wizardIceResistanceText;
    public TextMeshProUGUI wizardFireResistanceText;
    public TextMeshProUGUI wizardWaterResistanceText;


    [Header("Locked and Unlocked Levels")]

    public List<Canvas> lockedLevels;
    public List<Canvas> unlockedLevels;





    [Header("Paladin Attack Items")]

    public Canvas paladinAttackItemCanvas;
    public CanvasGroup paladinAttackItemCanvasGroup;
    [Space(20)]

    public GameObject copperSabreGameObject;
    public GameObject ironSabreGameObject;
    public GameObject bronzeSabreGameObject;
    public GameObject silverSabreGameObject;
    public GameObject goldSabreGameObject;
    public GameObject agapiteSabreGameObject;
    public GameObject shadowSabreGameObject;
    public GameObject strongholdSabreGameObject;
    public GameObject verminardSabreGameObject;
    public GameObject adamantineSabreGameObject;
    public GameObject blackrockSabreGameObject;
    public GameObject imperialSabreGameObject;

    [Space(10)]

    public Canvas informationTextCopper;
    public Canvas informationTextIron;
    public Canvas informationTextBronze;
    public Canvas informationTextSilver;
    public Canvas informationTextGold;
    public Canvas informationTextAgapite;
    public Canvas informationTextShadow;
    public Canvas informationTextStronghold;
    public Canvas informationTextVerminard;
    public Canvas informationTextAdamantine;
    public Canvas informationTextBlackrock;
    public Canvas informationTextImperial;


    [Header("Paladin Magic Items")]

    public Canvas paladinMagicItemCanvas;
    public CanvasGroup paladinMagicItemCanvasGroup;
    [Space(20)]

    public GameObject apprenticePaladinBookVol1GameObject;
    public GameObject apprenticePaladinBookVol2GameObject;
    public GameObject journeymanPaladinBookVol1GameObject;
    public GameObject journeymanPaladinBookVol2GameObject;
    public GameObject lostPaladinBookVol1GameObject;
    public GameObject lostPaladinBookVol2GameObject;
    public GameObject expertPaladinBookVol1GameObject;
    public GameObject grandmasterPaladinBookVol1GameObject;
    public GameObject grandmasterPaladinBookVol2GameObject;
    public GameObject imperialPaladinBookVol1GameObject;


    [Space(10)]

    public Canvas informationTextApprenticePaladinBookVol1;
    public Canvas informationTextApprenticePaladinBookVol2;
    public Canvas informationTextJourneymanPaladinBookVol1;
    public Canvas informationTextJourneymanPaladinBookVol2;
    public Canvas informationTextLostPaladinBookVol1;
    public Canvas informationTextLostPaladinBookVol2;
    public Canvas informationTextExpertPaladinBookVol1;
    public Canvas informationTextGrandmasterPaladinBookVol1;
    public Canvas informationTextGrandmasterPaladinBookVol2;
    public Canvas informationTextImperialPaladinBookVol1;



    [Header("Paladin Speed Items")]

    public Canvas paladinSpeedItemCanvas;
    public CanvasGroup paladinSpeedItemCanvasGroup;
    [Space(20)]

    public GameObject rustyCombatBootsGameObject;
    public GameObject poorCombatBootsGameObject;
    public GameObject fineCombatBootsGameObject;
    public GameObject decentCombatBootsGameObject;
    public GameObject excellentCombatBootsGameObject;
    public GameObject imperialCombatBootsGameObject;
    

    [Space(10)]

    public Canvas informationTextRustyCombatBoots;
    public Canvas informationTextPoorCombatBoots;
    public Canvas informationTextFineCombatBoots;
    public Canvas informationTextDecentCombatBoots;
    public Canvas informationTextExcellentCombatBoots;
    public Canvas informationTextImperialCombatBoots;



    [Header("Paladin Defense Items")]

    public Canvas paladinDefenseItemCanvas;
    public CanvasGroup paladinDefenseItemCanvasGroup;
    [Space(20)]

    public GameObject rustyPlatemailArmorGameObject;
    public GameObject poorPlatemailArmorGameObject;
    public GameObject finePlatemailArmorGameObject;
    public GameObject decentPlatemailArmorGameObject;
    public GameObject excellentPlatemailArmorGameObject;
    public GameObject imperialPlatemailArmorGameObject;


    [Space(10)]

    public Canvas informationTextRustyPlatemailArmor;
    public Canvas informationTextPoorPlatemailArmor;
    public Canvas informationTextFinePlatemailArmor;
    public Canvas informationTextDecentPlatemailArmor;
    public Canvas informationTextExcellentPlatemailArmor;
    public Canvas informationTextImperialPlatemailArmor;



    [Header("Paladin Magic Defense Items")]

    public Canvas paladinMagicDefenseItemCanvas;
    public CanvasGroup paladinMagicDefenseItemCanvasGroup;
    [Space(20)]

    public GameObject amberTiaraGameObject;
    public GameObject rubyTiaraGameObject;
    public GameObject emeraldTiaraGameObject;
    public GameObject diamondTiaraGameObject;
    public GameObject citrineTiaraGameObject;
    public GameObject imperialStarSapphireTiaraGameObject;


    [Space(10)]

    public Canvas informationTextAmberTiara;
    public Canvas informationTextRubyTiara;
    public Canvas informationTextEmeraldTiara;
    public Canvas informationTextDiamondTiara;
    public Canvas informationTextCitrineTiara;
    public Canvas informationTextImperialStarSapphireTiara;




    void Update()
    {
        if (start)
        {
            sky.Skies[entireGameControllerCollector.selectedLevel].enabled = true;

            if (entireGameControllerCollector.selectedLevel == 0) { mapName.text = "Desolated Waste"; }
            else if (entireGameControllerCollector.selectedLevel == 1) { mapName.text = "Calm beach"; }
            else if (entireGameControllerCollector.selectedLevel == 2) { mapName.text = "Night Forest"; }
            else if (entireGameControllerCollector.selectedLevel == 3) { mapName.text = "Marsh"; }
            else if (entireGameControllerCollector.selectedLevel == 4) { mapName.text = "Dystopia"; }
            else if (entireGameControllerCollector.selectedLevel == 5) { mapName.text = "Fields"; }
            else if (entireGameControllerCollector.selectedLevel == 6) { mapName.text = "Parished Ruins"; }
            else if (entireGameControllerCollector.selectedLevel == 7) { mapName.text = "Dead End"; }

            WorldMapUpdate();
            
            UpdatePlayerItems();

            start = false;
        }        
    }



    void WorldMapUpdate()
    {
        if (entireGameControllerCollector.completedLevels == 0)
        {
            unlockedLevels[0].enabled = true;

            lockedLevels[0].enabled = true;
            lockedLevels[1].enabled = true;
            lockedLevels[2].enabled = true;
            lockedLevels[3].enabled = true;
            lockedLevels[4].enabled = true;
            lockedLevels[5].enabled = true;
            lockedLevels[6].enabled = true;
        }

        else if (entireGameControllerCollector.completedLevels == 1)
        {
            unlockedLevels[0].enabled = true;
            unlockedLevels[1].enabled = true;

            lockedLevels[1].enabled = true;
            lockedLevels[2].enabled = true;
            lockedLevels[3].enabled = true;
            lockedLevels[4].enabled = true;
            lockedLevels[5].enabled = true;
            lockedLevels[6].enabled = true;
        }

        else if (entireGameControllerCollector.completedLevels == 2)
        {
            unlockedLevels[0].enabled = true;
            unlockedLevels[1].enabled = true;
            unlockedLevels[2].enabled = true;

            lockedLevels[2].enabled = true;
            lockedLevels[3].enabled = true;
            lockedLevels[4].enabled = true;
            lockedLevels[5].enabled = true;
            lockedLevels[6].enabled = true;
        }

        else if (entireGameControllerCollector.completedLevels == 3)
        {
            unlockedLevels[0].enabled = true;
            unlockedLevels[1].enabled = true;
            unlockedLevels[2].enabled = true;
            unlockedLevels[3].enabled = true;

            lockedLevels[3].enabled = true;
            lockedLevels[4].enabled = true;
            lockedLevels[5].enabled = true;
            lockedLevels[6].enabled = true;
        }

        else if (entireGameControllerCollector.completedLevels == 4)
        {
            unlockedLevels[0].enabled = true;
            unlockedLevels[1].enabled = true;
            unlockedLevels[2].enabled = true;
            unlockedLevels[3].enabled = true;
            unlockedLevels[4].enabled = true;
                        
            lockedLevels[4].enabled = true;
            lockedLevels[5].enabled = true;
            lockedLevels[6].enabled = true;
        }

        else if (entireGameControllerCollector.completedLevels == 5)
        {
            unlockedLevels[0].enabled = true;
            unlockedLevels[1].enabled = true;
            unlockedLevels[2].enabled = true;
            unlockedLevels[3].enabled = true;
            unlockedLevels[4].enabled = true;
            unlockedLevels[5].enabled = true;

            lockedLevels[5].enabled = true;
            lockedLevels[6].enabled = true;
        }

        else if (entireGameControllerCollector.completedLevels == 6)
        {
            unlockedLevels[0].enabled = true;
            unlockedLevels[1].enabled = true;
            unlockedLevels[2].enabled = true;
            unlockedLevels[3].enabled = true;
            unlockedLevels[4].enabled = true;
            unlockedLevels[5].enabled = true;
            unlockedLevels[6].enabled = true;

            lockedLevels[6].enabled = true;
        }

        else if (entireGameControllerCollector.completedLevels == 7)
        {
            unlockedLevels[0].enabled = true;
            unlockedLevels[1].enabled = true;
            unlockedLevels[2].enabled = true;
            unlockedLevels[3].enabled = true;
            unlockedLevels[4].enabled = true;
            unlockedLevels[5].enabled = true;
            unlockedLevels[6].enabled = true;
            unlockedLevels[7].enabled = true;
        }
    }



    void ChangeSky()
    {
        sky.Skies[0].enabled = false;
        sky.Skies[1].enabled = false;
        sky.Skies[2].enabled = false;
        sky.Skies[3].enabled = false;
        sky.Skies[4].enabled = false;
        sky.Skies[5].enabled = false;
        sky.Skies[6].enabled = false;
        sky.Skies[7].enabled = false;

        sky.Skies[selectedLevel].enabled = true;

        if (selectedLevel == 0) { mapName.text = "Desolated Waste"; }
        else if (selectedLevel == 1) { mapName.text = "Calm beach"; }
        else if (selectedLevel == 2) { mapName.text = "Night Forest"; }
        else if (selectedLevel == 3) { mapName.text = "Marsh"; }
        else if (selectedLevel == 4) { mapName.text = "Dystopia"; }
        else if (selectedLevel == 5) { mapName.text = "Fields"; }
        else if (selectedLevel == 6) { mapName.text = "Parished Ruins"; }
        else if (selectedLevel == 7) { mapName.text = "Dead End"; }
    }


    public void UpdatePlayerText()
    {
        paladinAttackText.text = entireGameControllerCollector.paladinAttack.ToString();
        paladinMagicText.text = entireGameControllerCollector.paladinMagic.ToString();

        if (entireGameControllerCollector.paladinSpeed > 0) { paladinSpeedText.text = 
                                                              "+" + entireGameControllerCollector.paladinSpeed.ToString() + "%"; }
        else if (entireGameControllerCollector.paladinSpeed < 0) { paladinSpeedText.text = 
                                                               entireGameControllerCollector.paladinSpeed.ToString() + "%"; }
        else if (entireGameControllerCollector.paladinSpeed == 0) { paladinSpeedText.text = 
                                                               entireGameControllerCollector.paladinSpeed.ToString() + "%"; }

        paladinDefenseText.text = entireGameControllerCollector.paladinDefense.ToString(); ;
        paladinMagicDefenseText.text = entireGameControllerCollector.paladinMagicDefense.ToString(); 
        paladinHealthText.text = entireGameControllerCollector.paladinMaxHealth.ToString();
                
        if (entireGameControllerCollector.paladinIceResistance > 0) { paladinIceResistanceText.text = 
                                                              "+" + entireGameControllerCollector.paladinIceResistance.ToString() + "%"; }
        else if (entireGameControllerCollector.paladinIceResistance < 0) { paladinIceResistanceText.text = 
                                                               entireGameControllerCollector.paladinIceResistance.ToString() + "%"; }
        else if (entireGameControllerCollector.paladinIceResistance == 0) { paladinIceResistanceText.text = 
                                                               entireGameControllerCollector.paladinIceResistance.ToString() + "%"; }

        if (entireGameControllerCollector.paladinFireResistance > 0) { paladinFireResistanceText.text = 
                                                              "+" + entireGameControllerCollector.paladinFireResistance.ToString() + "%"; }
        else if (entireGameControllerCollector.paladinFireResistance < 0) { paladinFireResistanceText.text = 
                                                               entireGameControllerCollector.paladinFireResistance.ToString() + "%"; }
        else if (entireGameControllerCollector.paladinFireResistance == 0) { paladinFireResistanceText.text = 
                                                               entireGameControllerCollector.paladinFireResistance.ToString() + "%"; }

        if (entireGameControllerCollector.paladinWaterResistance > 0) { paladinWaterResistanceText.text = 
                                                              "+" + entireGameControllerCollector.paladinWaterResistance.ToString() + "%"; }
        else if (entireGameControllerCollector.paladinWaterResistance < 0) { paladinWaterResistanceText.text = 
                                                               entireGameControllerCollector.paladinWaterResistance.ToString() + "%"; }
        else if (entireGameControllerCollector.paladinWaterResistance == 0) { paladinWaterResistanceText.text = 
                                                               entireGameControllerCollector.paladinWaterResistance.ToString() + "%"; }



        wizardAttackText.text = entireGameControllerCollector.wizardAttack.ToString();
        wizardMagicText.text = entireGameControllerCollector.wizardMagic.ToString();
        
        if (entireGameControllerCollector.wizardSpeed > 0) { wizardSpeedText.text = 
                                                              "+" + entireGameControllerCollector.wizardSpeed.ToString() + "%"; }
        else if (entireGameControllerCollector.wizardSpeed < 0) { wizardSpeedText.text = 
                                                               entireGameControllerCollector.wizardSpeed.ToString() + "%"; }
        else if (entireGameControllerCollector.wizardSpeed == 0) { wizardSpeedText.text = 
                                                               entireGameControllerCollector.wizardSpeed.ToString() + "%"; }

        wizardDefenseText.text = entireGameControllerCollector.wizardDefense.ToString(); ;
        wizardMagicDefenseText.text = entireGameControllerCollector.wizardMagicDefense.ToString();
        wizardHealthText.text = entireGameControllerCollector.wizardMaxHealth.ToString();

        if (entireGameControllerCollector.wizardIceResistance > 0) { wizardIceResistanceText.text = 
                                                              "+" + entireGameControllerCollector.wizardIceResistance.ToString() + "%"; }
        else if (entireGameControllerCollector.wizardIceResistance < 0) { wizardIceResistanceText.text = 
                                                               entireGameControllerCollector.wizardIceResistance.ToString() + "%"; }
        else if (entireGameControllerCollector.wizardIceResistance == 0) { wizardIceResistanceText.text = 
                                                               entireGameControllerCollector.wizardIceResistance.ToString() + "%"; }

        if (entireGameControllerCollector.wizardFireResistance > 0) { wizardFireResistanceText.text = 
                                                              "+" + entireGameControllerCollector.wizardFireResistance.ToString() + "%"; }
        else if (entireGameControllerCollector.wizardFireResistance < 0) { wizardFireResistanceText.text = 
                                                               entireGameControllerCollector.wizardFireResistance.ToString() + "%"; }
        else if (entireGameControllerCollector.wizardFireResistance == 0) { wizardFireResistanceText.text = 
                                                               entireGameControllerCollector.wizardFireResistance.ToString() + "%"; }

        if (entireGameControllerCollector.wizardWaterResistance > 0) { wizardWaterResistanceText.text = 
                                                              "+" + entireGameControllerCollector.wizardWaterResistance.ToString() + "%"; }
        else if (entireGameControllerCollector.wizardWaterResistance < 0) { wizardWaterResistanceText.text = 
                                                               entireGameControllerCollector.wizardWaterResistance.ToString() + "%"; }
        else if (entireGameControllerCollector.wizardWaterResistance == 0) { wizardWaterResistanceText.text = 
                                                               entireGameControllerCollector.wizardWaterResistance.ToString() + "%"; }
    }




    void UpdatePlayerItems()
    {
        /////////////
        // Paladin //
        /////////////
        // Attack //
        ////////////
        
        
        if (entireGameControllerCollector.copperSabre >= 1) { copperSabreGameObject.SetActive(true); }
        else if (entireGameControllerCollector.copperSabre == 0) { copperSabreGameObject.SetActive(false); }

        if (entireGameControllerCollector.ironSabre >= 1) { ironSabreGameObject.SetActive(true); }
        else if (entireGameControllerCollector.ironSabre == 0) { ironSabreGameObject.SetActive(false); }

        if (entireGameControllerCollector.bronzeSabre >= 1) { bronzeSabreGameObject.SetActive(true); }
        else if (entireGameControllerCollector.bronzeSabre == 0) { bronzeSabreGameObject.SetActive(false); }

        if (entireGameControllerCollector.silverSabre >= 1) { silverSabreGameObject.SetActive(true); }
        else if (entireGameControllerCollector.silverSabre == 0) { silverSabreGameObject.SetActive(false); }

        if (entireGameControllerCollector.goldSabre >= 1) { goldSabreGameObject.SetActive(true); }
        else if (entireGameControllerCollector.goldSabre == 0) { goldSabreGameObject.SetActive(false); }

        if (entireGameControllerCollector.agapiteSabre >= 1) { agapiteSabreGameObject.SetActive(true); }
        else if (entireGameControllerCollector.agapiteSabre == 0) { agapiteSabreGameObject.SetActive(false); }

        if (entireGameControllerCollector.shadowSabre >= 1) { shadowSabreGameObject.SetActive(true); }
        else if (entireGameControllerCollector.shadowSabre == 0) { shadowSabreGameObject.SetActive(false); }

        if (entireGameControllerCollector.strongholdSabre >= 1) { strongholdSabreGameObject.SetActive(true); }
        else if (entireGameControllerCollector.strongholdSabre == 0) { strongholdSabreGameObject.SetActive(false); }

        if (entireGameControllerCollector.verminardSabre >= 1) { verminardSabreGameObject.SetActive(true); }
        else if (entireGameControllerCollector.verminardSabre == 0) { verminardSabreGameObject.SetActive(false); }

        if (entireGameControllerCollector.adamantineSabre >= 1) { adamantineSabreGameObject.SetActive(true); }
        else if (entireGameControllerCollector.adamantineSabre == 0) { adamantineSabreGameObject.SetActive(false); }

        if (entireGameControllerCollector.blackrockSabre >= 1) { blackrockSabreGameObject.SetActive(true); }
        else if (entireGameControllerCollector.blackrockSabre == 0) { blackrockSabreGameObject.SetActive(false); }

        if (entireGameControllerCollector.imperialSabre >= 1) { imperialSabreGameObject.SetActive(true); }
        else if (entireGameControllerCollector.imperialSabre == 0) { imperialSabreGameObject.SetActive(false); }


        /////////////
        // Magic //
        ////////////


        if (entireGameControllerCollector.apprenticePaladinBookVol1 >= 1) { apprenticePaladinBookVol1GameObject.SetActive(true); }
        else if (entireGameControllerCollector.apprenticePaladinBookVol1 == 0) { apprenticePaladinBookVol1GameObject.SetActive(false); }

        if (entireGameControllerCollector.apprenticePaladinBookVol2 >= 1) { apprenticePaladinBookVol2GameObject.SetActive(true); }
        else if (entireGameControllerCollector.apprenticePaladinBookVol2 == 0) { apprenticePaladinBookVol2GameObject.SetActive(false); }

        if (entireGameControllerCollector.journeymanPaladinBookVol1 >= 1) { journeymanPaladinBookVol1GameObject.SetActive(true); }
        else if (entireGameControllerCollector.journeymanPaladinBookVol1 == 0) { journeymanPaladinBookVol1GameObject.SetActive(false); }

        if (entireGameControllerCollector.journeymanPaladinBookVol2 >= 1) { journeymanPaladinBookVol2GameObject.SetActive(true); }
        else if (entireGameControllerCollector.journeymanPaladinBookVol2 == 0) { journeymanPaladinBookVol2GameObject.SetActive(false); }

        if (entireGameControllerCollector.lostPaladinBookVol1 >= 1) { lostPaladinBookVol1GameObject.SetActive(true); }
        else if (entireGameControllerCollector.lostPaladinBookVol1 == 0) { lostPaladinBookVol1GameObject.SetActive(false); }

        if (entireGameControllerCollector.lostPaladinBookVol2 >= 1) { lostPaladinBookVol2GameObject.SetActive(true); }
        else if (entireGameControllerCollector.lostPaladinBookVol2 == 0) { lostPaladinBookVol2GameObject.SetActive(false); }

        if (entireGameControllerCollector.expertPaladinBookVol1 >= 1) { expertPaladinBookVol1GameObject.SetActive(true); }
        else if (entireGameControllerCollector.expertPaladinBookVol1 == 0) { expertPaladinBookVol1GameObject.SetActive(false); }

        if (entireGameControllerCollector.grandmasterPaladinBookVol1 >= 1) { grandmasterPaladinBookVol1GameObject.SetActive(true); }
        else if (entireGameControllerCollector.grandmasterPaladinBookVol1 == 0) { grandmasterPaladinBookVol1GameObject.SetActive(false); }

        if (entireGameControllerCollector.grandmasterPaladinBookVol2 >= 1) { grandmasterPaladinBookVol2GameObject.SetActive(true); }
        else if (entireGameControllerCollector.grandmasterPaladinBookVol2 == 0) { grandmasterPaladinBookVol2GameObject.SetActive(false); }

        if (entireGameControllerCollector.imperialPaladinBookVol1 >= 1) { imperialPaladinBookVol1GameObject.SetActive(true); }
        else if (entireGameControllerCollector.imperialPaladinBookVol1 == 0) { imperialPaladinBookVol1GameObject.SetActive(false); }



        /////////////
        // Speed  //
        ////////////


        if (entireGameControllerCollector.rustyCombatBoots >= 1) { rustyCombatBootsGameObject.SetActive(true); }
        else if (entireGameControllerCollector.rustyCombatBoots == 0) { rustyCombatBootsGameObject.SetActive(false); }

        if (entireGameControllerCollector.poorCombatBoots >= 1) { poorCombatBootsGameObject.SetActive(true); }
        else if (entireGameControllerCollector.poorCombatBoots == 0) { poorCombatBootsGameObject.SetActive(false); }

        if (entireGameControllerCollector.fineCombatBoots >= 1) { fineCombatBootsGameObject.SetActive(true); }
        else if (entireGameControllerCollector.fineCombatBoots == 0) { fineCombatBootsGameObject.SetActive(false); }

        if (entireGameControllerCollector.decentCombatBoots >= 1) { decentCombatBootsGameObject.SetActive(true); }
        else if (entireGameControllerCollector.decentCombatBoots == 0) { decentCombatBootsGameObject.SetActive(false); }

        if (entireGameControllerCollector.excellentCombatBoots >= 1) { excellentCombatBootsGameObject.SetActive(true); }
        else if (entireGameControllerCollector.excellentCombatBoots == 0) { excellentCombatBootsGameObject.SetActive(false); }

        if (entireGameControllerCollector.imperialCombatBoots >= 1) { imperialCombatBootsGameObject.SetActive(true); }
        else if (entireGameControllerCollector.imperialCombatBoots == 0) { imperialCombatBootsGameObject.SetActive(false); }


        //////////////
        // Defense //
        /////////////


        if (entireGameControllerCollector.rustyPlatemailArmor >= 1) { rustyPlatemailArmorGameObject.SetActive(true); }
        else if (entireGameControllerCollector.rustyPlatemailArmor == 0) { rustyPlatemailArmorGameObject.SetActive(false); }

        if (entireGameControllerCollector.poorPlatemailArmor >= 1) { poorPlatemailArmorGameObject.SetActive(true); }
        else if (entireGameControllerCollector.poorPlatemailArmor == 0) { poorPlatemailArmorGameObject.SetActive(false); }

        if (entireGameControllerCollector.finePlatemailArmor >= 1) { finePlatemailArmorGameObject.SetActive(true); }
        else if (entireGameControllerCollector.finePlatemailArmor == 0) { finePlatemailArmorGameObject.SetActive(false); }

        if (entireGameControllerCollector.decentPlatemailArmor >= 1) { decentPlatemailArmorGameObject.SetActive(true); }
        else if (entireGameControllerCollector.decentPlatemailArmor == 0) { decentPlatemailArmorGameObject.SetActive(false); }

        if (entireGameControllerCollector.excellentPlatemailArmor >= 1) { excellentPlatemailArmorGameObject.SetActive(true); }
        else if (entireGameControllerCollector.excellentPlatemailArmor == 0) { excellentPlatemailArmorGameObject.SetActive(false); }

        if (entireGameControllerCollector.imperialPlatemailArmor >= 1) { imperialPlatemailArmorGameObject.SetActive(true); }
        else if (entireGameControllerCollector.imperialPlatemailArmor == 0) { imperialPlatemailArmorGameObject.SetActive(false); }


        ///////////////////
        // Magic Defense //
        ///////////////////


        if (entireGameControllerCollector.amberTiara >= 1) { amberTiaraGameObject.SetActive(true); }
        else if (entireGameControllerCollector.amberTiara == 0) { amberTiaraGameObject.SetActive(false); }

        if (entireGameControllerCollector.rubyTiara >= 1) { rubyTiaraGameObject.SetActive(true); }
        else if (entireGameControllerCollector.rubyTiara == 0) { rubyTiaraGameObject.SetActive(false); }

        if (entireGameControllerCollector.emeraldTiara >= 1) { emeraldTiaraGameObject.SetActive(true); }
        else if (entireGameControllerCollector.emeraldTiara == 0) { emeraldTiaraGameObject.SetActive(false); }

        if (entireGameControllerCollector.diamondTiara >= 1) { diamondTiaraGameObject.SetActive(true); }
        else if (entireGameControllerCollector.diamondTiara == 0) { diamondTiaraGameObject.SetActive(false); }

        if (entireGameControllerCollector.citrineTiara >= 1) { citrineTiaraGameObject.SetActive(true); }
        else if (entireGameControllerCollector.citrineTiara == 0) { citrineTiaraGameObject.SetActive(false); }

        if (entireGameControllerCollector.imperialStarSapphireTiara >= 1) { imperialStarSapphireTiaraGameObject.SetActive(true); }
        else if (entireGameControllerCollector.imperialStarSapphireTiara == 0) { imperialStarSapphireTiaraGameObject.SetActive(false); }



    }




    public void OnClickSettings()
    {
        canvasGroupSettingsMenu.blocksRaycasts = true;
        canvasSettingsMenu.enabled = true;
    }

    public void OnClickCloseSettings()
    {
        canvasGroupSettingsMenu.blocksRaycasts = false;
        canvasSettingsMenu.enabled = false;
    }


    public void OnClickPlayerMenu()
    {
        canvasGroupPlayerMenu.blocksRaycasts = true;
        canvasPlayerMenu.enabled = true;
    }

    public void OnClickPaladinOnPlayerMenu()
    {
        canvasPaladinPlayerMenu.enabled = false;
        canvasWizardPlayerMenu.enabled = true;
    }

    public void OnClickWizardOnPlayerMenu()
    {
        canvasWizardPlayerMenu.enabled = false;
        canvasPaladinPlayerMenu.enabled = true;        
    }


    public void OnClickClosePlayerMenu()
    {
        canvasGroupPlayerMenu.blocksRaycasts = false;
        canvasPlayerMenu.enabled = false;
    }


    public void OnClickWorldMapMenu()
    {
        canvasGroupWorldMapMenu.blocksRaycasts = true;
        canvasWorldMapMenu.enabled = true;
    }

    public void OnClickCloseWorldMapMenu()
    {
        canvasGroupWorldMapMenu.blocksRaycasts = false;
        canvasWorldMapMenu.enabled = false;
    }





    public void OnClickWorldMapAreaOne()
    {
        selectedLevel = 0;
        ChangeSky();
        entireGameControllerCollector.UpdateSelectedLevel(0);
        OnClickCloseWorldMapMenu();
    }

    public void OnClickWorldMapAreaTwo()
    {
        selectedLevel = 1;
        ChangeSky();
        entireGameControllerCollector.UpdateSelectedLevel(1);
        OnClickCloseWorldMapMenu();
    }

    public void OnClickWorldMapAreaThree()
    {
        selectedLevel = 2;
        ChangeSky();
        entireGameControllerCollector.UpdateSelectedLevel(2);
        OnClickCloseWorldMapMenu();
    }

    public void OnClickWorldMapAreaFour()
    {
        selectedLevel = 3;
        ChangeSky();
        entireGameControllerCollector.UpdateSelectedLevel(3);
        OnClickCloseWorldMapMenu();
    }

    public void OnClickWorldMapAreaFive()
    {
        selectedLevel = 4;
        ChangeSky();
        entireGameControllerCollector.UpdateSelectedLevel(4);
        OnClickCloseWorldMapMenu();
    }

    public void OnClickWorldMapAreaSix()
    {
        selectedLevel = 5;
        ChangeSky();
        entireGameControllerCollector.UpdateSelectedLevel(5);
        OnClickCloseWorldMapMenu();
    }

    public void OnClickWorldMapAreaSeven()
    {
        selectedLevel = 6;
        ChangeSky();
        entireGameControllerCollector.UpdateSelectedLevel(6);
        OnClickCloseWorldMapMenu();
    }

    public void OnClickWorldMapAreaEight()
    {
        selectedLevel = 7;
        ChangeSky();
        entireGameControllerCollector.UpdateSelectedLevel(7);
        OnClickCloseWorldMapMenu();
    }

    

    public void OnClickAdventure()
    {
        entireGameControllerCollector.SaveGameToMain();
        startingAnimationController.loadingAdventure = true;
    }



    /////////////////////
    /// Paladin Items ///
    /////////////////////

    /// //// ///
    // Attack //
    /// //// ///


    public void OnClickPaladinAttackItem()
    {
        if (entireGameControllerCollector.copperSabreEquiped) { informationTextCopper.enabled = true; }
        else if (entireGameControllerCollector.ironSabreEquiped) { informationTextIron.enabled = true; }
        else if (entireGameControllerCollector.bronzeSabreEquiped) { informationTextBronze.enabled = true; }
        else if (entireGameControllerCollector.silverSabreEquiped) { informationTextSilver.enabled = true; }
        else if (entireGameControllerCollector.goldSabreEquiped) { informationTextGold.enabled = true; }
        else if (entireGameControllerCollector.agapiteSabreEquiped) { informationTextAgapite.enabled = true; }
        else if (entireGameControllerCollector.shadowSabreEquiped) { informationTextShadow.enabled = true; }
        else if (entireGameControllerCollector.strongholdSabreEquiped) { informationTextStronghold.enabled = true; }
        else if (entireGameControllerCollector.verminardSabreEquiped) { informationTextVerminard.enabled = true; }
        else if (entireGameControllerCollector.adamantineSabreEquiped) { informationTextAdamantine.enabled = true; }
        else if (entireGameControllerCollector.blackrockSabreEquiped) { informationTextBlackrock.enabled = true; }
        else if (entireGameControllerCollector.imperialSabreEquiped) { informationTextImperial.enabled = true; }

        paladinAttackItemCanvasGroup.blocksRaycasts = true;
        paladinAttackItemCanvas.enabled = true;
        
    }

    public void OnClickClosePaladinAttackItem()
    {
        informationTextCopper.enabled = false;
        informationTextIron.enabled = false;
        informationTextBronze.enabled = false;
        informationTextSilver.enabled = false;
        informationTextGold.enabled = false;
        informationTextAgapite.enabled = false;
        informationTextShadow.enabled = false;
        informationTextStronghold.enabled = false;
        informationTextVerminard.enabled = false;
        informationTextAdamantine.enabled = false;
        informationTextBlackrock.enabled = false;
        informationTextImperial.enabled = false;

        paladinAttackItemCanvasGroup.blocksRaycasts = false;
        paladinAttackItemCanvas.enabled = false;
    }


    public void OnClickCopperSabre()
    {
        informationTextCopper.enabled = true;
        informationTextIron.enabled = false;
        informationTextBronze.enabled = false;
        informationTextSilver.enabled = false;
        informationTextGold.enabled = false;
        informationTextAgapite.enabled = false;
        informationTextShadow.enabled = false;
        informationTextStronghold.enabled = false;
        informationTextVerminard.enabled = false;
        informationTextAdamantine.enabled = false;
        informationTextBlackrock.enabled = false;
        informationTextImperial.enabled = false;
    }
    public void OnClickEquipCopperSabre()
    {
        entireGameControllerCollector.copperSabreEquiped = true;
        entireGameControllerCollector.ironSabreEquiped = false;
        entireGameControllerCollector.bronzeSabreEquiped = false;
        entireGameControllerCollector.silverSabreEquiped = false;
        entireGameControllerCollector.goldSabreEquiped = false;
        entireGameControllerCollector.agapiteSabreEquiped = false;
        entireGameControllerCollector.shadowSabreEquiped = false;
        entireGameControllerCollector.strongholdSabreEquiped = false;
        entireGameControllerCollector.verminardSabreEquiped = false;
        entireGameControllerCollector.adamantineSabreEquiped = false;
        entireGameControllerCollector.blackrockSabreEquiped = false;
        entireGameControllerCollector.imperialSabreEquiped = false;

        itemStats.UpdatePaladinAttackItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinAttackItem();
    }

    public void OnClickIronSabre()
    {
        informationTextCopper.enabled = false;
        informationTextIron.enabled = true;
        informationTextBronze.enabled = false;
        informationTextSilver.enabled = false;
        informationTextGold.enabled = false;
        informationTextAgapite.enabled = false;
        informationTextShadow.enabled = false;
        informationTextStronghold.enabled = false;
        informationTextVerminard.enabled = false;
        informationTextAdamantine.enabled = false;
        informationTextBlackrock.enabled = false;
        informationTextImperial.enabled = false;
    }
    public void OnClickEquipIronSabre()
    {
        entireGameControllerCollector.copperSabreEquiped = false;
        entireGameControllerCollector.ironSabreEquiped = true;
        entireGameControllerCollector.bronzeSabreEquiped = false;
        entireGameControllerCollector.silverSabreEquiped = false;
        entireGameControllerCollector.goldSabreEquiped = false;
        entireGameControllerCollector.agapiteSabreEquiped = false;
        entireGameControllerCollector.shadowSabreEquiped = false;
        entireGameControllerCollector.strongholdSabreEquiped = false;
        entireGameControllerCollector.verminardSabreEquiped = false;
        entireGameControllerCollector.adamantineSabreEquiped = false;
        entireGameControllerCollector.blackrockSabreEquiped = false;
        entireGameControllerCollector.imperialSabreEquiped = false;

        itemStats.UpdatePaladinAttackItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinAttackItem();
    }

    public void OnClickBronzeSabre()
    {
        informationTextCopper.enabled = false;
        informationTextIron.enabled = false;
        informationTextBronze.enabled = true;
        informationTextSilver.enabled = false;
        informationTextGold.enabled = false;
        informationTextAgapite.enabled = false;
        informationTextShadow.enabled = false;
        informationTextStronghold.enabled = false;
        informationTextVerminard.enabled = false;
        informationTextAdamantine.enabled = false;
        informationTextBlackrock.enabled = false;
        informationTextImperial.enabled = false;
    }
    public void OnClickEquipBronzeSabre()
    {
        entireGameControllerCollector.copperSabreEquiped = false;
        entireGameControllerCollector.ironSabreEquiped = false;
        entireGameControllerCollector.bronzeSabreEquiped = true;
        entireGameControllerCollector.silverSabreEquiped = false;
        entireGameControllerCollector.goldSabreEquiped = false;
        entireGameControllerCollector.agapiteSabreEquiped = false;
        entireGameControllerCollector.shadowSabreEquiped = false;
        entireGameControllerCollector.strongholdSabreEquiped = false;
        entireGameControllerCollector.verminardSabreEquiped = false;
        entireGameControllerCollector.adamantineSabreEquiped = false;
        entireGameControllerCollector.blackrockSabreEquiped = false;
        entireGameControllerCollector.imperialSabreEquiped = false;

        itemStats.UpdatePaladinAttackItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinAttackItem();
    }

    public void OnClickSilverSabre()
    {
        informationTextCopper.enabled = false;
        informationTextIron.enabled = false;
        informationTextBronze.enabled = false;
        informationTextSilver.enabled = true;
        informationTextGold.enabled = false;
        informationTextAgapite.enabled = false;
        informationTextShadow.enabled = false;
        informationTextStronghold.enabled = false;
        informationTextVerminard.enabled = false;
        informationTextAdamantine.enabled = false;
        informationTextBlackrock.enabled = false;
        informationTextImperial.enabled = false;
    }
    public void OnClickEquipSilverSabre()
    {
        entireGameControllerCollector.copperSabreEquiped = false;
        entireGameControllerCollector.ironSabreEquiped = false;
        entireGameControllerCollector.bronzeSabreEquiped = false;
        entireGameControllerCollector.silverSabreEquiped = true;
        entireGameControllerCollector.goldSabreEquiped = false;
        entireGameControllerCollector.agapiteSabreEquiped = false;
        entireGameControllerCollector.shadowSabreEquiped = false;
        entireGameControllerCollector.strongholdSabreEquiped = false;
        entireGameControllerCollector.verminardSabreEquiped = false;
        entireGameControllerCollector.adamantineSabreEquiped = false;
        entireGameControllerCollector.blackrockSabreEquiped = false;
        entireGameControllerCollector.imperialSabreEquiped = false;

        itemStats.UpdatePaladinAttackItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinAttackItem();
    }

    public void OnClickGoldSabre()
    {
        informationTextCopper.enabled = false;
        informationTextIron.enabled = false;
        informationTextBronze.enabled = false;
        informationTextSilver.enabled = false;
        informationTextGold.enabled = true;
        informationTextAgapite.enabled = false;
        informationTextShadow.enabled = false;
        informationTextStronghold.enabled = false;
        informationTextVerminard.enabled = false;
        informationTextAdamantine.enabled = false;
        informationTextBlackrock.enabled = false;
        informationTextImperial.enabled = false;
    }
    public void OnClickEquipGoldSabre()
    {
        entireGameControllerCollector.copperSabreEquiped = false;
        entireGameControllerCollector.ironSabreEquiped = false;
        entireGameControllerCollector.bronzeSabreEquiped = false;
        entireGameControllerCollector.silverSabreEquiped = false;
        entireGameControllerCollector.goldSabreEquiped = true;
        entireGameControllerCollector.agapiteSabreEquiped = false;
        entireGameControllerCollector.shadowSabreEquiped = false;
        entireGameControllerCollector.strongholdSabreEquiped = false;
        entireGameControllerCollector.verminardSabreEquiped = false;
        entireGameControllerCollector.adamantineSabreEquiped = false;
        entireGameControllerCollector.blackrockSabreEquiped = false;
        entireGameControllerCollector.imperialSabreEquiped = false;

        itemStats.UpdatePaladinAttackItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinAttackItem();
    }

    public void OnClickAgapiteSabre()
    {
        informationTextCopper.enabled = false;
        informationTextIron.enabled = false;
        informationTextBronze.enabled = false;
        informationTextSilver.enabled = false;
        informationTextGold.enabled = false;
        informationTextAgapite.enabled = true;
        informationTextShadow.enabled = false;
        informationTextStronghold.enabled = false;
        informationTextVerminard.enabled = false;
        informationTextAdamantine.enabled = false;
        informationTextBlackrock.enabled = false;
        informationTextImperial.enabled = false;
    }
    public void OnClickEquipAgapiteSabre()
    {
        entireGameControllerCollector.copperSabreEquiped = false;
        entireGameControllerCollector.ironSabreEquiped = false;
        entireGameControllerCollector.bronzeSabreEquiped = false;
        entireGameControllerCollector.silverSabreEquiped = false;
        entireGameControllerCollector.goldSabreEquiped = false;
        entireGameControllerCollector.agapiteSabreEquiped = true;
        entireGameControllerCollector.shadowSabreEquiped = false;
        entireGameControllerCollector.strongholdSabreEquiped = false;
        entireGameControllerCollector.verminardSabreEquiped = false;
        entireGameControllerCollector.adamantineSabreEquiped = false;
        entireGameControllerCollector.blackrockSabreEquiped = false;
        entireGameControllerCollector.imperialSabreEquiped = false;

        itemStats.UpdatePaladinAttackItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinAttackItem();
    }

    public void OnClickShadowSabre()
    {
        informationTextCopper.enabled = false;
        informationTextIron.enabled = false;
        informationTextBronze.enabled = false;
        informationTextSilver.enabled = false;
        informationTextGold.enabled = false;
        informationTextAgapite.enabled = false;
        informationTextShadow.enabled = true;
        informationTextStronghold.enabled = false;
        informationTextVerminard.enabled = false;
        informationTextAdamantine.enabled = false;
        informationTextBlackrock.enabled = false;
        informationTextImperial.enabled = false;
    }
    public void OnClickEquipShadowSabre()
    {
        entireGameControllerCollector.copperSabreEquiped = false;
        entireGameControllerCollector.ironSabreEquiped = false;
        entireGameControllerCollector.bronzeSabreEquiped = false;
        entireGameControllerCollector.silverSabreEquiped = false;
        entireGameControllerCollector.goldSabreEquiped = false;
        entireGameControllerCollector.agapiteSabreEquiped = false;
        entireGameControllerCollector.shadowSabreEquiped = true;
        entireGameControllerCollector.strongholdSabreEquiped = false;
        entireGameControllerCollector.verminardSabreEquiped = false;
        entireGameControllerCollector.adamantineSabreEquiped = false;
        entireGameControllerCollector.blackrockSabreEquiped = false;
        entireGameControllerCollector.imperialSabreEquiped = false;

        itemStats.UpdatePaladinAttackItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinAttackItem();
    }

    public void OnClickStrongholdSabre()
    {
        informationTextCopper.enabled = false;
        informationTextIron.enabled = false;
        informationTextBronze.enabled = false;
        informationTextSilver.enabled = false;
        informationTextGold.enabled = false;
        informationTextAgapite.enabled = false;
        informationTextShadow.enabled = false;
        informationTextStronghold.enabled = true;
        informationTextVerminard.enabled = false;
        informationTextAdamantine.enabled = false;
        informationTextBlackrock.enabled = false;
        informationTextImperial.enabled = false;
    }
    public void OnClickEquipStrongholdSabre()
    {
        entireGameControllerCollector.copperSabreEquiped = false;
        entireGameControllerCollector.ironSabreEquiped = false;
        entireGameControllerCollector.bronzeSabreEquiped = false;
        entireGameControllerCollector.silverSabreEquiped = false;
        entireGameControllerCollector.goldSabreEquiped = false;
        entireGameControllerCollector.agapiteSabreEquiped = false;
        entireGameControllerCollector.shadowSabreEquiped = false;
        entireGameControllerCollector.strongholdSabreEquiped = true;
        entireGameControllerCollector.verminardSabreEquiped = false;
        entireGameControllerCollector.adamantineSabreEquiped = false;
        entireGameControllerCollector.blackrockSabreEquiped = false;
        entireGameControllerCollector.imperialSabreEquiped = false;

        itemStats.UpdatePaladinAttackItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinAttackItem();
    }

    public void OnClickVerminardSabre()
    {
        informationTextCopper.enabled = false;
        informationTextIron.enabled = false;
        informationTextBronze.enabled = false;
        informationTextSilver.enabled = false;
        informationTextGold.enabled = false;
        informationTextAgapite.enabled = false;
        informationTextShadow.enabled = false;
        informationTextStronghold.enabled = false;
        informationTextVerminard.enabled = true;
        informationTextAdamantine.enabled = false;
        informationTextBlackrock.enabled = false;
        informationTextImperial.enabled = false;
    }
    public void OnClickEquipVerminardSabre()
    {
        entireGameControllerCollector.copperSabreEquiped = false;
        entireGameControllerCollector.ironSabreEquiped = false;
        entireGameControllerCollector.bronzeSabreEquiped = false;
        entireGameControllerCollector.silverSabreEquiped = false;
        entireGameControllerCollector.goldSabreEquiped = false;
        entireGameControllerCollector.agapiteSabreEquiped = false;
        entireGameControllerCollector.shadowSabreEquiped = false;
        entireGameControllerCollector.strongholdSabreEquiped = false;
        entireGameControllerCollector.verminardSabreEquiped = true;
        entireGameControllerCollector.adamantineSabreEquiped = false;
        entireGameControllerCollector.blackrockSabreEquiped = false;
        entireGameControllerCollector.imperialSabreEquiped = false;

        itemStats.UpdatePaladinAttackItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinAttackItem();
    }

    public void OnClickAdamantineSabre()
    {
        informationTextCopper.enabled = false;
        informationTextIron.enabled = false;
        informationTextBronze.enabled = false;
        informationTextSilver.enabled = false;
        informationTextGold.enabled = false;
        informationTextAgapite.enabled = false;
        informationTextShadow.enabled = false;
        informationTextStronghold.enabled = false;
        informationTextVerminard.enabled = false;
        informationTextAdamantine.enabled = true;
        informationTextBlackrock.enabled = false;
        informationTextImperial.enabled = false;
    }
    public void OnClickEquipAdamantineSabre()
    {
        entireGameControllerCollector.copperSabreEquiped = false;
        entireGameControllerCollector.ironSabreEquiped = false;
        entireGameControllerCollector.bronzeSabreEquiped = false;
        entireGameControllerCollector.silverSabreEquiped = false;
        entireGameControllerCollector.goldSabreEquiped = false;
        entireGameControllerCollector.agapiteSabreEquiped = false;
        entireGameControllerCollector.shadowSabreEquiped = false;
        entireGameControllerCollector.strongholdSabreEquiped = false;
        entireGameControllerCollector.verminardSabreEquiped = false;
        entireGameControllerCollector.adamantineSabreEquiped = true;
        entireGameControllerCollector.blackrockSabreEquiped = false;
        entireGameControllerCollector.imperialSabreEquiped = false;

        itemStats.UpdatePaladinAttackItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinAttackItem();
    }

    public void OnClickBlackrockSabre()
    {
        informationTextCopper.enabled = false;
        informationTextIron.enabled = false;
        informationTextBronze.enabled = false;
        informationTextSilver.enabled = false;
        informationTextGold.enabled = false;
        informationTextAgapite.enabled = false;
        informationTextShadow.enabled = false;
        informationTextStronghold.enabled = false;
        informationTextVerminard.enabled = false;
        informationTextAdamantine.enabled = false;
        informationTextBlackrock.enabled = true;
        informationTextImperial.enabled = false;
    }
    public void OnClickEquipBlackrockSabre()
    {
        entireGameControllerCollector.copperSabreEquiped = false;
        entireGameControllerCollector.ironSabreEquiped = false;
        entireGameControllerCollector.bronzeSabreEquiped = false;
        entireGameControllerCollector.silverSabreEquiped = false;
        entireGameControllerCollector.goldSabreEquiped = false;
        entireGameControllerCollector.agapiteSabreEquiped = false;
        entireGameControllerCollector.shadowSabreEquiped = false;
        entireGameControllerCollector.strongholdSabreEquiped = false;
        entireGameControllerCollector.verminardSabreEquiped = false;
        entireGameControllerCollector.adamantineSabreEquiped = false;
        entireGameControllerCollector.blackrockSabreEquiped = true;
        entireGameControllerCollector.imperialSabreEquiped = false;

        itemStats.UpdatePaladinAttackItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinAttackItem();
    }

    public void OnClickImperialSabre()
    {
        informationTextCopper.enabled = false;
        informationTextIron.enabled = false;
        informationTextBronze.enabled = false;
        informationTextSilver.enabled = false;
        informationTextGold.enabled = false;
        informationTextAgapite.enabled = false;
        informationTextShadow.enabled = false;
        informationTextStronghold.enabled = false;
        informationTextVerminard.enabled = false;
        informationTextAdamantine.enabled = false;
        informationTextBlackrock.enabled = false;
        informationTextImperial.enabled = true;
    }
    public void OnClickEquipImperialSabre()
    {
        entireGameControllerCollector.copperSabreEquiped = false;
        entireGameControllerCollector.ironSabreEquiped = false;
        entireGameControllerCollector.bronzeSabreEquiped = false;
        entireGameControllerCollector.silverSabreEquiped = false;
        entireGameControllerCollector.goldSabreEquiped = false;
        entireGameControllerCollector.agapiteSabreEquiped = false;
        entireGameControllerCollector.shadowSabreEquiped = false;
        entireGameControllerCollector.strongholdSabreEquiped = false;
        entireGameControllerCollector.verminardSabreEquiped = false;
        entireGameControllerCollector.adamantineSabreEquiped = false;
        entireGameControllerCollector.blackrockSabreEquiped = false;
        entireGameControllerCollector.imperialSabreEquiped = true;

        itemStats.UpdatePaladinAttackItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinAttackItem();
    }



    /// //// ////
    //  Magic  //
    /// //// ////


    public void OnClickPaladinMagicItem()
    {
        if (entireGameControllerCollector.apprenticePaladinBookVol1Equiped) { informationTextApprenticePaladinBookVol1.enabled = true; }
        else if (entireGameControllerCollector.apprenticePaladinBookVol2Equiped) { informationTextApprenticePaladinBookVol2.enabled = true; }
        else if (entireGameControllerCollector.journeymanPaladinBookVol1Equiped) { informationTextJourneymanPaladinBookVol1.enabled = true; }
        else if (entireGameControllerCollector.journeymanPaladinBookVol2Equiped) { informationTextJourneymanPaladinBookVol2.enabled = true; }
        else if (entireGameControllerCollector.lostPaladinBookVol1Equiped) { informationTextLostPaladinBookVol1.enabled = true; }
        else if (entireGameControllerCollector.lostPaladinBookVol2Equiped) { informationTextLostPaladinBookVol2.enabled = true; }
        else if (entireGameControllerCollector.expertPaladinBookVol1Equiped) { informationTextExpertPaladinBookVol1.enabled = true; }
        else if (entireGameControllerCollector.grandmasterPaladinBookVol1Equiped) { informationTextGrandmasterPaladinBookVol1.enabled = true; }
        else if (entireGameControllerCollector.grandmasterPaladinBookVol2Equiped) { informationTextGrandmasterPaladinBookVol2.enabled = true; }
        else if (entireGameControllerCollector.imperialPaladinBookVol1Equiped) { informationTextImperialPaladinBookVol1.enabled = true; }

        paladinMagicItemCanvasGroup.blocksRaycasts = true;
        paladinMagicItemCanvas.enabled = true;
    }


    public void OnClickClosePaladinMagicItem()
    {
        informationTextApprenticePaladinBookVol1.enabled = false;
        informationTextApprenticePaladinBookVol2.enabled = false;
        informationTextJourneymanPaladinBookVol1.enabled = false;
        informationTextJourneymanPaladinBookVol2.enabled = false;
        informationTextLostPaladinBookVol1.enabled = false;
        informationTextLostPaladinBookVol2.enabled = false;
        informationTextExpertPaladinBookVol1.enabled = false;
        informationTextGrandmasterPaladinBookVol1.enabled = false;
        informationTextGrandmasterPaladinBookVol2.enabled = false;
        informationTextImperialPaladinBookVol1.enabled = false;


        paladinMagicItemCanvasGroup.blocksRaycasts = false;
        paladinMagicItemCanvas.enabled = false;
    }




    public void OnClickApprenticePaladinBookVol1()
    {
        informationTextApprenticePaladinBookVol1.enabled = true;
        informationTextApprenticePaladinBookVol2.enabled = false;
        informationTextJourneymanPaladinBookVol1.enabled = false;
        informationTextJourneymanPaladinBookVol2.enabled = false;
        informationTextLostPaladinBookVol1.enabled = false;
        informationTextLostPaladinBookVol2.enabled = false;
        informationTextExpertPaladinBookVol1.enabled = false;
        informationTextGrandmasterPaladinBookVol1.enabled = false;
        informationTextGrandmasterPaladinBookVol2.enabled = false;
        informationTextImperialPaladinBookVol1.enabled = false;
    }
    public void OnClickEquipApprenticePaladinBookVol1()
    {
        entireGameControllerCollector.apprenticePaladinBookVol1Equiped = true;
        entireGameControllerCollector.apprenticePaladinBookVol2Equiped = false;
        entireGameControllerCollector.journeymanPaladinBookVol1Equiped = false;
        entireGameControllerCollector.journeymanPaladinBookVol2Equiped = false;
        entireGameControllerCollector.lostPaladinBookVol1Equiped = false;
        entireGameControllerCollector.lostPaladinBookVol2Equiped = false;
        entireGameControllerCollector.expertPaladinBookVol1Equiped = false;
        entireGameControllerCollector.grandmasterPaladinBookVol1Equiped = false;
        entireGameControllerCollector.grandmasterPaladinBookVol2Equiped = false;
        entireGameControllerCollector.imperialPaladinBookVol1Equiped = false;

        itemStats.UpdatePaladinMagicItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinMagicItem();
    }

    public void OnClickApprenticePaladinBookVol2()
    {
        informationTextApprenticePaladinBookVol1.enabled = false;
        informationTextApprenticePaladinBookVol2.enabled = true;
        informationTextJourneymanPaladinBookVol1.enabled = false;
        informationTextJourneymanPaladinBookVol2.enabled = false;
        informationTextLostPaladinBookVol1.enabled = false;
        informationTextLostPaladinBookVol2.enabled = false;
        informationTextExpertPaladinBookVol1.enabled = false;
        informationTextGrandmasterPaladinBookVol1.enabled = false;
        informationTextGrandmasterPaladinBookVol2.enabled = false;
        informationTextImperialPaladinBookVol1.enabled = false;
    }
    public void OnClickEquipApprenticePaladinBookVol2()
    {
        entireGameControllerCollector.apprenticePaladinBookVol1Equiped = false;
        entireGameControllerCollector.apprenticePaladinBookVol2Equiped = true;
        entireGameControllerCollector.journeymanPaladinBookVol1Equiped = false;
        entireGameControllerCollector.journeymanPaladinBookVol2Equiped = false;
        entireGameControllerCollector.lostPaladinBookVol1Equiped = false;
        entireGameControllerCollector.lostPaladinBookVol2Equiped = false;
        entireGameControllerCollector.expertPaladinBookVol1Equiped = false;
        entireGameControllerCollector.grandmasterPaladinBookVol1Equiped = false;
        entireGameControllerCollector.grandmasterPaladinBookVol2Equiped = false;
        entireGameControllerCollector.imperialPaladinBookVol1Equiped = false;

        itemStats.UpdatePaladinMagicItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinMagicItem();
    }

    public void OnClickJourneymanPaladinBookVol1()
    {
        informationTextApprenticePaladinBookVol1.enabled = false;
        informationTextApprenticePaladinBookVol2.enabled = false;
        informationTextJourneymanPaladinBookVol1.enabled = true;
        informationTextJourneymanPaladinBookVol2.enabled = false;
        informationTextLostPaladinBookVol1.enabled = false;
        informationTextLostPaladinBookVol2.enabled = false;
        informationTextExpertPaladinBookVol1.enabled = false;
        informationTextGrandmasterPaladinBookVol1.enabled = false;
        informationTextGrandmasterPaladinBookVol2.enabled = false;
        informationTextImperialPaladinBookVol1.enabled = false;
    }
    public void OnClickEquipJourneymanPaladinBookVol1()
    {
        entireGameControllerCollector.apprenticePaladinBookVol1Equiped = false;
        entireGameControllerCollector.apprenticePaladinBookVol2Equiped = false;
        entireGameControllerCollector.journeymanPaladinBookVol1Equiped = true;
        entireGameControllerCollector.journeymanPaladinBookVol2Equiped = false;
        entireGameControllerCollector.lostPaladinBookVol1Equiped = false;
        entireGameControllerCollector.lostPaladinBookVol2Equiped = false;
        entireGameControllerCollector.expertPaladinBookVol1Equiped = false;
        entireGameControllerCollector.grandmasterPaladinBookVol1Equiped = false;
        entireGameControllerCollector.grandmasterPaladinBookVol2Equiped = false;
        entireGameControllerCollector.imperialPaladinBookVol1Equiped = false;

        itemStats.UpdatePaladinMagicItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinMagicItem();
    }

    public void OnClickJourneymanPaladinBookVol2()
    {
        informationTextApprenticePaladinBookVol1.enabled = false;
        informationTextApprenticePaladinBookVol2.enabled = false;
        informationTextJourneymanPaladinBookVol1.enabled = false;
        informationTextJourneymanPaladinBookVol2.enabled = true;
        informationTextLostPaladinBookVol1.enabled = false;
        informationTextLostPaladinBookVol2.enabled = false;
        informationTextExpertPaladinBookVol1.enabled = false;
        informationTextGrandmasterPaladinBookVol1.enabled = false;
        informationTextGrandmasterPaladinBookVol2.enabled = false;
        informationTextImperialPaladinBookVol1.enabled = false;
    }
    public void OnClickEquipJourneymanPaladinBookVol2()
    {
        entireGameControllerCollector.apprenticePaladinBookVol1Equiped = false;
        entireGameControllerCollector.apprenticePaladinBookVol2Equiped = false;
        entireGameControllerCollector.journeymanPaladinBookVol1Equiped = false;
        entireGameControllerCollector.journeymanPaladinBookVol2Equiped = true;
        entireGameControllerCollector.lostPaladinBookVol1Equiped = false;
        entireGameControllerCollector.lostPaladinBookVol2Equiped = false;
        entireGameControllerCollector.expertPaladinBookVol1Equiped = false;
        entireGameControllerCollector.grandmasterPaladinBookVol1Equiped = false;
        entireGameControllerCollector.grandmasterPaladinBookVol2Equiped = false;
        entireGameControllerCollector.imperialPaladinBookVol1Equiped = false;

        itemStats.UpdatePaladinMagicItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinMagicItem();
    }

    public void OnClickLostPaladinBookVol1()
    {
        informationTextApprenticePaladinBookVol1.enabled = false;
        informationTextApprenticePaladinBookVol2.enabled = false;
        informationTextJourneymanPaladinBookVol1.enabled = false;
        informationTextJourneymanPaladinBookVol2.enabled = false;
        informationTextLostPaladinBookVol1.enabled = true;
        informationTextLostPaladinBookVol2.enabled = false;
        informationTextExpertPaladinBookVol1.enabled = false;
        informationTextGrandmasterPaladinBookVol1.enabled = false;
        informationTextGrandmasterPaladinBookVol2.enabled = false;
        informationTextImperialPaladinBookVol1.enabled = false;
    }
    public void OnClickEquipLostPaladinBookVol1()
    {
        entireGameControllerCollector.apprenticePaladinBookVol1Equiped = false;
        entireGameControllerCollector.apprenticePaladinBookVol2Equiped = false;
        entireGameControllerCollector.journeymanPaladinBookVol1Equiped = false;
        entireGameControllerCollector.journeymanPaladinBookVol2Equiped = false;
        entireGameControllerCollector.lostPaladinBookVol1Equiped = true;
        entireGameControllerCollector.lostPaladinBookVol2Equiped = false;
        entireGameControllerCollector.expertPaladinBookVol1Equiped = false;
        entireGameControllerCollector.grandmasterPaladinBookVol1Equiped = false;
        entireGameControllerCollector.grandmasterPaladinBookVol2Equiped = false;
        entireGameControllerCollector.imperialPaladinBookVol1Equiped = false;

        itemStats.UpdatePaladinMagicItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinMagicItem();
    }

    public void OnClickLostPaladinBookVol2()
    {
        informationTextApprenticePaladinBookVol1.enabled = false;
        informationTextApprenticePaladinBookVol2.enabled = false;
        informationTextJourneymanPaladinBookVol1.enabled = false;
        informationTextJourneymanPaladinBookVol2.enabled = false;
        informationTextLostPaladinBookVol1.enabled = false;
        informationTextLostPaladinBookVol2.enabled = true;
        informationTextExpertPaladinBookVol1.enabled = false;
        informationTextGrandmasterPaladinBookVol1.enabled = false;
        informationTextGrandmasterPaladinBookVol2.enabled = false;
        informationTextImperialPaladinBookVol1.enabled = false;
    }
    public void OnClickEquipLostPaladinBookVol2()
    {
        entireGameControllerCollector.apprenticePaladinBookVol1Equiped = false;
        entireGameControllerCollector.apprenticePaladinBookVol2Equiped = false;
        entireGameControllerCollector.journeymanPaladinBookVol1Equiped = false;
        entireGameControllerCollector.journeymanPaladinBookVol2Equiped = false;
        entireGameControllerCollector.lostPaladinBookVol1Equiped = false;
        entireGameControllerCollector.lostPaladinBookVol2Equiped = true;
        entireGameControllerCollector.expertPaladinBookVol1Equiped = false;
        entireGameControllerCollector.grandmasterPaladinBookVol1Equiped = false;
        entireGameControllerCollector.grandmasterPaladinBookVol2Equiped = false;
        entireGameControllerCollector.imperialPaladinBookVol1Equiped = false;

        itemStats.UpdatePaladinMagicItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinMagicItem();
    }

    public void OnClickExpertPaladinBookVol1()
    {
        informationTextApprenticePaladinBookVol1.enabled = false;
        informationTextApprenticePaladinBookVol2.enabled = false;
        informationTextJourneymanPaladinBookVol1.enabled = false;
        informationTextJourneymanPaladinBookVol2.enabled = false;
        informationTextLostPaladinBookVol1.enabled = false;
        informationTextLostPaladinBookVol2.enabled = false;
        informationTextExpertPaladinBookVol1.enabled = true;
        informationTextGrandmasterPaladinBookVol1.enabled = false;
        informationTextGrandmasterPaladinBookVol2.enabled = false;
        informationTextImperialPaladinBookVol1.enabled = false;
    }
    public void OnClickEquipExpertPaladinBookVol1()
    {
        entireGameControllerCollector.apprenticePaladinBookVol1Equiped = false;
        entireGameControllerCollector.apprenticePaladinBookVol2Equiped = false;
        entireGameControllerCollector.journeymanPaladinBookVol1Equiped = false;
        entireGameControllerCollector.journeymanPaladinBookVol2Equiped = false;
        entireGameControllerCollector.lostPaladinBookVol1Equiped = false;
        entireGameControllerCollector.lostPaladinBookVol2Equiped = false;
        entireGameControllerCollector.expertPaladinBookVol1Equiped = true;
        entireGameControllerCollector.grandmasterPaladinBookVol1Equiped = false;
        entireGameControllerCollector.grandmasterPaladinBookVol2Equiped = false;
        entireGameControllerCollector.imperialPaladinBookVol1Equiped = false;

        itemStats.UpdatePaladinMagicItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinMagicItem();
    }

    public void OnClickGrandmasterPaladinBookVol1()
    {
        informationTextApprenticePaladinBookVol1.enabled = false;
        informationTextApprenticePaladinBookVol2.enabled = false;
        informationTextJourneymanPaladinBookVol1.enabled = false;
        informationTextJourneymanPaladinBookVol2.enabled = false;
        informationTextLostPaladinBookVol1.enabled = false;
        informationTextLostPaladinBookVol2.enabled = false;
        informationTextExpertPaladinBookVol1.enabled = false;
        informationTextGrandmasterPaladinBookVol1.enabled = true;
        informationTextGrandmasterPaladinBookVol2.enabled = false;
        informationTextImperialPaladinBookVol1.enabled = false;
    }
    public void OnClickEquipGrandmasterPaladinBookVol1()
    {
        entireGameControllerCollector.apprenticePaladinBookVol1Equiped = false;
        entireGameControllerCollector.apprenticePaladinBookVol2Equiped = false;
        entireGameControllerCollector.journeymanPaladinBookVol1Equiped = false;
        entireGameControllerCollector.journeymanPaladinBookVol2Equiped = false;
        entireGameControllerCollector.lostPaladinBookVol1Equiped = false;
        entireGameControllerCollector.lostPaladinBookVol2Equiped = false;
        entireGameControllerCollector.expertPaladinBookVol1Equiped = false;
        entireGameControllerCollector.grandmasterPaladinBookVol1Equiped = true;
        entireGameControllerCollector.grandmasterPaladinBookVol2Equiped = false;
        entireGameControllerCollector.imperialPaladinBookVol1Equiped = false;

        itemStats.UpdatePaladinMagicItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinMagicItem();
    }

    public void OnClickGrandmasterPaladinBookVol2()
    {
        informationTextApprenticePaladinBookVol1.enabled = false;
        informationTextApprenticePaladinBookVol2.enabled = false;
        informationTextJourneymanPaladinBookVol1.enabled = false;
        informationTextJourneymanPaladinBookVol2.enabled = false;
        informationTextLostPaladinBookVol1.enabled = false;
        informationTextLostPaladinBookVol2.enabled = false;
        informationTextExpertPaladinBookVol1.enabled = false;
        informationTextGrandmasterPaladinBookVol1.enabled = false;
        informationTextGrandmasterPaladinBookVol2.enabled = true;
        informationTextImperialPaladinBookVol1.enabled = false;
    }
    public void OnClickEquipGrandmasterPaladinBookVol2()
    {
        entireGameControllerCollector.apprenticePaladinBookVol1Equiped = false;
        entireGameControllerCollector.apprenticePaladinBookVol2Equiped = false;
        entireGameControllerCollector.journeymanPaladinBookVol1Equiped = false;
        entireGameControllerCollector.journeymanPaladinBookVol2Equiped = false;
        entireGameControllerCollector.lostPaladinBookVol1Equiped = false;
        entireGameControllerCollector.lostPaladinBookVol2Equiped = false;
        entireGameControllerCollector.expertPaladinBookVol1Equiped = false;
        entireGameControllerCollector.grandmasterPaladinBookVol1Equiped = false;
        entireGameControllerCollector.grandmasterPaladinBookVol2Equiped = true;
        entireGameControllerCollector.imperialPaladinBookVol1Equiped = false;

        itemStats.UpdatePaladinMagicItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinMagicItem();
    }

    public void OnClickImperialPaladinBookVol1()
    {
        informationTextApprenticePaladinBookVol1.enabled = false;
        informationTextApprenticePaladinBookVol2.enabled = false;
        informationTextJourneymanPaladinBookVol1.enabled = false;
        informationTextJourneymanPaladinBookVol2.enabled = false;
        informationTextLostPaladinBookVol1.enabled = false;
        informationTextLostPaladinBookVol2.enabled = false;
        informationTextExpertPaladinBookVol1.enabled = false;
        informationTextGrandmasterPaladinBookVol1.enabled = false;
        informationTextGrandmasterPaladinBookVol2.enabled = false;
        informationTextImperialPaladinBookVol1.enabled = true;
    }
    public void OnClickEquipImperialPaladinBookVol1()
    {
        entireGameControllerCollector.apprenticePaladinBookVol1Equiped = false;
        entireGameControllerCollector.apprenticePaladinBookVol2Equiped = false;
        entireGameControllerCollector.journeymanPaladinBookVol1Equiped = false;
        entireGameControllerCollector.journeymanPaladinBookVol2Equiped = false;
        entireGameControllerCollector.lostPaladinBookVol1Equiped = false;
        entireGameControllerCollector.lostPaladinBookVol2Equiped = false;
        entireGameControllerCollector.expertPaladinBookVol1Equiped = false;
        entireGameControllerCollector.grandmasterPaladinBookVol1Equiped = false;
        entireGameControllerCollector.grandmasterPaladinBookVol2Equiped = false;
        entireGameControllerCollector.imperialPaladinBookVol1Equiped = true;

        itemStats.UpdatePaladinMagicItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinMagicItem();
    }
    




    /// //// ////
    //  Speed  //
    /// //// ////


    public void OnClickPaladinSpeedItem()
    {
        if (entireGameControllerCollector.rustyCombatBootsEquiped) { informationTextRustyCombatBoots.enabled = true; }
        else if (entireGameControllerCollector.poorCombatBootsEquiped) { informationTextPoorCombatBoots.enabled = true; }
        else if (entireGameControllerCollector.fineCombatBootsEquiped) { informationTextFineCombatBoots.enabled = true; }
        else if (entireGameControllerCollector.decentCombatBootsEquiped) { informationTextDecentCombatBoots.enabled = true; }
        else if (entireGameControllerCollector.excellentCombatBootsEquiped) { informationTextExcellentCombatBoots.enabled = true; }
        else if (entireGameControllerCollector.imperialCombatBootsEquiped) { informationTextImperialCombatBoots.enabled = true; }

        paladinSpeedItemCanvasGroup.blocksRaycasts = true;
        paladinSpeedItemCanvas.enabled = true;
    }


    public void OnClickClosePaladinSpeedItem()
    {
        informationTextRustyCombatBoots.enabled = false;
        informationTextPoorCombatBoots.enabled = false;
        informationTextFineCombatBoots.enabled = false;
        informationTextDecentCombatBoots.enabled = false;
        informationTextExcellentCombatBoots.enabled = false;
        informationTextImperialCombatBoots.enabled = false;

        paladinSpeedItemCanvasGroup.blocksRaycasts = false;
        paladinSpeedItemCanvas.enabled = false;
    }


    public void OnClickRustyCombatBoots()
    {
        informationTextRustyCombatBoots.enabled = true;
        informationTextPoorCombatBoots.enabled = false;
        informationTextFineCombatBoots.enabled = false;
        informationTextDecentCombatBoots.enabled = false;
        informationTextExcellentCombatBoots.enabled = false;
        informationTextImperialCombatBoots.enabled = false;
    }
    public void OnClickEquipRustyCombatBoots()
    {
        entireGameControllerCollector.rustyCombatBootsEquiped = true;
        entireGameControllerCollector.poorCombatBootsEquiped = false;
        entireGameControllerCollector.fineCombatBootsEquiped = false;
        entireGameControllerCollector.decentCombatBootsEquiped = false;
        entireGameControllerCollector.excellentCombatBootsEquiped = false;
        entireGameControllerCollector.imperialCombatBootsEquiped = false;

        itemStats.UpdatePaladinSpeedItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinSpeedItem();
    }

    public void OnClickPoorCombatBoots()
    {
        informationTextRustyCombatBoots.enabled = false;
        informationTextPoorCombatBoots.enabled = true;
        informationTextFineCombatBoots.enabled = false;
        informationTextDecentCombatBoots.enabled = false;
        informationTextExcellentCombatBoots.enabled = false;
        informationTextImperialCombatBoots.enabled = false;
    }
    public void OnClickEquipPoorCombatBoots()
    {
        entireGameControllerCollector.rustyCombatBootsEquiped = false;
        entireGameControllerCollector.poorCombatBootsEquiped = true;
        entireGameControllerCollector.fineCombatBootsEquiped = false;
        entireGameControllerCollector.decentCombatBootsEquiped = false;
        entireGameControllerCollector.excellentCombatBootsEquiped = false;
        entireGameControllerCollector.imperialCombatBootsEquiped = false;

        itemStats.UpdatePaladinSpeedItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinSpeedItem();
    }

    public void OnClickFineCombatBoots()
    {
        informationTextRustyCombatBoots.enabled = false;
        informationTextPoorCombatBoots.enabled = false;
        informationTextFineCombatBoots.enabled = true;
        informationTextDecentCombatBoots.enabled = false;
        informationTextExcellentCombatBoots.enabled = false;
        informationTextImperialCombatBoots.enabled = false;
    }
    public void OnClickEquipFineCombatBoots()
    {
        entireGameControllerCollector.rustyCombatBootsEquiped = false;
        entireGameControllerCollector.poorCombatBootsEquiped = false;
        entireGameControllerCollector.fineCombatBootsEquiped = true;
        entireGameControllerCollector.decentCombatBootsEquiped = false;
        entireGameControllerCollector.excellentCombatBootsEquiped = false;
        entireGameControllerCollector.imperialCombatBootsEquiped = false;

        itemStats.UpdatePaladinSpeedItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinSpeedItem();
    }

    public void OnClickDecentCombatBoots()
    {
        informationTextRustyCombatBoots.enabled = false;
        informationTextPoorCombatBoots.enabled = false;
        informationTextFineCombatBoots.enabled = false;
        informationTextDecentCombatBoots.enabled = true;
        informationTextExcellentCombatBoots.enabled = false;
        informationTextImperialCombatBoots.enabled = false;
    }
    public void OnClickEquipDecentCombatBoots()
    {
        entireGameControllerCollector.rustyCombatBootsEquiped = false;
        entireGameControllerCollector.poorCombatBootsEquiped = false;
        entireGameControllerCollector.fineCombatBootsEquiped = false;
        entireGameControllerCollector.decentCombatBootsEquiped = true;
        entireGameControllerCollector.excellentCombatBootsEquiped = false;
        entireGameControllerCollector.imperialCombatBootsEquiped = false;

        itemStats.UpdatePaladinSpeedItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinSpeedItem();
    }

    public void OnClickExcellentCombatBoots()
    {
        informationTextRustyCombatBoots.enabled = false;
        informationTextPoorCombatBoots.enabled = false;
        informationTextFineCombatBoots.enabled = false;
        informationTextDecentCombatBoots.enabled = false;
        informationTextExcellentCombatBoots.enabled = true;
        informationTextImperialCombatBoots.enabled = false;
    }
    public void OnClickEquipExcellentCombatBoots()
    {
        entireGameControllerCollector.rustyCombatBootsEquiped = false;
        entireGameControllerCollector.poorCombatBootsEquiped = false;
        entireGameControllerCollector.fineCombatBootsEquiped = false;
        entireGameControllerCollector.decentCombatBootsEquiped = false;
        entireGameControllerCollector.excellentCombatBootsEquiped = true;
        entireGameControllerCollector.imperialCombatBootsEquiped = false;

        itemStats.UpdatePaladinSpeedItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinSpeedItem();
    }

    public void OnClickImperialCombatBoots()
    {
        informationTextRustyCombatBoots.enabled = false;
        informationTextPoorCombatBoots.enabled = false;
        informationTextFineCombatBoots.enabled = false;
        informationTextDecentCombatBoots.enabled = false;
        informationTextExcellentCombatBoots.enabled = false;
        informationTextImperialCombatBoots.enabled = true;
    }
    public void OnClickEquipImperialCombatBoots()
    {
        entireGameControllerCollector.rustyCombatBootsEquiped = false;
        entireGameControllerCollector.poorCombatBootsEquiped = false;
        entireGameControllerCollector.fineCombatBootsEquiped = false;
        entireGameControllerCollector.decentCombatBootsEquiped = false;
        entireGameControllerCollector.excellentCombatBootsEquiped = false;
        entireGameControllerCollector.imperialCombatBootsEquiped = true;

        itemStats.UpdatePaladinSpeedItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinSpeedItem();
    }






    /// ////// ////
    //  Defense  //
    /// ////// ////


    public void OnClickPaladinDefenseItem()
    {
        if (entireGameControllerCollector.rustyPlatemailArmorEquiped) { informationTextRustyPlatemailArmor.enabled = true; }
        else if (entireGameControllerCollector.poorPlatemailArmorEquiped) { informationTextPoorPlatemailArmor.enabled = true; }
        else if (entireGameControllerCollector.finePlatemailArmorEquiped) { informationTextFinePlatemailArmor.enabled = true; }
        else if (entireGameControllerCollector.decentPlatemailArmorEquiped) { informationTextDecentPlatemailArmor.enabled = true; }
        else if (entireGameControllerCollector.excellentPlatemailArmorEquiped) { informationTextExcellentPlatemailArmor.enabled = true; }
        else if (entireGameControllerCollector.imperialPlatemailArmorEquiped) { informationTextImperialPlatemailArmor.enabled = true; }

        paladinDefenseItemCanvasGroup.blocksRaycasts = true;
        paladinDefenseItemCanvas.enabled = true;
    }


    public void OnClickClosePaladinDefenseItem()
    {
        informationTextRustyPlatemailArmor.enabled = false;
        informationTextPoorPlatemailArmor.enabled = false;
        informationTextFinePlatemailArmor.enabled = false;
        informationTextDecentPlatemailArmor.enabled = false;
        informationTextExcellentPlatemailArmor.enabled = false;
        informationTextImperialPlatemailArmor.enabled = false;

        paladinDefenseItemCanvasGroup.blocksRaycasts = false;
        paladinDefenseItemCanvas.enabled = false;
    }


    public void OnClickRustyPlatemailArmor()
    {
        informationTextRustyPlatemailArmor.enabled = true;
        informationTextPoorPlatemailArmor.enabled = false;
        informationTextFinePlatemailArmor.enabled = false;
        informationTextDecentPlatemailArmor.enabled = false;
        informationTextExcellentPlatemailArmor.enabled = false;
        informationTextImperialPlatemailArmor.enabled = false;
    }
    public void OnClickEquipRustyPlatemailArmor()
    {
        entireGameControllerCollector.rustyPlatemailArmorEquiped = true;
        entireGameControllerCollector.poorPlatemailArmorEquiped = false;
        entireGameControllerCollector.finePlatemailArmorEquiped = false;
        entireGameControllerCollector.decentPlatemailArmorEquiped = false;
        entireGameControllerCollector.excellentPlatemailArmorEquiped = false;
        entireGameControllerCollector.imperialPlatemailArmorEquiped = false;

        itemStats.UpdatePaladinDefenseItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinDefenseItem();
    }

    public void OnClickPoorPlatemailArmor()
    {
        informationTextRustyPlatemailArmor.enabled = false;
        informationTextPoorPlatemailArmor.enabled = true;
        informationTextFinePlatemailArmor.enabled = false;
        informationTextDecentPlatemailArmor.enabled = false;
        informationTextExcellentPlatemailArmor.enabled = false;
        informationTextImperialPlatemailArmor.enabled = false;
    }
    public void OnClickEquipPoorPlatemailArmor()
    {
        entireGameControllerCollector.rustyPlatemailArmorEquiped = false;
        entireGameControllerCollector.poorPlatemailArmorEquiped = true;
        entireGameControllerCollector.finePlatemailArmorEquiped = false;
        entireGameControllerCollector.decentPlatemailArmorEquiped = false;
        entireGameControllerCollector.excellentPlatemailArmorEquiped = false;
        entireGameControllerCollector.imperialPlatemailArmorEquiped = false;

        itemStats.UpdatePaladinDefenseItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinDefenseItem();
    }

    public void OnClickFinePlatemailArmor()
    {
        informationTextRustyPlatemailArmor.enabled = false;
        informationTextPoorPlatemailArmor.enabled = false;
        informationTextFinePlatemailArmor.enabled = true;
        informationTextDecentPlatemailArmor.enabled = false;
        informationTextExcellentPlatemailArmor.enabled = false;
        informationTextImperialPlatemailArmor.enabled = false;
    }
    public void OnClickEquipFinePlatemailArmor()
    {
        entireGameControllerCollector.rustyPlatemailArmorEquiped = false;
        entireGameControllerCollector.poorPlatemailArmorEquiped = false;
        entireGameControllerCollector.finePlatemailArmorEquiped = true;
        entireGameControllerCollector.decentPlatemailArmorEquiped = false;
        entireGameControllerCollector.excellentPlatemailArmorEquiped = false;
        entireGameControllerCollector.imperialPlatemailArmorEquiped = false;

        itemStats.UpdatePaladinDefenseItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinDefenseItem();
    }

    public void OnClickDecentPlatemailArmor()
    {
        informationTextRustyPlatemailArmor.enabled = false;
        informationTextPoorPlatemailArmor.enabled = false;
        informationTextFinePlatemailArmor.enabled = false;
        informationTextDecentPlatemailArmor.enabled = true;
        informationTextExcellentPlatemailArmor.enabled = false;
        informationTextImperialPlatemailArmor.enabled = false;
    }
    public void OnClickEquipDecentPlatemailArmor()
    {
        entireGameControllerCollector.rustyPlatemailArmorEquiped = false;
        entireGameControllerCollector.poorPlatemailArmorEquiped = false;
        entireGameControllerCollector.finePlatemailArmorEquiped = false;
        entireGameControllerCollector.decentPlatemailArmorEquiped = true;
        entireGameControllerCollector.excellentPlatemailArmorEquiped = false;
        entireGameControllerCollector.imperialPlatemailArmorEquiped = false;

        itemStats.UpdatePaladinDefenseItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinDefenseItem();
    }

    public void OnClickExcellentPlatemailArmor()
    {
        informationTextRustyPlatemailArmor.enabled = false;
        informationTextPoorPlatemailArmor.enabled = false;
        informationTextFinePlatemailArmor.enabled = false;
        informationTextDecentPlatemailArmor.enabled = false;
        informationTextExcellentPlatemailArmor.enabled = true;
        informationTextImperialPlatemailArmor.enabled = false;
    }
    public void OnClickEquipExcellentPlatemailArmor()
    {
        entireGameControllerCollector.rustyPlatemailArmorEquiped = false;
        entireGameControllerCollector.poorPlatemailArmorEquiped = false;
        entireGameControllerCollector.finePlatemailArmorEquiped = false;
        entireGameControllerCollector.decentPlatemailArmorEquiped = false;
        entireGameControllerCollector.excellentPlatemailArmorEquiped = true;
        entireGameControllerCollector.imperialPlatemailArmorEquiped = false;

        itemStats.UpdatePaladinDefenseItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinDefenseItem();
    }

    public void OnClickImperialPlatemailArmor()
    {
        informationTextRustyPlatemailArmor.enabled = false;
        informationTextPoorPlatemailArmor.enabled = false;
        informationTextFinePlatemailArmor.enabled = false;
        informationTextDecentPlatemailArmor.enabled = false;
        informationTextExcellentPlatemailArmor.enabled = false;
        informationTextImperialPlatemailArmor.enabled = true;
    }
    public void OnClickEquipImperialPlatemailArmor()
    {
        entireGameControllerCollector.rustyPlatemailArmorEquiped = false;
        entireGameControllerCollector.poorPlatemailArmorEquiped = false;
        entireGameControllerCollector.finePlatemailArmorEquiped = false;
        entireGameControllerCollector.decentPlatemailArmorEquiped = false;
        entireGameControllerCollector.excellentPlatemailArmorEquiped = false;
        entireGameControllerCollector.imperialPlatemailArmorEquiped = true;

        itemStats.UpdatePaladinDefenseItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinDefenseItem();
    }




    /// ///////////// ////
    //  Magic Defense  //
    /// //////////// ////


    public void OnClickPaladinMagicDefenseItem()
    {
        if (entireGameControllerCollector.amberTiaraEquiped) { informationTextAmberTiara.enabled = true; }
        else if (entireGameControllerCollector.rubyTiaraEquiped) { informationTextRubyTiara.enabled = true; }
        else if (entireGameControllerCollector.emeraldTiaraEquiped) { informationTextEmeraldTiara.enabled = true; }
        else if (entireGameControllerCollector.diamondTiaraEquiped) { informationTextDiamondTiara.enabled = true; }
        else if (entireGameControllerCollector.citrineTiaraEquiped) { informationTextCitrineTiara.enabled = true; }
        else if (entireGameControllerCollector.imperialStarSapphireTiaraEquiped) { informationTextImperialStarSapphireTiara.enabled = true; }

        paladinMagicDefenseItemCanvasGroup.blocksRaycasts = true;
        paladinMagicDefenseItemCanvas.enabled = true;
    }


    public void OnClickClosePaladinMagicDefenseItem()
    {
        informationTextAmberTiara.enabled = false;
        informationTextRubyTiara.enabled = false;
        informationTextEmeraldTiara.enabled = false;
        informationTextDiamondTiara.enabled = false;
        informationTextCitrineTiara.enabled = false;
        informationTextImperialStarSapphireTiara.enabled = false;

        paladinMagicDefenseItemCanvasGroup.blocksRaycasts = false;
        paladinMagicDefenseItemCanvas.enabled = false;
    }


    public void OnClickAmberTiara()
    {
        informationTextAmberTiara.enabled = true;
        informationTextRubyTiara.enabled = false;
        informationTextEmeraldTiara.enabled = false;
        informationTextDiamondTiara.enabled = false;
        informationTextCitrineTiara.enabled = false;
        informationTextImperialStarSapphireTiara.enabled = false;
    }
    public void OnClickEquipAmberTiara()
    {
        entireGameControllerCollector.amberTiaraEquiped = true;
        entireGameControllerCollector.rubyTiaraEquiped = false;
        entireGameControllerCollector.emeraldTiaraEquiped = false;
        entireGameControllerCollector.diamondTiaraEquiped = false;
        entireGameControllerCollector.citrineTiaraEquiped = false;
        entireGameControllerCollector.imperialStarSapphireTiaraEquiped = false;

        itemStats.UpdatePaladinMagicDefenseItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinMagicDefenseItem();
    }

    public void OnClickRubyTiara()
    {
        informationTextAmberTiara.enabled = false;
        informationTextRubyTiara.enabled = true;
        informationTextEmeraldTiara.enabled = false;
        informationTextDiamondTiara.enabled = false;
        informationTextCitrineTiara.enabled = false;
        informationTextImperialStarSapphireTiara.enabled = false;
    }
    public void OnClickEquipRubyTiara()
    {
        entireGameControllerCollector.amberTiaraEquiped = false;
        entireGameControllerCollector.rubyTiaraEquiped = true;
        entireGameControllerCollector.emeraldTiaraEquiped = false;
        entireGameControllerCollector.diamondTiaraEquiped = false;
        entireGameControllerCollector.citrineTiaraEquiped = false;
        entireGameControllerCollector.imperialStarSapphireTiaraEquiped = false;

        itemStats.UpdatePaladinMagicDefenseItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinMagicDefenseItem();
    }

    public void OnClickEmeraldTiara()
    {
        informationTextAmberTiara.enabled = false;
        informationTextRubyTiara.enabled = false;
        informationTextEmeraldTiara.enabled = true;
        informationTextDiamondTiara.enabled = false;
        informationTextCitrineTiara.enabled = false;
        informationTextImperialStarSapphireTiara.enabled = false;
    }
    public void OnClickEquipEmeraldTiara()
    {
        entireGameControllerCollector.amberTiaraEquiped = false;
        entireGameControllerCollector.rubyTiaraEquiped = false;
        entireGameControllerCollector.emeraldTiaraEquiped = true;
        entireGameControllerCollector.diamondTiaraEquiped = false;
        entireGameControllerCollector.citrineTiaraEquiped = false;
        entireGameControllerCollector.imperialStarSapphireTiaraEquiped = false;

        itemStats.UpdatePaladinMagicDefenseItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinMagicDefenseItem();
    }

    public void OnClickDiamondTiara()
    {
        informationTextAmberTiara.enabled = false;
        informationTextRubyTiara.enabled = false;
        informationTextEmeraldTiara.enabled = false;
        informationTextDiamondTiara.enabled = true;
        informationTextCitrineTiara.enabled = false;
        informationTextImperialStarSapphireTiara.enabled = false;
    }
    public void OnClickEquipDiamondTiara()
    {
        entireGameControllerCollector.amberTiaraEquiped = false;
        entireGameControllerCollector.rubyTiaraEquiped = false;
        entireGameControllerCollector.emeraldTiaraEquiped = false;
        entireGameControllerCollector.diamondTiaraEquiped = true;
        entireGameControllerCollector.citrineTiaraEquiped = false;
        entireGameControllerCollector.imperialStarSapphireTiaraEquiped = false;

        itemStats.UpdatePaladinMagicDefenseItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinMagicDefenseItem();
    }

    public void OnClickCitrineTiara()
    {
        informationTextAmberTiara.enabled = false;
        informationTextRubyTiara.enabled = false;
        informationTextEmeraldTiara.enabled = false;
        informationTextDiamondTiara.enabled = false;
        informationTextCitrineTiara.enabled = true;
        informationTextImperialStarSapphireTiara.enabled = false;
    }
    public void OnClickEquipCitrineTiara()
    {
        entireGameControllerCollector.amberTiaraEquiped = false;
        entireGameControllerCollector.rubyTiaraEquiped = false;
        entireGameControllerCollector.emeraldTiaraEquiped = false;
        entireGameControllerCollector.diamondTiaraEquiped = false;
        entireGameControllerCollector.citrineTiaraEquiped = true;
        entireGameControllerCollector.imperialStarSapphireTiaraEquiped = false;

        itemStats.UpdatePaladinMagicDefenseItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinMagicDefenseItem();
    }

    public void OnClickImperialStarSapphireTiara()
    {
        informationTextAmberTiara.enabled = false;
        informationTextRubyTiara.enabled = false;
        informationTextEmeraldTiara.enabled = false;
        informationTextDiamondTiara.enabled = false;
        informationTextCitrineTiara.enabled = false;
        informationTextImperialStarSapphireTiara.enabled = true;
    }
    public void OnClickEquipImperialStarSapphireTiara()
    {
        entireGameControllerCollector.amberTiaraEquiped = false;
        entireGameControllerCollector.rubyTiaraEquiped = false;
        entireGameControllerCollector.emeraldTiaraEquiped = false;
        entireGameControllerCollector.diamondTiaraEquiped = false;
        entireGameControllerCollector.citrineTiaraEquiped = false;
        entireGameControllerCollector.imperialStarSapphireTiaraEquiped = true;

        itemStats.UpdatePaladinMagicDefenseItems();
        UpdatePlayerText();
        entireGameControllerCollector.SaveGameToMain();

        OnClickClosePaladinMagicDefenseItem();
    }

}


