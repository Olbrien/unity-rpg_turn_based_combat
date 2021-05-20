using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageOneController : MonoBehaviour
{
    public EntireGameControllerCollector entireGameControllerCollector;
    public EnemyController enemyController;
    public GlobalController globalController;
    public GridController gridController;
    public Paladin paladin;
    public Wizard wizard;

    public List<Canvas> sectionZeroEnemiesCanvas;
    public List<Enemy> sectionZeroEnemiesScript;

    public bool canSpawn = true;
    float theTimer = 0;
    public int section = 0;

    int enemyNumber = 0;


    void Update()
    {
        if (entireGameControllerCollector.selectedLevel == 0 && canSpawn)
        {
            SpawnLevel();
            theTimer += Time.deltaTime;
        }        
    }


    void SpawnLevel()
    {
        ///////
        // 1 // 
        ///////


        if (section == 0 && theTimer >= 2)
        {            
            SpawnControllerPlayer(2);

            theTimer = 0;
            section += 1;            
        }

        else if (section == 1 && theTimer >= 0f)
        {   
            enemyController.SlimeStats();

            SpawnControllerEnemy(enemyNumber, 5, 1);

            theTimer = 0;
            canSpawn = false;
        }

        ///////
        // 2 // 
        ///////

        else if (section == 2 && theTimer >= 1f)
        {
            SpawnControllerEnemy(enemyNumber, 5, 2);

            theTimer = 0;
            section += 1;
        }


        else if (section == 3 && theTimer >= 1f)
        {
            SpawnControllerEnemy(enemyNumber, 5, 3);

            theTimer = 0;
            canSpawn = false;
        }


        ///////
        // 3 // 
        ///////


        else if (section == 4 && theTimer >= 1f)
        {
            SpawnControllerEnemy(enemyNumber, 5, 4);

            theTimer = 0;
            section += 1;
        }

        else if (section == 5 && theTimer >= 1f)
        {
            SpawnControllerEnemy(enemyNumber, 5, 5);

            theTimer = 0;
            section += 1;
        }

        else if (section == 6 && theTimer >= 1f)
        {
            SpawnControllerEnemy(enemyNumber, 5, 6);

            theTimer = 0;
            canSpawn = false;
        }

    }











    void SpawnControllerEnemy(int enemy, int grid, int gridLocation)
    {
        globalController.allEnemies.Add(sectionZeroEnemiesScript[enemy]);

        sectionZeroEnemiesScript[enemy].enabled = true;

        sectionZeroEnemiesScript[enemy].grid = grid;
        sectionZeroEnemiesScript[enemy].gridLocation = gridLocation;

        //sectionZeroEnemiesScript[enemy].speedTimer = 0;
        //sectionZeroEnemiesScript[enemy].startSpeed = false;
        sectionZeroEnemiesScript[enemy].appear = true;

        //if (globalController.paladinIsReady || globalController.wizardIsReady)
        //{
        //    //sectionZeroEnemiesScript[enemy].startSpeed = false;
        //}

        if (globalController.paladinUsingAttack || globalController.wizardUsingAttack)
        {
            globalController.EnableAllEnemiesSelectArrowAndClickController();
        }

        globalController.enemiesInGame += 1;


        if (grid == 1 && gridLocation == 1)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheRight();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridOneEnemyLocationOnePosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridOneEnemyLocationOnePosition;
            gridController.gridOneEnemyLocationOne = true;
        }

        else if (grid == 1 && gridLocation == 2)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheRight();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridOneEnemyLocationTwoPosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridOneEnemyLocationTwoPosition;
            gridController.gridOneEnemyLocationTwo = true;
        }

        else if (grid == 1 && gridLocation == 3)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheRight();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridOneEnemyLocationThreePosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridOneEnemyLocationThreePosition;
            gridController.gridOneEnemyLocationThree = true;
        }


        else if (grid == 1 && gridLocation == 4)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheRight();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridOneEnemyLocationFourPosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridOneEnemyLocationFourPosition;
            gridController.gridOneEnemyLocationFour = true;
        }

        else if (grid == 1 && gridLocation == 5)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheRight();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridOneEnemyLocationFivePosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridOneEnemyLocationFivePosition;
            gridController.gridOneEnemyLocationFive = true;
        }

        else if (grid == 1 && gridLocation == 6)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheRight();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridOneEnemyLocationSixPosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridOneEnemyLocationSixPosition;
            gridController.gridOneEnemyLocationSix = true;
        }



        else if (grid == 2 && gridLocation == 1)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheRight();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridTwoEnemyLocationOnePosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridTwoEnemyLocationOnePosition;
            gridController.gridTwoEnemyLocationOne = true;
        }

        else if (grid == 2 && gridLocation == 2)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheRight();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridTwoEnemyLocationTwoPosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridTwoEnemyLocationTwoPosition;
            gridController.gridTwoEnemyLocationTwo = true;
        }

        else if (grid == 2 && gridLocation == 3)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheRight();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridTwoEnemyLocationThreePosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridTwoEnemyLocationThreePosition;
            gridController.gridTwoEnemyLocationThree = true;
        }


        else if (grid == 2 && gridLocation == 4)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheRight();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridTwoEnemyLocationFourPosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridTwoEnemyLocationFourPosition;
            gridController.gridTwoEnemyLocationFour = true;
        }

        else if (grid == 2 && gridLocation == 5)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheRight();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridTwoEnemyLocationFivePosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridTwoEnemyLocationFivePosition;
            gridController.gridTwoEnemyLocationFive = true;
        }

        else if (grid == 2 && gridLocation == 6)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheRight();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridTwoEnemyLocationSixPosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridTwoEnemyLocationSixPosition;
            gridController.gridTwoEnemyLocationSix = true;
        }





        else if (grid == 3 && gridLocation == 1)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheRight();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridThreeEnemyLocationOnePosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridThreeEnemyLocationOnePosition;
            gridController.gridThreeEnemyLocationOne = true;
        }

        else if (grid == 3 && gridLocation == 2)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheRight();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridThreeEnemyLocationTwoPosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridThreeEnemyLocationTwoPosition;
            gridController.gridThreeEnemyLocationTwo = true;
        }

        else if (grid == 3 && gridLocation == 3)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheRight();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridThreeEnemyLocationThreePosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridThreeEnemyLocationThreePosition;
            gridController.gridThreeEnemyLocationThree = true;
        }


        else if (grid == 3 && gridLocation == 4)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheRight();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridThreeEnemyLocationFourPosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridThreeEnemyLocationFourPosition;
            gridController.gridThreeEnemyLocationFour = true;
        }

        else if (grid == 3 && gridLocation == 5)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheRight();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridThreeEnemyLocationFivePosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridThreeEnemyLocationFivePosition;
            gridController.gridThreeEnemyLocationFive = true;
        }

        else if (grid == 3 && gridLocation == 6)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheRight();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridThreeEnemyLocationSixPosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridThreeEnemyLocationSixPosition;
            gridController.gridThreeEnemyLocationSix = true;
        }





        else if (grid == 4 && gridLocation == 1)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheLeft();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridFourEnemyLocationOnePosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridFourEnemyLocationOnePosition;
            gridController.gridFourEnemyLocationOne = true;
        }

        else if (grid == 4 && gridLocation == 2)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheLeft();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridFourEnemyLocationTwoPosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridFourEnemyLocationTwoPosition;
            gridController.gridFourEnemyLocationTwo = true;
        }

        else if (grid == 4 && gridLocation == 3)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheLeft();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridFourEnemyLocationThreePosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridFourEnemyLocationThreePosition;
            gridController.gridFourEnemyLocationThree = true;
        }

        else if (grid == 4 && gridLocation == 4)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheLeft();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridFourEnemyLocationFourPosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridFourEnemyLocationFourPosition;
            gridController.gridFourEnemyLocationFour = true;
        }

        else if (grid == 4 && gridLocation == 5)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheLeft();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridFourEnemyLocationFivePosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridFourEnemyLocationFivePosition;
            gridController.gridFourEnemyLocationFive = true;
        }

        else if (grid == 4 && gridLocation == 6)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheLeft();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridFourEnemyLocationSixPosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridFourEnemyLocationSixPosition;
            gridController.gridFourEnemyLocationSix = true;
        }






        else if (grid == 5 && gridLocation == 1)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheLeft();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridFiveEnemyLocationOnePosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridFiveEnemyLocationOnePosition;
            gridController.gridFiveEnemyLocationOne = true;
        }

        else if (grid == 5 && gridLocation == 2)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheLeft();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridFiveEnemyLocationTwoPosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridFiveEnemyLocationTwoPosition;
            gridController.gridFiveEnemyLocationTwo = true;
        }

        else if (grid == 5 && gridLocation == 3)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheLeft();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridFiveEnemyLocationThreePosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridFiveEnemyLocationThreePosition;
            gridController.gridFiveEnemyLocationThree = true;
        }


        else if (grid == 5 && gridLocation == 4)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheLeft();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridFiveEnemyLocationFourPosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridFiveEnemyLocationFourPosition;
            gridController.gridFiveEnemyLocationFour = true;
        }

        else if (grid == 5 && gridLocation == 5)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheLeft();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridFiveEnemyLocationFivePosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridFiveEnemyLocationFivePosition;
            gridController.gridFiveEnemyLocationFive = true;
        }

        else if (grid == 5 && gridLocation == 6)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheLeft();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridFiveEnemyLocationSixPosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridFiveEnemyLocationSixPosition;
            gridController.gridFiveEnemyLocationSix = true;
        }




        else if (grid == 6 && gridLocation == 1)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheLeft();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridSixEnemyLocationOnePosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridSixEnemyLocationOnePosition;
            gridController.gridSixEnemyLocationOne = true;
        }

        else if (grid == 6 && gridLocation == 2)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheLeft();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridSixEnemyLocationTwoPosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridSixEnemyLocationTwoPosition;
            gridController.gridSixEnemyLocationTwo = true;
        }

        else if (grid == 6 && gridLocation == 3)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheLeft();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridSixEnemyLocationThreePosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridSixEnemyLocationThreePosition;
            gridController.gridSixEnemyLocationThree = true;
        }


        else if (grid == 6 && gridLocation == 4)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheLeft();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridSixEnemyLocationFourPosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridSixEnemyLocationFourPosition;
            gridController.gridSixEnemyLocationFour = true;
        }

        else if (grid == 6 && gridLocation == 5)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheLeft();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridSixEnemyLocationFivePosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridSixEnemyLocationFivePosition;
            gridController.gridSixEnemyLocationFive = true;
        }

        else if (grid == 6 && gridLocation == 6)
        {
            sectionZeroEnemiesScript[enemy].FlipCharacterToTheLeft();
            sectionZeroEnemiesScript[enemy].transform.position = gridController.gridSixEnemyLocationSixPosition;
            sectionZeroEnemiesScript[enemy].gridPosition = gridController.gridSixEnemyLocationSixPosition;
            gridController.gridSixEnemyLocationSix = true;
        }




        sectionZeroEnemiesCanvas[enemy].enabled = true;

        enemyNumber += 1;
    }

    void SpawnControllerPlayer(int grid)
    {
        if (grid == 1)
        {
            paladin.facingLeft = false;
            paladin.facingRight = true;
            paladin.FlipCharacterToTheRight();
            paladin.gridPosition = gridController.gridOnePaladinLocationOnePosition;
            paladin.transform.position = gridController.gridOnePaladinLocationOnePosition;
            gridController.gridOnePaladinLocationOne = true;

            wizard.facingLeft = false;
            wizard.facingRight = true;
            wizard.FlipCharacterToTheRight();
            wizard.transform.position = gridController.gridOneWizardLocationOnePosition;
            wizard.gridPosition = gridController.gridOneWizardLocationOnePosition;
            gridController.gridOneWizardLocationOne = true;
        }

        else if (grid == 2)
        {
            paladin.facingLeft = false;
            paladin.facingRight = true;
            paladin.FlipCharacterToTheRight();
            paladin.gridPosition = gridController.gridTwoPaladinLocationOnePosition;
            paladin.transform.position = gridController.gridTwoPaladinLocationOnePosition;
            gridController.gridTwoPaladinLocationOne = true;

            wizard.facingLeft = false;
            wizard.facingRight = true;
            wizard.FlipCharacterToTheRight();
            wizard.transform.position = gridController.gridTwoWizardLocationOnePosition;
            wizard.gridPosition = gridController.gridTwoWizardLocationOnePosition;
            gridController.gridTwoWizardLocationOne = true;
        }

        else if (grid == 3)
        {
            paladin.facingLeft = false;
            paladin.facingRight = true;
            paladin.FlipCharacterToTheRight();
            paladin.gridPosition = gridController.gridThreePaladinLocationOnePosition;
            paladin.transform.position = gridController.gridThreePaladinLocationOnePosition;
            gridController.gridThreePaladinLocationOne = true;

            wizard.facingLeft = true;
            wizard.facingRight = false;
            wizard.FlipCharacterToTheLeft();
            wizard.transform.position = gridController.gridThreeWizardLocationOnePosition;
            wizard.gridPosition = gridController.gridThreeWizardLocationOnePosition;
            gridController.gridThreeWizardLocationOne = true;
        }

        else if (grid == 4)
        {
            paladin.facingLeft = true;
            paladin.facingRight = false;
            paladin.FlipCharacterToTheLeft();
            paladin.gridPosition = gridController.gridFourPaladinLocationOnePosition;
            paladin.transform.position = gridController.gridFourPaladinLocationOnePosition;
            gridController.gridFourPaladinLocationOne = true;

            wizard.facingLeft = true;
            wizard.facingRight = false;
            wizard.FlipCharacterToTheLeft();
            wizard.transform.position = gridController.gridFourWizardLocationOnePosition;
            wizard.gridPosition = gridController.gridFourWizardLocationOnePosition;
            gridController.gridFourWizardLocationOne = true;
        }

        else if (grid == 5)
        {
            paladin.facingLeft = true;
            paladin.facingRight = false;
            paladin.FlipCharacterToTheLeft();
            paladin.gridPosition = gridController.gridFivePaladinLocationOnePosition;
            paladin.transform.position = gridController.gridFivePaladinLocationOnePosition;
            gridController.gridFivePaladinLocationOne = true;

            wizard.facingLeft = true;
            wizard.facingRight = false;
            wizard.FlipCharacterToTheLeft();
            wizard.transform.position = gridController.gridFiveWizardLocationOnePosition;
            wizard.gridPosition = gridController.gridFiveWizardLocationOnePosition;
            gridController.gridFiveWizardLocationOne = true;
        }

    }

}
