using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControllerWizard : MonoBehaviour
{
    bool onMoving;

    int gridInitialPosition;
    int gridFinalPosition;

    public GridController gridController;
    public Wizard wizard;

    public Canvas canvasGridWizardOne;
    public Canvas canvasGridWizardTwo;
    public Canvas canvasGridWizardThree;
    public Canvas canvasGridWizardFour;

    public GlobalController globalController;



    private void Update()
    {
        if (onMoving)
        {
            OnMoving();
        }
    }


    public void OnClickMove()
    {
        globalController.wizardUsingMove = true;
        globalController.wizardTurnPointer.enabled = false;

        globalController.canChangeCharacters = false;
        globalController.DisableChangeButtons();


        if (gridController.gridOneWizardLocationOne)
        {
            if (!gridController.gridTwoEnemyLocationOne && !gridController.gridTwoEnemyLocationTwo
                && !gridController.gridTwoEnemyLocationThree)
            {
                gridInitialPosition = 1;
                canvasGridWizardTwo.enabled = true;
            }

            if (!gridController.gridTwoEnemyLocationOne && !gridController.gridTwoEnemyLocationTwo
                && gridController.gridTwoEnemyLocationThree &&
                !gridController.gridThreeEnemyLocationOne && !gridController.gridThreeEnemyLocationTwo
                && !gridController.gridThreeEnemyLocationThree)
            {
                gridInitialPosition = 1;
                canvasGridWizardThree.enabled = true;
            }
        }

        else if (gridController.gridTwoWizardLocationOne)
        {
            if (!gridController.gridOneEnemyLocationOne && !gridController.gridOneEnemyLocationTwo
                && !gridController.gridOneEnemyLocationThree)
            {
                gridInitialPosition = 2;
                canvasGridWizardOne.enabled = true;
            }

            if (!gridController.gridThreeEnemyLocationOne && !gridController.gridThreeEnemyLocationTwo
                && !gridController.gridThreeEnemyLocationThree)
            {
                gridInitialPosition = 2;
                canvasGridWizardThree.enabled = true;
            }

            if (!gridController.gridThreeEnemyLocationOne && !gridController.gridThreeEnemyLocationTwo
            && gridController.gridThreeEnemyLocationThree &&
               !gridController.gridFourEnemyLocationOne && !gridController.gridFourEnemyLocationTwo
                && !gridController.gridFourEnemyLocationThree)
            {
                gridInitialPosition = 2;
                canvasGridWizardFour.enabled = true;
            }
        }

        else if (gridController.gridThreeWizardLocationOne)
        {
            if (!gridController.gridTwoEnemyLocationOne && !gridController.gridTwoEnemyLocationTwo
                && !gridController.gridTwoEnemyLocationThree)
            {
                gridInitialPosition = 3;
                canvasGridWizardTwo.enabled = true;
            }

            if (!gridController.gridFourEnemyLocationOne && !gridController.gridFourEnemyLocationTwo
                && !gridController.gridFourEnemyLocationThree)
            {
                gridInitialPosition = 3;
                canvasGridWizardFour.enabled = true;
            }

            if (!gridController.gridTwoEnemyLocationOne && !gridController.gridTwoEnemyLocationTwo
                && gridController.gridTwoEnemyLocationThree &&
                !gridController.gridOneEnemyLocationOne && !gridController.gridOneEnemyLocationTwo
                && !gridController.gridOneEnemyLocationThree)
            {
                gridInitialPosition = 3;
                canvasGridWizardOne.enabled = true;
            }
        }

        else if (gridController.gridFourWizardLocationOne)
        {
            if (!gridController.gridThreeEnemyLocationOne && !gridController.gridThreeEnemyLocationTwo
                && !gridController.gridThreeEnemyLocationThree)
            {
                gridInitialPosition = 4;
                canvasGridWizardThree.enabled = true;
            }

            if (!gridController.gridThreeEnemyLocationOne && !gridController.gridThreeEnemyLocationTwo
                && gridController.gridThreeEnemyLocationThree &&
                !gridController.gridTwoEnemyLocationOne && !gridController.gridTwoEnemyLocationTwo
                && !gridController.gridTwoEnemyLocationThree)
            {
                gridInitialPosition = 4;
                canvasGridWizardTwo.enabled = true;
            }
        }

        globalController.wizardUsingMove = false;
    }


    public void OnCancelMove()
    {
        globalController.wizardUsingMove = false;
        globalController.wizardTurnPointer.enabled = true;

        globalController.canChangeCharacters = true;
        globalController.EnableChangeButtons();

        canvasGridWizardOne.enabled = false;
        canvasGridWizardTwo.enabled = false;
        canvasGridWizardThree.enabled = false;
        canvasGridWizardFour.enabled = false;
    }


    public void OnClickMoveToOne()
    {
        if (globalController.paladinUsingAnAction || globalController.wizardUsingAnAction || globalController.enemyUsingAnAction)
        {
            Debug.Log("Someone is using an action");
            return;
        }

        if (gridInitialPosition == 2 || gridInitialPosition == 3 || gridInitialPosition == 4)
        {
            wizard.FlipCharacterToTheLeft();
            gridFinalPosition = 1;
        }


        wizard.gridPosition = gridController.gridOneWizardLocationOnePosition;
        wizard.moveToGrid = true;

        globalController.wizardUsingMove = false;
        globalController.wizardUsingAnAction = true;
        globalController.wizardIsReady = false;

        gridController.gridOneWizardLocationOne = true;
        gridController.gridTwoWizardLocationOne = false;
        gridController.gridThreeWizardLocationOne = false;
        gridController.gridFourWizardLocationOne = false;

        OnCancelMove();

        onMoving = true;
    }

    public void OnClickMoveToTwo()
    {
        if (globalController.paladinUsingAnAction || globalController.wizardUsingAnAction || globalController.enemyUsingAnAction)
        {
            Debug.Log("Someone is using an action");
            return;
        }

        if (gridInitialPosition == 1)
        {
            wizard.FlipCharacterToTheRight();
            gridFinalPosition = 2;
        }

        else if (gridInitialPosition == 3 || gridInitialPosition == 4)
        {
            wizard.FlipCharacterToTheLeft();
            gridFinalPosition = 2;
        }


        wizard.gridPosition = gridController.gridTwoWizardLocationOnePosition;
        wizard.moveToGrid = true;

        globalController.wizardUsingMove = false;
        globalController.wizardUsingAnAction = true;
        globalController.wizardIsReady = false;

        gridController.gridOneWizardLocationOne = false;
        gridController.gridTwoWizardLocationOne = true;
        gridController.gridThreeWizardLocationOne = false;
        gridController.gridFourWizardLocationOne = false;

        OnCancelMove();

        onMoving = true;
    }

    public void OnClickMoveToThree()
    {
        if (globalController.paladinUsingAnAction || globalController.wizardUsingAnAction || globalController.enemyUsingAnAction)
        {
            Debug.Log("Someone is using an action");
            return;
        }

        if (gridInitialPosition == 1 || gridInitialPosition == 2)
        {
            wizard.FlipCharacterToTheRight();
            gridFinalPosition = 3;
        }

        else if (gridInitialPosition == 4)
        {
            wizard.FlipCharacterToTheLeft();
            gridFinalPosition = 3;
        }

        wizard.gridPosition = gridController.gridThreeWizardLocationOnePosition;
        wizard.moveToGrid = true;

        globalController.wizardUsingMove = false;
        globalController.wizardUsingAnAction = true;
        globalController.wizardIsReady = false;

        gridController.gridOneWizardLocationOne = false;
        gridController.gridTwoWizardLocationOne = false;
        gridController.gridThreeWizardLocationOne = true;
        gridController.gridFourWizardLocationOne = false;

        OnCancelMove();

        onMoving = true;
    }

    public void OnClickMoveToFour()
    {
        if (globalController.paladinUsingAnAction || globalController.wizardUsingAnAction || globalController.enemyUsingAnAction)
        {
            Debug.Log("Someone is using an action");
            return;
        }

        if (gridInitialPosition == 1 || gridInitialPosition == 2 || gridInitialPosition == 3)
        {
            wizard.FlipCharacterToTheRight();
            gridFinalPosition = 4;
        }

        wizard.gridPosition = gridController.gridFourWizardLocationOnePosition;
        wizard.moveToGrid = true;

        globalController.wizardUsingMove = false;
        globalController.wizardUsingAnAction = true;
        globalController.wizardIsReady = false;

        gridController.gridOneWizardLocationOne = false;
        gridController.gridTwoWizardLocationOne = false;
        gridController.gridThreeWizardLocationOne = false;
        gridController.gridFourWizardLocationOne = true;

        OnCancelMove();

        onMoving = true;
    }

    void OnMoving()
    {
        if (wizard.moveToGridAtGrid)
        {
            wizard.moveToGridAtGrid = false;
            globalController.wizardUsingAnAction = false;
            globalController.isCharacterSelect = false;

            wizard.StartOverSpeedBar();

            globalController.CharactersAreReady();

            globalController.canChangeCharacters = true;
            globalController.EnableChangeButtons();

            globalController.RestartAllSpeedTime();

            onMoving = false;

            if (gridFinalPosition == 1) { wizard.FlipCharacterToTheRight(); return; }

            else if (gridFinalPosition == 2)
            {
                if (gridController.gridOneEnemyLocationOne || gridController.gridOneEnemyLocationTwo ||
                    gridController.gridOneEnemyLocationThree)
                {
                    wizard.FlipCharacterToTheLeft();
                    return;
                }

                else if (!gridController.gridOneEnemyLocationOne && !gridController.gridOneEnemyLocationTwo &&
                         !gridController.gridOneEnemyLocationThree)
                {
                    wizard.FlipCharacterToTheRight();
                    return;
                }
            }

            else if (gridFinalPosition == 3)
            {
                if (gridController.gridFourEnemyLocationOne || gridController.gridFourEnemyLocationTwo ||
                    gridController.gridFourEnemyLocationThree)
                {
                    wizard.FlipCharacterToTheRight();
                    return;
                }

                else if (!gridController.gridFourEnemyLocationOne && !gridController.gridFourEnemyLocationTwo &&
                         !gridController.gridFourEnemyLocationThree)
                {
                    wizard.FlipCharacterToTheLeft();
                    return;
                }
            }

            else if (gridFinalPosition == 4) { wizard.FlipCharacterToTheLeft(); return; }

        }

        else if (!wizard.moveToGridAtGrid)
        {
            globalController.StopAllSpeedTime();
            globalController.WaitingPosition();
        }
    }



}
