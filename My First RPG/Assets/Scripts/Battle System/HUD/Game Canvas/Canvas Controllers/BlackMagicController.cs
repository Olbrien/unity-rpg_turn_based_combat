using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlackMagicController : MonoBehaviour
{

    public Paladin paladin;
    public Wizard wizard;

    public SpellController spellController;
    public Canvas blackMagicSpellInformationCanvas;
    public TextMeshProUGUI blackMagicSpellInformation;

    public FindAllSelectArrow findAllSelectArrow;
    public ClickController clickController;
    public AllClickTarget allClickTarget;
    public GameController gameController;

    public TurnPointsList turnPointsList;
    public TurnPointsController turnPointsController;

    public Canvas turnPointsToSpendCanvas;
    public TextMeshProUGUI turnPointsToSpendTxt;

    public Canvas spaceCanvasActionBlackMagic;
    public Canvas spaceCanvasActionBlackMagicArrow;
    public Canvas cancelBlackMagicButtonGO;
    public Canvas cancelBlackMagicSpellButtonGO;

    public Canvas blackMagicCanvasIce;
    public Canvas blackMagicCanvasFreeze;

    public Canvas infoTab;
    public Canvas blackMagicTab;

    public GameObject offensiveTabGO;
    public GameObject effectsTabGO;

    public Canvas offensiveTabCanvas;
    public Canvas effectsTabCanvas;

    public Canvas buffsAndDebuffsPaladin;
    public Canvas buffsAndDebuffsWizard;

    public Canvas offensiveArrows;
    public Canvas effectsArrows;

    public Canvas wizardPointerGO;

    public ActionButtonArrow scriptActionArrows;
    public ActionButtonArrow scriptBlackMagicOffensiveArrows;
    public ActionButtonArrow scriptBlackMagicEffectsArrows;



    bool onOffensiveTab;
    bool onEffectsTab;
    bool usingSpell;



    [Header("Spells")]

    public bool iceOne;
    public bool iceTwo;
    public bool iceThree;

    public bool iceFour;
    public bool iceFive;
    public bool iceSix;

    public bool fireOne;
    public bool fireTwo;
    public bool fireThree;

    public bool fireFour;
    public bool fireFive;
    public bool fireSix;

    public bool waterOne;
    public bool waterTwo;
    public bool waterThree;

    public bool waterFour;
    public bool waterFive;
    public bool waterSix;


    public bool freezeOne;
    public bool freezeTwo;
    public bool freezeThree;

    public bool burnOne;
    public bool burnTwo;
    public bool burnThree;

    public bool silenceOne;
    public bool silenceTwo;
    public bool silenceThree;

    public bool blindOne;
    public bool blindTwo;
    public bool blindThree;




    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void OnClickBlackMagic()
    {
        scriptBlackMagicOffensiveArrows.ResetThisButton();

        cancelBlackMagicButtonGO.enabled = true;

        offensiveTabCanvas.enabled = true;
        effectsTabCanvas.enabled = true;

        infoTab.enabled = false;
        blackMagicTab.enabled = true;

        onOffensiveTab = true;

        var offensiveTabRect = offensiveTabGO.GetComponent<RectTransform>();
        offensiveTabRect.localPosition = new Vector3(offensiveTabRect.localPosition.x, -112, offensiveTabRect.localPosition.z);

        var effectsTabRect = effectsTabGO.GetComponent<RectTransform>();
        effectsTabRect.localPosition = new Vector3(effectsTabRect.localPosition.x, -116, effectsTabRect.localPosition.z);

        buffsAndDebuffsPaladin.enabled = false;
        buffsAndDebuffsWizard.enabled = false;
    }

    public void OnCancelBlackMagic()
    {
        scriptActionArrows.ResetThisButton();

        cancelBlackMagicButtonGO.enabled = false;

        spaceCanvasActionBlackMagic.enabled = true;
        spaceCanvasActionBlackMagicArrow.enabled = true;

        infoTab.enabled = true;
        blackMagicTab.enabled = false;

        buffsAndDebuffsPaladin.enabled = true;
        buffsAndDebuffsWizard.enabled =true;

        offensiveTabCanvas.enabled = false;
        effectsTabCanvas.enabled = false;

        onOffensiveTab = false;
        onEffectsTab = false;

        clickController.wizardIsUsingBlackMagic = false;
    }



    public void OnCancelBlackMagicSpell()
    {
        offensiveTabCanvas.enabled = true;
        effectsTabCanvas.enabled = true;

        usingSpell = false;

        cancelBlackMagicSpellButtonGO.enabled = false;
        cancelBlackMagicButtonGO.enabled = true;

        blackMagicCanvasIce.enabled = true;

        infoTab.enabled = false;
        blackMagicTab.enabled = true;

        buffsAndDebuffsPaladin.enabled = false;
        buffsAndDebuffsWizard.enabled = false;

        if (onOffensiveTab)
        {
            scriptBlackMagicOffensiveArrows.ResetThisButton();
        }

        else if (onEffectsTab)
        {
            scriptBlackMagicEffectsArrows.ResetThisButton();
        }


        turnPointsToSpendCanvas.enabled = false;

        findAllSelectArrow.SelectOnlyPaladinArrowFalse();
        findAllSelectArrow.SelectOnlyWizardArrowFalse();
        findAllSelectArrow.SelectOnlyEnemyArrowFalse();

        allClickTarget.AllClicksPaladinDisabled();
        allClickTarget.AllClicksWizardDisabled();
        allClickTarget.AllClicksEnemiesDisabled();

        TurnAllSpellsFalse();
    }




    /// ////////////////////////////////////////////////////////////////////
    /// ////////////////////////////////////////////////////////////////////
    /// ////////////////////////////////////////////////////////////////////

    public void OnClickIceOne() { iceOne = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.iceOneTP);
                                  blackMagicSpellInformationCanvas.enabled = true;
                                  blackMagicSpellInformation.text = spellController.iceOneInformation; }
    public void OnClickIceTwo() { iceTwo = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.iceTwoTP);
                                  blackMagicSpellInformationCanvas.enabled = true;
                                  blackMagicSpellInformation.text = spellController.iceTwoInformation; }
    public void OnClickIceThree() { iceThree = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.iceThreeTP);
                                    blackMagicSpellInformationCanvas.enabled = true;
                                    blackMagicSpellInformation.text = spellController.iceThreeInformation; }

    public void OnClickIceFour() { iceFour = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.iceFourTP);
                                   blackMagicSpellInformationCanvas.enabled = true;
                                   blackMagicSpellInformation.text = spellController.iceFourInformation; }
    public void OnClickIceFive() { iceFive = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.iceFiveTP);
                                   blackMagicSpellInformationCanvas.enabled = true;
                                   blackMagicSpellInformation.text = spellController.iceFiveInformation; }
    public void OnClickIceSix() { iceSix = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.iceSixTP);
                                  blackMagicSpellInformationCanvas.enabled = true;
                                  blackMagicSpellInformation.text = spellController.iceSixInformation; }

    public void OnClickFireOne() { fireOne = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.fireOneTP);
                                   blackMagicSpellInformationCanvas.enabled = true;
                                   blackMagicSpellInformation.text = spellController.fireOneInformation; }
    public void OnClickFireTwo() { fireTwo = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.fireTwoTP);
                                   blackMagicSpellInformationCanvas.enabled = true;
                                   blackMagicSpellInformation.text = spellController.fireTwoInformation; }
    public void OnClickFireThree() { fireThree = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.fireThreeTP);
                                     blackMagicSpellInformationCanvas.enabled = true;
                                     blackMagicSpellInformation.text = spellController.fireThreeInformation; }

    public void OnClickFireFour() { fireFour = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.fireFourTP);
                                    blackMagicSpellInformationCanvas.enabled = true;
                                    blackMagicSpellInformation.text = spellController.fireFourInformation; }
    public void OnClickFireFive() { fireFive = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.fireFiveTP);
                                    blackMagicSpellInformationCanvas.enabled = true;
                                    blackMagicSpellInformation.text = spellController.fireFiveInformation; }
    public void OnClickFireSix() { fireSix = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.fireSixTP);
                                   blackMagicSpellInformationCanvas.enabled = true;
                                   blackMagicSpellInformation.text = spellController.fireSixInformation; }

    public void OnClickWaterOne() { waterOne = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.waterOneTP);
                                    blackMagicSpellInformationCanvas.enabled = true;
                                    blackMagicSpellInformation.text = spellController.waterOneInformation; }
    public void OnClickWaterTwo() { waterTwo = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.waterTwoTP);
                                    blackMagicSpellInformationCanvas.enabled = true;
                                    blackMagicSpellInformation.text = spellController.waterTwoInformation; }
    public void OnClickWaterThree() { waterThree = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.waterThreeTP);
                                      blackMagicSpellInformationCanvas.enabled = true;
                                      blackMagicSpellInformation.text = spellController.waterThreeInformation; }

    public void OnClickWaterFour() { waterFour = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.waterFourTP);
                                     blackMagicSpellInformationCanvas.enabled = true;
                                     blackMagicSpellInformation.text = spellController.waterFourInformation; }
    public void OnClickWaterFive() { waterFive = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.waterFiveTP);
                                     blackMagicSpellInformationCanvas.enabled = true;
                                     blackMagicSpellInformation.text = spellController.waterFiveInformation; }
    public void OnClickWaterSix() { waterSix = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.waterSixTP);
                                    blackMagicSpellInformationCanvas.enabled = true;
                                    blackMagicSpellInformation.text = spellController.waterSixInformation; }

    public void OnClickFreezeOne() { freezeOne = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.freezeOneTP);
                                     blackMagicSpellInformationCanvas.enabled = true;
                                     blackMagicSpellInformation.text = spellController.freezeOneInformation; }
    public void OnClickFreezeTwo() { freezeTwo = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.freezeTwoTP);
                                     blackMagicSpellInformationCanvas.enabled = true;
                                     blackMagicSpellInformation.text = spellController.freezeTwoInformation; }
    public void OnClickFreezeThree() { freezeThree = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.freezeThreeTP);
                                       blackMagicSpellInformationCanvas.enabled = true;
                                       blackMagicSpellInformation.text = spellController.freezeThreeInformation; }
    public void OnClickBurnOne() { burnOne = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.burnOneTP);
                                   blackMagicSpellInformationCanvas.enabled = true;
                                   blackMagicSpellInformation.text = spellController.burnOneInformation; }
    public void OnClickBurnTwo() { burnTwo = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.burnTwoTP);
                                   blackMagicSpellInformationCanvas.enabled = true;
                                   blackMagicSpellInformation.text = spellController.burnTwoInformation; }
    public void OnClickBurnThree() { burnThree = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.burnThreeTP);
                                     blackMagicSpellInformationCanvas.enabled = true;
                                     blackMagicSpellInformation.text = spellController.burnThreeInformation; }

    public void OnClickSilenceOne() { silenceOne = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.silenceOneTP);
                                      blackMagicSpellInformationCanvas.enabled = true;
                                      blackMagicSpellInformation.text = spellController.silenceOneInformation; }
    public void OnClickSilenceTwo() { silenceTwo = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.silenceTwoTP);
                                      blackMagicSpellInformationCanvas.enabled = true;
                                      blackMagicSpellInformation.text = spellController.silenceTwoInformation; }
    public void OnClickSilenceThree() { silenceThree = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.silenceThreeTP);
                                        blackMagicSpellInformationCanvas.enabled = true;
                                        blackMagicSpellInformation.text = spellController.silenceThreeInformation; }

    public void OnClickBlindOne() { blindOne = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.blindOneTP);
                                    blackMagicSpellInformationCanvas.enabled = true;
                                    blackMagicSpellInformation.text = spellController.blindOneInformation; }
    public void OnClickBlindTwo() { blindTwo = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.blindTwoTP);
                                    blackMagicSpellInformationCanvas.enabled = true;
                                    blackMagicSpellInformation.text = spellController.blindTwoInformation; }
    public void OnClickBlindThree() { blindThree = true; OnUsingBlackMagicSpellSingleTargetEnemy(turnPointsController.blindThreeTP);
                                      blackMagicSpellInformationCanvas.enabled = true;
                                      blackMagicSpellInformation.text = spellController.blindThreeInformation; }


    /// ////////////////////////////////////////////////////////////////////
    /// ////////////////////////////////////////////////////////////////////
    /// ////////////////////////////////////////////////////////////////////



    public void OnUsingBlackMagicSpellSingleTargetEnemy(int spellName)
    {
        gameController.SetButtonCanvasOff();
        gameController.SetArrowsCanvasOff();

        wizard.usingAnAction = true;

        usingSpell = true;

        cancelBlackMagicButtonGO.enabled = false;
        cancelBlackMagicSpellButtonGO.enabled = true;        

        findAllSelectArrow.SelectOnlyEnemyArrowTrue();

        turnPointsToSpendTxt.text = spellName.ToString() + "TP";
        turnPointsToSpendCanvas.enabled = true;

        allClickTarget.AllClicksEnemiesEnabled();

        clickController.wizardIsUsingBlackMagic = true;

        //clickController.RefreshOnClickOnEnemies();

        offensiveTabCanvas.enabled = false;
        effectsTabCanvas.enabled = false;
        

    }


    public void OnUsingBlackMagicSpell(int spellName)
    {
        turnPointsController.turnPointsWizard -= spellName;
        turnPointsController.TurnPointsUpdate();

        usingSpell = false;

        turnPointsList.BlackMagicSpell();

        cancelBlackMagicSpellButtonGO.enabled = false;

        infoTab.enabled = true;
        blackMagicTab.enabled = false;

        offensiveTabCanvas.enabled = false;
        effectsTabCanvas.enabled = false;

        onOffensiveTab = false;
        onEffectsTab = false;

        buffsAndDebuffsPaladin.enabled = true;
        buffsAndDebuffsWizard.enabled = true;

        findAllSelectArrow.SelectAllArrowsFalse();
        turnPointsToSpendCanvas.enabled = false;

        allClickTarget.AllClicksEnemiesDisabled();
        allClickTarget.AllClicksPaladinDisabled();
        allClickTarget.AllClicksWizardDisabled();

        gameController.waitingAction.enabled = true;

        wizardPointerGO.enabled = false;

        wizard.usingAnAction = false;
    }





    public void TurnAllSpellsFalse()
    {
        blackMagicSpellInformationCanvas.enabled = false;

        iceOne = false;
        iceTwo = false;
        iceThree = false;

        iceFour = false;
        iceFive = false;
        iceSix = false;

        fireOne = false;
        fireTwo = false;
        fireThree = false;

        fireFour = false;
        fireFive = false;
        fireSix = false;

        waterOne = false;
        waterTwo = false;
        waterThree = false;

        waterFour = false;
        waterFive = false;
        waterSix = false;

        freezeOne = false;
        freezeTwo = false;
        freezeThree = false;

        burnOne = false;
        burnTwo = false;
        burnThree = false;

        silenceOne = false;
        silenceTwo = false;
        silenceThree = false;

        blindOne = false;
        blindTwo = false;
        blindThree = false;

    }



    public void OnClickOffensiveTab()
    {
        if (usingSpell)
        {
            return;
        }

        if (onOffensiveTab)
        {
            return;
        }

        scriptBlackMagicOffensiveArrows.ResetThisButton();

        onOffensiveTab = true;
        onEffectsTab = false;

        var offensiveTabRect = offensiveTabGO.GetComponent<RectTransform>();
        offensiveTabRect.localPosition = new Vector3(offensiveTabRect.localPosition.x, -112, offensiveTabRect.localPosition.z);

        var effectsTabRect = effectsTabGO.GetComponent<RectTransform>();
        effectsTabRect.localPosition = new Vector3(effectsTabRect.localPosition.x, -116, effectsTabRect.localPosition.z);

        offensiveArrows.enabled = true;
        effectsArrows.enabled = false;
    }

    public void OnClickEffectsTab()
    {

        if (usingSpell)
        {
            return;
        }

        if (onEffectsTab)
        {
            return;
        }

        scriptBlackMagicEffectsArrows.ResetThisButton();

        onOffensiveTab = false;
        onEffectsTab = true;


        var offensiveTabRect = offensiveTabGO.GetComponent<RectTransform>();
        offensiveTabRect.localPosition = new Vector3(offensiveTabRect.localPosition.x, -116, offensiveTabRect.localPosition.z);

        var effectsTabRect = effectsTabGO.GetComponent<RectTransform>();
        effectsTabRect.localPosition = new Vector3(effectsTabRect.localPosition.x, -112, effectsTabRect.localPosition.z);

        offensiveArrows.enabled = false;
        effectsArrows.enabled = true;
    }
}
