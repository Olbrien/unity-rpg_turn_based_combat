using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ArrowsController : MonoBehaviour
{
    public Camera uICameraActions;
    public Transform uICameraActionsTransform;

    Vector3 initialPaladinActionsPosition = new Vector3(20, 0, 0);    
    Vector3 initialWizardActionsPosition = new Vector3(50, 0, 0);

    Vector3 paladinAttackCancelPosition = new Vector3(20, -10, 0);
    Vector3 wizardAttackCancelPosition = new Vector3(50, -10, 0);

    Vector3 paladinSpellCancelPosition = new Vector3(20, -20, 0);
    Vector3 wizardSpellCancelPosition = new Vector3(50, -20, 0);
    


    public AttackControllerPaladin attackControllerPaladin;
    public AttackControllerWizard attackControllerWizard;

    public BlackMagicController blackMagicController;

    public GlobalController globalController;



    /////////////////////////////
    /// Paladin Attack Action  //
    /////////////////////////////


    public void OnClickAttackPaladin()
    {
        uICameraActionsTransform.position = paladinAttackCancelPosition;
        attackControllerPaladin.OnClickAttack();
    }


    public void OnClickCancelAttackPaladin()
    {
        uICameraActionsTransform.position = initialPaladinActionsPosition;
        attackControllerPaladin.OnClickCancelAttack();
    }




    /////////////////////////////
    /// Wizard Attack Action  //
    /////////////////////////////


    public void OnClickAttackWizard()
    {
        uICameraActionsTransform.position = wizardAttackCancelPosition;
        attackControllerWizard.OnClickAttack();
    }


    public void OnClickCancelAttackWizard()
    {
        uICameraActionsTransform.position = initialWizardActionsPosition;
        attackControllerWizard.OnClickCancelAttack();
    }



    //////////////////////////////////
    /// Paladin White Magic Action  //
    //////////////////////////////////


    public void OnClickWhiteMagicPaladin()
    {
        uICameraActionsTransform.position = paladinSpellCancelPosition;
    }



    //////////////////////////////////
    /// Wizard Black Magic Action  //
    //////////////////////////////////


    public void OnClickBlackMagicFireOne()
    {
        uICameraActionsTransform.position = wizardSpellCancelPosition;

        blackMagicController.OnClickCastSpellFireOne();
    }
    public void OnClickBlackMagicFireTwo()
    {
        uICameraActionsTransform.position = wizardSpellCancelPosition;

        blackMagicController.OnClickCastSpellFireTwo();
    }
    public void OnClickBlackMagicFireThree()
    {
        uICameraActionsTransform.position = wizardSpellCancelPosition;

        blackMagicController.OnClickCastSpellFireThree();
    }


    public void OnClickBlackMagicIceOne()
    {
        uICameraActionsTransform.position = wizardSpellCancelPosition;

        blackMagicController.OnClickCastSpellIceOne();
    }
    public void OnClickBlackMagicIceTwo()
    {
        uICameraActionsTransform.position = wizardSpellCancelPosition;

        blackMagicController.OnClickCastSpellIceTwo();
    }
    public void OnClickBlackMagicIceThree()
    {
        uICameraActionsTransform.position = wizardSpellCancelPosition;

        blackMagicController.OnClickCastSpellIceThree();
    }


    public void OnClickBlackMagicWaterOne()
    {
        uICameraActionsTransform.position = wizardSpellCancelPosition;

        blackMagicController.OnClickCastSpellWaterOne();
    }
    public void OnClickBlackMagicWaterTwo()
    {
        uICameraActionsTransform.position = wizardSpellCancelPosition;

        blackMagicController.OnClickCastSpellWaterTwo();
    }
    public void OnClickBlackMagicWaterThree()
    {
        uICameraActionsTransform.position = wizardSpellCancelPosition;

        blackMagicController.OnClickCastSpellWaterThree();
    }



    public void OnClickCancelBlackMagic()
    {
        uICameraActionsTransform.position = initialWizardActionsPosition;
        blackMagicController.OnClickCancelSpell();
    }


}