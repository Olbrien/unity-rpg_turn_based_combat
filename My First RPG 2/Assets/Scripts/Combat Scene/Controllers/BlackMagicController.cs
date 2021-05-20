using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackMagicController : MonoBehaviour
{
    public bool spellIceOne;
    public bool spellIceTwo;
    public bool spellIceThree;
    public bool spellFireOne;
    public bool spellFireTwo;
    public bool spellFireThree;
    public bool spellWaterOne;
    public bool spellWaterTwo;
    public bool spellWaterThree;



    public GlobalController globalController;
    public Wizard wizard;
    public ClickController clickController;
    public ShakingCamera shakingCamera;
    public EntireGameControllerCollector entireGameControllerCollector;

    public GridController gridController;

    bool onCastingSpell;    
    int section;

    public bool spellHasBeenCasted;
    public bool spellEnd;

    public BubbleText bubbleText;

    void Start()
    {
        
    }


    void Update()
    {
       WizardCastingSpellUpdate();
    }



    public void OnClickCastSpellIceOne()
    {
        spellIceOne = true;

        globalController.EnableAllEnemiesSelectArrowAndClickController();
        globalController.wizardUsingSpell = true;
        globalController.wizardTurnPointer.enabled = false;

        globalController.canChangeCharacters = false;
        globalController.DisableChangeButtons();
    }

    public void OnClickCastSpellIceTwo()
    {
        spellIceTwo = true;

        globalController.EnableAllEnemiesSelectArrowAndClickController();
        globalController.wizardUsingSpell = true;
        globalController.wizardTurnPointer.enabled = false;

        globalController.canChangeCharacters = false;
        globalController.DisableChangeButtons();
    }

    public void OnClickCastSpellIceThree()
    {
        spellIceThree = true;

        globalController.EnableAllEnemiesSelectArrowAndClickController();
        globalController.wizardUsingSpell = true;
        globalController.wizardTurnPointer.enabled = false;

        globalController.canChangeCharacters = false;
        globalController.DisableChangeButtons();
    }

    public void OnClickCastSpellFireOne()
    {
        spellFireOne = true;

        globalController.EnableAllEnemiesSelectArrowAndClickController();
        globalController.wizardUsingSpell = true;
        globalController.wizardTurnPointer.enabled = false;

        globalController.canChangeCharacters = false;
        globalController.DisableChangeButtons();
    }

    public void OnClickCastSpellFireTwo()
    {
        spellFireTwo = true;

        globalController.EnableAllEnemiesSelectArrowAndClickController();
        globalController.wizardUsingSpell = true;
        globalController.wizardTurnPointer.enabled = false;

        globalController.canChangeCharacters = false;
        globalController.DisableChangeButtons();
    }

    public void OnClickCastSpellFireThree()
    {
        spellFireThree = true;

        globalController.EnableAllEnemiesSelectArrowAndClickController();
        globalController.wizardUsingSpell = true;
        globalController.wizardTurnPointer.enabled = false;

        globalController.canChangeCharacters = false;
        globalController.DisableChangeButtons();
    }

    public void OnClickCastSpellWaterOne()
    {
        spellWaterOne = true;

        globalController.EnableAllEnemiesSelectArrowAndClickController();
        globalController.wizardUsingSpell = true;
        globalController.wizardTurnPointer.enabled = false;

        globalController.canChangeCharacters = false;
        globalController.DisableChangeButtons();
    }

    public void OnClickCastSpellWaterTwo()
    {
        spellWaterTwo = true;

        globalController.EnableAllEnemiesSelectArrowAndClickController();
        globalController.wizardUsingSpell = true;
        globalController.wizardTurnPointer.enabled = false;

        globalController.canChangeCharacters = false;
        globalController.DisableChangeButtons();
    }

    public void OnClickCastSpellWaterThree()
    {
        spellWaterThree = true;

        globalController.EnableAllEnemiesSelectArrowAndClickController();
        globalController.wizardUsingSpell = true;
        globalController.wizardTurnPointer.enabled = false;

        globalController.canChangeCharacters = false;
        globalController.DisableChangeButtons();    }




    public void OnClickCancelSpell()
    {
        spellIceOne = false;
        spellIceTwo = false;
        spellIceThree = false;
        spellFireOne = false;
        spellFireTwo = false;
        spellFireThree = false;
        spellWaterOne = false;
        spellWaterTwo = false;
        spellWaterThree = false;

        globalController.DisableAllEnemiesSelectArrowAndClickController();
        globalController.wizardUsingSpell = false;
        globalController.wizardTurnPointer.enabled = true;

        globalController.canChangeCharacters = true;
        globalController.EnableChangeButtons();
    }



    public void OnCastingSpell()
    {
        if (globalController.paladinUsingAnAction || globalController.wizardUsingAnAction || globalController.enemyUsingAnAction)
        {
            Debug.Log("Someone is using an action");
            return;
        }

        gridController.FlipIfWizardIsAtackingRightOrLeft();
                
        globalController.wizardUsingAnAction = true;
        globalController.wizardIsReady = false;
                
        onCastingSpell = true;
    }




    void WizardCastingSpellUpdate()
    {
        if (onCastingSpell)
        {
            if (section == 0)
            {
                globalController.StopAllSpeedTime();

                globalController.WaitingPosition();
                globalController.DisableAllEnemiesSelectArrowAndClickController();     

                section += 1;
            }

            else if (section == 1)
            {
                wizard.AnimationCastSpellTrue();

                section += 1;
            }



            else if (section == 2 && spellHasBeenCasted)
            {
                foreach (var theEnemy in globalController.allEnemies)
                {
                    if (theEnemy.beingAttacked)
                    {
                        theEnemy.AnimationGettingHitTrue();

                        if (spellIceOne) { theEnemy.gettingHitWithIce = true; theEnemy.GettingHit(globalController.level, wizard.SpellIceOne()); }
                        else if (spellIceTwo) { theEnemy.gettingHitWithIce = true; theEnemy.GettingHit(globalController.level, wizard.SpellIceTwo()); }
                        else if (spellIceThree) { theEnemy.gettingHitWithIce = true; theEnemy.GettingHit(globalController.level, wizard.SpellIceThree()); }

                        else if (spellFireOne) { theEnemy.gettingHitWithFire = true; theEnemy.GettingHit(globalController.level, wizard.SpellFireOne()); }
                        else if (spellFireTwo) { theEnemy.gettingHitWithFire = true; theEnemy.GettingHit(globalController.level, wizard.SpellFireTwo()); }
                        else if (spellFireThree) { theEnemy.gettingHitWithFire = true; theEnemy.GettingHit(globalController.level, wizard.SpellFireThree()); }

                        else if (spellWaterOne) { theEnemy.gettingHitWithWater = true; theEnemy.GettingHit(globalController.level, wizard.SpellWaterOne()); }
                        else if (spellWaterTwo) { theEnemy.gettingHitWithWater = true; theEnemy.GettingHit(globalController.level, wizard.SpellWaterTwo()); }
                        else if (spellWaterThree) { theEnemy.gettingHitWithWater = true; theEnemy.GettingHit(globalController.level, wizard.SpellWaterThree()); }
                    }
                }

                //bubbleText.AddBubble(); Remove Here

                shakingCamera.ShakeCamera();

                spellHasBeenCasted = false;

                section += 1;
            }


            else if (section == 3 && spellEnd)
            {            
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

                spellEnd = false;

                section += 1;
            }

            else if (section == 4)
            {
                wizard.AnimationCastSpellFalse();

                globalController.wizardUsingAnAction = false;
                globalController.wizardUsingSpell = false;
                globalController.isCharacterSelect = false;
                wizard.StartOverSpeedBar();

                globalController.CharactersAreReady();
                globalController.CharacterReadyAnimationOffWizard();

                globalController.canChangeCharacters = true;
                globalController.EnableChangeButtons();

                globalController.RestartAllSpeedTime();                

                section = 0;

                spellIceOne = false;
                spellIceTwo = false;
                spellIceThree = false;
                spellFireOne = false;
                spellFireTwo = false;
                spellFireThree = false;
                spellWaterOne = false;
                spellWaterTwo = false;
                spellWaterThree = false;

                onCastingSpell = false;
            }
        }
    }



}
