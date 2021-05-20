using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    [TextArea]
    public string information;


    [HideInInspector]
    public int enemyGridLocationTemporary;
    [HideInInspector]
    public bool enemyFlipLeft;
    [HideInInspector]
    public bool enemyFlipRight;
    [HideInInspector]
    public int distance;

    [Space(20)]

    public bool gridOneEnemyLocationOne;
    public bool gridOneEnemyLocationTwo;
    public bool gridOneEnemyLocationThree;
    public bool gridOneEnemyLocationFour;
    public bool gridOneEnemyLocationFive;
    public bool gridOneEnemyLocationSix;

    public bool gridTwoEnemyLocationOne;
    public bool gridTwoEnemyLocationTwo;
    public bool gridTwoEnemyLocationThree;
    public bool gridTwoEnemyLocationFour;
    public bool gridTwoEnemyLocationFive;
    public bool gridTwoEnemyLocationSix;

    public bool gridThreeEnemyLocationOne;
    public bool gridThreeEnemyLocationTwo;
    public bool gridThreeEnemyLocationThree;
    public bool gridThreeEnemyLocationFour;
    public bool gridThreeEnemyLocationFive;
    public bool gridThreeEnemyLocationSix;

    public bool gridFourEnemyLocationOne;
    public bool gridFourEnemyLocationTwo;
    public bool gridFourEnemyLocationThree;
    public bool gridFourEnemyLocationFour;
    public bool gridFourEnemyLocationFive;
    public bool gridFourEnemyLocationSix;

    public bool gridFiveEnemyLocationOne;
    public bool gridFiveEnemyLocationTwo;
    public bool gridFiveEnemyLocationThree;
    public bool gridFiveEnemyLocationFour;
    public bool gridFiveEnemyLocationFive;
    public bool gridFiveEnemyLocationSix;

    public bool gridSixEnemyLocationOne;
    public bool gridSixEnemyLocationTwo;
    public bool gridSixEnemyLocationThree;
    public bool gridSixEnemyLocationFour;
    public bool gridSixEnemyLocationFive;
    public bool gridSixEnemyLocationSix;


    [Space(20)]


    public bool gridOnePaladinLocationOne;
    public bool gridOneWizardLocationOne;

    public bool gridTwoPaladinLocationOne;
    public bool gridTwoWizardLocationOne;

    public bool gridThreePaladinLocationOne;
    public bool gridThreeWizardLocationOne;

    public bool gridFourPaladinLocationOne;
    public bool gridFourWizardLocationOne;

    public bool gridFivePaladinLocationOne;
    public bool gridFiveWizardLocationOne;


    [Space(20)]


    public Vector3 gridOneEnemyLocationOnePosition = new Vector3(-8.45f, 0.33f, 0);
    public Vector3 gridOneEnemyLocationTwoPosition = new Vector3(-7.43f, 0.79f, 0); 
    public Vector3 gridOneEnemyLocationThreePosition = new Vector3(-8.59f, -0.37f, 0);
    public Vector3 gridOneEnemyLocationFourPosition = new Vector3(-8.45f, 0.33f, 0);
    public Vector3 gridOneEnemyLocationFivePosition = new Vector3(-7.43f, 0.79f, 0);
    public Vector3 gridOneEnemyLocationSixPosition = new Vector3(-8.59f, -0.37f, 0);

    public Vector3 gridTwoEnemyLocationOnePosition = new Vector3(-6.59f, 0.33f, 0);
    public Vector3 gridTwoEnemyLocationTwoPosition = new Vector3(-5.54f, 0.79f, 0);
    public Vector3 gridTwoEnemyLocationThreePosition = new Vector3(-6.74f, -0.37f, 0);
    public Vector3 gridTwoEnemyLocationFourPosition = new Vector3(-6.59f, 1.17f, 0);
    public Vector3 gridTwoEnemyLocationFivePosition = new Vector3(-5.54f, -0.07f, 0);
    public Vector3 gridTwoEnemyLocationSixPosition = new Vector3(-6.74f, -1.11f, 0);

    public Vector3 gridThreeEnemyLocationOnePosition = new Vector3(-2.48f, 0.33f, 0); 
    public Vector3 gridThreeEnemyLocationTwoPosition = new Vector3(-3.21f, 0.79f, 0); 
    public Vector3 gridThreeEnemyLocationThreePosition = new Vector3(-1.86f, -0.37f, 0);
    public Vector3 gridThreeEnemyLocationFourPosition = new Vector3(-2.48f, 1.17f, 0);
    public Vector3 gridThreeEnemyLocationFivePosition = new Vector3(-3.21f, -0.07f, 0);
    public Vector3 gridThreeEnemyLocationSixPosition = new Vector3(-1.86f, -1.11f, 0);

    public Vector3 gridFourEnemyLocationOnePosition = new Vector3(-2.14f, 0.33f, 0);
    public Vector3 gridFourEnemyLocationTwoPosition = new Vector3(-1.09f, 0.79f, 0);
    public Vector3 gridFourEnemyLocationThreePosition = new Vector3(-2.29f, -0.37f, 0);
    public Vector3 gridFourEnemyLocationFourPosition = new Vector3(-2.14f, 1.17f, 0);
    public Vector3 gridFourEnemyLocationFivePosition = new Vector3(-1.09f, -0.07f, 0);
    public Vector3 gridFourEnemyLocationSixPosition = new Vector3(-2.29f, -1.11f, 0);

    public Vector3 gridFiveEnemyLocationOnePosition = new Vector3(4f, 0.33f, 0);
    public Vector3 gridFiveEnemyLocationTwoPosition = new Vector3(3.37f, 0.79f, 0);
    public Vector3 gridFiveEnemyLocationThreePosition = new Vector3(4.92f, -0.37f, 0);
    public Vector3 gridFiveEnemyLocationFourPosition = new Vector3(2.97f, 1.17f, 0);
    public Vector3 gridFiveEnemyLocationFivePosition = new Vector3(5.19f, 0.24f, 0);
    public Vector3 gridFiveEnemyLocationSixPosition = new Vector3(3.58f, -1.11f, 0);

    public Vector3 gridSixEnemyLocationOnePosition = new Vector3(3.98f, 0.33f, 0);
    public Vector3 gridSixEnemyLocationTwoPosition = new Vector3(3.25f, 0.79f, 0);
    public Vector3 gridSixEnemyLocationThreePosition = new Vector3(4.6f, -0.37f, 0);
    public Vector3 gridSixEnemyLocationFourPosition = new Vector3(3.98f, 1.17f, 0);
    public Vector3 gridSixEnemyLocationFivePosition = new Vector3(3.25f, -0.07f, 0);
    public Vector3 gridSixEnemyLocationSixPosition = new Vector3(4.6f, -1.11f, 0);


    [Space(20)]


    public Vector3 gridOnePaladinLocationOnePosition = new Vector3(-4.8f, -0.71f, 0);
    public Vector3 gridOneWizardLocationOnePosition = new Vector3(-7.1f, 0.66f, 0);

    public Vector3 gridTwoPaladinLocationOnePosition = new Vector3(-4.8f, -0.71f, 0); 
    public Vector3 gridTwoWizardLocationOnePosition = new Vector3(-7.1f, 0.66f, 0); 

    public Vector3 gridThreePaladinLocationOnePosition = new Vector3(1.38f, -0.71f, 0);
    public Vector3 gridThreeWizardLocationOnePosition = new Vector3(-1.23f, 0.66f, 0);

    public Vector3 gridFourPaladinLocationOnePosition = new Vector3(3.11f, -0.71f, 0); 
    public Vector3 gridFourWizardLocationOnePosition = new Vector3(4.71f, 0.66f, 0);

    public Vector3 gridFivePaladinLocationOnePosition = new Vector3(5.64f, -0.71f, 0);
    public Vector3 gridFiveWizardLocationOnePosition = new Vector3(7.2f, 0.66f, 0);



    [Space(20)]

    public Paladin paladin;
    public Wizard wizard;



    public void CheckDistancePaladin()
    {
        if (gridOnePaladinLocationOne && enemyGridLocationTemporary == 1)
        {
            distance = 0;
        }

        else if (gridOnePaladinLocationOne && enemyGridLocationTemporary == 2)
        {
            distance = 0;
        }

        else if (gridOnePaladinLocationOne && enemyGridLocationTemporary == 3)
        {
            distance = 1;
        }

        else if (gridOnePaladinLocationOne && enemyGridLocationTemporary == 4)
        {
            distance = 1;
        }

        else if (gridOnePaladinLocationOne && enemyGridLocationTemporary == 5)
        {
            distance = 2;
        }

        else if (gridOnePaladinLocationOne && enemyGridLocationTemporary == 6)
        {
            distance = 2;
        }



        else if (gridTwoPaladinLocationOne && enemyGridLocationTemporary == 1)
        {
            distance = 1;
        }

        else if (gridTwoPaladinLocationOne && enemyGridLocationTemporary == 2)
        {
            distance = 0;
        }

        else if (gridTwoPaladinLocationOne && enemyGridLocationTemporary == 3)
        {
            distance = 1;
        }

        else if (gridTwoPaladinLocationOne && enemyGridLocationTemporary == 4)
        {
            distance = 1;
        }

        else if (gridTwoPaladinLocationOne && enemyGridLocationTemporary == 5)
        {
            distance = 1;
        }

        else if (gridTwoPaladinLocationOne && enemyGridLocationTemporary == 6)
        {
            distance = 1;
        }



        else if (gridThreePaladinLocationOne && enemyGridLocationTemporary == 1)
        {
            distance = 1;
        }

        else if (gridThreePaladinLocationOne && enemyGridLocationTemporary == 2)
        {
            distance = 1;
        }

        else if (gridThreePaladinLocationOne && enemyGridLocationTemporary == 3)
        {
            distance = 0;
        }

        else if (gridThreePaladinLocationOne && enemyGridLocationTemporary == 4)
        {
            distance = 0;
        }

        else if (gridThreePaladinLocationOne && enemyGridLocationTemporary == 5)
        {
            distance = 1;
        }

        else if (gridThreePaladinLocationOne && enemyGridLocationTemporary == 6)
        {
            distance = 1;
        }



        else if (gridFourPaladinLocationOne && enemyGridLocationTemporary == 1)
        {
            distance = 1;
        }

        else if (gridFourPaladinLocationOne && enemyGridLocationTemporary == 2)
        {
            distance = 1;
        }

        else if (gridFourPaladinLocationOne && enemyGridLocationTemporary == 3)
        {
            distance = 0;
        }

        else if (gridFourPaladinLocationOne && enemyGridLocationTemporary == 4)
        {
            distance = 0;
        }

        else if (gridFourPaladinLocationOne && enemyGridLocationTemporary == 5)
        {
            distance = 0;
        }

        else if (gridFourPaladinLocationOne && enemyGridLocationTemporary == 6)
        {
            distance = 0;
        }


        else if (gridFivePaladinLocationOne && enemyGridLocationTemporary == 1)
        {
            distance = 2;
        }

        else if (gridFivePaladinLocationOne && enemyGridLocationTemporary == 2)
        {
            distance = 2;
        }

        else if (gridFivePaladinLocationOne && enemyGridLocationTemporary == 3)
        {
            distance = 1;
        }

        else if (gridFivePaladinLocationOne && enemyGridLocationTemporary == 4)
        {
            distance = 1;
        }

        else if (gridFivePaladinLocationOne && enemyGridLocationTemporary == 5)
        {
            distance = 0;
        }

        else if (gridFivePaladinLocationOne && enemyGridLocationTemporary == 6)
        {
            distance = 0;
        }
    }






    public void CheckDistanceWizard()
    {
        if (gridOneWizardLocationOne && enemyGridLocationTemporary == 1)
        {
            distance = 0;
        }

        else if (gridOneWizardLocationOne && enemyGridLocationTemporary == 2)
        {
            distance = 0;
        }

        else if (gridOneWizardLocationOne && enemyGridLocationTemporary == 3)
        {
            distance = 1;
        }

        else if (gridOneWizardLocationOne && enemyGridLocationTemporary == 4)
        {
            distance = 1;
        }

        else if (gridOneWizardLocationOne && enemyGridLocationTemporary == 5)
        {
            distance = 2;
        }

        else if (gridOneWizardLocationOne && enemyGridLocationTemporary == 6)
        {
            distance = 2;
        }



        else if (gridTwoWizardLocationOne && enemyGridLocationTemporary == 1)
        {
            distance = 1;
        }

        else if (gridTwoWizardLocationOne && enemyGridLocationTemporary == 2)
        {
            distance = 1;
        }

        else if (gridTwoWizardLocationOne && enemyGridLocationTemporary == 3)
        {
            distance = 1;
        }

        else if (gridTwoWizardLocationOne && enemyGridLocationTemporary == 4)
        {
            distance = 1;
        }

        else if (gridTwoWizardLocationOne && enemyGridLocationTemporary == 5)
        {
            distance = 1;
        }

        else if (gridTwoWizardLocationOne && enemyGridLocationTemporary == 6)
        {
            distance = 1;
        }



        else if (gridThreeWizardLocationOne && enemyGridLocationTemporary == 1)
        {
            distance = 1;
        }

        else if (gridThreeWizardLocationOne && enemyGridLocationTemporary == 2)
        {
            distance = 1;
        }

        else if (gridThreeWizardLocationOne && enemyGridLocationTemporary == 3)
        {
            distance = 0;
        }

        else if (gridThreeWizardLocationOne && enemyGridLocationTemporary == 4)
        {
            distance = 0;
        }

        else if (gridThreeWizardLocationOne && enemyGridLocationTemporary == 5)
        {
            distance = 1;
        }

        else if (gridThreeWizardLocationOne && enemyGridLocationTemporary == 6)
        {
            distance = 1;
        }



        else if (gridFourWizardLocationOne && enemyGridLocationTemporary == 1)
        {
            distance = 1;
        }

        else if (gridFourWizardLocationOne && enemyGridLocationTemporary == 2)
        {
            distance = 1;
        }

        else if (gridFourWizardLocationOne && enemyGridLocationTemporary == 3)
        {
            distance = 0;
        }

        else if (gridFourWizardLocationOne && enemyGridLocationTemporary == 4)
        {
            distance = 0;
        }

        else if (gridFourWizardLocationOne && enemyGridLocationTemporary == 5)
        {
            distance = 0;
        }

        else if (gridFourWizardLocationOne && enemyGridLocationTemporary == 6)
        {
            distance = 0;
        }


        else if (gridFiveWizardLocationOne && enemyGridLocationTemporary == 1)
        {
            distance = 2;
        }

        else if (gridFiveWizardLocationOne && enemyGridLocationTemporary == 2)
        {
            distance = 2;
        }

        else if (gridFiveWizardLocationOne && enemyGridLocationTemporary == 3)
        {
            distance = 1;
        }

        else if (gridFiveWizardLocationOne && enemyGridLocationTemporary == 4)
        {
            distance = 1;
        }

        else if (gridFiveWizardLocationOne && enemyGridLocationTemporary == 5)
        {
            distance = 0;
        }

        else if (gridFiveWizardLocationOne && enemyGridLocationTemporary == 6)
        {
            distance = 0;
        }
    }



    public void FlipIfPaladinIsAtackingRightOrLeft()
    {
        if (gridOnePaladinLocationOne)
        {
            paladin.FlipCharacterToTheRight();
        }

        if (gridTwoPaladinLocationOne)
        {
            paladin.FlipCharacterToTheRight();
        }

        if (gridThreePaladinLocationOne && enemyGridLocationTemporary == 1)
        {
            paladin.FlipCharacterToTheLeft();
        }

        else if (gridThreePaladinLocationOne && enemyGridLocationTemporary == 2)
        {
            paladin.FlipCharacterToTheLeft();
        }

        else if (gridThreePaladinLocationOne && enemyGridLocationTemporary == 4)
        {
            paladin.FlipCharacterToTheRight();
        }

        else if (gridThreePaladinLocationOne && enemyGridLocationTemporary == 5)
        {
            paladin.FlipCharacterToTheRight();
        }

        else if (gridThreePaladinLocationOne && enemyGridLocationTemporary == 6)
        {
            paladin.FlipCharacterToTheRight();
        }

        if (gridFourPaladinLocationOne)
        {
            paladin.FlipCharacterToTheLeft();
        }

        if (gridFivePaladinLocationOne)
        {
            paladin.FlipCharacterToTheLeft();
        }
    }


    public void FlipIfWizardIsAtackingRightOrLeft()
    {
        if (gridOneWizardLocationOne)
        {
            wizard.FlipCharacterToTheRight();
        }

        if (gridTwoWizardLocationOne)
        {
            wizard.FlipCharacterToTheRight();
        }

        if (gridThreeWizardLocationOne && enemyGridLocationTemporary == 1)
        {
            wizard.FlipCharacterToTheLeft();
        }

        else if (gridThreeWizardLocationOne && enemyGridLocationTemporary == 2)
        {
            wizard.FlipCharacterToTheLeft();
        }

        else if (gridThreeWizardLocationOne && enemyGridLocationTemporary == 4)
        {
            wizard.FlipCharacterToTheRight();
        }

        else if (gridThreeWizardLocationOne && enemyGridLocationTemporary == 5)
        {
            wizard.FlipCharacterToTheRight();
        }

        else if (gridThreeWizardLocationOne && enemyGridLocationTemporary == 6)
        {
            wizard.FlipCharacterToTheRight();
        }

        if (gridFourWizardLocationOne)
        {
            wizard.FlipCharacterToTheLeft();
        }

        if (gridFiveWizardLocationOne)
        {
            wizard.FlipCharacterToTheLeft();
        }
    }

}


