using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickController : MonoBehaviour
{
    public GlobalController globalController;

    public AttackControllerPaladin attackControllerPaladin;
    public AttackControllerWizard attackControllerWizard;

    public BlackMagicController blackMagicController;

    public Vector3 targetPosition;


    void Start()
    {
        
    }

    

    public void OnClickControllerButton(Vector3 theTargetPosition)
    {
        targetPosition = theTargetPosition;

        if (globalController.paladinUsingAttack)
        {
            attackControllerPaladin.OnAttacking();
        }

        else if (globalController.wizardUsingAttack)
        {
            attackControllerWizard.OnAttacking();
        }





        else if (globalController.wizardUsingSpell)
        {
            blackMagicController.OnCastingSpell(); // Meter os spells Ice Fire aqui.
        }

    }



}

