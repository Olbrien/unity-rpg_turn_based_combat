using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurnPointsController : MonoBehaviour
{
    [Header("Turn Points At Start")]
    public int turnPointsPaladin;
    public int turnPointsWizard;
    [Space(10)]
    public int spawnBubblesTime;

    [Header("Paladin Attack")]

    public int paladinAttackTP;

    [Header("Buffs")]
    [Header("Paladin White Magic Spells")]

    public int agilityOneTP;
    public int agilityTwoTP;
    public int agilityThreeTP;
    public int strenghtOneTP;
    public int strenghtTwoTP;
    public int strenghtThreeTP;
    public int armorProtectionOneTP;
    public int armorProtectionTwoTP;
    public int armorProtectionThreeTP;
    public int magicProtectionOneTP;
    public int magicProtectionTwoTP;
    public int magicProtectionThreeTP;
    public int magicUpOneTP;
    public int magicUpTwoTP;
    public int magicUpThreeTP;
    public int higherVitalityUpOneTP;
    public int higherVitalityUpTwoTP;
    public int higherVitalityUpThreeTP;

    [Header("Debuffs")]

    public int clumsyOneTP;
    public int clumsyTwoTP;
    public int clumsyThreeTP;
    public int weakenOneTP;
    public int weakenTwoTP;
    public int weakenThreeTP;
    public int deflateArmorOneTP;
    public int deflateArmorTwoTP;
    public int deflateArmorThreeTP;
    public int deflateMagicProtectionOneTP;
    public int deflateMagicProtectionTwoTP;
    public int deflateMagicProtectionThreeTP;
    public int feeblemindOneTP;
    public int feeblemindTwoTP;
    public int feeblemindThreeTP;
    public int dispelOneTP;
    public int dispelTwoTP;
    public int dispelThreeTP;

    [Header("Heals")]

    public int healOneTP;
    public int healTwoTP;
    public int healThreeTP;



    [Header("Wizard Attack")]

    public int wizardAttackTP;


    [Header("Offensive")]
    [Header("Wizard Black Magic Spells")]

    public int iceOneTP;
    public int iceTwoTP;
    public int iceThreeTP;
    public int iceFourTP;
    public int iceFiveTP;
    public int iceSixTP;
    public int fireOneTP;
    public int fireTwoTP;
    public int fireThreeTP;
    public int fireFourTP;
    public int fireFiveTP;
    public int fireSixTP;
    public int waterOneTP;
    public int waterTwoTP;
    public int waterThreeTP;
    public int waterFourTP;
    public int waterFiveTP;
    public int waterSixTP;

    [Header("Effects")]

    public int freezeOneTP;
    public int freezeTwoTP;
    public int freezeThreeTP;
    public int burnOneTP;
    public int burnTwoTP;
    public int burnThreeTP;
    public int silenceOneTP;
    public int silenceTwoTP;
    public int silenceThreeTP;
    public int blindOneTP;
    public int blindTwoTP;
    public int blindThreeTP;






    [Space(500)]
    public GameController gameController;
    public TextMeshPro paladinTurnPointsTxt;
    public TextMeshPro wizardTurnPointsTxt;
    public TurnPointsList turnPointsList;
    public Paladin paladin;
    public Wizard wizard;
    public List<GameObject> bubbleTurnPoints;



    void Start()
    {
        InvokeRepeating("InstantiateBubbles", spawnBubblesTime, spawnBubblesTime);

        TurnPointsUpdate();
    }


    void Update()
    {

    }
    
    public void AddTurnPointsButtonBubble(int turnPoints)
    {
        if (!gameController.paladin.dead)
        {
            turnPointsPaladin += turnPoints;

            paladin.UpdatePaladinTurnPoints();

            turnPointsList.AddPaladinTurnPoints();
        }

        if (!gameController.wizard.dead)
        {
            turnPointsWizard += turnPoints;

            wizard.UpdateWizardTurnPoints();

            turnPointsList.AddWizardTurnPoints();
        }

        TurnPointsUpdate();
    }


    public void TurnPointsUpdate()
    {
        paladinTurnPointsTxt.text = turnPointsPaladin.ToString();
        wizardTurnPointsTxt.text = turnPointsWizard.ToString();
    }


    void InstantiateBubbles()
    {
        foreach (var bubbles in bubbleTurnPoints)
        {
            if (bubbles.activeSelf == false)
            {
                bubbles.SetActive(true);
                break;
            }
        }
    }


}
