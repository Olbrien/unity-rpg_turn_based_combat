using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaladinAnimationEvent : MonoBehaviour
{
    public AttackControllerPaladin attackControllerPaladin;
       
    public void AttackOneAnimationEnd()
    {
        attackControllerPaladin.attackEnd = true;        
    }

    public void EnemyGettingHit()
    {
        attackControllerPaladin.enemyGettingHit = true;        
    }
}
