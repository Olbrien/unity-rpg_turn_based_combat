using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackControllerWizard : MonoBehaviour
{
    public GlobalController globalController;
    public Wizard wizard;
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
        WizardAttackUpdate();
    }



    public void OnClickAttack()
    {
        globalController.EnableAllEnemiesSelectArrowAndClickController();
        globalController.wizardUsingAttack = true;
        globalController.wizardTurnPointer.enabled = false;

        globalController.canChangeCharacters = false;
        globalController.DisableChangeButtons();
    }

    public void OnClickCancelAttack()
    {
        globalController.DisableAllEnemiesSelectArrowAndClickController();
        globalController.wizardUsingAttack = false;
        globalController.wizardTurnPointer.enabled = true;

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

        gridController.FlipIfWizardIsAtackingRightOrLeft();
        
        globalController.wizardUsingAnAction = true;
        globalController.wizardIsReady = false;

        onAttacking = true;
    }



    void WizardAttackUpdate()
    {
        if (onAttacking)
        {
            if (section == 0)
            {
                globalController.StopAllSpeedTime();

                globalController.WaitingPosition();
                globalController.DisableAllEnemiesSelectArrowAndClickController();

                wizard.targetPosition = clickController.targetPosition;
                wizard.moveToTarget = true;
                
                section += 1;
            }

            else if (section == 1 && wizard.moveToTargetAtTarget)
            {
                wizard.moveToTargetAtTarget = false;

                wizard.AnimationAttackOneTrue();

                section += 1;
            }



            else if (section == 2 && enemyGettingHit)
            {
                foreach (var theEnemy in globalController.allEnemies)
                {
                    if (theEnemy.beingAttacked)
                    {
                        theEnemy.AnimationGettingHitTrue();
                        theEnemy.GettingHit(globalController.level, wizard.attack);
                    }
                }

                bubbleText.AddBubble();

                shakingCamera.ShakeCamera();

                enemyGettingHit = false;

                section += 1;
            }


            else if (section == 3 && attackEnd)
            {
                wizard.moveToStart = true;

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

            else if (section == 4 && wizard.moveToStartAtStart)
            {
                wizard.AnimationAttackOneFalse();

                wizard.moveToStartAtStart = false;
                globalController.wizardUsingAnAction = false;
                globalController.wizardUsingAttack = false;
                globalController.isCharacterSelect = false;
                wizard.StartOverSpeedBar();

                globalController.CharactersAreReady();
                globalController.CharacterReadyAnimationOffWizard();

                globalController.canChangeCharacters = true;
                globalController.EnableChangeButtons();

                globalController.RestartAllSpeedTime();

                onAttacking = false;
                section = 0;
            }
        }
    }
}
