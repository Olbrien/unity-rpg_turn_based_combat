using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionButtonArrow : MonoBehaviour
{

    [Header("Pick Only One")]
    public bool actionArrowsPaladin;
    public bool actionArrowsWizard;
    public bool whiteMagicArrowsBuffs;
    public bool whiteMagicArrowsDebuffs;
    public bool whiteMagicArrowsHeals;
    public bool blackMagicArrowsOffensive;
    public bool blackMagicArrowsEffects;    
    public bool specialArrows;

    Vector3 localPosition;

    int actionArrowNumber;

    int whiteMagicArrowsBuffsNumber;
    int whiteMagicArrowsDebuffsNumber;

    int blackMagicArrowsOffensiveNumber;
    int blackMagicArrowsEffectsNumber;


    [Space(400)]

    public GameController gameController; 

    [Space(20)]
    
    public Canvas actionAttackPaladinButton;
    public Canvas actionWhiteMagicPaladinButton;
    public Canvas actionSpecialPaladinButton;
    public Canvas actionItemPaladinButton;
    public Canvas actionEscapePaladinButton;

    public Canvas actionArrowsOfPaladin;


    [Space(5)]

    public Canvas actionAttackWizardButton;
    public Canvas actionBlackMagicWizardButton;
    public Canvas actionSpecialWizardButton;
    public Canvas actionItemWizardButton;
    public Canvas actionEscapeWizardButton;

    public Canvas actionArrowsOfWizard;

    [Space(5)]

    public Canvas whiteMagicPaladinArrowsBuffs;
    public Canvas whiteMagicPaladinArrowsDebuffs;
    public Canvas whiteMagicPaladinArrowsHeals;

    [Space(5)]

    public Canvas whiteMagicPaladinBuffsBlockOne;
    public Canvas whiteMagicPaladinBuffsBlockTwo;
    public Canvas whiteMagicPaladinBuffsBlockThree;
    public Canvas whiteMagicPaladinBuffsBlockFour;
    public Canvas whiteMagicPaladinBuffsBlockFive;
    public Canvas whiteMagicPaladinBuffsBlockSix;

    public Canvas whiteMagicPaladinDebuffsBlockOne;
    public Canvas whiteMagicPaladinDebuffsBlockTwo;
    public Canvas whiteMagicPaladinDebuffsBlockThree;
    public Canvas whiteMagicPaladinDebuffsBlockFour;
    public Canvas whiteMagicPaladinDebuffsBlockFive;
    public Canvas whiteMagicPaladinDebuffsBlockSix;

    public Canvas whiteMagicPaladinHealsBlockOne;

    [Space(5)]

    public Canvas blackMagicPaladinArrowsOffensive;
    public Canvas blackMagicPaladinArrowsEffects;


    [Space(5)]

    public Canvas blackMagicWizardOffensiveBlockOne;
    public Canvas blackMagicWizardOffensiveBlockTwo;
    public Canvas blackMagicWizardOffensiveBlockThree;
    public Canvas blackMagicWizardOffensiveBlockFour;
    public Canvas blackMagicWizardOffensiveBlockFive;
    public Canvas blackMagicWizardOffensiveBlockSix;

    public Canvas blackMagicWizardEffectsBlockOne;
    public Canvas blackMagicWizardEffectsBlockTwo;
    public Canvas blackMagicWizardEffectsBlockThree;
    public Canvas blackMagicWizardEffectsBlockFour;



    void Start()
    {
        actionArrowNumber = 1;

        whiteMagicArrowsBuffsNumber = 1;
        whiteMagicArrowsDebuffsNumber = 1;

        blackMagicArrowsOffensiveNumber = 1;
        blackMagicArrowsEffectsNumber = 1;
    }


    void Update()
    {

    }


    public void ResetThisButton()
    {
        actionArrowNumber = 1;

        whiteMagicArrowsBuffsNumber = 1;
        whiteMagicArrowsDebuffsNumber = 1;

        blackMagicArrowsOffensiveNumber = 1;
        blackMagicArrowsEffectsNumber = 1;


        if (actionArrowsPaladin)
        {
            gameController.SetButtonCanvasOff();
            gameController.SetArrowsCanvasOff();
            actionAttackPaladinButton.enabled = true;
            actionArrowsOfPaladin.enabled = true;
        }

        else if (actionArrowsWizard)
        {
            gameController.SetButtonCanvasOff();
            actionAttackWizardButton.enabled = true;
            actionArrowsOfWizard.enabled = true;
        }

        else if (whiteMagicArrowsBuffs)
        {
            gameController.SetButtonCanvasOff();
            whiteMagicPaladinBuffsBlockOne.enabled = true;
            whiteMagicPaladinArrowsBuffs.enabled = true;
        }

        else if (whiteMagicArrowsDebuffs)
        {
            gameController.SetButtonCanvasOff();
            whiteMagicPaladinDebuffsBlockOne.enabled = true;
            whiteMagicPaladinArrowsDebuffs.enabled = true;
        }

        else if (whiteMagicArrowsHeals)
        {
            gameController.SetButtonCanvasOff();
            whiteMagicPaladinHealsBlockOne.enabled = true;
            whiteMagicPaladinArrowsHeals.enabled = true;
        }

        else if (blackMagicArrowsOffensive)
        {
            gameController.SetButtonCanvasOff();
            blackMagicWizardOffensiveBlockOne.enabled = true;
            blackMagicPaladinArrowsOffensive.enabled = true;
        }

        else if (blackMagicArrowsEffects)
        {
            gameController.SetButtonCanvasOff();
            blackMagicWizardEffectsBlockOne.enabled = true;
            blackMagicPaladinArrowsEffects.enabled = true;
        }
    }



    public void RightArrowAction()
    {
        if (actionArrowsPaladin)
        {
            actionArrowNumber += 1;

            if (actionArrowNumber >= 6)
            {
                actionArrowNumber = 1;
            }

            if (actionArrowNumber == 1)
            {
                actionAttackPaladinButton.enabled = true;
                actionWhiteMagicPaladinButton.enabled = false;
                actionSpecialPaladinButton.enabled = false;
                actionItemPaladinButton.enabled = false;
                actionEscapePaladinButton.enabled = false;
            }

            else if (actionArrowNumber == 2)
            {
                actionAttackPaladinButton.enabled = false;
                actionWhiteMagicPaladinButton.enabled = true;
                actionSpecialPaladinButton.enabled = false;
                actionItemPaladinButton.enabled = false;
                actionEscapePaladinButton.enabled = false;
            }

            else if (actionArrowNumber == 3)
            {
                actionAttackPaladinButton.enabled = false;
                actionWhiteMagicPaladinButton.enabled = false;
                actionSpecialPaladinButton.enabled = true;
                actionItemPaladinButton.enabled = false;
                actionEscapePaladinButton.enabled = false;
            }

            else if (actionArrowNumber == 4)
            {
                actionAttackPaladinButton.enabled = false;
                actionWhiteMagicPaladinButton.enabled = false;
                actionSpecialPaladinButton.enabled = false;
                actionItemPaladinButton.enabled = true;
                actionEscapePaladinButton.enabled = false;
            }

            else if (actionArrowNumber == 5)
            {
                actionAttackPaladinButton.enabled = false;
                actionWhiteMagicPaladinButton.enabled = false;
                actionSpecialPaladinButton.enabled = false;
                actionItemPaladinButton.enabled = false;
                actionEscapePaladinButton.enabled = true;
            }
        }



        if (actionArrowsWizard)
        {
            actionArrowNumber += 1;

            if (actionArrowNumber >= 6)
            {
                actionArrowNumber = 1;
            }

            if (actionArrowNumber == 1)
            {
                actionAttackWizardButton.enabled = true;
                actionBlackMagicWizardButton.enabled = false;
                actionSpecialWizardButton.enabled = false;
                actionItemWizardButton.enabled = false;
                actionEscapeWizardButton.enabled = false;
            }

            else if (actionArrowNumber == 2)
            {
                actionAttackWizardButton.enabled = false;
                actionBlackMagicWizardButton.enabled = true;
                actionSpecialWizardButton.enabled = false;
                actionItemWizardButton.enabled = false;
                actionEscapeWizardButton.enabled = false;
            }

            else if (actionArrowNumber == 3)
            {
                actionAttackWizardButton.enabled = false;
                actionBlackMagicWizardButton.enabled = false;
                actionSpecialWizardButton.enabled = true;
                actionItemWizardButton.enabled = false;
                actionEscapeWizardButton.enabled = false;
            }

            else if (actionArrowNumber == 4)
            {
                actionAttackWizardButton.enabled = false;
                actionBlackMagicWizardButton.enabled = false;
                actionSpecialWizardButton.enabled = false;
                actionItemWizardButton.enabled = true;
                actionEscapeWizardButton.enabled = false;
            }

            else if (actionArrowNumber == 5)
            {
                actionAttackWizardButton.enabled = false;
                actionBlackMagicWizardButton.enabled = false;
                actionSpecialWizardButton.enabled = false;
                actionItemWizardButton.enabled = false;
                actionEscapeWizardButton.enabled = true;
            }
        }


        if (whiteMagicArrowsBuffs)
        {
            whiteMagicArrowsBuffsNumber += 1;

            if (whiteMagicArrowsBuffsNumber >= 7)
            {
                whiteMagicArrowsBuffsNumber = 1;
            }

            if (whiteMagicArrowsBuffsNumber == 1)
            {
                whiteMagicPaladinBuffsBlockOne.enabled = true;
                whiteMagicPaladinBuffsBlockTwo.enabled = false;
                whiteMagicPaladinBuffsBlockThree.enabled = false;
                whiteMagicPaladinBuffsBlockFour.enabled = false;
                whiteMagicPaladinBuffsBlockFive.enabled = false;
                whiteMagicPaladinBuffsBlockSix.enabled = false;
            }

            else if (whiteMagicArrowsBuffsNumber == 2)
            {
                whiteMagicPaladinBuffsBlockOne.enabled = false;
                whiteMagicPaladinBuffsBlockTwo.enabled = true;
                whiteMagicPaladinBuffsBlockThree.enabled = false;
                whiteMagicPaladinBuffsBlockFour.enabled = false;
                whiteMagicPaladinBuffsBlockFive.enabled = false;
                whiteMagicPaladinBuffsBlockSix.enabled = false;
            }

            else if (whiteMagicArrowsBuffsNumber == 3)
            {
                whiteMagicPaladinBuffsBlockOne.enabled = false;
                whiteMagicPaladinBuffsBlockTwo.enabled = false;
                whiteMagicPaladinBuffsBlockThree.enabled = true;
                whiteMagicPaladinBuffsBlockFour.enabled = false;
                whiteMagicPaladinBuffsBlockFive.enabled = false;
                whiteMagicPaladinBuffsBlockSix.enabled = false;
            }

            else if (whiteMagicArrowsBuffsNumber == 4)
            {
                whiteMagicPaladinBuffsBlockOne.enabled = false;
                whiteMagicPaladinBuffsBlockTwo.enabled = false;
                whiteMagicPaladinBuffsBlockThree.enabled = false;
                whiteMagicPaladinBuffsBlockFour.enabled = true;
                whiteMagicPaladinBuffsBlockFive.enabled = false;
                whiteMagicPaladinBuffsBlockSix.enabled = false;
            }

            else if (whiteMagicArrowsBuffsNumber == 5)
            {
                whiteMagicPaladinBuffsBlockOne.enabled = false;
                whiteMagicPaladinBuffsBlockTwo.enabled = false;
                whiteMagicPaladinBuffsBlockThree.enabled = false;
                whiteMagicPaladinBuffsBlockFour.enabled = false;
                whiteMagicPaladinBuffsBlockFive.enabled = true;
                whiteMagicPaladinBuffsBlockSix.enabled = false;
            }

            else if (whiteMagicArrowsBuffsNumber == 6)
            {
                whiteMagicPaladinBuffsBlockOne.enabled = false;
                whiteMagicPaladinBuffsBlockTwo.enabled = false;
                whiteMagicPaladinBuffsBlockThree.enabled = false;
                whiteMagicPaladinBuffsBlockFour.enabled = false;
                whiteMagicPaladinBuffsBlockFive.enabled = false;
                whiteMagicPaladinBuffsBlockSix.enabled = true;
            }
        }



        if (whiteMagicArrowsDebuffs)
        {
            whiteMagicArrowsDebuffsNumber += 1;

            if (whiteMagicArrowsDebuffsNumber >= 7)
            {
                whiteMagicArrowsDebuffsNumber = 1;
            }

            if (whiteMagicArrowsDebuffsNumber == 1)
            {
                whiteMagicPaladinDebuffsBlockOne.enabled = true;
                whiteMagicPaladinDebuffsBlockTwo.enabled = false;
                whiteMagicPaladinDebuffsBlockThree.enabled = false;
                whiteMagicPaladinDebuffsBlockFour.enabled = false;
                whiteMagicPaladinDebuffsBlockFive.enabled = false;
                whiteMagicPaladinDebuffsBlockSix.enabled = false;
            }

            else if (whiteMagicArrowsDebuffsNumber == 2)
            {
                whiteMagicPaladinDebuffsBlockOne.enabled = false;
                whiteMagicPaladinDebuffsBlockTwo.enabled = true;
                whiteMagicPaladinDebuffsBlockThree.enabled = false;
                whiteMagicPaladinDebuffsBlockFour.enabled = false;
                whiteMagicPaladinDebuffsBlockFive.enabled = false;
                whiteMagicPaladinDebuffsBlockSix.enabled = false;
            }

            else if (whiteMagicArrowsDebuffsNumber == 3)
            {
                whiteMagicPaladinDebuffsBlockOne.enabled = false;
                whiteMagicPaladinDebuffsBlockTwo.enabled = false;
                whiteMagicPaladinDebuffsBlockThree.enabled = true;
                whiteMagicPaladinDebuffsBlockFour.enabled = false;
                whiteMagicPaladinDebuffsBlockFive.enabled = false;
                whiteMagicPaladinDebuffsBlockSix.enabled = false;
            }

            else if (whiteMagicArrowsDebuffsNumber == 4)
            {
                whiteMagicPaladinDebuffsBlockOne.enabled = false;
                whiteMagicPaladinDebuffsBlockTwo.enabled = false;
                whiteMagicPaladinDebuffsBlockThree.enabled = false;
                whiteMagicPaladinDebuffsBlockFour.enabled = true;
                whiteMagicPaladinDebuffsBlockFive.enabled = false;
                whiteMagicPaladinDebuffsBlockSix.enabled = false;
            }

            else if (whiteMagicArrowsDebuffsNumber == 5)
            {
                whiteMagicPaladinDebuffsBlockOne.enabled = false;
                whiteMagicPaladinDebuffsBlockTwo.enabled = false;
                whiteMagicPaladinDebuffsBlockThree.enabled = false;
                whiteMagicPaladinDebuffsBlockFour.enabled = false;
                whiteMagicPaladinDebuffsBlockFive.enabled = true;
                whiteMagicPaladinDebuffsBlockSix.enabled = false;
            }

            else if (whiteMagicArrowsDebuffsNumber == 6)
            {
                whiteMagicPaladinDebuffsBlockOne.enabled = false;
                whiteMagicPaladinDebuffsBlockTwo.enabled = false;
                whiteMagicPaladinDebuffsBlockThree.enabled = false;
                whiteMagicPaladinDebuffsBlockFour.enabled = false;
                whiteMagicPaladinDebuffsBlockFive.enabled = false;
                whiteMagicPaladinDebuffsBlockSix.enabled = true;
            }
        }


        if (blackMagicArrowsOffensive)
        {
            blackMagicArrowsOffensiveNumber += 1;

            if (blackMagicArrowsOffensiveNumber >= 7)
            {
                blackMagicArrowsOffensiveNumber = 1;
            }

            if (blackMagicArrowsOffensiveNumber == 1)
            {
                blackMagicWizardOffensiveBlockOne.enabled = true;
                blackMagicWizardOffensiveBlockTwo.enabled = false;
                blackMagicWizardOffensiveBlockThree.enabled = false;
                blackMagicWizardOffensiveBlockFour.enabled = false;
                blackMagicWizardOffensiveBlockFive.enabled = false;
                blackMagicWizardOffensiveBlockSix.enabled = false;
            }

            else if (blackMagicArrowsOffensiveNumber == 2)
            {
                blackMagicWizardOffensiveBlockOne.enabled = false;
                blackMagicWizardOffensiveBlockTwo.enabled = true;
                blackMagicWizardOffensiveBlockThree.enabled = false;
                blackMagicWizardOffensiveBlockFour.enabled = false;
                blackMagicWizardOffensiveBlockFive.enabled = false;
                blackMagicWizardOffensiveBlockSix.enabled = false;
            }

            else if (blackMagicArrowsOffensiveNumber == 3)
            {
                blackMagicWizardOffensiveBlockOne.enabled = false;
                blackMagicWizardOffensiveBlockTwo.enabled = false;
                blackMagicWizardOffensiveBlockThree.enabled = true;
                blackMagicWizardOffensiveBlockFour.enabled = false;
                blackMagicWizardOffensiveBlockFive.enabled = false;
                blackMagicWizardOffensiveBlockSix.enabled = false;
            }

            else if (blackMagicArrowsOffensiveNumber == 4)
            {
                blackMagicWizardOffensiveBlockOne.enabled = false;
                blackMagicWizardOffensiveBlockTwo.enabled = false;
                blackMagicWizardOffensiveBlockThree.enabled = false;
                blackMagicWizardOffensiveBlockFour.enabled = true;
                blackMagicWizardOffensiveBlockFive.enabled = false;
                blackMagicWizardOffensiveBlockSix.enabled = false;
            }

            else if (blackMagicArrowsOffensiveNumber == 5)
            {
                blackMagicWizardOffensiveBlockOne.enabled = false;
                blackMagicWizardOffensiveBlockTwo.enabled = false;
                blackMagicWizardOffensiveBlockThree.enabled = false;
                blackMagicWizardOffensiveBlockFour.enabled = false;
                blackMagicWizardOffensiveBlockFive.enabled = true;
                blackMagicWizardOffensiveBlockSix.enabled = false;
            }

            else if (blackMagicArrowsOffensiveNumber == 6)
            {
                blackMagicWizardOffensiveBlockOne.enabled = false;
                blackMagicWizardOffensiveBlockTwo.enabled = false;
                blackMagicWizardOffensiveBlockThree.enabled = false;
                blackMagicWizardOffensiveBlockFour.enabled = false;
                blackMagicWizardOffensiveBlockFive.enabled = false;
                blackMagicWizardOffensiveBlockSix.enabled = true;
            }
        }



        if (blackMagicArrowsEffects)
        {
            blackMagicArrowsEffectsNumber += 1;

            if (blackMagicArrowsEffectsNumber >= 5)
            {
                blackMagicArrowsEffectsNumber = 1;
            }

            if (blackMagicArrowsEffectsNumber == 1)
            {
                blackMagicWizardEffectsBlockOne.enabled = true;
                blackMagicWizardEffectsBlockTwo.enabled = false;
                blackMagicWizardEffectsBlockThree.enabled = false;
                blackMagicWizardEffectsBlockFour.enabled = false;
            }

            else if (blackMagicArrowsEffectsNumber == 2)
            {
                blackMagicWizardEffectsBlockOne.enabled = false;
                blackMagicWizardEffectsBlockTwo.enabled = true;
                blackMagicWizardEffectsBlockThree.enabled = false;
                blackMagicWizardEffectsBlockFour.enabled = false;
            }

            else if (blackMagicArrowsEffectsNumber == 3)
            {
                blackMagicWizardEffectsBlockOne.enabled = false;
                blackMagicWizardEffectsBlockTwo.enabled = false;
                blackMagicWizardEffectsBlockThree.enabled = true;
                blackMagicWizardEffectsBlockFour.enabled = false;
            }

            else if (blackMagicArrowsEffectsNumber == 4)
            {
                blackMagicWizardEffectsBlockOne.enabled = false;
                blackMagicWizardEffectsBlockTwo.enabled = false;
                blackMagicWizardEffectsBlockThree.enabled = false;
                blackMagicWizardEffectsBlockFour.enabled = true;
            }
        }        
    }


    public void LeftArrowAction()
    {
        if (actionArrowsPaladin)
        {
            actionArrowNumber -= 1;

            if (actionArrowNumber <= 0)
            {
                actionArrowNumber = 5;
            }

            if (actionArrowNumber == 1)
            {
                actionAttackPaladinButton.enabled = true;
                actionWhiteMagicPaladinButton.enabled = false;
                actionSpecialPaladinButton.enabled = false;
                actionItemPaladinButton.enabled = false;
                actionEscapePaladinButton.enabled = false;
            }

            else if (actionArrowNumber == 2)
            {
                actionAttackPaladinButton.enabled = false;
                actionWhiteMagicPaladinButton.enabled = true;
                actionSpecialPaladinButton.enabled = false;
                actionItemPaladinButton.enabled = false;
                actionEscapePaladinButton.enabled = false;
            }

            else if (actionArrowNumber == 3)
            {
                actionAttackPaladinButton.enabled = false;
                actionWhiteMagicPaladinButton.enabled = false;
                actionSpecialPaladinButton.enabled = true;
                actionItemPaladinButton.enabled = false;
                actionEscapePaladinButton.enabled = false;
            }

            else if (actionArrowNumber == 4)
            {
                actionAttackPaladinButton.enabled = false;
                actionWhiteMagicPaladinButton.enabled = false;
                actionSpecialPaladinButton.enabled = false;
                actionItemPaladinButton.enabled = true;
                actionEscapePaladinButton.enabled = false;
            }

            else if (actionArrowNumber == 5)
            {
                actionAttackPaladinButton.enabled = false;
                actionWhiteMagicPaladinButton.enabled = false;
                actionSpecialPaladinButton.enabled = false;
                actionItemPaladinButton.enabled = false;
                actionEscapePaladinButton.enabled = true;
            }
        }



        if (actionArrowsWizard)
        {
            actionArrowNumber -= 1;

            if (actionArrowNumber <= 0)
            {
                actionArrowNumber = 5;
            }

            if (actionArrowNumber == 1)
            {
                actionAttackWizardButton.enabled = true;
                actionBlackMagicWizardButton.enabled = false;
                actionSpecialWizardButton.enabled = false;
                actionItemWizardButton.enabled = false;
                actionEscapeWizardButton.enabled = false;
            }

            else if (actionArrowNumber == 2)
            {
                actionAttackWizardButton.enabled = false;
                actionBlackMagicWizardButton.enabled = true;
                actionSpecialWizardButton.enabled = false;               
                actionItemWizardButton.enabled = false;
                actionEscapeWizardButton.enabled = false;
            }

            else if (actionArrowNumber == 3)
            {
                actionAttackWizardButton.enabled = false;
                actionBlackMagicWizardButton.enabled = false;
                actionSpecialWizardButton.enabled = true;
                actionItemWizardButton.enabled = false;
                actionEscapeWizardButton.enabled = false;
            }

            else if (actionArrowNumber == 4)
            {
                actionAttackWizardButton.enabled = false;
                actionBlackMagicWizardButton.enabled = false;
                actionSpecialWizardButton.enabled = false;
                actionItemWizardButton.enabled = true;
                actionEscapeWizardButton.enabled = false;
            }

            else if (actionArrowNumber == 5)
            {
                actionAttackWizardButton.enabled = false;
                actionBlackMagicWizardButton.enabled = false;
                actionSpecialWizardButton.enabled = false;
                actionItemWizardButton.enabled = false;
                actionEscapeWizardButton.enabled = true;
            }
        }


        if (whiteMagicArrowsBuffs)
        {
            whiteMagicArrowsBuffsNumber -= 1;

            if (whiteMagicArrowsBuffsNumber <= 0)
            {
                whiteMagicArrowsBuffsNumber = 6;
            }

            if (whiteMagicArrowsBuffsNumber == 1)
            {
                whiteMagicPaladinBuffsBlockOne.enabled = true;
                whiteMagicPaladinBuffsBlockTwo.enabled = false;
                whiteMagicPaladinBuffsBlockThree.enabled = false;
                whiteMagicPaladinBuffsBlockFour.enabled = false;
                whiteMagicPaladinBuffsBlockFive.enabled = false;
                whiteMagicPaladinBuffsBlockSix.enabled = false;
            }

            else if (whiteMagicArrowsBuffsNumber == 2)
            {
                whiteMagicPaladinBuffsBlockOne.enabled = false;
                whiteMagicPaladinBuffsBlockTwo.enabled = true;
                whiteMagicPaladinBuffsBlockThree.enabled = false;
                whiteMagicPaladinBuffsBlockFour.enabled = false;
                whiteMagicPaladinBuffsBlockFive.enabled = false;
                whiteMagicPaladinBuffsBlockSix.enabled = false;
            }

            else if (whiteMagicArrowsBuffsNumber == 3)
            {
                whiteMagicPaladinBuffsBlockOne.enabled = false;
                whiteMagicPaladinBuffsBlockTwo.enabled = false;
                whiteMagicPaladinBuffsBlockThree.enabled = true;
                whiteMagicPaladinBuffsBlockFour.enabled = false;
                whiteMagicPaladinBuffsBlockFive.enabled = false;
                whiteMagicPaladinBuffsBlockSix.enabled = false;
            }

            else if (whiteMagicArrowsBuffsNumber == 4)
            {
                whiteMagicPaladinBuffsBlockOne.enabled = false;
                whiteMagicPaladinBuffsBlockTwo.enabled = false;
                whiteMagicPaladinBuffsBlockThree.enabled = false;
                whiteMagicPaladinBuffsBlockFour.enabled = true;
                whiteMagicPaladinBuffsBlockFive.enabled = false;
                whiteMagicPaladinBuffsBlockSix.enabled = false;
            }

            else if (whiteMagicArrowsBuffsNumber == 5)
            {
                whiteMagicPaladinBuffsBlockOne.enabled = false;
                whiteMagicPaladinBuffsBlockTwo.enabled = false;
                whiteMagicPaladinBuffsBlockThree.enabled = false;
                whiteMagicPaladinBuffsBlockFour.enabled = false;
                whiteMagicPaladinBuffsBlockFive.enabled = true;
                whiteMagicPaladinBuffsBlockSix.enabled = false;
            }

            else if (whiteMagicArrowsBuffsNumber == 6)
            {
                whiteMagicPaladinBuffsBlockOne.enabled = false;
                whiteMagicPaladinBuffsBlockTwo.enabled = false;
                whiteMagicPaladinBuffsBlockThree.enabled = false;
                whiteMagicPaladinBuffsBlockFour.enabled = false;
                whiteMagicPaladinBuffsBlockFive.enabled = false;
                whiteMagicPaladinBuffsBlockSix.enabled = true;
            }
        }


        if (whiteMagicArrowsDebuffs)
        {
            whiteMagicArrowsDebuffsNumber -= 1;

            if (whiteMagicArrowsDebuffsNumber <= 0)
            {
                whiteMagicArrowsDebuffsNumber = 6;
            }

            if (whiteMagicArrowsDebuffsNumber == 1)
            {
                whiteMagicPaladinDebuffsBlockOne.enabled = true;
                whiteMagicPaladinDebuffsBlockTwo.enabled = false;
                whiteMagicPaladinDebuffsBlockThree.enabled = false;
                whiteMagicPaladinDebuffsBlockFour.enabled = false;
                whiteMagicPaladinDebuffsBlockFive.enabled = false;
                whiteMagicPaladinDebuffsBlockSix.enabled = false;
            }

            else if (whiteMagicArrowsDebuffsNumber == 2)
            {
                whiteMagicPaladinDebuffsBlockOne.enabled = false;
                whiteMagicPaladinDebuffsBlockTwo.enabled = true;
                whiteMagicPaladinDebuffsBlockThree.enabled = false;
                whiteMagicPaladinDebuffsBlockFour.enabled = false;
                whiteMagicPaladinDebuffsBlockFive.enabled = false;
                whiteMagicPaladinDebuffsBlockSix.enabled = false;
            }

            else if (whiteMagicArrowsDebuffsNumber == 3)
            {
                whiteMagicPaladinDebuffsBlockOne.enabled = false;
                whiteMagicPaladinDebuffsBlockTwo.enabled = false;
                whiteMagicPaladinDebuffsBlockThree.enabled = true;
                whiteMagicPaladinDebuffsBlockFour.enabled = false;
                whiteMagicPaladinDebuffsBlockFive.enabled = false;
                whiteMagicPaladinDebuffsBlockSix.enabled = false;
            }

            else if (whiteMagicArrowsDebuffsNumber == 4)
            {
                whiteMagicPaladinDebuffsBlockOne.enabled = false;
                whiteMagicPaladinDebuffsBlockTwo.enabled = false;
                whiteMagicPaladinDebuffsBlockThree.enabled = false;
                whiteMagicPaladinDebuffsBlockFour.enabled = true;
                whiteMagicPaladinDebuffsBlockFive.enabled = false;
                whiteMagicPaladinDebuffsBlockSix.enabled = false;
            }

            else if (whiteMagicArrowsDebuffsNumber == 5)
            {
                whiteMagicPaladinDebuffsBlockOne.enabled = false;
                whiteMagicPaladinDebuffsBlockTwo.enabled = false;
                whiteMagicPaladinDebuffsBlockThree.enabled = false;
                whiteMagicPaladinDebuffsBlockFour.enabled = false;
                whiteMagicPaladinDebuffsBlockFive.enabled = true;
                whiteMagicPaladinDebuffsBlockSix.enabled = false;
            }

            else if (whiteMagicArrowsDebuffsNumber == 6)
            {
                whiteMagicPaladinDebuffsBlockOne.enabled = false;
                whiteMagicPaladinDebuffsBlockTwo.enabled = false;
                whiteMagicPaladinDebuffsBlockThree.enabled = false;
                whiteMagicPaladinDebuffsBlockFour.enabled = false;
                whiteMagicPaladinDebuffsBlockFive.enabled = false;
                whiteMagicPaladinDebuffsBlockSix.enabled = true;
            }
        }


        if (blackMagicArrowsOffensive)
        {
            blackMagicArrowsOffensiveNumber -= 1;

            if (blackMagicArrowsOffensiveNumber <= 0)
            {
                blackMagicArrowsOffensiveNumber = 6;
            }

            if (blackMagicArrowsOffensiveNumber == 1)
            {
                blackMagicWizardOffensiveBlockOne.enabled = true;
                blackMagicWizardOffensiveBlockTwo.enabled = false;
                blackMagicWizardOffensiveBlockThree.enabled = false;
                blackMagicWizardOffensiveBlockFour.enabled = false;
                blackMagicWizardOffensiveBlockFive.enabled = false;
                blackMagicWizardOffensiveBlockSix.enabled = false;
            }

            else if (blackMagicArrowsOffensiveNumber == 2)
            {
                blackMagicWizardOffensiveBlockOne.enabled = false;
                blackMagicWizardOffensiveBlockTwo.enabled = true;
                blackMagicWizardOffensiveBlockThree.enabled = false;
                blackMagicWizardOffensiveBlockFour.enabled = false;
                blackMagicWizardOffensiveBlockFive.enabled = false;
                blackMagicWizardOffensiveBlockSix.enabled = false;
            }

            else if (blackMagicArrowsOffensiveNumber == 3)
            {
                blackMagicWizardOffensiveBlockOne.enabled = false;
                blackMagicWizardOffensiveBlockTwo.enabled = false;
                blackMagicWizardOffensiveBlockThree.enabled = true;
                blackMagicWizardOffensiveBlockFour.enabled = false;
                blackMagicWizardOffensiveBlockFive.enabled = false;
                blackMagicWizardOffensiveBlockSix.enabled = false;
            }

            else if (blackMagicArrowsOffensiveNumber == 4)
            {
                blackMagicWizardOffensiveBlockOne.enabled = false;
                blackMagicWizardOffensiveBlockTwo.enabled = false;
                blackMagicWizardOffensiveBlockThree.enabled = false;
                blackMagicWizardOffensiveBlockFour.enabled = true;
                blackMagicWizardOffensiveBlockFive.enabled = false;
                blackMagicWizardOffensiveBlockSix.enabled = false;
            }

            else if (blackMagicArrowsOffensiveNumber == 5)
            {
                blackMagicWizardOffensiveBlockOne.enabled = false;
                blackMagicWizardOffensiveBlockTwo.enabled = false;
                blackMagicWizardOffensiveBlockThree.enabled = false;
                blackMagicWizardOffensiveBlockFour.enabled = false;
                blackMagicWizardOffensiveBlockFive.enabled = true;
                blackMagicWizardOffensiveBlockSix.enabled = false;
            }

            else if (blackMagicArrowsOffensiveNumber == 6)
            {
                blackMagicWizardOffensiveBlockOne.enabled = false;
                blackMagicWizardOffensiveBlockTwo.enabled = false;
                blackMagicWizardOffensiveBlockThree.enabled = false;
                blackMagicWizardOffensiveBlockFour.enabled = false;
                blackMagicWizardOffensiveBlockFive.enabled = false;
                blackMagicWizardOffensiveBlockSix.enabled = true;
            }
        }



        if (blackMagicArrowsEffects)
        {
            blackMagicArrowsEffectsNumber -= 1;

            if (blackMagicArrowsEffectsNumber <= 0)
            {
                blackMagicArrowsEffectsNumber = 4;
            }

            if (blackMagicArrowsEffectsNumber == 1)
            {
                blackMagicWizardEffectsBlockOne.enabled = true;
                blackMagicWizardEffectsBlockTwo.enabled = false;
                blackMagicWizardEffectsBlockThree.enabled = false;
                blackMagicWizardEffectsBlockFour.enabled = false;
            }

            else if (blackMagicArrowsEffectsNumber == 2)
            {
                blackMagicWizardEffectsBlockOne.enabled = false;
                blackMagicWizardEffectsBlockTwo.enabled = true;
                blackMagicWizardEffectsBlockThree.enabled = false;
                blackMagicWizardEffectsBlockFour.enabled = false;
            }

            else if (blackMagicArrowsEffectsNumber == 3)
            {
                blackMagicWizardEffectsBlockOne.enabled = false;
                blackMagicWizardEffectsBlockTwo.enabled = false;
                blackMagicWizardEffectsBlockThree.enabled = true;
                blackMagicWizardEffectsBlockFour.enabled = false;
            }

            else if (blackMagicArrowsEffectsNumber == 4)
            {
                blackMagicWizardEffectsBlockOne.enabled = false;
                blackMagicWizardEffectsBlockTwo.enabled = false;
                blackMagicWizardEffectsBlockThree.enabled = false;
                blackMagicWizardEffectsBlockFour.enabled = true;
            }
        }
    }



    private void OnDisable()
    {

    }
}
