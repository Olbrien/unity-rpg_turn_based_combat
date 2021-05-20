using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpecialControllerWizard : MonoBehaviour
{

    public Paladin paladin;
    public Wizard wizard;

    public SpellController spellController;
    public GameObject specialSpellInformationGO;
    public TextMeshPro specialSpellInformation;

    public FindAllSelectArrow findAllSelectArrow;
    public ClickController clickController;
    public AllClickTarget allClickTarget;
    public GameController gameController;

    public TurnPointsList turnPointsList;
    public TurnPointsController turnPointsController;

    public GameObject turnPointsToSpend;
    public TextMeshPro turnPointsToSpendTxt;

    public GameObject spaceCanvasActionGO;
    public GameObject spaceCanvasCancelActionGO;
    public GameObject cancelSpecialButtonGO;
    public GameObject cancelSpecialActionButtonGO;
    public GameObject specialCanvasGO;
    public GameObject specialRightButton;

    public GameObject infoTab;
    public GameObject specialTab;

    public GameObject buffsAndDebuffsPaladin;
    public GameObject buffsAndDebuffsWizard;

    public GameObject wizardPointerGO;



    bool usingSpell;

    public bool dualMagic;
    public bool tripleMagic;
    public bool hyperMagic;



    void Start()
    {
        
    }


    void Update()
    {
        
    }


    public void OnClickSpecial()
    {
        spaceCanvasActionGO.SetActive(false);
        spaceCanvasCancelActionGO.SetActive(true);
        cancelSpecialButtonGO.SetActive(true);
        specialCanvasGO.SetActive(true);
        specialRightButton.SetActive(true);

        infoTab.SetActive(false);
        specialTab.SetActive(true);

        buffsAndDebuffsPaladin.SetActive(false);
        buffsAndDebuffsWizard.SetActive(false);
    }



    public void OnCancelSpecial()
    {
        spaceCanvasCancelActionGO.SetActive(false);
        cancelSpecialButtonGO.SetActive(false);
        specialCanvasGO.SetActive(false);
        spaceCanvasActionGO.SetActive(true);

        infoTab.SetActive(true);
        specialTab.SetActive(false);
        buffsAndDebuffsPaladin.SetActive(true);
        buffsAndDebuffsWizard.SetActive(true);

        clickController.wizardIsUsingSpecial = false;
    }


    public void OnCancelSpecialAction()
    {
        spaceCanvasActionGO.SetActive(false);
        spaceCanvasCancelActionGO.SetActive(true);

        usingSpell = false;

        cancelSpecialActionButtonGO.SetActive(false);
        cancelSpecialButtonGO.SetActive(true);

        specialCanvasGO.SetActive(true);

        infoTab.SetActive(false);
        specialTab.SetActive(true);
        buffsAndDebuffsPaladin.SetActive(false);
        buffsAndDebuffsWizard.SetActive(false);


        turnPointsToSpend.SetActive(false);

        findAllSelectArrow.SelectOnlyPaladinArrowFalse();
        findAllSelectArrow.SelectOnlyWizardArrowFalse();
        findAllSelectArrow.SelectOnlyEnemyArrowFalse();

        allClickTarget.AllClicksPaladinDisabled();
        allClickTarget.AllClicksWizardDisabled();
        allClickTarget.AllClicksEnemiesDisabled();

        TurnAllSpellsFalse();
    }






    public void TurnAllSpellsFalse()
    {

    }
}
