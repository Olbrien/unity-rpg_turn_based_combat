using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GlobalController : MonoBehaviour
{
    Vector3 waitingPosition = new Vector3(20, 10, 0);

    Vector3 initialPaladinActionsPosition = new Vector3(20, 0, 0);
    Vector3 initialWizardActionsPosition = new Vector3(50, 0, 0);

    bool start = true;
    float theTime;


    [Header("Paladin Spells Effects")]

    public int paladinSpecialAttack;
    public int paladinSpellHealOne;
    public int paladinSpellHealTwo;
    public int paladinSpellHealThree;
    public int paladinSpellStrengthOne;
    public int paladinSpellStrengthTwo;
    public int paladinSpellStrengthThree;
    public int paladinSpellArmorProtectOne;
    public int paladinSpellArmorProtectTwo;
    public int paladinSpellArmorProtectThree;
    

    [Header("Wizard Spells Effects")]

    public int wizardSpecialAttack;
    public int wizardSpellIceOne;
    public int wizardSpellIceTwo;
    public int wizardSpellIceThree;
    public int wizardSpellFireOne;
    public int wizardSpellFireTwo;
    public int wizardSpellFireThree;
    public int wizardSpellWaterOne;
    public int wizardSpellWaterTwo;
    public int wizardSpellWaterThree;


    [Header("Escape")]

    public bool isEscapeOn;
    public float escapePercentage;


    [Header("Level")]

    public int selectedLevel;

    [Header("Player Gold")]

    public int gold;

    [Header("Player Level")]

    public int level;
    public int experience;

    [Header("Level Experience")]

    public int[] levelUp;

    [Header("Enemies In Game")]

    public int enemiesInGame;


    [Header("Character Selection")]

    public bool paladinIsReady;
    public bool wizardIsReady;
    public bool enemyIsReady;

    public bool isCharacterSelect;

    public bool canChangeCharacters;


    [Header("Using Action")]

    public bool paladinUsingAnAction;
    public bool wizardUsingAnAction;
    public bool enemyUsingAnAction;


    [Header("What Action is the Char Using")]

    public bool paladinUsingAttack;
    public bool wizardUsingAttack;

    public bool paladinUsingSpell;
    public bool wizardUsingSpell;




    public bool paladinUsingMove;
    public bool wizardUsingMove;

    [Header("Global Stuff")]

    public int globalFloatDamage;


    int experienceLeft;


    [Space(100)]

    public Camera uICameraActions;
    public Transform uICameraActionsTransform;

    [Space(10)]

    public Paladin paladin;
    public Wizard wizard;
    public List<Enemy> allEnemies;

    [Space(10)]

    public Canvas paladinTurnPointer;
    public Canvas wizardTurnPointer;

    [Space(10)]

    public Animator paladinHealthBar;
    public Animator paladinABBar;
    public Animator wizardHealthBar;
    public Animator wizardABBar;

    [Space(10)]

    public Canvas paladinChangeButton;
    public Canvas wizardChangeButton;

    [Space(10)]

    public WaitingText waitingText;

    [Space(10)]

    public FloatController floatController;
    public Transform levelUpPosition;

    [Space(10)]

    public Sky sky;
    public EntireGameControllerCollector entireGameControllerCollector;

    [Space(10)]    
    public CanvasGroup paladinCanvasGroup;
    public CanvasGroup wizardCanvasGroup;

    [Space(10)]
    public StageOneController stageOneController;
    public StageTwoController stageTwoController;
    public StageThreeController stageThreeController;
    public StageFourController stageFourController;
    public StageFiveController stageFiveController;
    public StageSixController stageSixController;
    public StageSevenController stageSevenController;
    public StageEightController stageEightController;

    [Space(10)]
    public TextMeshProUGUI levelTxt;
    public TextMeshProUGUI goldTxt;
    public TextMeshProUGUI experienceLeftTxt;

    [Space(10)]

    public ArrowsController arrowsController;

    public Canvas paladinAttackCanvas;
    public Canvas paladinSpecialAttackCanvas;
    public Canvas paladinHealOne;
    public Canvas paladinHealTwo;
    public Canvas paladinHealThree;
    public Canvas paladinStrengthOne;
    public Canvas paladinStrengthTwo;
    public Canvas paladinStrengthThree;
    public Canvas paladinArmorProtectOne;
    public Canvas paladinArmorProtectTwo;
    public Canvas paladinArmorProtectThree;

    public Canvas wizardAttackCanvas;
    public Canvas wizardSpecialAttackCanvas;
    public Canvas wizardFireOneCanvas;
    public Canvas wizardFireTwoCanvas;
    public Canvas wizardFireThreeCanvas;
    public Canvas wizardIceOneCanvas;
    public Canvas wizardIceTwoCanvas;
    public Canvas wizardIceThreeCanvas;
    public Canvas wizardWaterOneCanvas;
    public Canvas wizardWaterTwoCanvas;
    public Canvas wizardWaterThreeCanvas;

    [Space(10)]

    public Canvas escapeCanvas;



    void Start()
    {
        WaitingPosition();        

        //Shader.WarmupAllShaders(); <--- Se precisares de dar load a shaders antes do jogo começar. 

        // Debug.Log(Animator.StringToHash("Waiting"));   -1486375886
        // Debug.Log(Animator.StringToHash("Selected"));   1642061264
        //Debug.Log(Animator.StringToHash("StartState"));    1335092214
    }

    void Update()
    {
        if (start)
        {
            selectedLevel = entireGameControllerCollector.selectedLevel;
            UpdateLevelAndExperience();
            ChangeSky();            

            ProgressBar();
            UpdateGoldText();

            if (entireGameControllerCollector.level == 0)
            {
                levelTxt.text = "1";
                experienceLeftTxt.text = "+100";               
            }

            UpdateGameSpellsPaladin(); 
            UpdateGameSpellsWizard();
            UpdateGameEscape();

            start = false;
        }
    }

    void ChangeSky()
    {
        sky.Skies[0].enabled = false;
        sky.Skies[1].enabled = false;
        sky.Skies[2].enabled = false;
        sky.Skies[3].enabled = false;
        sky.Skies[4].enabled = false;
        sky.Skies[5].enabled = false;
        sky.Skies[6].enabled = false;
        sky.Skies[7].enabled = false;

        sky.Skies[selectedLevel].enabled = true;
    }


    public void WaitingPosition()
    {
        uICameraActionsTransform.position = waitingPosition;
        waitingText.StartWaitingText();
    }


    public void UpdateLevelAndExperience()
    {
        experience += entireGameControllerCollector.experience;
        level = entireGameControllerCollector.level;
        ProgressBar();
    }


    public void ProgressBar()
    {
        if (entireGameControllerCollector.experience >= levelUp[level])
        {
            entireGameControllerCollector.experience = entireGameControllerCollector.experience - levelUp[level];
            entireGameControllerCollector.level += 1;

            level = entireGameControllerCollector.level;

            if (level >= 2)
            {
                floatController.LevelUpFloatPopUp();
            }

            if (entireGameControllerCollector.experience >= levelUp[level]) { ProgressBar(); return; }; 
        }

        experience = entireGameControllerCollector.experience; 
        experienceLeft = levelUp[level] - entireGameControllerCollector.experience;

        levelTxt.text = level.ToString();        
        experienceLeftTxt.text = "+" + experienceLeft.ToString();

        //progressBarValue = (float)experience / (float) levelUp[level];
        //progressBarValue = Mathf.Clamp01(progressBarValue);

        //progressBar.fillAmount = progressBarValue;
    }



    public void CharacterReadyAnimationOffPaladin()
    {
        paladinHealthBar.SetBool(-1486375886, false);
        paladinABBar.SetBool(-1486375886, false);
    }

    public void CharacterReadyAnimationOffWizard()
    {
        wizardHealthBar.SetBool(-1486375886, false);
        wizardABBar.SetBool(-1486375886, false);
    }

    public void CharactersAreReady()
    {      
        if (paladinIsReady && isCharacterSelect == false)
        {
            waitingText.StopWaitingText();

            uICameraActionsTransform.position = initialPaladinActionsPosition;
            paladinTurnPointer.enabled = true;

            paladinHealthBar.SetBool(-1486375886, true);
            paladinABBar.SetBool(-1486375886, true);

            //paladinIsReady = false;
            isCharacterSelect = true;
            return;
        }

        else if (wizardIsReady && isCharacterSelect == false)
        {
            waitingText.StopWaitingText();

            uICameraActionsTransform.position = initialWizardActionsPosition;
            wizardTurnPointer.enabled = true;

            wizardHealthBar.SetBool(-1486375886, true);
            wizardABBar.SetBool(-1486375886, true);

            //wizardIsReady = false;
            isCharacterSelect = true;
            return;
        }

        if (paladinIsReady && wizardIsReady &&
            !paladinUsingAttack && !wizardUsingAttack &&
            !paladinUsingMove && !wizardUsingMove &&
            !paladinUsingSpell && !wizardUsingSpell) // Adiciona aqui todas as acções que fores fazer.
        {
            canChangeCharacters = true;
            EnableChangeButtons();
        }
    }



    //////////////////////////////////////////
    /// Select Arrows And Click Controller ///
    //////////////////////////////////////////



    public void EnableAllEnemiesSelectArrowAndClickController()
    {
        foreach (var theEnemy in allEnemies)
        {
            if (theEnemy.isDead == false)
            {
                theEnemy.EnableSelectArrowAndClickButton();
            }
        }
    }

    public void DisableAllEnemiesSelectArrowAndClickController()
    {
        foreach (var theEnemy in allEnemies)
        {
            if (theEnemy.isDead == false)
            {
                theEnemy.DisableSelectArrowAndClickButton();
            }
        }
    }



    public void EnableChangeButtons() { paladinChangeButton.enabled = true; wizardChangeButton.enabled = true; }
    public void DisableChangeButtons() { paladinChangeButton.enabled = false; wizardChangeButton.enabled = false; }


    public void OnClickChangeToPaladin()
    {
        if (paladinIsReady && wizardIsReady)
        {
            uICameraActionsTransform.position = initialPaladinActionsPosition;
            paladinTurnPointer.enabled = true;
            wizardTurnPointer.enabled = false;
        }
    }

    public void OnClickChangeToWizard()
    {
        if (wizardIsReady && paladinIsReady)
        {
            uICameraActionsTransform.position = initialWizardActionsPosition;
            paladinTurnPointer.enabled = false;
            wizardTurnPointer.enabled = true;
        }
    }

    
    public void StopAllSpeedTime()
    {
        paladin.startSpeed = false;
        wizard.startSpeed = false;

        foreach (var enemy in allEnemies)
        {
            enemy.startSpeed = false;
        }
    }

    public void RestartAllSpeedTime()
    {
        paladin.startSpeed = true;
        wizard.startSpeed = true;

        foreach (var enemy in allEnemies)
        {
            enemy.startSpeed = true;
        }
    }

    public void UpdateStageController()
    {
        if (enemiesInGame == 0 && entireGameControllerCollector.selectedLevel == 0) 
        {
            stageOneController.canSpawn = true;
            stageOneController.section += 1;
        }
    }


    public void UpdateGoldText()
    {
        goldTxt.text = entireGameControllerCollector.gold.ToString();
    }

          




    public void UpdateGameSpellsPaladin()
    {
        if (entireGameControllerCollector.thePaladinSpecialAttack)
        {
            paladinAttackCanvas.enabled = false;
            paladinSpecialAttackCanvas.enabled = true;
        }

        if (entireGameControllerCollector.thePaladinSpellHealOne)
        {
            paladinHealOne.enabled = true;
        }

        if (entireGameControllerCollector.thePaladinSpellHealTwo)
        {
            paladinHealTwo.enabled = true;
        }

        if (entireGameControllerCollector.thePaladinSpellHealThree)
        {
            paladinHealThree.enabled = true;
        }

        if (entireGameControllerCollector.thePaladinSpellStrenghtOne)
        {
            paladinStrengthOne.enabled = true;
        }

        if (entireGameControllerCollector.thePaladinSpellStrenghtTwo)
        {
            paladinStrengthTwo.enabled = true;
        }

        if (entireGameControllerCollector.thePaladinSpellStrenghtThree)
        {
            paladinStrengthThree.enabled = true;
        }

        if (entireGameControllerCollector.thePaladinSpellArmorProtectOne)
        {
            paladinArmorProtectOne.enabled = true;
        }

        if (entireGameControllerCollector.thePaladinSpellArmorProtectTwo)
        {
            paladinArmorProtectTwo.enabled = true;
        }

        if (entireGameControllerCollector.thePaladinSpellArmorProtectThree)
        {
            paladinArmorProtectThree.enabled = true;
        }
    }


    public void UpdateGameSpellsWizard()
    {
        if (entireGameControllerCollector.theWizardSpecialAttack)
        {
            wizardAttackCanvas.enabled = false;
            wizardSpecialAttackCanvas.enabled = true;
        }

        if (entireGameControllerCollector.theWizardSpellFireOne)
        {
            wizardFireOneCanvas.enabled = true;
        }

        if (entireGameControllerCollector.theWizardSpellFireTwo)
        {
            wizardFireTwoCanvas.enabled = true;
        }

        if (entireGameControllerCollector.theWizardSpellFireThree)
        {
            wizardFireThreeCanvas.enabled = true;
        }


        if (entireGameControllerCollector.theWizardSpellIceOne)
        {
            wizardIceOneCanvas.enabled = true;
        }

        if (entireGameControllerCollector.theWizardSpellIceTwo)
        { 
            wizardIceTwoCanvas.enabled = true;
        }

        if (entireGameControllerCollector.theWizardSpellIceThree)
        {
            wizardIceThreeCanvas.enabled = true;
        }



        if (entireGameControllerCollector.theWizardSpellWaterOne)
        {
            wizardWaterOneCanvas.enabled = true;
        }

        if (entireGameControllerCollector.theWizardSpellWaterTwo)
        {
            wizardWaterTwoCanvas.enabled = true;
        }

        if (entireGameControllerCollector.theWizardSpellWaterThree)
        {
            wizardWaterThreeCanvas.enabled = true;
        }
    }


    void UpdateGameEscape()
    {        
        if (entireGameControllerCollector.decentCombatBootsEquiped) { escapePercentage = 6; escapeCanvas.enabled = true; isEscapeOn = true; }
        else if (entireGameControllerCollector.excellentCombatBootsEquiped) { escapePercentage = 10; escapeCanvas.enabled = true; isEscapeOn = true; }
        else if (entireGameControllerCollector.imperialCombatBootsEquiped) { escapePercentage = 16; escapeCanvas.enabled = true; isEscapeOn = true; }
    }
}

