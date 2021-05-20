using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class AttackControllerWizard : MonoBehaviour
{
    public Wizard wizard;

    public FindAllSelectArrow findAllSelectArrow;
    public AllClickTarget allClickTarget;
    public ClickController clickController;
    public TurnPointsList turnPointsList;
    public TurnPointsController turnPointsController;

    public Canvas attackButtonCanvas;
    public Canvas cancelAttackButtonCanvas;

    public Canvas actionArrowsCanvas;

    public Canvas wizardPointerGO;

    public GameController gameController;

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
        wizard.usingAnAction = true;

        gameController.SetArrowsCanvasOff();
        gameController.SetButtonCanvasOff();

        cancelAttackButtonCanvas.enabled = true;

        findAllSelectArrow.SelectOnlyEnemyArrowTrue();

        turnPointsToSpendTxt.text = turnPointsController.wizardAttackTP.ToString() + "TP";
        turnPointsToSpend.enabled = true;


        //wizardgPointerGO.SetActive(false);

        allClickTarget.AllClicksEnemiesEnabled();

        clickController.wizardIsAttacking = true;

        //clickController.RefreshOnClickOnEnemies();
    }

    public void OnCancelAttack()
    {
        wizard.usingAnAction = false;

        scriptActionArrows.ResetThisButton();

        cancelAttackButtonCanvas.enabled = false;

        findAllSelectArrow.SelectOnlyEnemyArrowFalse();

        turnPointsToSpend.enabled = false;

        actionArrowsCanvas.enabled = true;

        //wizardgPointerGO.SetActive(true);

        allClickTarget.AllClicksEnemiesDisabled();

        clickController.wizardIsAttacking = false;

    }

    public void OnAttacking()
    {
        StartCoroutine(OnAttackingCorountine());
    }

    IEnumerator OnAttackingCorountine()
    {
        gameController.damageSaverFromAttacks = wizard.attack;

        turnPointsController.turnPointsWizard -= turnPointsController.wizardAttackTP;
        turnPointsController.TurnPointsUpdate();

        turnPointsList.SubtractWizardAttackTurnPoints();

        cancelAttackButtonCanvas.enabled = false;

        findAllSelectArrow.SelectAllArrowsFalse();
        turnPointsToSpend.enabled = false;

        allClickTarget.AllClicksEnemiesDisabled();
        allClickTarget.AllClicksPaladinDisabled();
        allClickTarget.AllClicksWizardDisabled();

        //whiteHudTopAttackGO.SetActive(false);
        //whiteHudTopAttackGO.SetActive(true);
        //whiteHudTopActionText.text = "Attack";

        clickController.wizardIsAttacking = false;

        gameController.waitingAction.enabled = true;

        wizardPointerGO.enabled = false;

        wizard.usingAnAction = false;


        yield return new WaitForSeconds(0.9f);

        //whiteHudTopAttackGO.SetActive(false);



    }
}
