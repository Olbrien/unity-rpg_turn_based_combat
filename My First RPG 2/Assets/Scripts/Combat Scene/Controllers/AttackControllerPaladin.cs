using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AttackControllerPaladin : MonoBehaviour
{
    public GlobalController globalController;
    public Paladin paladin;
    public ClickController clickController;
    public ShakingCamera shakingCamera;

    public GridController gridController;

    bool onAttacking;    
    int section;

    public bool enemyGettingHit;
    public bool attackEnd;

    public BubbleText bubbleText;


    void Start()
    {
        
    }

    void Update()
    {
        PaladinAttackUpdate();
    }


    public void OnClickAttack()
    {
        globalController.EnableAllEnemiesSelectArrowAndClickController();
        globalController.paladinUsingAttack = true;
        globalController.paladinTurnPointer.enabled = false;

        globalController.canChangeCharacters = false;
        globalController.DisableChangeButtons();
    }

    public void OnClickCancelAttack()
    {
        globalController.DisableAllEnemiesSelectArrowAndClickController();
        globalController.paladinUsingAttack = false;
        globalController.paladinTurnPointer.enabled = true;

        globalController.canChangeCharacters = true;
        globalController.EnableChangeButtons();
    }





    public void OnAttacking()
    {
        if (globalController.paladinUsingAnAction || globalController.wizardUsingAnAction || globalController.enemyUsingAnAction)
        {
            Debug.Log("Someone is using an action");
            return;
        }

        gridController.FlipIfPaladinIsAtackingRightOrLeft();
        
        globalController.paladinUsingAnAction = true;
        globalController.paladinIsReady = false;

        onAttacking = true;
    }




    public void PaladinAttackUpdate()
    {
        if (onAttacking)
        {        
            if (section == 0)
            {
                globalController.StopAllSpeedTime();

                globalController.WaitingPosition();
                globalController.DisableAllEnemiesSelectArrowAndClickController();

                paladin.targetPosition = clickController.targetPosition;
                paladin.moveToTarget = true;

                section += 1;
            }

            else if (section == 1 && paladin.moveToTargetAtTarget)
            {
                paladin.moveToTargetAtTarget = false;

                paladin.AnimationAttackOneTrue();

                section += 1;
            }




            else if (section == 2 && enemyGettingHit)
            {
                foreach (var theEnemy in globalController.allEnemies)
                {
                    if (theEnemy.beingAttacked)
                    {
                        theEnemy.AnimationGettingHitTrue();
                        theEnemy.GettingHit(globalController.level, paladin.attack);
                    }
                }

                bubbleText.AddBubble();

                shakingCamera.ShakeCamera();

                enemyGettingHit = false;

                section += 1;
            }

            else if (section == 3 && attackEnd)
            {
                paladin.moveToStart = true;

                foreach (var theEnemy in globalController.allEnemies)
                {
                    if (theEnemy.beingAttacked)
                    {
                        if (theEnemy.currentHealth > 0)
                        {
                            theEnemy.AnimationGettingHitFalse();
                            theEnemy.beingAttacked = false;
                        }

                        theEnemy.beingAttacked = false;
                    }
                }

                attackEnd = false;

                section += 1;
            }


            else if (section == 4 && paladin.moveToStartAtStart)
            {
                paladin.AnimationAttackOneFalse();

                paladin.moveToStartAtStart = false;
                globalController.paladinUsingAnAction = false;
                globalController.paladinUsingAttack = false;
                globalController.isCharacterSelect = false;
                paladin.StartOverSpeedBar();

                globalController.CharactersAreReady();
                globalController.CharacterReadyAnimationOffPaladin();

                globalController.canChangeCharacters = true;
                globalController.EnableChangeButtons();

                globalController.RestartAllSpeedTime();

                onAttacking = false;
                section = 0;
            }
        }
    }

}
