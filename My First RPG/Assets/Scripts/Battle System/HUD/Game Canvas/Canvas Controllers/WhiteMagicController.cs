using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WhiteMagicController : MonoBehaviour
{
    public Paladin paladin;
    public Wizard wizard;

    public SpellController spellController;
    public Canvas whiteMagicSpellInformationCanvas;
    public TextMeshProUGUI whiteMagicSpellInformation;

    public FindAllSelectArrow findAllSelectArrow;
    public ClickController clickController;
    public AllClickTarget allClickTarget;
    public GameController gameController;

    public TurnPointsList turnPointsList;
    public TurnPointsController turnPointsController;

    public Canvas turnPointsToSpendCanvas;
    public TextMeshProUGUI turnPointsToSpendTxt;

    public Canvas spaceCanvasActionWhiteMagic;
    public Canvas spaceCanvasActionWhiteMagicArrow;
    public Canvas cancelWhiteMagicButtonGO;
    public Canvas cancelWhiteMagicSpellButtonGO;

    public Canvas whiteMagicCanvasAgility;
    public Canvas whiteMagicCanvasClumsy;
    public Canvas whiteMagicCanvasHeal;

    public Canvas infoTab;
    public Canvas whiteMagicTab;

    public GameObject buffsTabGO;
    public GameObject debuffsTabGO;
    public GameObject healsTabGO;

    public Canvas buffsTabCanvas;
    public Canvas debuffsTabCanvas;
    public Canvas healsTabCanvas;

    public Canvas buffsAndDebuffsPaladin;
    public Canvas buffsAndDebuffsWizard;

    public Canvas buffsArrows;
    public Canvas debuffsArrows;
    public Canvas healsArrows;

    public Canvas paladinPointerGO;

    public ActionButtonArrow scriptActionArrows;
    public ActionButtonArrow scriptWhiteMagicBuffsArrows;
    public ActionButtonArrow scriptWhiteMagicDebuffsArrows;
    public ActionButtonArrow scriptWhiteMagicHealsArrows;


    bool onBuffsTab;
    bool onDebuffsTab;
    bool onHealsTab;
    bool usingSpell;


    [Header("Spells")]

    public bool agiltyOne;
    public bool agiltyTwo;
    public bool agiltyThree;

    public bool strenghtOne;
    public bool strenghtTwo;
    public bool strenghtThree;

    public bool armorProtectionOne;
    public bool armorProtectionTwo;
    public bool armorProtectionThree;

    public bool magicProtectionOne;
    public bool magicProtectionTwo;
    public bool magicProtectionThree;

    public bool magicUpOne;
    public bool magicUpTwo;
    public bool magicUpThree;

    public bool higherVitalityUpOne;
    public bool higherVitalityUpTwo;
    public bool higherVitalityUpThree;


    public bool clumsyOne;
    public bool clumsyTwo;
    public bool clumsyThree;

    public bool weakenOne;
    public bool weakenTwo;
    public bool weakenThree;

    public bool deflateArmorOne;
    public bool deflateArmorTwo;
    public bool deflateArmorThree;

    public bool deflateMagicProtectionOne;
    public bool deflateMagicProtectionTwo;
    public bool deflateMagicProtectionThree;

    public bool feeblemindOne;
    public bool feeblemindTwo;
    public bool feeblemindThree;

    public bool dispelOne;
    public bool dispelTwo;
    public bool dispelThree;

    public bool healOne;
    public bool healTwo;
    public bool healThree;



    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void OnClickWhiteMagic()
    {
        scriptWhiteMagicBuffsArrows.ResetThisButton();

        cancelWhiteMagicButtonGO.enabled = true;

        infoTab.enabled = false;
        whiteMagicTab.enabled = true;
        onBuffsTab = true;

        buffsTabCanvas.enabled = true;
        debuffsTabCanvas.enabled = true;
        healsTabCanvas.enabled = true;

        var buffsTabRect = buffsTabGO.GetComponent<RectTransform>();
        buffsTabRect.localPosition = new Vector3(buffsTabRect.localPosition.x, -112, buffsTabRect.localPosition.z);

        var debuffsTabRect = debuffsTabGO.GetComponent<RectTransform>();
        debuffsTabRect.localPosition = new Vector3(debuffsTabRect.localPosition.x, -116, debuffsTabRect.localPosition.z);

        var healsTabRect = healsTabGO.GetComponent<RectTransform>();
        healsTabRect.localPosition = new Vector3(healsTabRect.localPosition.x, -116, healsTabRect.localPosition.z);

        buffsAndDebuffsPaladin.enabled = false;
        buffsAndDebuffsWizard.enabled = false;
    }

    public void OnCancelWhiteMagic()
    {
        scriptActionArrows.ResetThisButton();

        cancelWhiteMagicButtonGO.enabled = false;

        infoTab.enabled = true;
        whiteMagicTab.enabled = false;

        buffsAndDebuffsPaladin.enabled = true;
        buffsAndDebuffsWizard.enabled = true;

        onBuffsTab = false;
        onDebuffsTab = false;
        onHealsTab = false;

        buffsTabCanvas.enabled = false;
        debuffsTabCanvas.enabled = false;
        healsTabCanvas.enabled = false;

        clickController.paladinIsUsingWhiteMagic = false;
    }

    public void OnCancelWhiteMagicSpell()
    {
        buffsTabCanvas.enabled = true;
        debuffsTabCanvas.enabled = true;
        healsTabCanvas.enabled = true;

        usingSpell = false;

        cancelWhiteMagicSpellButtonGO.enabled = false;
        cancelWhiteMagicButtonGO.enabled = true;

        infoTab.enabled = false;
        whiteMagicTab.enabled = true;

        buffsAndDebuffsPaladin.enabled = false;
        buffsAndDebuffsWizard.enabled = false;

        if (onBuffsTab)
        {
            scriptWhiteMagicBuffsArrows.ResetThisButton();
        }

        else if (onDebuffsTab)
        {
            scriptWhiteMagicDebuffsArrows.ResetThisButton();
        }
        
        else if (onHealsTab)
        {
            scriptWhiteMagicHealsArrows.ResetThisButton();
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


    public void OnClickAgilityOne() { agiltyOne = true; OnUsingWhiteMagicSpellSingleTargetAlly(turnPointsController.agilityOneTP);
                                      whiteMagicSpellInformationCanvas.enabled = true;
                                      whiteMagicSpellInformation.text = spellController.agilityOneInformation; }
    public void OnClickAgilityTwo() { agiltyTwo = true; OnUsingWhiteMagicSpellSingleTargetAlly(turnPointsController.agilityTwoTP);
                                      whiteMagicSpellInformationCanvas.enabled = true;
                                      whiteMagicSpellInformation.text = spellController.agilityTwoInformation;}
    public void OnClickAgilityThree() { agiltyThree = true; OnUsingWhiteMagicSpellSingleTargetAlly(turnPointsController.agilityThreeTP);
                                        whiteMagicSpellInformationCanvas.enabled = true;
                                        whiteMagicSpellInformation.text = spellController.agilityThreeInformation; }


    public void OnClickStrenghtOne() { strenghtOne = true; OnUsingWhiteMagicSpellSingleTargetAlly(turnPointsController.strenghtOneTP);
                                       whiteMagicSpellInformationCanvas.enabled = true;
                                       whiteMagicSpellInformation.text = spellController.strenghtOneInformation;}
    public void OnClickStrenghtTwo() { strenghtTwo = true; OnUsingWhiteMagicSpellSingleTargetAlly(turnPointsController.strenghtTwoTP);
                                       whiteMagicSpellInformationCanvas.enabled = true;
                                       whiteMagicSpellInformation.text = spellController.strenghtTwoInformation;}
    public void OnClickStrenghtThree() { strenghtThree = true; OnUsingWhiteMagicSpellSingleTargetAlly(turnPointsController.strenghtThreeTP);
                                         whiteMagicSpellInformationCanvas.enabled = true;
                                         whiteMagicSpellInformation.text = spellController.strenghtThreeInformation; }


    public void OnClickArmorProtectionOne() { armorProtectionOne = true; OnUsingWhiteMagicSpellSingleTargetAlly(turnPointsController.armorProtectionOneTP);
                                              whiteMagicSpellInformationCanvas.enabled = true;
                                              whiteMagicSpellInformation.text = spellController.armorOneInformation;}
    public void OnClickArmorProtectionTwo() { armorProtectionTwo = true; OnUsingWhiteMagicSpellSingleTargetAlly(turnPointsController.armorProtectionTwoTP);
                                              whiteMagicSpellInformationCanvas.enabled = true;
                                              whiteMagicSpellInformation.text = spellController.armorTwoInformation; }
    public void OnClickArmorProtectionThree() { armorProtectionThree = true; OnUsingWhiteMagicSpellSingleTargetAlly(turnPointsController.armorProtectionThreeTP);
                                                whiteMagicSpellInformationCanvas.enabled = true;
                                                whiteMagicSpellInformation.text = spellController.armorThreeInformation; }


    public void OnClickMagicProtectionOne() { magicProtectionOne = true; OnUsingWhiteMagicSpellSingleTargetAlly(turnPointsController.magicProtectionOneTP);
                                              whiteMagicSpellInformationCanvas.enabled = true;
                                              whiteMagicSpellInformation.text = spellController.magicProtectionOneInformation; }
    public void OnClickMagicProtectionTwo() { magicProtectionTwo = true; OnUsingWhiteMagicSpellSingleTargetAlly(turnPointsController.magicProtectionTwoTP);
                                              whiteMagicSpellInformationCanvas.enabled = true;
                                              whiteMagicSpellInformation.text = spellController.magicProtectionTwoInformation;}
    public void OnClickMagicProtectionThree() { magicProtectionThree = true; OnUsingWhiteMagicSpellSingleTargetAlly(turnPointsController.magicProtectionThreeTP);
                                            whiteMagicSpellInformationCanvas.enabled = true;
                                            whiteMagicSpellInformation.text = spellController.magicProtectionThreeInformation; }


    public void OnClickMagicUpOne() { magicUpOne = true; OnUsingWhiteMagicSpellSingleTargetAlly(turnPointsController.magicUpOneTP);
                                      whiteMagicSpellInformationCanvas.enabled = true;
                                      whiteMagicSpellInformation.text = spellController.magicUpOneInformation; }
    public void OnClickMagicUpTwo() { magicUpTwo = true; OnUsingWhiteMagicSpellSingleTargetAlly(turnPointsController.magicUpTwoTP);
                                      whiteMagicSpellInformationCanvas.enabled = true;
                                      whiteMagicSpellInformation.text = spellController.magicUpTwoInformation; }
    public void OnClickMagicUpThree() { magicUpThree = true; OnUsingWhiteMagicSpellSingleTargetAlly(turnPointsController.magicUpThreeTP);
                                        whiteMagicSpellInformationCanvas.enabled = true;
                                        whiteMagicSpellInformation.text = spellController.magicUpThreeInformation; }

    public void OnClickHigherVitalityUpOne() { higherVitalityUpOne = true; OnUsingWhiteMagicSpellSingleTargetAlly(turnPointsController.higherVitalityUpOneTP);
                                               whiteMagicSpellInformationCanvas.enabled = true;
                                               whiteMagicSpellInformation.text = spellController.higherVitalityOneInformation; }
    public void OnClickHigherVitalityUpTwo() { higherVitalityUpTwo = true; OnUsingWhiteMagicSpellSingleTargetAlly(turnPointsController.higherVitalityUpTwoTP);
                                               whiteMagicSpellInformationCanvas.enabled = true;
                                               whiteMagicSpellInformation.text = spellController.higherVitalityTwoInformation; }
    public void OnClickHigherVitalityUpThree() { higherVitalityUpThree = true; OnUsingWhiteMagicSpellSingleTargetAlly(turnPointsController.higherVitalityUpThreeTP);
                                                 whiteMagicSpellInformationCanvas.enabled = true;
                                                 whiteMagicSpellInformation.text = spellController.higherVitalityThreeInformation; }



    public void OnClickClumsyOne() { clumsyOne = true; OnUsingWhiteMagicSpellSingleTargetEnemy(turnPointsController.clumsyOneTP);
                                     whiteMagicSpellInformationCanvas.enabled = true;
                                     whiteMagicSpellInformation.text = spellController.clumsyOneInformation; }
    public void OnClickClumsyTwo() { clumsyTwo = true; OnUsingWhiteMagicSpellSingleTargetEnemy(turnPointsController.clumsyTwoTP);
                                     whiteMagicSpellInformationCanvas.enabled = true;
                                     whiteMagicSpellInformation.text = spellController.clumsyTwoInformation; }
    public void OnClickClumsyThree() { clumsyThree = true; OnUsingWhiteMagicSpellSingleTargetEnemy(turnPointsController.clumsyThreeTP);
                                       whiteMagicSpellInformationCanvas.enabled = true;
                                       whiteMagicSpellInformation.text = spellController.clumsyThreeInformation; }



    public void OnClickWeakenOne() { weakenOne = true; OnUsingWhiteMagicSpellSingleTargetEnemy(turnPointsController.weakenOneTP);
                                     whiteMagicSpellInformationCanvas.enabled = true;
                                     whiteMagicSpellInformation.text = spellController.weakenOneInformation; }
    public void OnClickWeakenTwo() { weakenTwo = true; OnUsingWhiteMagicSpellSingleTargetEnemy(turnPointsController.weakenTwoTP);
                                     whiteMagicSpellInformationCanvas.enabled = true;
                                     whiteMagicSpellInformation.text = spellController.weakenTwoInformation; }
    public void OnClickWeakenThree() { weakenThree = true; OnUsingWhiteMagicSpellSingleTargetEnemy(turnPointsController.weakenThreeTP);
                                       whiteMagicSpellInformationCanvas.enabled = true;
                                       whiteMagicSpellInformation.text = spellController.weakenThreeInformation; }


    public void OnClickDeflateArmorOne() { deflateArmorOne = true; OnUsingWhiteMagicSpellSingleTargetEnemy(turnPointsController.deflateArmorOneTP);
                                           whiteMagicSpellInformationCanvas.enabled = true;
                                           whiteMagicSpellInformation.text = spellController.deflateArmorOneInformation; }
    public void OnClickDeflateArmorTwo() { deflateArmorTwo = true; OnUsingWhiteMagicSpellSingleTargetEnemy(turnPointsController.deflateArmorTwoTP);
                                           whiteMagicSpellInformationCanvas.enabled = true;
                                           whiteMagicSpellInformation.text = spellController.deflateArmorTwoInformation; }
    public void OnClickDeflateArmorThree() { deflateArmorThree = true; OnUsingWhiteMagicSpellSingleTargetEnemy(turnPointsController.deflateArmorThreeTP);
                                             whiteMagicSpellInformationCanvas.enabled = true;
                                             whiteMagicSpellInformation.text = spellController.deflateArmorThreeInformation; }

    public void OnClickDeflateMagicProtectionOne() { deflateMagicProtectionOne = true; OnUsingWhiteMagicSpellSingleTargetEnemy(turnPointsController.deflateMagicProtectionOneTP);
                                                     whiteMagicSpellInformationCanvas.enabled = true;
                                                     whiteMagicSpellInformation.text = spellController.deflateMagicOneInformation; }
    public void OnClickDeflateMagicProtectionTwo() { deflateMagicProtectionTwo = true; OnUsingWhiteMagicSpellSingleTargetEnemy(turnPointsController.deflateMagicProtectionTwoTP);
                                                     whiteMagicSpellInformationCanvas.enabled = true;
                                                     whiteMagicSpellInformation.text = spellController.deflateMagicTwoInformation; }
    public void OnClickDeflateMagicProtectionThree() { deflateMagicProtectionThree = true; OnUsingWhiteMagicSpellSingleTargetEnemy(turnPointsController.deflateMagicProtectionThreeTP);
                                                       whiteMagicSpellInformationCanvas.enabled = true;
                                                       whiteMagicSpellInformation.text = spellController.deflateMagicThreeInformation; }


    public void OnClickFeeblemindOne() { feeblemindOne = true; OnUsingWhiteMagicSpellSingleTargetEnemy(turnPointsController.feeblemindOneTP);
                                         whiteMagicSpellInformationCanvas.enabled = true;
                                         whiteMagicSpellInformation.text = spellController.feeblemindOneInformation; }
    public void OnClickFeeblemindTwo() { feeblemindTwo = true; OnUsingWhiteMagicSpellSingleTargetEnemy(turnPointsController.feeblemindTwoTP);
                                         whiteMagicSpellInformationCanvas.enabled = true;
                                         whiteMagicSpellInformation.text = spellController.feeblemindTwoInformation; }
    public void OnClickFeeblemindThree() { feeblemindThree = true; OnUsingWhiteMagicSpellSingleTargetEnemy(turnPointsController.feeblemindThreeTP);
                                           whiteMagicSpellInformationCanvas.enabled = true;
                                           whiteMagicSpellInformation.text = spellController.feeblemindThreeInformation; }


    public void OnClickDispelOne() { dispelOne = true; OnUsingWhiteMagicSpellSingleTargetEnemy(turnPointsController.dispelOneTP);
                                     whiteMagicSpellInformationCanvas.enabled = true;
                                     whiteMagicSpellInformation.text = spellController.dispelOneInformation; }
    public void OnClickDispelTwo() { dispelTwo = true; OnUsingWhiteMagicSpellSingleTargetEnemy(turnPointsController.dispelTwoTP);                                     
                                     whiteMagicSpellInformationCanvas.enabled = true;
                                     whiteMagicSpellInformation.text = spellController.dispelTwoInformation; }
    public void OnClickDispelThree() { dispelThree = true; OnUsingWhiteMagicSpellSingleTargetEnemy(turnPointsController.dispelThreeTP);
                                       whiteMagicSpellInformationCanvas.enabled = true;
                                       whiteMagicSpellInformation.text = spellController.dispelThreeInformation; }


    public void OnClickHealOne() { healOne = true; OnUsingWhiteMagicSpellSingleTargetAlly(turnPointsController.healOneTP);
                                   whiteMagicSpellInformationCanvas.enabled = true;
                                   whiteMagicSpellInformation.text = spellController.healOneInformation; }
    public void OnClickHealTwo() { healTwo = true; OnUsingWhiteMagicSpellSingleTargetAlly(turnPointsController.healTwoTP);
                                   whiteMagicSpellInformationCanvas.enabled = true;
                                   whiteMagicSpellInformation.text = spellController.healTwoInformation; }
    public void OnClickHealThree() { healThree = true; OnUsingWhiteMagicSpellSingleTargetAlly(turnPointsController.healThreeTP);
                                     whiteMagicSpellInformationCanvas.enabled = true;
                                     whiteMagicSpellInformation.text = spellController.healThreeInformation; }




    public void OnUsingWhiteMagicSpellSingleTargetAlly(int spellName)
    {
        gameController.SetButtonCanvasOff();
        gameController.SetArrowsCanvasOff();

        paladin.usingAnAction = true;

        usingSpell = true;

        cancelWhiteMagicButtonGO.enabled = false;
        cancelWhiteMagicSpellButtonGO.enabled = true;

        findAllSelectArrow.SelectOnlyPaladinArrowTrue(); 

        if (wizard.currentHealth > 0)
        {
            findAllSelectArrow.SelectOnlyWizardArrowTrue();
            allClickTarget.AllClicksWizardEnabled();
            //clickController.RefreshOnClickOnWizard();
        }

        turnPointsToSpendTxt.text = spellName.ToString() + "TP";
        turnPointsToSpendCanvas.enabled = true;


        allClickTarget.AllClicksPaladinEnabled();

        clickController.paladinIsUsingWhiteMagic = true;

        //clickController.RefreshOnClickOnPaladin();

        buffsTabCanvas.enabled = false;
        debuffsTabCanvas.enabled = false;
        healsTabCanvas.enabled = false;
    }



    public void OnUsingWhiteMagicSpellSingleTargetEnemy(int spellName)
    {
        gameController.SetButtonCanvasOff();
        gameController.SetArrowsCanvasOff();

        paladin.usingAnAction = true;

        usingSpell = true;

        cancelWhiteMagicButtonGO.enabled = false;
        cancelWhiteMagicSpellButtonGO.enabled = true;

        findAllSelectArrow.SelectOnlyEnemyArrowTrue();

        turnPointsToSpendCanvas.enabled = true;
        turnPointsToSpendTxt.text = spellName.ToString() + "TP";

        allClickTarget.AllClicksEnemiesEnabled();

        clickController.paladinIsUsingWhiteMagic = true;

        //clickController.RefreshOnClickOnEnemies();

        buffsTabCanvas.enabled = false;
        debuffsTabCanvas.enabled = false;
        healsTabCanvas.enabled = false;
    }



    public void OnUsingWhiteMagicSpell(int spellName)
    {
        turnPointsController.turnPointsPaladin -= spellName;
        turnPointsController.TurnPointsUpdate();

        usingSpell = false;

        turnPointsList.WhiteMagicSpell();

        cancelWhiteMagicSpellButtonGO.enabled = false;

        infoTab.enabled = true;
        whiteMagicTab.enabled = false;

        buffsTabCanvas.enabled = false;
        debuffsTabCanvas.enabled = false;
        healsTabCanvas.enabled = false;

        onBuffsTab = false;
        onDebuffsTab = false;
        onHealsTab = false;

        buffsAndDebuffsPaladin.enabled = true;
        buffsAndDebuffsWizard.enabled = true;

        findAllSelectArrow.SelectAllArrowsFalse();
        turnPointsToSpendCanvas.enabled = false;

        allClickTarget.AllClicksEnemiesDisabled();
        allClickTarget.AllClicksPaladinDisabled();
        allClickTarget.AllClicksWizardDisabled();

        gameController.waitingAction.enabled = true;

        paladinPointerGO.enabled = false;

        paladin.usingAnAction = false;
    }


    public void TurnAllSpellsFalse()
    {
        whiteMagicSpellInformationCanvas.enabled = false;

        agiltyOne = false;
        agiltyTwo = false;
        agiltyThree = false;

        strenghtOne = false;
        strenghtTwo = false;
        strenghtThree = false;

        armorProtectionOne = false;
        armorProtectionTwo = false;
        armorProtectionThree = false;

        magicProtectionOne = false;
        magicProtectionTwo = false;
        magicProtectionThree = false;

        magicUpOne = false;
        magicUpTwo = false;
        magicUpThree = false;

        clumsyOne = false;
        clumsyTwo = false;
        clumsyThree = false;

        weakenOne = false;
        weakenTwo = false;
        weakenThree = false;

        deflateArmorOne = false;
        deflateArmorTwo = false;
        deflateArmorThree = false;

        deflateMagicProtectionOne = false;
        deflateMagicProtectionTwo = false;
        deflateMagicProtectionThree = false;

        feeblemindOne = false;
        feeblemindTwo = false;
        feeblemindThree = false;

        dispelOne = false;
        dispelTwo = false;
        dispelThree = false;

        healOne = false;
        healTwo = false;
        healThree = false;

        higherVitalityUpOne = false;
        higherVitalityUpTwo = false;
        higherVitalityUpThree = false;
    }



    
    public void OnClickBuffsTab()
    {
        if (usingSpell)
        {
            return;
        }

        if (onBuffsTab)
        {
            return;
        }

        scriptWhiteMagicBuffsArrows.ResetThisButton();

        onBuffsTab = true;
        onDebuffsTab = false;
        onHealsTab = false;
        
        var buffsTabRect = buffsTabGO.GetComponent<RectTransform>();
        buffsTabRect.localPosition = new Vector3(buffsTabRect.localPosition.x, -112, buffsTabRect.localPosition.z);

        var debuffsTabRect = debuffsTabGO.GetComponent<RectTransform>();
        debuffsTabRect.localPosition = new Vector3(debuffsTabRect.localPosition.x, -116, debuffsTabRect.localPosition.z);

        var healsTabRect = healsTabGO.GetComponent<RectTransform>();
        healsTabRect.localPosition = new Vector3(healsTabRect.localPosition.x, -116, healsTabRect.localPosition.z);

        buffsArrows.enabled = true;
        debuffsArrows.enabled = false;
        healsArrows.enabled = false;
    }

    public void OnClickDebuffsTab()
    {

        if (usingSpell)
        {
            return;
        }

        if (onDebuffsTab)
        {
            return;
        }

        onBuffsTab = false;
        onDebuffsTab = true;
        onHealsTab = false;

        scriptWhiteMagicDebuffsArrows.ResetThisButton();

        var buffsTabRect = buffsTabGO.GetComponent<RectTransform>();
        buffsTabRect.localPosition = new Vector3(buffsTabRect.localPosition.x, -116, buffsTabRect.localPosition.z);

        var debuffsTabRect = debuffsTabGO.GetComponent<RectTransform>();
        debuffsTabRect.localPosition = new Vector3(debuffsTabRect.localPosition.x, -112, debuffsTabRect.localPosition.z);

        var healsTabRect = healsTabGO.GetComponent<RectTransform>();
        healsTabRect.localPosition = new Vector3(healsTabRect.localPosition.x, -116, healsTabRect.localPosition.z);

        buffsArrows.enabled = false;
        debuffsArrows.enabled = true;
        healsArrows.enabled = false;
    }

    public void OnClickHealsTab()
    {
        if (usingSpell)
        {
            return;
        }

        if (onHealsTab)
        {
            return;
        }

        scriptWhiteMagicHealsArrows.ResetThisButton();

        onBuffsTab = false;
        onDebuffsTab = false;
        onHealsTab = true;

        var buffsTabRect = buffsTabGO.GetComponent<RectTransform>();
        buffsTabRect.localPosition = new Vector3(buffsTabRect.localPosition.x, -116, buffsTabRect.localPosition.z);

        var debuffsTabRect = debuffsTabGO.GetComponent<RectTransform>();
        debuffsTabRect.localPosition = new Vector3(debuffsTabRect.localPosition.x, -116, debuffsTabRect.localPosition.z);

        var healsTabRect = healsTabGO.GetComponent<RectTransform>();
        healsTabRect.localPosition = new Vector3(healsTabRect.localPosition.x, -112, healsTabRect.localPosition.z);

        buffsArrows.enabled = false;
        debuffsArrows.enabled = false;
        healsArrows.enabled = true;
    }


}

