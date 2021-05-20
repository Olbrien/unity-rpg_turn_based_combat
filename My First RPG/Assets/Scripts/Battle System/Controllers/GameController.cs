using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;


public class GameController : MonoBehaviour
{
    [Header("Add All Enemies Here")]
    public Enemy[] enemies;

    [Space(10)]

    [Header("Levels and Experience")]
    public int level;
    [Space(10)]
    public int experience;
    [Space(10)]
    public int expToLevel2;
    public int expToLevel3;
    public int expToLevel4;
    public int expToLevel5;
    public int expToLevel6;
    public int expToLevel7;
    public int expToLevel8;
    public int expToLevel9;
    public int expToLevel10;


    [Space(2)]

    [Header("GameObjects and Other Stuff")]
    [Space(300)]
    public Paladin paladin;
    public Wizard wizard;
    public EnemyController enemyController;
    public ClickController clickController;
    public EventsChatController eventsChatController;
    public TurnPointsList turnPointsList;

    public GameObject paladinFaceset;
    public GameObject wizardFaceset;
    Animator paladinFacesetAnimator;
    Animator wizardFacesetAnimator;

    [Space(10)]

    public GameObject spaceCanvasOfAreas;
    public GameObject spaceCanvasAreaTxtOne;
    public TextMeshPro timerOfGame;
    float theTime;

    [Space(10)]

    
    public Canvas paladinTurnPointer;
    public Canvas wizardTurnPointer;
    public List<GameObject> bubbleTurnPoints;
    public List<GameObject> middleTextPopUpList;
    float timeForMiddleTextPopUp;
    public GameObject instantiateTurnPointAddPlusPaladin;
    public GameObject instantiateTurnPointAddPlusWizard;
    public GameObject instantiateTurnPointSubtractMinusPaladin;
    public GameObject instantiateTurnPointSubtractMinusWizard;
    public GameObject notEnoughTurnPoints;
    public GameObject notEnoughManaPoints;
    public GameObject paladinNotReadyInstantiate;
    public GameObject wizardNotReadyInstantiate;
    public GameObject paladinIsDeadInstantiate;
    public GameObject wizardIsDeadInstantiate;

    [Space(10)]
    public Animator paladinTurnPoints;
    public Animator wizardTurnPoints;
    public Animator paladinShadow;
    public Animator wizardShadow;
    public Animator paladinBubbleShadow;
    public Animator wizardBubbleShadow;
    public Animator paladinCanvasAnimator;
    public Animator wizardCanvasAnimator;

    [Space(10)]

    public Canvas actionAttackButtonsPaladin;
    public Canvas actionAttackButtonsWizard;
    public Canvas actionArrowsPaladin;
    public Canvas actionArrowsWizard;


    [Space(10)]

    public Canvas waitingAction;
           
    [Space(10)]

    public Canvas canvasCancelPaladinAttack;
    public Canvas canvasCancelPaladinWhiteMagic;
    public Canvas canvasCancelPaladinWhiteMagicSpell;
    public Canvas canvasCancelPaladinSpecial;
    public Canvas canvasCancelPaladinSpecialAction;
    public Canvas canvasCancelPaladinItem;
    public Canvas canvasCancelPaladinItemAction;

    [Space(10)]

    public Canvas canvasCancelWizardAttack;
    public Canvas canvasCancelWizardBlackMagic;
    public Canvas canvasCancelWizardBlackMagicSpell;
    public Canvas canvasCancelWizardSpecial;
    public Canvas canvasCancelWizardSpecialAction;
    public Canvas canvasCancelWizardItem;
    public Canvas canvasCancelWizardItemAction;

    [Space(10)]

    public AttackControllerPaladin attackControllerPaladin;
    public WhiteMagicController whiteMagicController;
    public SpecialControllerPaladin specialControllerPaladin;
    public ItemControllerPaladin itemControllerPaladin;
    public AttackControllerWizard attackControllerWizard;
    public BlackMagicController blackMagicController;
    public SpecialControllerWizard specialControllerWizard;
    public ItemControllerWizard itemControllerWizard;

    [Space(10)]
    public TextMeshPro paladinTurnPointsTxt;
    public TextMeshPro wizardTurnPointsTxt;

    [Space(10)]
    public GameObject mainTabGO;
    public GameObject mainTabToMoveOne;
    public GameObject mainTabToMoveTwo;
    public GameObject mainTabToMoveThree;
    public GameObject mainTabToMoveFour;
    public GameObject mainTabToMoveFive;
    public GameObject mainTabToMoveSix;
    public GameObject mainTabToMoveSeven;    


    [Space(10)]
    public TextMeshProUGUI paladinTabAttackText;
    public TextMeshProUGUI paladinTabMagicText;
    public TextMeshProUGUI paladinTabDefenseText;
    public TextMeshProUGUI paladinTabMagicDefenseText;
    public TextMeshProUGUI paladinTabABModText;

    public TextMeshProUGUI paladinTabIceResistanceText;
    public TextMeshProUGUI paladinTabFireResistanceText;
    public TextMeshProUGUI paladinTabWaterResistanceText;
    public TextMeshProUGUI paladinTabExperienceText;

    [Space(10)]
    public TextMeshProUGUI wizardTabAttackText;
    public TextMeshProUGUI wizardTabMagicText;
    public TextMeshProUGUI wizardTabDefenseText;
    public TextMeshProUGUI wizardTabMagicDefenseText;
    public TextMeshProUGUI wizardTabABModText;

    public TextMeshProUGUI wizardTabIceResistanceText;
    public TextMeshProUGUI wizardTabFireResistanceText;
    public TextMeshProUGUI wizardTabWaterResistanceText;
    public TextMeshProUGUI wizardTabExperienceText;


    [Space(10)]
    public GameObject victoryOrDefeatCanvas;


    [Space(10)]
    public Canvas infoTabPaladinAndWizardInformationOne;
    public Canvas infoTabPaladinAndWizardInformationTwo;


    [Header("Action Button GameObjects")]
    [Space(10)]




    public Canvas actionAttackPaladinButton;
    public Canvas actionWhiteMagicPaladinButton;
    public Canvas actionSpecialPaladinButton;
    public Canvas actionItemPaladinButton;
    public Canvas actionEscapePaladinButton;

    [Space(5)]

    public Canvas actionAttackWizardButton;
    public Canvas actionBlackMagicWizardButton;
    public Canvas actionSpecialWizardButton;
    public Canvas actionItemWizardButton;
    public Canvas actionEscapeWizardButton;

    [Space(5)]

    public Canvas whiteMagicPaladinArrowsBuffs;
    public Canvas whiteMagicPaladinArrowsDebuffs;
    public Canvas whiteMagicPaladinArrowsHeals;

    [Space(5)]

    //public Canvas whiteMagicPaladinBuffs;
    //public Canvas whiteMagicPaladinDebuffs;
    //public Canvas whiteMagicPaladinHeals;

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

    public Canvas blackMagicWizardArrowsOffensive;
    public Canvas blackMagicWizardArrowsEffects;

    [Space(5)]

    //public Canvas blackMagicWizardOffensive;
    //public Canvas blackMagicWizardEffects;

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


    [HideInInspector]
    public bool paladinTurn;
    [HideInInspector]
    public bool wizardTurn;
    [HideInInspector]
    public bool paladinWaiting;
    [HideInInspector]
    public bool wizardWaiting;
    [HideInInspector]
    public bool paladinCanSwap;
    [HideInInspector]
    public bool wizardCanSwap;
    [HideInInspector]
    public int turnsPassed;


    [HideInInspector]
    public bool mainIsActive = true;
    [HideInInspector]
    public bool paladinStatsIsActive;
    [HideInInspector]
    public bool wizardStatsIsActive;


    [HideInInspector]
    public bool someoneDoingAnAction;


    public bool defendingAnAttack;

    [HideInInspector]
    public int numberOfEnemies;


    [HideInInspector]
    public int damageSaverFromAttacks;


    bool infoTabOnOne = true;
    bool infoTabOnTwo;

    bool canSpawn = true;
    bool isWaiting = true;

    public ActionButtonArrow scriptActionArrowsPaladin;
    public ActionButtonArrow scriptActionArrowsWizard;




    void Start()
    {
        //StartCoroutine(PhasesAndTimer());

        paladinFacesetAnimator = paladinFaceset.GetComponent<Animator>();
        wizardFacesetAnimator = wizardFaceset.GetComponent<Animator>();

        UpdatePaladinAndWizardTab();        
    }


    void Update()
    {
        InvokeRepeating("TimeForMiddleTextPopUpMethod", 0, 1f);

        if (canSpawn && numberOfEnemies == 0)
        {
            //Debug.Log("1");
            StartCoroutine(NextArea());
        }




        if (paladin.ab < 1 && wizard.ab < 1 && !paladin.dead && !wizard.dead && isWaiting)
        {
            //Debug.Log("2");
            waitingAction.enabled = true;
            isWaiting = false;
        }


        if (paladin.ab < 1 && wizard.ab < 1 && paladin.dead && wizard.dead)
        {
            //Debug.Log("3");
            waitingAction.enabled = true;
            victoryOrDefeatCanvas.SetActive(true);
            StopAllAB();
        }

        if (paladin.ab < 1 && wizard.ab < 1 && wizard.dead)
        {
            //Debug.Log("4");
            waitingAction.enabled = true;
        }

        if (paladin.ab < 1 && wizard.ab < 1 && paladin.dead)
        {
            //Debug.Log("5");
            waitingAction.enabled = true;
        }




        if (paladin.ab >= 1 && paladin.dead)
        {
            isWaiting = true;
            //Debug.Log("6");
            paladinTurn = false;
            paladinCanSwap = false;
            wizardWaiting = false;

            paladinTurnPointer.enabled = false;

            paladinFacesetAnimator.ResetTrigger("Selected");
            paladinFacesetAnimator.ResetTrigger("Idle");
            paladinFacesetAnimator.SetTrigger("Idle");

            actionAttackButtonsPaladin.enabled = false;
            actionArrowsPaladin.enabled = false;

            waitingAction.enabled = false;


        }


        if (wizard.ab >= 1 && wizard.dead)
        {
            isWaiting = true;

            //Debug.Log("7");
            wizardTurn = false;
            wizardCanSwap = false;
            paladinWaiting = false;

            wizardTurnPointer.enabled = false;

            wizardFacesetAnimator.ResetTrigger("Selected");
            wizardFacesetAnimator.ResetTrigger("Idle");
            wizardFacesetAnimator.SetTrigger("Idle");

            actionAttackButtonsWizard.enabled = false;
            actionArrowsWizard.enabled = false;

            waitingAction.enabled = false;


        }



        if (paladin.ab >= 1 && !paladinTurn && !wizardTurn && !paladin.dead)
        {
            isWaiting = true;

            //Debug.Log("8");
            paladinTurn = true;
            paladinCanSwap = false;
            wizardWaiting = true;
            paladinTurnPointer.enabled = true;

            paladinFacesetAnimator.ResetTrigger("Selected");
            paladinFacesetAnimator.SetTrigger("Selected");

            //StopAllAB();

            waitingAction.enabled = false;

            scriptActionArrowsPaladin.ResetThisButton();
        }
        


        if (wizard.ab >= 1 && !paladinTurn && !wizardTurn && !wizard.dead)
        {
            isWaiting = true;

            //Debug.Log("9");
            wizardTurn = true;
            wizardCanSwap = false;
            paladinWaiting = true;
            wizardTurnPointer.enabled = true;

            wizardFacesetAnimator.ResetTrigger("Selected");
            wizardFacesetAnimator.SetTrigger("Selected");

            //StopAllAB();

            waitingAction.enabled = false;

            scriptActionArrowsWizard.ResetThisButton();
        }




        if (paladin.ab >= 1 && !paladinTurn && wizardTurn && paladinWaiting)
        {
            isWaiting = true;

            //Debug.Log("10");
            paladinWaiting = false;
            paladinCanSwap = true;
            paladinFacesetAnimator.ResetTrigger("WaitingForSelect");
            paladinFacesetAnimator.SetTrigger("WaitingForSelect");
        }

        if (wizard.ab >= 1 && paladinTurn && !wizardTurn && wizardWaiting)
        {
            isWaiting = true;

            //Debug.Log("11");
            wizardWaiting = false;
            wizardCanSwap = true;
            wizardFacesetAnimator.ResetTrigger("WaitingForSelect");
            wizardFacesetAnimator.SetTrigger("WaitingForSelect");
        }
    }

    IEnumerator PhasesAndTimer()
    {
        while (theTime <= 2000000000000000000)
        {
            theTime = Time.timeSinceLevelLoad;

            int minutes = Mathf.FloorToInt(theTime / 60F);
            int seconds = Mathf.FloorToInt(theTime - minutes * 60);
            string niceTime = string.Format("{00:00}:{01:00}", minutes, seconds);

            timerOfGame.text = niceTime;

            yield return new WaitForSeconds(0.5f);
        }
    }

    public void StopAllAB()
    {
        paladin.startAB = false;
        wizard.startAB = false;

        foreach (var enemy in enemies)
        {
            enemy.startAB = false;
        }
    }

    public void ContinueAllAB()
    {
        paladin.startAB = true;
        wizard.startAB = true;

        foreach (var enemy in enemies)
        {
            enemy.startAB = true;
        }
    }


    public void OnClickInfoTab()
    {
        if (infoTabOnOne)
        {
            infoTabPaladinAndWizardInformationOne.enabled = false;
            infoTabPaladinAndWizardInformationTwo.enabled = true;


            infoTabOnOne = false;
            infoTabOnTwo = true;
        }

        else if (infoTabOnTwo)
        {
            infoTabPaladinAndWizardInformationTwo.enabled = false;
            infoTabPaladinAndWizardInformationOne.enabled = true;

            infoTabOnTwo = false;
            infoTabOnOne = true;
        }
    }


    public void CloseAllPaladinsActionsWhenDead()
    {
        if (canvasCancelPaladinAttack.enabled)
        {         
            attackControllerPaladin.OnCancelAttack();
        }

        if (canvasCancelPaladinWhiteMagic.enabled)
        {            
            whiteMagicController.OnCancelWhiteMagic();
        }

        if (canvasCancelPaladinWhiteMagicSpell.enabled)
        {            
            whiteMagicController.OnCancelWhiteMagicSpell();
            whiteMagicController.OnCancelWhiteMagic();            
        }

        if (canvasCancelPaladinSpecial.enabled)
        {
            specialControllerPaladin.OnCancelSpecial();
        }

        if (canvasCancelPaladinSpecialAction.enabled)
        {
            specialControllerPaladin.OnCancelSpecialAction();
            specialControllerPaladin.OnCancelSpecial();
        }

        if (canvasCancelPaladinItem.enabled)
        {
            itemControllerPaladin.OnCancelItems();
        }

        if (canvasCancelPaladinItemAction.enabled)
        {
            itemControllerPaladin.OnCancelItemsAction();
            itemControllerPaladin.OnCancelItems();
        }

        actionAttackButtonsPaladin.enabled = false;

        paladinTurnPointer.enabled = false;
    }

    public void CloseAllWizardsActionsWhenDead()
    {
        if (canvasCancelWizardAttack.enabled)
        {
            attackControllerWizard.OnCancelAttack();
        }

        if (canvasCancelWizardBlackMagic.enabled)
        {
            blackMagicController.OnCancelBlackMagic();
        }

        if (canvasCancelWizardBlackMagicSpell.enabled)
        {
            blackMagicController.OnCancelBlackMagicSpell();
            blackMagicController.OnCancelBlackMagic();
        }

        if (canvasCancelWizardSpecial.enabled)
        {
            specialControllerWizard.OnCancelSpecial();
        }

        if (canvasCancelWizardSpecialAction.enabled)
        {
            specialControllerWizard.OnCancelSpecialAction();
            specialControllerWizard.OnCancelSpecial();
        }

        if (canvasCancelWizardItem.enabled)
        {
            itemControllerWizard.OnCancelItems();
        }

        if (canvasCancelWizardItemAction.enabled)
        {
            itemControllerWizard.OnCancelItemsAction();
            itemControllerWizard.OnCancelItems();
        }

        actionAttackButtonsWizard.enabled = false;

        wizardTurnPointer.enabled = false;
    }


    public void OnClickSwapToPaladin()
    {
        if (paladinCanSwap && someoneDoingAnAction == false)
        {
            if (canvasCancelWizardAttack.enabled)
            {
                attackControllerWizard.OnCancelAttack();
            }

            if (canvasCancelWizardBlackMagic.enabled)
            {
                blackMagicController.OnCancelBlackMagic();
            }

            if (canvasCancelWizardBlackMagicSpell.enabled)
            {
                blackMagicController.OnCancelBlackMagicSpell();
                blackMagicController.OnCancelBlackMagic();
            }

            if (canvasCancelWizardSpecial.enabled)
            {
                specialControllerWizard.OnCancelSpecial();
            }

            if (canvasCancelWizardSpecialAction.enabled)
            {
                specialControllerWizard.OnCancelSpecialAction();
                specialControllerWizard.OnCancelSpecial();
            }

            if (canvasCancelWizardItem.enabled)
            {
                itemControllerWizard.OnCancelItems();
            }

            if (canvasCancelWizardItemAction.enabled)
            {
                itemControllerWizard.OnCancelItemsAction();
                itemControllerWizard.OnCancelItems();
            }

            scriptActionArrowsPaladin.ResetThisButton();

            wizardTurnPointer.enabled = false;
            paladinTurnPointer.enabled = true;

            wizardFacesetAnimator.ResetTrigger("Selected");
            wizardFacesetAnimator.ResetTrigger("WaitingForSelect");
            wizardFacesetAnimator.SetTrigger("WaitingForSelect");

            paladinFacesetAnimator.ResetTrigger("WaitingForSelect");
            paladinFacesetAnimator.ResetTrigger("Selected");
            paladinFacesetAnimator.SetTrigger("Selected");

            paladinCanSwap = false;
            paladinWaiting = false;
            paladinTurn = true;

            wizardWaiting = true;
            wizardTurn = false;
            wizardCanSwap = false;
        }
    }

    public void OnClickSwapToWizard()
    {       
        if (wizardCanSwap && someoneDoingAnAction == false)
        {
            if (canvasCancelPaladinAttack.enabled)
            {
                attackControllerPaladin.OnCancelAttack();
            }

            if (canvasCancelPaladinWhiteMagic.enabled)
            {
                whiteMagicController.OnCancelWhiteMagic();
            }

            if (canvasCancelPaladinWhiteMagicSpell.enabled)
            {
                whiteMagicController.OnCancelWhiteMagicSpell();
                whiteMagicController.OnCancelWhiteMagic();
            }

            if (canvasCancelPaladinSpecial.enabled)
            {
                specialControllerPaladin.OnCancelSpecial();
            }

            if (canvasCancelPaladinSpecialAction.enabled)
            {
                specialControllerPaladin.OnCancelSpecialAction();
                specialControllerPaladin.OnCancelSpecial();
            }

            if (canvasCancelPaladinItem.enabled)
            {
                itemControllerPaladin.OnCancelItems();
            }

            if (canvasCancelPaladinItemAction.enabled)
            {
                itemControllerPaladin.OnCancelItemsAction();
                itemControllerPaladin.OnCancelItems();
            }

            scriptActionArrowsWizard.ResetThisButton();

            paladinTurnPointer.enabled = false;
            wizardTurnPointer.enabled = true;

            paladinFacesetAnimator.ResetTrigger("Selected");
            paladinFacesetAnimator.ResetTrigger("WaitingForSelect");
            paladinFacesetAnimator.SetTrigger("WaitingForSelect");

            wizardFacesetAnimator.ResetTrigger("WaitingForSelect");
            wizardFacesetAnimator.ResetTrigger("Selected");
            wizardFacesetAnimator.SetTrigger("Selected");

            wizardCanSwap = false;
            wizardWaiting = false;
            wizardTurn = true;

            paladinWaiting = true;
            paladinTurn = false;
            paladinCanSwap = false;
        }
    }
       

       

    void TimeForMiddleTextPopUpMethod()
    {
        timeForMiddleTextPopUp += 1;
    }

    public void NotEnoughTurnPointsMethod()
    {
        if (timeForMiddleTextPopUp > 1)
        {
            foreach (var textPopUp in middleTextPopUpList)
            {
                if (textPopUp.activeSelf == false)
                {
                    textPopUp.SetActive(true);
                    timeForMiddleTextPopUp = 0;
                    break;
                }
            }
        }
    }




    public void PaladinDied()
    {
        paladin.dead = true;
        paladinTurnPoints.SetBool("Dying", true);
        paladinShadow.SetBool("Dying", true);
        paladinBubbleShadow.SetBool("Dying", true);
        paladinCanvasAnimator.SetBool("Dying", true);

        if (canvasCancelPaladinAttack.enabled)
        {            
            attackControllerPaladin.OnCancelAttack();
        }


        actionArrowsPaladin.enabled = false;
        actionAttackButtonsPaladin.enabled = false;


        paladinTurnPointer.enabled = false;
    }

    public void WizardDied()
    {
        wizard.dead = true;
        wizardTurnPoints.SetBool("Dying", true);
        wizardShadow.SetBool("Dying", true);
        wizardBubbleShadow.SetBool("Dying", true);
        wizardCanvasAnimator.SetBool("Dying", true);


        if (canvasCancelWizardAttack.enabled)
        {
            attackControllerWizard.OnCancelAttack();
        }

        actionArrowsWizard.enabled = false;
        actionAttackButtonsWizard.enabled = false;

        wizardTurnPointer.enabled = false;
    }



    public void UpdatePaladinAndWizardTab()
    {
        paladinTabAttackText.text = "Attack " + "<color=#FFE36E>" + paladin.attack.ToString() + "</color>" + " Mod. " + "<color=#FFA323>" + paladin.attackModifierPercentage.ToString() + "%" + "</color>";
        paladinTabMagicText.text = "Magic " + "<color=#FFE36E>" + paladin.magic.ToString() + "</color>" + " Mod. " + "<color=#FFA323>" + paladin.magicModifierPercentage.ToString() + "%" + "</color>";
        paladinTabDefenseText.text = "Defense " + "<color=#FFE36E>" + paladin.defense.ToString() + "</color>" + " Mod. " + "<color=#FFA323>" + paladin.defenseModifierPercentage.ToString() + "%" + "</color>";
        paladinTabMagicDefenseText.text = "M. Def. " + "<color=#FFE36E>" + paladin.magicDefense.ToString() + "</color>" + " Mod. " + "<color=#FFA323>" + paladin.magicDefenseModifierPercentage.ToString() + "%" + "</color>";
        paladinTabABModText.text = "AB Mod. " + "<color=#FFA323>" + paladin.abModifierPercentage.ToString() + "%" + "</color>";

        paladinTabIceResistanceText.text = "Ice Resistance " + "<color=#FFE36E>" + paladin.iceResistance.ToString() + "%" + "</color>";
        paladinTabFireResistanceText.text = "Fire Resistance " + "<color=#FFE36E>" + paladin.fireResistance.ToString() + "%" + "</color>";
        paladinTabWaterResistanceText.text = "Water Resistance " + "<color=#FFE36E>" + paladin.waterResistance.ToString() + "%" + "</color>";
        paladinTabExperienceText.text = "Experience " + "<color=#FFE407>" + experience.ToString() + "</color>";


        wizardTabAttackText.text = "Attack " + "<color=#FFE36E>" + wizard.attack.ToString() + "</color>" + " Mod. " + "<color=#FFA323>" + wizard.attackModifierPercentage.ToString() + "%" + "</color>";
        wizardTabMagicText.text = "Magic " + "<color=#FFE36E>" + wizard.magic.ToString() + "</color>" + " Mod. " + "<color=#FFA323>" + wizard.magicModifierPercentage.ToString() + "%" + "</color>";
        wizardTabDefenseText.text = "Defense " + "<color=#FFE36E>" + wizard.defense.ToString() + "</color>" + " Mod. " + "<color=#FFA323>" + wizard.defenseModifierPercentage.ToString() + "%" + "</color>";
        wizardTabMagicDefenseText.text = "M. Def. " + "<color=#FFE36E>" + wizard.magicDefense.ToString() + "</color>" + " Mod. " + "<color=#FFA323>" + paladin.magicDefenseModifierPercentage.ToString() + "%" + "</color>";
        wizardTabABModText.text = "AB Mod. " + "<color=#FFA323>" + wizard.abModifierPercentage.ToString() + "%" + "</color>";

        wizardTabIceResistanceText.text = "Ice Resistance " + "<color=#FFE36E>" + wizard.iceResistance.ToString() + "%" + "</color>";
        wizardTabFireResistanceText.text = "Fire Resistance " + "<color=#FFE36E>" + wizard.fireResistance.ToString() + "%" + "</color>";
        wizardTabWaterResistanceText.text = "Water Resistance " + "<color=#FFE36E>" + wizard.waterResistance.ToString() + "%" + "</color>";
        wizardTabExperienceText.text = "Experience " + "<color=#FFE407>" + experience.ToString() + "</color>";
    }



    IEnumerator NextArea()
    {
        canSpawn = false;

        if (numberOfEnemies == 0)
        {
            if (enemyController.a1Spawn1Boar == true)
            {
                enemyController.a1Spawn1Boar = false;
                enemyController.a1Spawn2Boar = true;
                NextAreaSpawnShort();
                canSpawn = true;
                yield return new WaitForSeconds(3f);
                yield break;
            }

            if (enemyController.a1Spawn2Boar == true)
            {
                enemyController.a1Spawn2Boar = false;
                enemyController.a1Spawn3Boar = true;
                NextAreaSpawnShort();
                canSpawn = true;
                yield return new WaitForSeconds(3f);
                yield break;
            }

            if (enemyController.a1Spawn3Boar == true)
            {
                enemyController.a1Spawn3Boar = false;
                enemyController.a1Spawn1DarkBoar = true;
                NextAreaSpawnShort();
                canSpawn = true;
                yield return new WaitForSeconds(3f);
                yield break;
            }

            if (enemyController.a1Spawn1DarkBoar == true)
            {
                enemyController.a1Spawn1DarkBoar = false;
                enemyController.a1Spawn2DarkBoar = true;
                NextAreaSpawnShort();
                canSpawn = true;
                yield return new WaitForSeconds(3f);
                yield break;
            }

            if (enemyController.a1Spawn2DarkBoar == true)
            {
                enemyController.a1Spawn2DarkBoar = false;
                enemyController.a1Spawn3Boar1DarkBoar = true;
                NextAreaSpawnShort();
                canSpawn = true;
                yield return new WaitForSeconds(3f);
                yield break;
            }

            if (enemyController.a1Spawn3Boar1DarkBoar == true)
            {
                enemyController.a1Spawn3Boar1DarkBoar = false;
                enemyController.a1Spawn3Boar2DarkBoar = true;
                NextAreaSpawnShort();
                canSpawn = true;
                yield return new WaitForSeconds(3f);
                yield break;
            }

            if (enemyController.a1Spawn3Boar2DarkBoar == true)
            {

                NextAreaSpawnShort();
                canSpawn = true;
                yield return new WaitForSeconds(3f);
                yield break;
            }
        }
    }

    void NextAreaSpawnShort()
    {
        enemyController.SpawnEnemies();
        //enemies = FindObjectsOfType<Enemy>();
        //clickController.RefreshOnClickOnEnemies();
    }

    string GainingExperienceText()
    {
        //float theTime = Time.timeSinceLevelLoad;

        //int minutes = Mathf.FloorToInt(theTime / 60F);
        //int seconds = Mathf.FloorToInt(theTime - minutes * 60);
        //string niceTime = string.Format("{00:00}:{01:00}", minutes, seconds);

        //return "<color=#FFFA09> Level Up!</color>";
        //return "(" + niceTime + ")" + "<color=#FFFA09> Level Up!</color>";

        return "<color=#FFFA09>Level Up!</color>";
    }

    string GainingExperienceTextTwo()
    {
        //float theTime = Time.timeSinceLevelLoad;

        //int minutes = Mathf.FloorToInt(theTime / 60F);
        //int seconds = Mathf.FloorToInt(theTime - minutes * 60);
        //string niceTime = string.Format("{00:00}:{01:00}", minutes, seconds);

        ////return " You are now at <color=#FFFA09>Level " + level.ToString() + "</color>";
        //return "(" + niceTime + ")" + " You are now at <color=#FFFA09>Level " + level.ToString() + "</color>";

        return "You are now at <color=#FFFA09>Level " + level.ToString() + "</color>.";
    }

    public void GainingExperience()
    {
        StartCoroutine(GainingExperienceCoroutine());
    }

    IEnumerator GainingExperienceCoroutine()
    {
        if (level == 1 && experience >= expToLevel2)
        {
            level = 2;

            //eventsChatController.SendMessageToChatFromOtherScripts(GainingExperienceText());
            eventsChatController.SendMessageToChatFromOtherScripts(GainingExperienceTextTwo());
        }

        else if (level == 2 && experience >= expToLevel3)
        {
            level = 3;

            //eventsChatController.SendMessageToChatFromOtherScripts(GainingExperienceText());
            eventsChatController.SendMessageToChatFromOtherScripts(GainingExperienceTextTwo());
        }

        else if (level == 3 && experience >= expToLevel4)
        {
            level = 4;

            //eventsChatController.SendMessageToChatFromOtherScripts(GainingExperienceText());
            eventsChatController.SendMessageToChatFromOtherScripts(GainingExperienceTextTwo());
        }

        if (level == 4 && experience >= expToLevel5)
        {
            level = 5;

            //eventsChatController.SendMessageToChatFromOtherScripts(GainingExperienceText());
            eventsChatController.SendMessageToChatFromOtherScripts(GainingExperienceTextTwo());
        }

        else if (level == 5 && experience >= expToLevel6)
        {
            level = 6;

            //eventsChatController.SendMessageToChatFromOtherScripts(GainingExperienceText());
            eventsChatController.SendMessageToChatFromOtherScripts(GainingExperienceTextTwo());
        }

        else if (level == 6 && experience >= expToLevel7)
        {
            level = 7;

            //eventsChatController.SendMessageToChatFromOtherScripts(GainingExperienceText());
            eventsChatController.SendMessageToChatFromOtherScripts(GainingExperienceTextTwo());
        }

        else if (level == 7 && experience >= expToLevel8)
        {
            level = 8;

            //eventsChatController.SendMessageToChatFromOtherScripts(GainingExperienceText());
            eventsChatController.SendMessageToChatFromOtherScripts(GainingExperienceTextTwo());
        }

        else if (level == 8 && experience >= expToLevel9)
        {
            level = 9;

            //eventsChatController.SendMessageToChatFromOtherScripts(GainingExperienceText());
            eventsChatController.SendMessageToChatFromOtherScripts(GainingExperienceTextTwo());
        }

        else if (level == 9 && experience >= expToLevel10)
        {
            level = 10;

            //eventsChatController.SendMessageToChatFromOtherScripts(GainingExperienceText());
            eventsChatController.SendMessageToChatFromOtherScripts(GainingExperienceTextTwo());
        }
        yield return new WaitForSeconds(0.01f);
    }



    public void SetArrowsCanvasOff()
    {
        actionArrowsPaladin.enabled = false;
        actionArrowsWizard.enabled = false;

        whiteMagicPaladinArrowsBuffs.enabled = false;
        whiteMagicPaladinArrowsDebuffs.enabled = false;
        whiteMagicPaladinArrowsHeals.enabled = false;

        blackMagicWizardArrowsOffensive.enabled = false;
        blackMagicWizardArrowsEffects.enabled = false;

    }

    public void SetButtonCanvasOff()
    {
        actionAttackPaladinButton.enabled = false;
        actionWhiteMagicPaladinButton.enabled = false;
        actionSpecialPaladinButton.enabled = false;
        actionItemPaladinButton.enabled = false;
        actionEscapePaladinButton.enabled = false;

        actionAttackWizardButton.enabled = false;
        actionBlackMagicWizardButton.enabled = false;
        actionSpecialWizardButton.enabled = false;
        actionItemWizardButton.enabled = false;
        actionEscapeWizardButton.enabled = false;

        whiteMagicPaladinBuffsBlockOne.enabled = false;
        whiteMagicPaladinBuffsBlockTwo.enabled = false;
        whiteMagicPaladinBuffsBlockThree.enabled = false;
        whiteMagicPaladinBuffsBlockFour.enabled = false;
        whiteMagicPaladinBuffsBlockFive.enabled = false;
        whiteMagicPaladinBuffsBlockSix.enabled = false;

        whiteMagicPaladinDebuffsBlockOne.enabled = false;
        whiteMagicPaladinDebuffsBlockTwo.enabled = false;
        whiteMagicPaladinDebuffsBlockThree.enabled = false;
        whiteMagicPaladinDebuffsBlockFour.enabled = false;
        whiteMagicPaladinDebuffsBlockFive.enabled = false;
        whiteMagicPaladinDebuffsBlockSix.enabled = false;

        whiteMagicPaladinHealsBlockOne.enabled = false;

        blackMagicWizardOffensiveBlockOne.enabled = false;
        blackMagicWizardOffensiveBlockTwo.enabled = false;
        blackMagicWizardOffensiveBlockThree.enabled = false;
        blackMagicWizardOffensiveBlockFour.enabled = false;
        blackMagicWizardOffensiveBlockFive.enabled = false;
        blackMagicWizardOffensiveBlockSix.enabled = false;

        blackMagicWizardEffectsBlockOne.enabled = false;
        blackMagicWizardEffectsBlockTwo.enabled = false;
        blackMagicWizardEffectsBlockThree.enabled = false;
        blackMagicWizardEffectsBlockFour.enabled = false;
    }
}
