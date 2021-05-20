using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class AttackControllerPaladin : MonoBehaviour
{
    public Paladin paladin;

    public FindAllSelectArrow findAllSelectArrow;
    public AllClickTarget allClickTarget;
    public ClickController clickController;
    public TurnPointsList turnPointsList;

    public Canvas cancelAttackButtonCanvas;
    public Canvas attackButtonCanvas;

    public Canvas actionArrowsCanvas;

    public Canvas paladingPointerGO;

    public GameController gameController;
    public TurnPointsController turnPointsController;

    public Canvas turnPointsToSpend;
    public TextMeshProUGUI turnPointsToSpendTxt;

    public ActionButtonArrow scriptActionArrows;



    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void OnClickAttack()
    {
        paladin.usingAnAction = true;

        gameController.SetArrowsCanvasOff();
        gameController.SetButtonCanvasOff();

        cancelAttackButtonCanvas.enabled = true;
        findAllSelectArrow.SelectOnlyEnemyArrowTrue();

        turnPointsToSpendTxt.text = turnPointsController.paladinAttackTP.ToString() + "TP";
        turnPointsToSpend.enabled = true;

        //paladingPointerGO.SetActive(false);

        allClickTarget.AllClicksEnemiesEnabled();

        clickController.paladinIsAttacking = true;

        //clickController.RefreshOnClickOnEnemies();
    }


    public void OnCancelAttack()
    {
        paladin.usingAnAction = false;

        scriptActionArrows.ResetThisButton();

        cancelAttackButtonCanvas.enabled = false;

        findAllSelectArrow.SelectOnlyEnemyArrowFalse();
        turnPointsToSpend.enabled = false;

        //paladingPointerGO.SetActive(true);

        actionArrowsCanvas.enabled = true;

        allClickTarget.AllClicksEnemiesDisabled();

        clickController.paladinIsAttacking = false;

    }

    public void OnAttacking()
    {
        StartCoroutine(OnAttackingCorountine());
    }

    IEnumerator OnAttackingCorountine()
    {
        gameController.damageSaverFromAttacks = paladin.attack;

        turnPointsController.turnPointsPaladin -= turnPointsController.paladinAttackTP;
        turnPointsController.TurnPointsUpdate();

        turnPointsList.SubtractPaladinAttackTurnPoints();

        cancelAttackButtonCanvas.enabled = false;

        findAllSelectArrow.SelectAllArrowsFalse();
        turnPointsToSpend.enabled = false;

        allClickTarget.AllClicksEnemiesDisabled();
        allClickTarget.AllClicksPaladinDisabled();
        allClickTarget.AllClicksWizardDisabled();

        //whiteHudTopAttackGO.SetActive(false);
        //whiteHudTopAttackGO.SetActive(true);
        //whiteHudTopActionText.text = "Attack";

        clickController.paladinIsAttacking = false;

        gameController.waitingAction.enabled = true;

        paladingPointerGO.enabled = false;

        paladin.usingAnAction = false;


        yield return new WaitForSeconds(0.9f);

        //whiteHudTopAttackGO.SetActive(false);
    }     
}
