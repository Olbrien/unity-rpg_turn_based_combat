using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ClickController : MonoBehaviour
{
    public GameController gameController;
    public ShakingCamera shakingCamera;
    public AttackControllerPaladin attackControllerPaladin;
    public AttackControllerWizard attackControllerWizard;
    public WhiteMagicController whiteMagicController;
    public BlackMagicController blackMagicController;
    public SpellController spellController;
    public TurnPointsController turnPointsController;

    public Paladin paladin;
    public Wizard wizard;

    Enemy enemy;


    public GameObject paladinFaceset;
    public GameObject wizardFaceset;
    Animator paladinFacesetAnimator;
    Animator wizardFacesetAnimator;


    public GameObject damageFloatPaladinCanvasPrefab;
    public GameObject damageFloatWizardCanvasPrefab;
    [Space(10)]
    public GameObject damageFloatBoarEnemyCanvasPrefab;
    public GameObject damageFloatDarkBoarEnemyCanvasPrefab;

    [Space(10)]
    public GameObject paladinShadow;
    public GameObject wizardShadow;

    GameObject thisGameObject;
    Animator thisAnimator;

    Animator paladinAnimator;
    Animator wizardAnimator;

    SpriteRenderer spriteRendererPaladin;
    SpriteRenderer spriteRendererWizard;

    [Header("Paladin")]
    public GameObject paladinGO;
    public bool paladinIsAttacking;
    public bool paladinIsUsingWhiteMagic;
    public bool paladinIsUsingSpecial;
    public bool paladinIsUsingItem;




    [Header("Wizard")]
    public GameObject wizardGO;
    public bool wizardIsAttacking;
    public bool wizardIsUsingBlackMagic;
    public bool wizardIsUsingSpecial;
    public bool wizardIsUsingItem;



    Vector3 paladinInitialPosition;
    Vector3 wizardInitialPosition;

    GameObject[] findAllEnemyClick;
    GameObject findPaladinClick;
    GameObject findWizardClick;


    void Start()
    {
        paladinInitialPosition = paladinGO.transform.root.localPosition;
        wizardInitialPosition = wizardGO.transform.root.localPosition;

        paladinAnimator = paladinGO.GetComponent<Animator>();
        wizardAnimator = wizardGO.GetComponent<Animator>();

        spriteRendererPaladin = paladin.GetComponent<SpriteRenderer>();
        spriteRendererWizard = wizard.GetComponent<SpriteRenderer>();

        paladinFacesetAnimator = paladinFaceset.GetComponent<Animator>();
        wizardFacesetAnimator = wizardFaceset.GetComponent<Animator>();
    }

    
    void Update()
    {
        
    }



    //public void RefreshOnClickOnEnemies()
    //{
    //    findAllEnemyClick = GameObject.FindGameObjectsWithTag("EnemyClick");

    //    foreach (var click in findAllEnemyClick)
    //    {
    //        click.GetComponent<Button>().onClick.AddListener(ClickAction);
    //    }
    //}

    //public void RefreshOnClickOnPaladin()
    //{
    //    findPaladinClick = GameObject.FindGameObjectWithTag("PaladinClick");

    //    findPaladinClick.GetComponent<Button>().onClick.AddListener(ClickAction);
    //}

    //public void RefreshOnClickOnWizard()
    //{
    //    findWizardClick = GameObject.FindGameObjectWithTag("WizardClick");

    //    findWizardClick.GetComponent<Button>().onClick.AddListener(ClickAction);
    //}


    public void ClickAction()
    {      
        if (paladinIsAttacking == true)
        {
            PaladinAttackingAction();
        }

        if (wizardIsAttacking == true)
        {
            WizardAttackingAction();
        }

        if (paladinIsUsingWhiteMagic == true)
        {
            PaladinUsingWhiteMagicAction();
        }

        if (wizardIsUsingBlackMagic == true)
        {
            WizardUsingBlackMagicAction();
        }

        if (paladinIsUsingSpecial == true)
        {
            PaladinUsingSpecialAction();
        }

        if (wizardIsUsingSpecial == true)
        {
            WizardUsingSpecialAction();
        }

        if (paladinIsUsingItem == true)
        {
            PaladinUsingItemAction();
        }

        if (wizardIsUsingItem == true)
        {
            WizardUsingItemAction();
        }
    }


    ////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////
    ///

    void PaladinAttackingAction()
    {      
        ////
        //BOAR
        ////

        if (EventSystem.current.currentSelectedGameObject.tag == "EnemyClick" &&
                                                 EventSystem.current.currentSelectedGameObject.name == "Boar Click")
        {
            StartCoroutine(PaladinAttackCoroutine(0.75f, 0.05f));
        }


        ////
        //DARK BOAR
        ////

        else if (EventSystem.current.currentSelectedGameObject.tag == "EnemyClick" &&
                                         EventSystem.current.currentSelectedGameObject.name == "Dark Boar Click")
        {
            StartCoroutine(PaladinAttackCoroutine(0.75f, 0.05f));
        }
        
    }

    void WizardAttackingAction()
    {
        ////
        //BOAR
        ////

        if (EventSystem.current.currentSelectedGameObject.tag == "EnemyClick" &&
                                                 EventSystem.current.currentSelectedGameObject.name == "Boar Click")
        {
            StartCoroutine(WizardAttackCoroutine(0.75f, 0.01f));
        }


        ////
        //DARK BOAR
        ////

        else if (EventSystem.current.currentSelectedGameObject.tag == "EnemyClick" &&
                                         EventSystem.current.currentSelectedGameObject.name == "Dark Boar Click")
        {
            StartCoroutine(WizardAttackCoroutine(0.75f, 0.01f));
        }
    }



    ////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////


    void PaladinUsingWhiteMagicAction()
    {
        if (whiteMagicController.agiltyOne)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "PaladinClick")
            {
                StartCoroutine(WhiteMagicSinglePaladinClick(turnPointsController.agilityOneTP));
            }

            else if (EventSystem.current.currentSelectedGameObject.tag == "WizardClick")
            {
                StartCoroutine(WhiteMagicSingleWizardClick(turnPointsController.agilityOneTP));
            }
        }

        else if (whiteMagicController.agiltyTwo)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "PaladinClick")
            {
                StartCoroutine(WhiteMagicSinglePaladinClick(turnPointsController.agilityTwoTP));
            }

            else if (EventSystem.current.currentSelectedGameObject.tag == "WizardClick")
            {
                StartCoroutine(WhiteMagicSingleWizardClick(turnPointsController.agilityTwoTP));
            }
        }

        else if (whiteMagicController.agiltyThree)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "PaladinClick")
            {
                StartCoroutine(WhiteMagicSinglePaladinClick(turnPointsController.agilityThreeTP));
            }

            else if (EventSystem.current.currentSelectedGameObject.tag == "WizardClick")
            {
                StartCoroutine(WhiteMagicSingleWizardClick(turnPointsController.agilityThreeTP));
            }
        }



        else if (whiteMagicController.strenghtOne)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "PaladinClick")
            {
                StartCoroutine(WhiteMagicSinglePaladinClick(turnPointsController.strenghtOneTP));
            }

            else if (EventSystem.current.currentSelectedGameObject.tag == "WizardClick")
            {
                StartCoroutine(WhiteMagicSingleWizardClick(turnPointsController.strenghtOneTP));
            }
        }


        else if (whiteMagicController.strenghtTwo)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "PaladinClick")
            {
                StartCoroutine(WhiteMagicSinglePaladinClick(turnPointsController.strenghtTwoTP));
            }

            else if (EventSystem.current.currentSelectedGameObject.tag == "WizardClick")
            {
                StartCoroutine(WhiteMagicSingleWizardClick(turnPointsController.strenghtTwoTP));
            }
        }

        else if (whiteMagicController.strenghtThree)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "PaladinClick")
            {
                StartCoroutine(WhiteMagicSinglePaladinClick(turnPointsController.strenghtThreeTP));
            }

            else if (EventSystem.current.currentSelectedGameObject.tag == "WizardClick")
            {
                StartCoroutine(WhiteMagicSingleWizardClick(turnPointsController.strenghtThreeTP));
            }
        }




        else if (whiteMagicController.armorProtectionOne)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "PaladinClick")
            {
                StartCoroutine(WhiteMagicSinglePaladinClick(turnPointsController.armorProtectionOneTP));
            }

            else if (EventSystem.current.currentSelectedGameObject.tag == "WizardClick")
            {
                StartCoroutine(WhiteMagicSingleWizardClick(turnPointsController.armorProtectionOneTP));
            }
        }


        else if (whiteMagicController.armorProtectionTwo)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "PaladinClick")
            {
                StartCoroutine(WhiteMagicSinglePaladinClick(turnPointsController.armorProtectionTwoTP));
            }

            else if (EventSystem.current.currentSelectedGameObject.tag == "WizardClick")
            {
                StartCoroutine(WhiteMagicSingleWizardClick(turnPointsController.armorProtectionTwoTP));
            }
        }

        else if (whiteMagicController.armorProtectionThree)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "PaladinClick")
            {
                StartCoroutine(WhiteMagicSinglePaladinClick(turnPointsController.armorProtectionThreeTP));
            }

            else if (EventSystem.current.currentSelectedGameObject.tag == "WizardClick")
            {
                StartCoroutine(WhiteMagicSingleWizardClick(turnPointsController.armorProtectionThreeTP));
            }
        }





        else if (whiteMagicController.magicProtectionOne)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "PaladinClick")
            {
                StartCoroutine(WhiteMagicSinglePaladinClick(turnPointsController.magicProtectionOneTP));
            }

            else if (EventSystem.current.currentSelectedGameObject.tag == "WizardClick")
            {
                StartCoroutine(WhiteMagicSingleWizardClick(turnPointsController.magicProtectionOneTP));
            }
        }


        else if (whiteMagicController.magicProtectionTwo)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "PaladinClick")
            {
                StartCoroutine(WhiteMagicSinglePaladinClick(turnPointsController.magicProtectionTwoTP));
            }

            else if (EventSystem.current.currentSelectedGameObject.tag == "WizardClick")
            {
                StartCoroutine(WhiteMagicSingleWizardClick(turnPointsController.magicProtectionTwoTP));
            }
        }

        else if (whiteMagicController.magicProtectionThree)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "PaladinClick")
            {
                StartCoroutine(WhiteMagicSinglePaladinClick(turnPointsController.magicProtectionThreeTP));
            }

            else if (EventSystem.current.currentSelectedGameObject.tag == "WizardClick")
            {
                StartCoroutine(WhiteMagicSingleWizardClick(turnPointsController.magicProtectionThreeTP));
            }
        }




        else if (whiteMagicController.magicUpOne)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "PaladinClick")
            {
                StartCoroutine(WhiteMagicSinglePaladinClick(turnPointsController.magicUpOneTP));
            }

            else if (EventSystem.current.currentSelectedGameObject.tag == "WizardClick")
            {
                StartCoroutine(WhiteMagicSingleWizardClick(turnPointsController.magicUpOneTP));
            }
        }


        else if (whiteMagicController.magicUpTwo)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "PaladinClick")
            {
                StartCoroutine(WhiteMagicSinglePaladinClick(turnPointsController.magicUpTwoTP));
            }

            else if (EventSystem.current.currentSelectedGameObject.tag == "WizardClick")
            {
                StartCoroutine(WhiteMagicSingleWizardClick(turnPointsController.magicUpTwoTP));
            }
        }

        else if (whiteMagicController.magicUpThree)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "PaladinClick")
            {
                StartCoroutine(WhiteMagicSinglePaladinClick(turnPointsController.magicUpThreeTP));
            }

            else if (EventSystem.current.currentSelectedGameObject.tag == "WizardClick")
            {
                StartCoroutine(WhiteMagicSingleWizardClick(turnPointsController.magicUpThreeTP));
            }
        }



        else if (whiteMagicController.higherVitalityUpOne)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "PaladinClick")
            {
                StartCoroutine(WhiteMagicSinglePaladinClick(turnPointsController.higherVitalityUpOneTP));
            }

            else if (EventSystem.current.currentSelectedGameObject.tag == "WizardClick")
            {
                StartCoroutine(WhiteMagicSingleWizardClick(turnPointsController.higherVitalityUpOneTP));
            }
        }


        else if (whiteMagicController.higherVitalityUpTwo)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "PaladinClick")
            {
                StartCoroutine(WhiteMagicSinglePaladinClick(turnPointsController.higherVitalityUpTwoTP));
            }

            else if (EventSystem.current.currentSelectedGameObject.tag == "WizardClick")
            {
                StartCoroutine(WhiteMagicSingleWizardClick(turnPointsController.higherVitalityUpTwoTP));
            }
        }

        else if (whiteMagicController.higherVitalityUpThree)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "PaladinClick")
            {
                StartCoroutine(WhiteMagicSinglePaladinClick(turnPointsController.higherVitalityUpThreeTP));
            }

            else if (EventSystem.current.currentSelectedGameObject.tag == "WizardClick")
            {
                StartCoroutine(WhiteMagicSingleWizardClick(turnPointsController.higherVitalityUpThreeTP));
            }
        }







        else if (whiteMagicController.clumsyOne)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "EnemyClick")
            {
                StartCoroutine(WhiteMagicSingleEnemyClick(turnPointsController.clumsyOneTP));
            }
        }


        else if (whiteMagicController.clumsyTwo)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "EnemyClick")
            {
                StartCoroutine(WhiteMagicSingleEnemyClick(turnPointsController.clumsyTwoTP));
            }
        }

        else if (whiteMagicController.clumsyThree)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "EnemyClick")
            {
                StartCoroutine(WhiteMagicSingleEnemyClick(turnPointsController.clumsyThreeTP));
            }
        }





        else if (whiteMagicController.weakenOne)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "EnemyClick")
            {
                StartCoroutine(WhiteMagicSingleEnemyClick(turnPointsController.weakenOneTP));
            }
        }


        else if (whiteMagicController.weakenTwo)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "EnemyClick")
            {
                StartCoroutine(WhiteMagicSingleEnemyClick(turnPointsController.weakenTwoTP));
            }
        }

        else if (whiteMagicController.weakenThree)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "EnemyClick")
            {
                StartCoroutine(WhiteMagicSingleEnemyClick(turnPointsController.weakenThreeTP));
            }
        }



        else if (whiteMagicController.deflateArmorOne)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "EnemyClick")
            {
                StartCoroutine(WhiteMagicSingleEnemyClick(turnPointsController.deflateArmorOneTP));
            }
        }


        else if (whiteMagicController.deflateArmorTwo)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "EnemyClick")
            {
                StartCoroutine(WhiteMagicSingleEnemyClick(turnPointsController.deflateArmorTwoTP));
            }
        }

        else if (whiteMagicController.deflateArmorThree)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "EnemyClick")
            {
                StartCoroutine(WhiteMagicSingleEnemyClick(turnPointsController.deflateArmorThreeTP));
            }
        }




        else if (whiteMagicController.deflateMagicProtectionOne)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "EnemyClick")
            {
                StartCoroutine(WhiteMagicSingleEnemyClick(turnPointsController.deflateMagicProtectionOneTP));
            }
        }


        else if (whiteMagicController.deflateMagicProtectionTwo)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "EnemyClick")
            {
                StartCoroutine(WhiteMagicSingleEnemyClick(turnPointsController.deflateMagicProtectionTwoTP));
            }
        }

        else if (whiteMagicController.deflateMagicProtectionThree)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "EnemyClick")
            {
                StartCoroutine(WhiteMagicSingleEnemyClick(turnPointsController.deflateMagicProtectionThreeTP));
            }
        }



        else if (whiteMagicController.feeblemindOne)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "EnemyClick")
            {
                StartCoroutine(WhiteMagicSingleEnemyClick(turnPointsController.feeblemindOneTP));
            }
        }


        else if (whiteMagicController.feeblemindTwo)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "EnemyClick")
            {
                StartCoroutine(WhiteMagicSingleEnemyClick(turnPointsController.feeblemindTwoTP));
            }
        }

        else if (whiteMagicController.feeblemindThree)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "EnemyClick")
            {
                StartCoroutine(WhiteMagicSingleEnemyClick(turnPointsController.feeblemindThreeTP));
            }
        }




        else if (whiteMagicController.dispelOne)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "EnemyClick")
            {
                StartCoroutine(WhiteMagicSingleEnemyClick(turnPointsController.dispelOneTP));
            }
        }


        else if (whiteMagicController.dispelTwo)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "EnemyClick")
            {
                StartCoroutine(WhiteMagicSingleEnemyClick(turnPointsController.dispelTwoTP));
            }
        }

        else if (whiteMagicController.dispelThree)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "EnemyClick")
            {
                StartCoroutine(WhiteMagicSingleEnemyClick(turnPointsController.dispelThreeTP));
            }
        }





        else if (whiteMagicController.healOne)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "PaladinClick")
            {
                StartCoroutine(WhiteMagicSinglePaladinClick(turnPointsController.healOneTP));
            }

            else if (EventSystem.current.currentSelectedGameObject.tag == "WizardClick")
            {
                StartCoroutine(WhiteMagicSingleWizardClick(turnPointsController.healOneTP));
            }
        }


        else if (whiteMagicController.healTwo)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "PaladinClick")
            {
                StartCoroutine(WhiteMagicSinglePaladinClick(turnPointsController.healTwoTP));
            }

            else if (EventSystem.current.currentSelectedGameObject.tag == "WizardClick")
            {
                StartCoroutine(WhiteMagicSingleWizardClick(turnPointsController.healTwoTP));
            }
        }

        else if (whiteMagicController.healThree)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "PaladinClick")
            {
                StartCoroutine(WhiteMagicSinglePaladinClick(turnPointsController.healThreeTP));
            }

            else if (EventSystem.current.currentSelectedGameObject.tag == "WizardClick")
            {
                StartCoroutine(WhiteMagicSingleWizardClick(turnPointsController.healThreeTP));
            }
        }


    }

    ////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////

    void WizardUsingBlackMagicAction()
    {
        if (blackMagicController.iceOne)
        {
            StartCoroutine(BlackMagicSingleEnemyClick(turnPointsController.iceOneTP));
        }

        else if (blackMagicController.iceTwo)
        {
            StartCoroutine(BlackMagicSingleEnemyClick(turnPointsController.iceTwoTP));
        }

        else if (blackMagicController.iceThree)
        {
            StartCoroutine(BlackMagicSingleEnemyClick(turnPointsController.iceThreeTP));
        }



        else if (blackMagicController.iceFour)
        {
            StartCoroutine(BlackMagicPartyEnemyClick(turnPointsController.iceFourTP));
        }

        else if (blackMagicController.iceFive)
        {
            StartCoroutine(BlackMagicPartyEnemyClick(turnPointsController.iceFiveTP));
        }

        else if (blackMagicController.iceSix)
        {
            StartCoroutine(BlackMagicPartyEnemyClick(turnPointsController.iceSixTP));
        }



        else if (blackMagicController.fireOne)
        {
            StartCoroutine(BlackMagicSingleEnemyClick(turnPointsController.fireOneTP));
        }

        else if (blackMagicController.fireTwo)
        {
            StartCoroutine(BlackMagicSingleEnemyClick(turnPointsController.fireTwoTP));
        }

        else if (blackMagicController.fireThree)
        {
            StartCoroutine(BlackMagicSingleEnemyClick(turnPointsController.fireThreeTP));
        }



        else if (blackMagicController.fireFour)
        {
            StartCoroutine(BlackMagicPartyEnemyClick(turnPointsController.fireFourTP));
        }

        else if (blackMagicController.fireFive)
        {
            StartCoroutine(BlackMagicPartyEnemyClick(turnPointsController.fireFiveTP));
        }

        else if (blackMagicController.fireSix)
        {
            StartCoroutine(BlackMagicPartyEnemyClick(turnPointsController.fireSixTP));
        }



        else if (blackMagicController.waterOne)
        {
            StartCoroutine(BlackMagicSingleEnemyClick(turnPointsController.waterOneTP));
        }

        else if (blackMagicController.waterTwo)
        {
            StartCoroutine(BlackMagicSingleEnemyClick(turnPointsController.waterTwoTP));
        }

        else if (blackMagicController.waterThree)
        {
            StartCoroutine(BlackMagicSingleEnemyClick(turnPointsController.waterThreeTP));
        }



        else if (blackMagicController.waterFour)
        {
            StartCoroutine(BlackMagicPartyEnemyClick(turnPointsController.waterFourTP));
        }

        else if (blackMagicController.waterFive)
        {
            StartCoroutine(BlackMagicPartyEnemyClick(turnPointsController.waterFiveTP));
        }

        else if (blackMagicController.waterSix)
        {
            StartCoroutine(BlackMagicPartyEnemyClick(turnPointsController.waterSixTP));
        }




        else if (blackMagicController.freezeOne)
        {
            StartCoroutine(BlackMagicSingleEnemyClickEffect(turnPointsController.freezeOneTP));
        }

        else if (blackMagicController.freezeTwo)
        {
            StartCoroutine(BlackMagicSingleEnemyClickEffect(turnPointsController.freezeTwoTP));
        }

        else if (blackMagicController.freezeThree)
        {
            StartCoroutine(BlackMagicSingleEnemyClickEffect(turnPointsController.freezeThreeTP));
        }



        else if (blackMagicController.burnOne)
        {
            StartCoroutine(BlackMagicSingleEnemyClickEffect(turnPointsController.burnOneTP));
        }

        else if (blackMagicController.burnTwo)
        {
            StartCoroutine(BlackMagicSingleEnemyClickEffect(turnPointsController.burnTwoTP));
        }

        else if (blackMagicController.burnThree)
        {
            StartCoroutine(BlackMagicSingleEnemyClickEffect(turnPointsController.burnThreeTP));
        }


        else if (blackMagicController.silenceOne)
        {
            StartCoroutine(BlackMagicSingleEnemyClickEffect(turnPointsController.silenceOneTP));
        }

        else if (blackMagicController.silenceTwo)
        {
            StartCoroutine(BlackMagicSingleEnemyClickEffect(turnPointsController.silenceTwoTP));
        }

        else if (blackMagicController.silenceThree)
        {
            StartCoroutine(BlackMagicSingleEnemyClickEffect(turnPointsController.silenceThreeTP));
        }


        else if (blackMagicController.blindOne)
        {
            StartCoroutine(BlackMagicSingleEnemyClickEffect(turnPointsController.blindOneTP));
        }

        else if (blackMagicController.blindTwo)
        {
            StartCoroutine(BlackMagicSingleEnemyClickEffect(turnPointsController.blindTwoTP));
        }

        else if (blackMagicController.blindThree)
        {
            StartCoroutine(BlackMagicSingleEnemyClickEffect(turnPointsController.blindThreeTP));
        }

    }



    ////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////

    void PaladinUsingSpecialAction()
    {

    }

    void WizardUsingSpecialAction()
    {

    }


    ////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////

    void PaladinUsingItemAction()
    {

    }

    void WizardUsingItemAction()
    {

    }


    ////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////



    IEnumerator PaladinAttackCoroutine(float positionX, float positionY)
    {
        if (turnPointsController.turnPointsPaladin < turnPointsController.paladinAttackTP)
        {
            gameController.NotEnoughTurnPointsMethod();
            yield break;
        }

        if (paladinIsAttacking == false)
        {
            yield break;
        }


        if (gameController.someoneDoingAnAction == true)
        {
            yield break;
        }

        paladinIsAttacking = false;


        gameController.someoneDoingAnAction = true;

        attackControllerPaladin.OnAttacking();
        gameController.StopAllAB();


        var paladinPositionX = EventSystem.current.currentSelectedGameObject.transform.root.localPosition.x - positionX;

        var instantiateX = EventSystem.current.currentSelectedGameObject.transform.root.localPosition.x;
        var instantiateY = EventSystem.current.currentSelectedGameObject.transform.root.localPosition.y;

        if (instantiateY > 0.8f)
        {
            spriteRendererPaladin.sortingOrder = 2;
        }

        else if (instantiateY > 0.6f)
        {
            spriteRendererPaladin.sortingOrder = 3;
        }

        else if (instantiateY > 0.4f)
        {
            spriteRendererPaladin.sortingOrder = 4;
        }

        else if (instantiateY > 0.2f)
        {
            spriteRendererPaladin.sortingOrder = 5;
        }


        else if (instantiateY > 0f)
        {
            spriteRendererPaladin.sortingOrder = 6;
        }

        else if (instantiateY > -0.2f)
        {
            spriteRendererPaladin.sortingOrder = 7;
        }

        else if (instantiateY > -0.4f)
        {
            spriteRendererPaladin.sortingOrder = 8;
        }

        else if (instantiateY > -0.6f)
        {
            spriteRendererPaladin.sortingOrder = 9;
        }


        //var paladinPositionTotal = new Vector3(paladinPositionX, instantiateY + positionY, 0);

        //paladinGO.transform.root.localPosition = paladinPositionTotal;


        var enemyComponent = EventSystem.current.currentSelectedGameObject.transform.root.GetComponent<Enemy>();
        thisAnimator = EventSystem.current.currentSelectedGameObject.GetComponentInParent<Animator>();

        paladin.enemyPosition = enemyComponent.transform.position;
        paladin.moveToEnemy = true;

        yield return new WaitForSeconds(0.22f);
        paladin.moveToEnemy = false;



        thisAnimator.SetBool("GetHit", false);
        paladinAnimator.ResetTrigger("Attack");
        paladinAnimator.ResetTrigger("Buff");
        paladinAnimator.SetTrigger("Attack");



        yield return new WaitForSeconds(0.4f);

        enemyComponent.GettingHitFromPaladinAttack();

        enemyComponent.DamageFloatOnEnemy();


        shakingCamera.ShakeCamera();

        if (enemyComponent.currentHealth > 0)
        {
            thisAnimator.SetBool("GetHit", true);
        }

        else if (enemyComponent.currentHealth <= 0)
        {
            thisAnimator.SetBool("Dying", true);
        }

        yield return new WaitForSeconds(0.5f);

        paladinGO.transform.rotation = Quaternion.Euler(0, 0, 0);

        if (enemyComponent.currentHealth > 0)
        {
            thisAnimator.SetBool("GetHit", false);
        }

        paladin.moveToStart = true;
        yield return new WaitForSeconds(0.22f);
        paladin.moveToStart = false;
        //paladinGO.transform.root.localPosition = paladinInitialPosition;

        spriteRendererPaladin.sortingOrder = 4;

        paladin.ab = 0;

        paladinFacesetAnimator.SetTrigger("Idle");


        gameController.ContinueAllAB();
        gameController.paladinTurn = false;

        gameController.someoneDoingAnAction = false;
    }



    IEnumerator WizardAttackCoroutine(float positionX, float positionY)
    {
        if (turnPointsController.turnPointsWizard < turnPointsController.wizardAttackTP)
        {
            gameController.NotEnoughTurnPointsMethod();
            yield break;
        }

        if (wizardIsAttacking == false)
        {
            yield break;
        }               

        if (gameController.someoneDoingAnAction == true)
        {
            yield break;
        }


        wizardIsAttacking = false;

        gameController.someoneDoingAnAction = true;

        attackControllerWizard.OnAttacking();
        gameController.StopAllAB();


        var wizardPositionX = EventSystem.current.currentSelectedGameObject.transform.root.localPosition.x - positionX;

        var instantiateX = EventSystem.current.currentSelectedGameObject.transform.root.localPosition.x;
        var instantiateY = EventSystem.current.currentSelectedGameObject.transform.root.localPosition.y;

        if (instantiateY > 0.8f)
        {
            spriteRendererWizard.sortingOrder = 2;
        }

        else if (instantiateY > 0.6f)
        {
            spriteRendererWizard.sortingOrder = 3;
        }

        else if (instantiateY > 0.4f)
        {
            spriteRendererWizard.sortingOrder = 4;
        }

        else if (instantiateY > 0.2f)
        {
            spriteRendererWizard.sortingOrder = 5;
        }


        else if (instantiateY > 0f)
        {
            spriteRendererWizard.sortingOrder = 6;
        }

        else if (instantiateY > -0.2f)
        {
            spriteRendererWizard.sortingOrder = 7;
        }

        else if (instantiateY > -0.4f)
        {
            spriteRendererWizard.sortingOrder = 8;
        }

        else if (instantiateY > -0.6f)
        {
            spriteRendererWizard.sortingOrder = 9;
        }


        //var wizardPositionTotal = new Vector3(wizardPositionX, instantiateY + positionY, 0);

        //wizardGO.transform.root.localPosition = wizardPositionTotal;

        var enemyComponent = EventSystem.current.currentSelectedGameObject.transform.root.GetComponent<Enemy>();
        thisAnimator = EventSystem.current.currentSelectedGameObject.GetComponentInParent<Animator>();

        wizard.enemyPosition = enemyComponent.transform.position;
        wizard.moveToEnemy = true;

        yield return new WaitForSeconds(0.22f);
        wizard.moveToEnemy = false;

        thisAnimator.SetBool("GetHit", false);
        wizardAnimator.ResetTrigger("Attack");
        wizardAnimator.ResetTrigger("CastSpell");
        wizardAnimator.SetTrigger("Attack");


        yield return new WaitForSeconds(0.4f);

        enemyComponent.GettingHitFromWizardAttack();

        enemyComponent.DamageFloatOnEnemy();


        shakingCamera.ShakeCamera();

        if (enemyComponent.currentHealth > 0)
        {
            thisAnimator.SetBool("GetHit", true);
        }

        else if (enemyComponent.currentHealth <= 0)
        {
            thisAnimator.SetBool("Dying", true);
        }

        yield return new WaitForSeconds(0.47f);

        wizardGO.transform.rotation = Quaternion.Euler(0, 0, 0);

        if (enemyComponent.currentHealth > 0)
        {
            thisAnimator.SetBool("GetHit", false);
        }

        wizard.moveToStart = true;
        yield return new WaitForSeconds(0.22f);
        wizard.moveToStart = false;

        //wizardGO.transform.root.localPosition = wizardInitialPosition;

        spriteRendererWizard.sortingOrder = 4;

        wizard.ab = 0;

        wizardFacesetAnimator.SetTrigger("Idle");

        gameController.ContinueAllAB();
        gameController.wizardTurn = false;

        gameController.someoneDoingAnAction = false;

    }



    ////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////


    IEnumerator WhiteMagicSinglePaladinClick(int spellTP)
    {
        if (turnPointsController.turnPointsPaladin < spellTP)
        {
            gameController.NotEnoughTurnPointsMethod();
            yield break;
        }

        if (paladinIsUsingWhiteMagic == false)
        {
            yield break;
        }       


        if (gameController.someoneDoingAnAction == true)
        {
            yield break;
        }

        paladinIsUsingWhiteMagic = false;

        gameController.someoneDoingAnAction = true;

        whiteMagicController.OnUsingWhiteMagicSpell(spellTP);
        gameController.StopAllAB();

        var instantiateX = EventSystem.current.currentSelectedGameObject.transform.localPosition.x;
        var instantiateY = EventSystem.current.currentSelectedGameObject.transform.localPosition.y;


        thisAnimator = EventSystem.current.currentSelectedGameObject.GetComponentInParent<Animator>();

        paladinAnimator.ResetTrigger("Attack");
        paladinAnimator.ResetTrigger("Buff");
        paladinAnimator.SetTrigger("Buff");

        yield return new WaitForSeconds(0.57f);

        spellController.SpellEffectGeneral("Paladin");

        yield return new WaitForSeconds(0.5f);

        paladin.ab = 0;

        paladinFacesetAnimator.SetTrigger("Idle");

        gameController.ContinueAllAB();
        gameController.paladinTurn = false;

        gameController.someoneDoingAnAction = false;

        whiteMagicController.TurnAllSpellsFalse();
    }


    IEnumerator WhiteMagicSingleWizardClick(int spellTP)
    {
        if (turnPointsController.turnPointsPaladin < spellTP)
        {
            gameController.NotEnoughTurnPointsMethod();
            yield break;
        }

        if (paladinIsUsingWhiteMagic == false)
        {
            yield break;
        }

        if (gameController.someoneDoingAnAction == true)
        {
            yield break;
        }

        paladinIsUsingWhiteMagic = false;

        gameController.someoneDoingAnAction = true;

        whiteMagicController.OnUsingWhiteMagicSpell(spellTP);
        gameController.StopAllAB();


        var initialPaladinShadowPosition = paladinShadow.transform.position;
        var paladinPositionX = EventSystem.current.currentSelectedGameObject.transform.root.localPosition.x - 0.75f;

        var instantiateX = EventSystem.current.currentSelectedGameObject.transform.root.localPosition.x;
        var instantiateY = EventSystem.current.currentSelectedGameObject.transform.root.localPosition.y;

        var paladinPositionTotal = new Vector3(paladinPositionX + 1.3f, instantiateY, 0);

        paladinGO.transform.root.localPosition = paladinPositionTotal;



        paladinShadow.transform.position = new Vector3(-0.4f, paladinShadow.transform.position.y, paladinShadow.transform.position.z);

        var thePaladinFlip = paladin.GetComponent<SpriteRenderer>();
        thePaladinFlip.flipX = false;

        thisAnimator = EventSystem.current.currentSelectedGameObject.GetComponentInParent<Animator>();

        paladinAnimator.ResetTrigger("Attack");
        paladinAnimator.ResetTrigger("Buff");
        paladinAnimator.SetTrigger("Buff");

        yield return new WaitForSeconds(0.57f);

        spellController.SpellEffectGeneral("Wizard");

        yield return new WaitForSeconds(0.5f);

        paladinGO.transform.root.localPosition = paladinInitialPosition;
        paladinShadow.transform.position = initialPaladinShadowPosition;

        thePaladinFlip.flipX = true;

        paladin.ab = 0;

        paladinFacesetAnimator.SetTrigger("Idle");

        gameController.ContinueAllAB();
        gameController.paladinTurn = false;

        gameController.someoneDoingAnAction = false;
        whiteMagicController.TurnAllSpellsFalse();
    }


    IEnumerator WhiteMagicSingleEnemyClick(int spellTP)
    {
        if (turnPointsController.turnPointsPaladin < spellTP)
        {
            gameController.NotEnoughTurnPointsMethod();
            yield break;
        }

        if (paladinIsUsingWhiteMagic == false)
        {
            yield break;
        }


        if (gameController.someoneDoingAnAction == true)
        {
            yield break;
        }

        paladinIsUsingWhiteMagic = false;

        gameController.someoneDoingAnAction = true;

        whiteMagicController.OnUsingWhiteMagicSpell(spellTP);
        gameController.StopAllAB();

        var instantiateX = EventSystem.current.currentSelectedGameObject.transform.localPosition.x;
        var instantiateY = EventSystem.current.currentSelectedGameObject.transform.localPosition.y;


        thisAnimator = EventSystem.current.currentSelectedGameObject.GetComponentInParent<Animator>();
        var enemyComponent = EventSystem.current.currentSelectedGameObject.transform.root.GetComponent<Enemy>();

        paladinAnimator.ResetTrigger("Attack");
        paladinAnimator.ResetTrigger("Buff");
        paladinAnimator.SetTrigger("Buff");

        yield return new WaitForSeconds(0.57f);

        enemyComponent.SpellEffectGeneral();

        yield return new WaitForSeconds(0.5f);

        paladin.ab = 0;

        paladinFacesetAnimator.SetTrigger("Idle");

        gameController.ContinueAllAB();
        gameController.paladinTurn = false;

        gameController.someoneDoingAnAction = false;

        whiteMagicController.TurnAllSpellsFalse();
    }



    ////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////
    

    IEnumerator BlackMagicSingleEnemyClick(int spellTP)
    {
        if (turnPointsController.turnPointsWizard < spellTP)
        {
            gameController.NotEnoughTurnPointsMethod();
            yield break;
        }

        if (wizardIsUsingBlackMagic == false)
        {
            yield break;
        }


        if (gameController.someoneDoingAnAction == true)
        {
            yield break;
        }

        wizardIsUsingBlackMagic = false;

        gameController.someoneDoingAnAction = true;

        blackMagicController.OnUsingBlackMagicSpell(spellTP);
        gameController.StopAllAB();

        var instantiateX = EventSystem.current.currentSelectedGameObject.transform.localPosition.x;
        var instantiateY = EventSystem.current.currentSelectedGameObject.transform.localPosition.y;


        thisAnimator = EventSystem.current.currentSelectedGameObject.GetComponentInParent<Animator>();
        var enemyComponent = EventSystem.current.currentSelectedGameObject.transform.root.GetComponent<Enemy>();

        wizardAnimator.ResetTrigger("CastSpell");
        wizardAnimator.ResetTrigger("Attack");
        wizardAnimator.SetTrigger("CastSpell");

        yield return new WaitForSeconds(1.5f);

        enemyComponent.SpellEffectGeneral();

        enemyComponent.DamageFloatOnEnemy();


        shakingCamera.ShakeCamera();

        if (enemyComponent.currentHealth > 0)
        {
            thisAnimator.SetBool("GetHit", true);
        }

        else if (enemyComponent.currentHealth <= 0)
        {
            thisAnimator.SetBool("Dying", true);
        }

        yield return new WaitForSeconds(0.5f);

        if (enemyComponent.currentHealth > 0)
        {
            thisAnimator.SetBool("GetHit", false);
        }

        wizard.ab = 0;

        wizardFacesetAnimator.SetTrigger("Idle");

        gameController.ContinueAllAB();
        gameController.wizardTurn = false;

        gameController.someoneDoingAnAction = false;

        blackMagicController.TurnAllSpellsFalse();
    }

    IEnumerator BlackMagicSingleEnemyClickEffect(int spellTP)
    {
        if (turnPointsController.turnPointsWizard < spellTP)
        {
            gameController.NotEnoughTurnPointsMethod();
            yield break;
        }

        if (wizardIsUsingBlackMagic == false)
        {
            yield break;
        }


        if (gameController.someoneDoingAnAction == true)
        {
            yield break;
        }

        wizardIsUsingBlackMagic = false;

        gameController.someoneDoingAnAction = true;

        blackMagicController.OnUsingBlackMagicSpell(spellTP);
        gameController.StopAllAB();

        var instantiateX = EventSystem.current.currentSelectedGameObject.transform.localPosition.x;
        var instantiateY = EventSystem.current.currentSelectedGameObject.transform.localPosition.y;


        thisAnimator = EventSystem.current.currentSelectedGameObject.GetComponentInParent<Animator>();
        var enemyComponent = EventSystem.current.currentSelectedGameObject.transform.root.GetComponent<Enemy>();

        wizardAnimator.ResetTrigger("CastSpell");
        wizardAnimator.ResetTrigger("Attack");
        wizardAnimator.SetTrigger("CastSpell");

        yield return new WaitForSeconds(1.5f);

        enemyComponent.SpellEffectGeneral();

        yield return new WaitForSeconds(0.5f);

        wizard.ab = 0;

        wizardFacesetAnimator.SetTrigger("Idle");

        gameController.ContinueAllAB();
        gameController.wizardTurn = false;

        gameController.someoneDoingAnAction = false;

        blackMagicController.TurnAllSpellsFalse();
    }




    IEnumerator BlackMagicPartyEnemyClick(int spellTP)
    {
        if (turnPointsController.turnPointsWizard < spellTP)
        {
            gameController.NotEnoughTurnPointsMethod();
            yield break;
        }

        if (wizardIsUsingBlackMagic == false)
        {
            yield break;
        }


        if (gameController.someoneDoingAnAction == true)
        {
            yield break;
        }

        wizardIsUsingBlackMagic = false;

        gameController.someoneDoingAnAction = true;

        blackMagicController.OnUsingBlackMagicSpell(spellTP);
        gameController.StopAllAB();

        var instantiateX = EventSystem.current.currentSelectedGameObject.transform.localPosition.x;
        var instantiateY = EventSystem.current.currentSelectedGameObject.transform.localPosition.y;


        thisAnimator = EventSystem.current.currentSelectedGameObject.GetComponentInParent<Animator>();
        var enemyComponent = EventSystem.current.currentSelectedGameObject.transform.root.GetComponent<Enemy>();

        wizardAnimator.ResetTrigger("CastSpell");
        wizardAnimator.ResetTrigger("Attack");
        wizardAnimator.SetTrigger("CastSpell");

        yield return new WaitForSeconds(1.5f);

        foreach (var enemy in gameController.enemies)
        {
            if (enemy.isDead == false)
            {
                enemy.SpellEffectGeneral();
                enemy.DamageFloatOnEnemy();
            }
        }

        shakingCamera.ShakeCamera();

        foreach (var enemy in gameController.enemies)
        {
            if (enemy.currentHealth > 0 && enemy.isDead == false)
            {
                var theAnimator = enemy.GetComponent<Animator>();
                theAnimator.SetBool("GetHit", true);
            }

            else if (enemy.currentHealth <= 0 && enemy.isDead == false)
            {
                var theAnimator = enemy.GetComponent<Animator>();
                theAnimator.SetBool("Dying", true);
            }
        }

        yield return new WaitForSeconds(0.5f);


        foreach (var enemy in gameController.enemies)
        {
            if (enemy.currentHealth > 0 && enemy.isDead == false)
            {
                var theAnimator = enemy.GetComponent<Animator>();
                theAnimator.SetBool("GetHit", false);
            }
        }

        wizard.ab = 0;

        wizardFacesetAnimator.SetTrigger("Idle");

        gameController.ContinueAllAB();
        gameController.wizardTurn = false;

        gameController.someoneDoingAnAction = false;

        blackMagicController.TurnAllSpellsFalse();
    }

}

