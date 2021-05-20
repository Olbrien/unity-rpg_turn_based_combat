using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardAnimationEvent : MonoBehaviour
{
    public AttackControllerWizard attackControllerWizard;
    public BlackMagicController blackMagicController;

    public void AttackOneAnimationEnd()
    {
        attackControllerWizard.attackEnd = true;
    }

    public void EnemyGettingHit()
    {
        attackControllerWizard.enemyGettingHit = true;
    }


    public void SpellHasBeenCasted()
    {
        blackMagicController.spellHasBeenCasted = true;
    }

    public void SpellEnd()
    {
        blackMagicController.spellEnd = true;
    }
}
