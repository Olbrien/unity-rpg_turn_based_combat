using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemControllerWizard : MonoBehaviour
{
    public Paladin paladin;
    public Wizard wizard;

    public ItemsController itemsController;
    public GameObject itemInformationGO;
    public TextMeshPro itemInformation;

    public FindAllSelectArrow findAllSelectArrow;
    public ClickController clickController;
    public AllClickTarget allClickTarget;
    public GameController gameController;

    public GameObject spaceCanvasActionGO;
    public GameObject spaceCanvasCancelActionGO;
    public GameObject cancelItemButtonGO;
    public GameObject cancelItemActionButtonGO;
    public GameObject itemCanvasGO;
    public GameObject itemRightButton;

    public GameObject infoTab;
    public GameObject itemTab;

    public GameObject potionsTab;
    public GameObject foodTab;
    public GameObject miscTab;

    public GameObject buffsAndDebuffsPaladin;
    public GameObject buffsAndDebuffsWizard;

    public GameObject fakeSliderPotions;
    public GameObject fakeSliderFood;
    public GameObject fakeSliderMisc;

    public GameObject potionsArrows;
    public GameObject foodArrows;
    public GameObject miscArrows;


    public GameObject wizardPointerGO;


    bool onPotionsTab;
    bool onFoodTab;
    bool onMiscTab;
    bool usingItem;



    void Start()
    {
        
    }


    void Update()
    {
        
    }



    public void OnClickItems()
    {
        spaceCanvasActionGO.SetActive(false);
        spaceCanvasCancelActionGO.SetActive(true);
        cancelItemButtonGO.SetActive(true);
        itemCanvasGO.SetActive(true);


        potionsTab.SetActive(true);
        foodTab.SetActive(true);
        miscTab.SetActive(true);

        infoTab.SetActive(false);
        itemTab.SetActive(true);
        onPotionsTab = true;

        var potionsTabRect = potionsTab.GetComponent<RectTransform>();
        potionsTabRect.localPosition = new Vector3(potionsTabRect.localPosition.x, -112, potionsTabRect.localPosition.z);

        var foodTabRect = foodTab.GetComponent<RectTransform>();
        foodTabRect.localPosition = new Vector3(foodTabRect.localPosition.x, -116, foodTabRect.localPosition.z);

        var miscTabRect = miscTab.GetComponent<RectTransform>();
        miscTabRect.localPosition = new Vector3(miscTabRect.localPosition.x, -116, miscTabRect.localPosition.z);

        fakeSliderPotions.SetActive(true);
        potionsArrows.SetActive(true);

        buffsAndDebuffsPaladin.SetActive(false);
        buffsAndDebuffsWizard.SetActive(false);
    }


    public void OnCancelItems()
    {
        spaceCanvasCancelActionGO.SetActive(false);
        cancelItemButtonGO.SetActive(false);
        itemCanvasGO.SetActive(false);
        spaceCanvasActionGO.SetActive(true);

        infoTab.SetActive(true);
        itemTab.SetActive(false);
        buffsAndDebuffsPaladin.SetActive(true);
        buffsAndDebuffsWizard.SetActive(true);

        fakeSliderPotions.SetActive(false);
        fakeSliderFood.SetActive(false);
        fakeSliderMisc.SetActive(false);

        potionsArrows.SetActive(false);
        foodArrows.SetActive(false);
        miscArrows.SetActive(false);

        onPotionsTab = false;
        onFoodTab = false;
        onMiscTab = false;

        clickController.wizardIsUsingItem = false;
    }


    public void OnCancelItemsAction()
    {
        potionsTab.SetActive(true);
        foodTab.SetActive(true);
        miscTab.SetActive(true);

        spaceCanvasActionGO.SetActive(false);
        spaceCanvasCancelActionGO.SetActive(true);

        usingItem = false;

        cancelItemActionButtonGO.SetActive(false);
        cancelItemButtonGO.SetActive(true);

        itemCanvasGO.SetActive(true);

        infoTab.SetActive(false);
        itemTab.SetActive(true);
        buffsAndDebuffsPaladin.SetActive(false);
        buffsAndDebuffsWizard.SetActive(false);

        if (onPotionsTab)
        {
            fakeSliderPotions.SetActive(true);
            potionsArrows.SetActive(true);
        }

        else if (onFoodTab)
        {
            fakeSliderFood.SetActive(true);
            foodArrows.SetActive(true);
        }

        else if (onMiscTab)
        {
            fakeSliderMisc.SetActive(true);
            miscArrows.SetActive(true);
        }

        findAllSelectArrow.SelectOnlyPaladinArrowFalse();
        findAllSelectArrow.SelectOnlyWizardArrowFalse();
        findAllSelectArrow.SelectOnlyEnemyArrowFalse();

        allClickTarget.AllClicksPaladinDisabled();
        allClickTarget.AllClicksWizardDisabled();
        allClickTarget.AllClicksEnemiesDisabled();

        TurnAllItemsFalse();
    }




    /// ////////////////////////////////////////////////////////////////////
    /// ////////////////////////////////////////////////////////////////////
    /// ////////////////////////////////////////////////////////////////////


    public void OnClickLesserHealthPotion()
    {

    }

    public void OnClickHealthPotion()
    {

    }

    public void OnClickGreaterHealthPotion()
    {

    }



    /// ////////////////////////////////////////////////////////////////////
    /// ////////////////////////////////////////////////////////////////////
    /// ////////////////////////////////////////////////////////////////////













    void TurnAllItemsFalse()
    {

    }




    public void OnClickPotionsTab()
    {
        if (usingItem)
        {
            return;
        }

        if (onPotionsTab)
        {
            return;
        }

        onPotionsTab = true;
        onFoodTab = false;
        onMiscTab = false;

        var potionsTabRect = potionsTab.GetComponent<RectTransform>();
        potionsTabRect.localPosition = new Vector3(potionsTabRect.localPosition.x, -112, potionsTabRect.localPosition.z);

        var foodTabRect = foodTab.GetComponent<RectTransform>();
        foodTabRect.localPosition = new Vector3(foodTabRect.localPosition.x, -116, foodTabRect.localPosition.z);

        var miscTabRect = miscTab.GetComponent<RectTransform>();
        miscTabRect.localPosition = new Vector3(miscTabRect.localPosition.x, -116, miscTabRect.localPosition.z);

        fakeSliderPotions.SetActive(true);
        fakeSliderFood.SetActive(false);
        fakeSliderMisc.SetActive(false);

        potionsArrows.SetActive(true);
        foodArrows.SetActive(false);
        miscArrows.SetActive(false);
    }

    public void OnClickFoodTab()
    {

        if (usingItem)
        {
            return;
        }

        if (onFoodTab)
        {
            return;
        }

        onPotionsTab = false;
        onFoodTab = true;
        onMiscTab = false;


        var potionsTabRect = potionsTab.GetComponent<RectTransform>();
        potionsTabRect.localPosition = new Vector3(potionsTabRect.localPosition.x, -116, potionsTabRect.localPosition.z);

        var foodTabRect = foodTab.GetComponent<RectTransform>();
        foodTabRect.localPosition = new Vector3(foodTabRect.localPosition.x, -112, foodTabRect.localPosition.z);

        var miscTabRect = miscTab.GetComponent<RectTransform>();
        miscTabRect.localPosition = new Vector3(miscTabRect.localPosition.x, -116, miscTabRect.localPosition.z);

        fakeSliderPotions.SetActive(false);
        fakeSliderFood.SetActive(true);
        fakeSliderMisc.SetActive(false);

        potionsArrows.SetActive(false);
        foodArrows.SetActive(true);
        miscArrows.SetActive(false);
    }

    public void OnClickMiscTab()
    {
        if (usingItem)
        {
            return;
        }

        if (onMiscTab)
        {
            return;
        }

        onPotionsTab = false;
        onFoodTab = false;
        onMiscTab = true;

        var potionsTabRect = potionsTab.GetComponent<RectTransform>();
        potionsTabRect.localPosition = new Vector3(potionsTabRect.localPosition.x, -116, potionsTabRect.localPosition.z);

        var foodTabRect = foodTab.GetComponent<RectTransform>();
        foodTabRect.localPosition = new Vector3(foodTabRect.localPosition.x, -116, foodTabRect.localPosition.z);

        var miscTabRect = miscTab.GetComponent<RectTransform>();
        miscTabRect.localPosition = new Vector3(miscTabRect.localPosition.x, -112, miscTabRect.localPosition.z);

        fakeSliderPotions.SetActive(false);
        fakeSliderFood.SetActive(false);
        fakeSliderMisc.SetActive(true);

        potionsArrows.SetActive(false);
        foodArrows.SetActive(false);
        miscArrows.SetActive(true);
    }
}
