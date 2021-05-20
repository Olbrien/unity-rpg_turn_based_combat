using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControllerPaladin : MonoBehaviour
{
    bool onMoving;

    int gridInitialPosition;
    int gridFinalPosition;


    public GridController gridController;
    public Paladin paladin;

    public Canvas canvasGridPaladinOne;
    public Canvas canvasGridPaladinTwo;
    public Canvas canvasGridPaladinThree;
    public Canvas canvasGridPaladinFour;

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
        globalController.paladinUsingMove = true;
        globalController.paladinTurnPointer.enabled = false;

        globalController.canChangeCharacters = false;
        globalController.DisableChangeButtons();


        if (gridController.gridOnePaladinLocationOne)
        {
            if (!gridController.gridTwoEnemyLocationOne && !gridController.gridTwoEnemyLocationTwo 
                && !gridController.gridTwoEnemyLocationThree)
            {
                gridInitialPosition = 1;
                canvasGridPaladinTwo.enabled = true;
            }

            if (gridController.gridTwoEnemyLocationOne && !gridController.gridTwoEnemyLocationTwo
                && !gridController.gridTwoEnemyLocationThree && 
                !gridController.gridThreeEnemyLocationOne && !gridController.gridThreeEnemyLocationTwo
                && !gridController.gridThreeEnemyLocationThree)
            {
                gridInitialPosition = 1;
                canvasGridPaladinThree.enabled = true;
            }
        }



        else if (gridController.gridTwoPaladinLocationOne)
        {
            if (!gridController.gridOneEnemyLocationOne && !gridController.gridOneEnemyLocationTwo
                && !gridController.gridOneEnemyLocationThree)
            {
                gridInitialPosition = 2;
                canvasGridPaladinOne.enabled = true;
            }

            if (!gridController.gridThreeEnemyLocationOne && !gridController.gridThreeEnemyLocationTwo
                && !gridController.gridThreeEnemyLocationThree)
            {
                gridInitialPosition = 2;
                canvasGridPaladinThree.enabled = true;
            }

            if (gridController.gridThreeEnemyLocationOne && !gridController.gridThreeEnemyLocationTwo
            && !gridController.gridThreeEnemyLocationThree &&
               !gridController.gridFourEnemyLocationOne && !gridController.gridFourEnemyLocationTwo
                && !gridController.gridFourEnemyLocationThree)
            {
                gridInitialPosition = 2;
                canvasGridPaladinFour.enabled = true;
            }
        }

        else if (gridController.gridThreePaladinLocationOne)
        {
            if (!gridController.gridTwoEnemyLocationOne && !gridController.gridTwoEnemyLocationTwo
                && !gridController.gridTwoEnemyLocationThree)
            {
                gridInitialPosition = 3;
                canvasGridPaladinTwo.enabled = true;
            }

            if (!gridController.gridFourEnemyLocationOne && !gridController.gridFourEnemyLocationTwo
                && !gridController.gridFourEnemyLocationThree)
            {
                gridInitialPosition = 3;
                canvasGridPaladinFour.enabled = true;
            }

            if (gridController.gridTwoEnemyLocationOne && !gridController.gridTwoEnemyLocationTwo
                && !gridController.gridTwoEnemyLocationThree && 
                !gridController.gridOneEnemyLocationOne && !gridController.gridOneEnemyLocationTwo
                && !gridController.gridOneEnemyLocationThree)
            {
                gridInitialPosition = 3;
                canvasGridPaladinOne.enabled = true;
            }
        }

        else if (gridController.gridFourPaladinLocationOne)
        {
            if (!gridController.gridThreeEnemyLocationOne && !gridController.gridThreeEnemyLocationTwo
                && !gridController.gridThreeEnemyLocationThree)
            {
                gridInitialPosition = 4;
                canvasGridPaladinThree.enabled = true;
            }

            if (gridController.gridThreeEnemyLocationOne && !gridController.gridThreeEnemyLocationTwo
                && !gridController.gridThreeEnemyLocationThree &&
                !gridController.gridTwoEnemyLocationOne && !gridController.gridTwoEnemyLocationTwo
                && !gridController.gridTwoEnemyLocationThree)
            {
                gridInitialPosition = 4;
                canvasGridPaladinTwo.enabled = true;
            }
        }

        globalController.paladinUsingMove = false;
    }


    public void OnCancelMove()
    {
        globalController.paladinUsingMove = false;
        globalController.paladinTurnPointer.enabled = true;

        globalController.canChangeCharacters = true;
        globalController.EnableChangeButtons();

        canvasGridPaladinOne.enabled = false;
        canvasGridPaladinTwo.enabled = false;
        canvasGridPaladinThree.enabled = false;
        canvasGridPaladinFour.enabled = false;
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
            paladin.FlipCharacterToTheLeft();
            gridFinalPosition = 1;
        }


        paladin.gridPosition = gridController.gridOnePaladinLocationOnePosition;
        paladin.moveToGrid = true;

        globalController.paladinUsingMove = false;
        globalController.paladinUsingAnAction = true;
        globalController.paladinIsReady = false;

        gridController.gridOnePaladinLocationOne = true;
        gridController.gridTwoPaladinLocationOne = false;
        gridController.gridThreePaladinLocationOne = false;
        gridController.gridFourPaladinLocationOne = false;

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
            paladin.FlipCharacterToTheRight();
            gridFinalPosition = 2;
        }

        else if (gridInitialPosition == 3 || gridInitialPosition == 4)
        {
            paladin.FlipCharacterToTheLeft();
            gridFinalPosition = 2;
        }


        paladin.gridPosition = gridController.gridTwoPaladinLocationOnePosition;
        paladin.moveToGrid = true;

        globalController.paladinUsingMove = false;
        globalController.paladinUsingAnAction = true;
        globalController.paladinIsReady = false;

        gridController.gridOnePaladinLocationOne = false;
        gridController.gridTwoPaladinLocationOne = true;
        gridController.gridThreePaladinLocationOne = false;
        gridController.gridFourPaladinLocationOne = false;

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
            paladin.FlipCharacterToTheRight();
            gridFinalPosition = 3;
        }

        else if (gridInitialPosition == 4)
        {
            paladin.FlipCharacterToTheLeft();
            gridFinalPosition = 3;
        }


        paladin.gridPosition = gridController.gridThreePaladinLocationOnePosition;
        paladin.moveToGrid = true;

        globalController.paladinUsingMove = false;
        globalController.paladinUsingAnAction = true;
        globalController.paladinIsReady = false;

        gridController.gridOnePaladinLocationOne = false;
        gridController.gridTwoPaladinLocationOne = false;
        gridController.gridThreePaladinLocationOne = true;
        gridController.gridFourPaladinLocationOne = false;

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
            paladin.FlipCharacterToTheRight();
            gridFinalPosition = 4;
        }


        paladin.gridPosition = gridController.gridFourPaladinLocationOnePosition;
        paladin.moveToGrid = true;

        globalController.paladinUsingMove = false;
        globalController.paladinUsingAnAction = true;
        globalController.paladinIsReady = false;

        gridController.gridOnePaladinLocationOne = false;
        gridController.gridTwoPaladinLocationOne = false;
        gridController.gridThreePaladinLocationOne = false;
        gridController.gridFourPaladinLocationOne = true;

        OnCancelMove();

        onMoving = true;        
    }


    void OnMoving()
    {
        if (paladin.moveToGridAtGrid)
        {
            paladin.moveToGridAtGrid = false;
            globalController.paladinUsingAnAction = false;
            globalController.isCharacterSelect = false;

            paladin.StartOverSpeedBar();

            globalController.CharactersAreReady();

            globalController.canChangeCharacters = true;
            globalController.EnableChangeButtons();

            globalController.RestartAllSpeedTime();

            onMoving = false;

            if (gridFinalPosition == 1) { paladin.FlipCharacterToTheRight(); return; }

            else if (gridFinalPosition == 2)
            {
                if (gridController.gridOneEnemyLocationOne || gridController.gridOneEnemyLocationTwo ||
                    gridController.gridOneEnemyLocationThree)
                {
                    paladin.FlipCharacterToTheLeft();
                    return;
                }
                
                else if (!gridController.gridOneEnemyLocationOne && !gridController.gridOneEnemyLocationTwo &&
                         !gridController.gridOneEnemyLocationThree)
                {
                    paladin.FlipCharacterToTheRight();
                    return;
                }                                                                                                    
            }

            else if (gridFinalPosition == 3)
            {
                if (gridController.gridFourEnemyLocationOne || gridController.gridFourEnemyLocationTwo ||
                    gridController.gridFourEnemyLocationThree)
                {
                    paladin.FlipCharacterToTheRight();
                    return;
                }

                else if (!gridController.gridFourEnemyLocationOne && !gridController.gridFourEnemyLocationTwo &&
                         !gridController.gridFourEnemyLocationThree)
                {
                    paladin.FlipCharacterToTheLeft();
                    return;
                }
            }

            else if (gridFinalPosition == 4) { paladin.FlipCharacterToTheLeft(); return; }
        }

        else if (!paladin.moveToGridAtGrid)
        {
            globalController.StopAllSpeedTime();
            globalController.WaitingPosition();            
        }
    }
}

