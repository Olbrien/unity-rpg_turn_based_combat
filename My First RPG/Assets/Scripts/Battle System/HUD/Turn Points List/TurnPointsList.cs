using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurnPointsList : MonoBehaviour
{
    public GameController gameController;
    public WhiteMagicController whiteMagicController;
    public BlackMagicController blackMagicController;
    public TurnPointsController turnPointsController;
    public List<GameObject> turnPointsList;

    Vector3 paladinPosition = new Vector3(-270, 35, 0);
    Vector3 wizardPosition = new Vector3(-197.5f, 80.3f, 0);

    int spellName;

    void Start()
    {
        
    }


    private void Update()
    {
        
    }

    public void SubtractPaladinAttackTurnPoints()
    {
        foreach (var turnPointsText in turnPointsList)
        {
            if (turnPointsText.activeSelf == false)
            {
                var rect = turnPointsText.GetComponent<RectTransform>();
                rect.localPosition = paladinPosition;

                var turnPointsTxtVar = turnPointsText.GetComponent<TextMeshPro>();
                turnPointsTxtVar.text = "-" + turnPointsController.paladinAttackTP.ToString();

                turnPointsText.SetActive(true);

                break;
            }
        }
    }

    public void SubtractWizardAttackTurnPoints()
    {
        foreach (var turnPointsText in turnPointsList)
        {
            if (turnPointsText.activeSelf == false)
            {
                var rect = turnPointsText.GetComponent<RectTransform>();
                rect.localPosition = wizardPosition;

                var turnPointsTxtVar = turnPointsText.GetComponent<TextMeshPro>();
                turnPointsTxtVar.text = "-" + turnPointsController.wizardAttackTP.ToString();

                turnPointsText.SetActive(true);
                break;
            }
        }
    }






    public void WhiteMagicSpell()
    {
        if (whiteMagicController.agiltyOne == true) { SubtractPaladinWhiteMagic(turnPointsController.agilityOneTP); }
        else if (whiteMagicController.agiltyTwo == true) { SubtractPaladinWhiteMagic(turnPointsController.agilityTwoTP); }
        else if (whiteMagicController.agiltyThree == true) { SubtractPaladinWhiteMagic(turnPointsController.agilityThreeTP); }

        else if (whiteMagicController.strenghtOne == true) { SubtractPaladinWhiteMagic(turnPointsController.strenghtOneTP); }
        else if (whiteMagicController.strenghtTwo == true) { SubtractPaladinWhiteMagic(turnPointsController.strenghtTwoTP); }
        else if (whiteMagicController.strenghtThree == true) { SubtractPaladinWhiteMagic(turnPointsController.strenghtThreeTP); }

        else if (whiteMagicController.armorProtectionOne == true) { SubtractPaladinWhiteMagic(turnPointsController.armorProtectionOneTP); }
        else if (whiteMagicController.armorProtectionTwo == true) { SubtractPaladinWhiteMagic(turnPointsController.armorProtectionTwoTP); }
        else if (whiteMagicController.armorProtectionThree == true) { SubtractPaladinWhiteMagic(turnPointsController.armorProtectionThreeTP); }

        else if (whiteMagicController.magicProtectionOne == true) { SubtractPaladinWhiteMagic(turnPointsController.magicProtectionOneTP); }
        else if (whiteMagicController.magicProtectionTwo == true) { SubtractPaladinWhiteMagic(turnPointsController.magicProtectionTwoTP); }
        else if (whiteMagicController.magicProtectionThree == true) { SubtractPaladinWhiteMagic(turnPointsController.magicProtectionThreeTP); }

        else if (whiteMagicController.magicUpOne == true) { SubtractPaladinWhiteMagic(turnPointsController.magicUpOneTP); }
        else if (whiteMagicController.magicUpTwo == true) { SubtractPaladinWhiteMagic(turnPointsController.magicUpTwoTP); }
        else if (whiteMagicController.magicUpThree == true) { SubtractPaladinWhiteMagic(turnPointsController.magicUpThreeTP); }

        else if (whiteMagicController.higherVitalityUpOne == true) { SubtractPaladinWhiteMagic(turnPointsController.higherVitalityUpOneTP); }
        else if (whiteMagicController.higherVitalityUpTwo == true) { SubtractPaladinWhiteMagic(turnPointsController.higherVitalityUpTwoTP); }
        else if (whiteMagicController.higherVitalityUpThree == true) { SubtractPaladinWhiteMagic(turnPointsController.higherVitalityUpThreeTP); }



        else if (whiteMagicController.clumsyOne == true) { SubtractPaladinWhiteMagic(turnPointsController.clumsyOneTP); }
        else if (whiteMagicController.clumsyTwo == true) { SubtractPaladinWhiteMagic(turnPointsController.clumsyTwoTP); }
        else if (whiteMagicController.clumsyThree == true) { SubtractPaladinWhiteMagic(turnPointsController.clumsyThreeTP); }

        else if (whiteMagicController.weakenOne == true) { SubtractPaladinWhiteMagic(turnPointsController.weakenOneTP); }
        else if (whiteMagicController.weakenTwo == true) { SubtractPaladinWhiteMagic(turnPointsController.weakenTwoTP); }
        else if (whiteMagicController.weakenThree == true) { SubtractPaladinWhiteMagic(turnPointsController.weakenThreeTP); }

        else if (whiteMagicController.deflateArmorOne == true) { SubtractPaladinWhiteMagic(turnPointsController.deflateArmorOneTP); }
        else if (whiteMagicController.deflateArmorTwo == true) { SubtractPaladinWhiteMagic(turnPointsController.deflateArmorTwoTP); }
        else if (whiteMagicController.deflateArmorThree == true) { SubtractPaladinWhiteMagic(turnPointsController.deflateArmorThreeTP); }

        else if (whiteMagicController.deflateMagicProtectionOne == true) { SubtractPaladinWhiteMagic(turnPointsController.deflateMagicProtectionOneTP); }
        else if (whiteMagicController.deflateMagicProtectionTwo == true) { SubtractPaladinWhiteMagic(turnPointsController.deflateMagicProtectionTwoTP); }
        else if (whiteMagicController.deflateMagicProtectionThree == true) { SubtractPaladinWhiteMagic(turnPointsController.deflateMagicProtectionThreeTP); }

        else if (whiteMagicController.feeblemindOne == true) { SubtractPaladinWhiteMagic(turnPointsController.feeblemindOneTP); }
        else if (whiteMagicController.feeblemindTwo == true) { SubtractPaladinWhiteMagic(turnPointsController.feeblemindTwoTP); }
        else if (whiteMagicController.feeblemindThree == true) { SubtractPaladinWhiteMagic(turnPointsController.feeblemindThreeTP); }

        else if (whiteMagicController.dispelOne == true) { SubtractPaladinWhiteMagic(turnPointsController.dispelOneTP); }
        else if (whiteMagicController.dispelTwo == true) { SubtractPaladinWhiteMagic(turnPointsController.dispelTwoTP); }
        else if (whiteMagicController.dispelThree == true) { SubtractPaladinWhiteMagic(turnPointsController.dispelThreeTP); }



        else if (whiteMagicController.healOne == true) { SubtractPaladinWhiteMagic(turnPointsController.healOneTP); }
        else if (whiteMagicController.healTwo == true) { SubtractPaladinWhiteMagic(turnPointsController.healTwoTP); }
        else if (whiteMagicController.healThree == true) { SubtractPaladinWhiteMagic(turnPointsController.healThreeTP); }
    }



    public void SubtractPaladinWhiteMagic(int theSpellName)
    {
        foreach (var turnPointsText in turnPointsList)
        {
            if (turnPointsText.activeSelf == false)
            {
                var rect = turnPointsText.GetComponent<RectTransform>();
                rect.localPosition = paladinPosition;

                var turnPointsTxtVar = turnPointsText.GetComponent<TextMeshPro>();
                turnPointsTxtVar.text = "-" + theSpellName.ToString();

                turnPointsText.SetActive(true);
                break;
            }
        }
    }




    public void BlackMagicSpell()
    {
        if (blackMagicController.iceOne == true) { SubtractWizardBlackMagic(turnPointsController.iceOneTP); }
        else if (blackMagicController.iceTwo == true) { SubtractWizardBlackMagic(turnPointsController.iceTwoTP); }
        else if (blackMagicController.iceThree == true) { SubtractWizardBlackMagic(turnPointsController.iceThreeTP); }

        else if (blackMagicController.iceFour == true) { SubtractWizardBlackMagic(turnPointsController.iceFourTP); }
        else if (blackMagicController.iceFive == true) { SubtractWizardBlackMagic(turnPointsController.iceFiveTP); }
        else if (blackMagicController.iceSix == true) { SubtractWizardBlackMagic(turnPointsController.iceSixTP); }

        else if (blackMagicController.fireOne == true) { SubtractWizardBlackMagic(turnPointsController.fireOneTP); }
        else if (blackMagicController.fireTwo == true) { SubtractWizardBlackMagic(turnPointsController.fireTwoTP); }
        else if (blackMagicController.fireThree == true) { SubtractWizardBlackMagic(turnPointsController.fireThreeTP); }

        else if (blackMagicController.fireFour == true) { SubtractWizardBlackMagic(turnPointsController.fireFourTP); }
        else if (blackMagicController.fireFive == true) { SubtractWizardBlackMagic(turnPointsController.fireFiveTP); }
        else if (blackMagicController.fireSix == true) { SubtractWizardBlackMagic(turnPointsController.fireSixTP); }

        else if (blackMagicController.waterOne == true) { SubtractWizardBlackMagic(turnPointsController.waterOneTP); }
        else if (blackMagicController.waterTwo == true) { SubtractWizardBlackMagic(turnPointsController.waterTwoTP); }
        else if (blackMagicController.waterThree == true) { SubtractWizardBlackMagic(turnPointsController.waterThreeTP); }

        else if (blackMagicController.waterFour == true) { SubtractWizardBlackMagic(turnPointsController.waterFourTP); }
        else if (blackMagicController.waterFive == true) { SubtractWizardBlackMagic(turnPointsController.waterFiveTP); }
        else if (blackMagicController.waterSix == true) { SubtractWizardBlackMagic(turnPointsController.waterSixTP); }



        else if (blackMagicController.freezeOne == true) { SubtractWizardBlackMagic(turnPointsController.freezeOneTP); }
        else if (blackMagicController.freezeTwo == true) { SubtractWizardBlackMagic(turnPointsController.freezeTwoTP); }
        else if (blackMagicController.freezeThree == true) { SubtractWizardBlackMagic(turnPointsController.freezeThreeTP); }

        else if (blackMagicController.burnOne == true) { SubtractWizardBlackMagic(turnPointsController.burnOneTP); }
        else if (blackMagicController.burnTwo == true) { SubtractWizardBlackMagic(turnPointsController.burnTwoTP); }
        else if (blackMagicController.burnThree == true) { SubtractWizardBlackMagic(turnPointsController.burnThreeTP); }

        else if (blackMagicController.silenceOne == true) { SubtractWizardBlackMagic(turnPointsController.silenceOneTP); }
        else if (blackMagicController.silenceTwo == true) { SubtractWizardBlackMagic(turnPointsController.silenceTwoTP); }
        else if (blackMagicController.silenceThree == true) { SubtractWizardBlackMagic(turnPointsController.silenceThreeTP); }

        else if (blackMagicController.blindOne == true) { SubtractWizardBlackMagic(turnPointsController.blindOneTP); }
        else if (blackMagicController.blindTwo == true) { SubtractWizardBlackMagic(turnPointsController.blindTwoTP); }
        else if (blackMagicController.blindThree == true) { SubtractWizardBlackMagic(turnPointsController.blindThreeTP); }

    }



    public void SubtractWizardBlackMagic(int theSpellName)
    {
        foreach (var turnPointsText in turnPointsList)
        {
            if (turnPointsText.activeSelf == false)
            {
                var rect = turnPointsText.GetComponent<RectTransform>();
                rect.localPosition = wizardPosition;

                var turnPointsTxtVar = turnPointsText.GetComponent<TextMeshPro>();
                turnPointsTxtVar.text = "-" + theSpellName.ToString();

                turnPointsText.SetActive(true);
                break;
            }
        }
    }





    public void AddPaladinTurnPoints()
    {
        foreach (var turnPointsText in turnPointsList)
        {
            if (turnPointsText.activeSelf == false)
            {
                var rect = turnPointsText.GetComponent<RectTransform>();
                rect.localPosition = paladinPosition;

                var turnPointsTxtVar = turnPointsText.GetComponent<TextMeshPro>();
                turnPointsTxtVar.text = "+" + "1";

                turnPointsText.SetActive(true);
                break;
            }
        }
    }

    public void AddWizardTurnPoints()
    {
        foreach (var turnPointsText in turnPointsList)
        {
            if (turnPointsText.activeSelf == false)
            {
                var rect = turnPointsText.GetComponent<RectTransform>();
                rect.localPosition = wizardPosition;

                var turnPointsTxtVar = turnPointsText.GetComponent<TextMeshPro>();
                turnPointsTxtVar.text = "+" + "1";

                turnPointsText.SetActive(true);
                break;
            }
        }
    }
}
