using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TurnPointsSubtract : MonoBehaviour
{
    GameController gameController;
    TurnPointsController turnPointsController;
    TextMeshPro text;

    [Header("Paladin")]
    public bool subtractPaladinAttack;

    [Header("Wizard")]
    public bool subtractWizardAttack;

    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        turnPointsController = FindObjectOfType<TurnPointsController>();
        text = GetComponent<TextMeshPro>();

        if (subtractPaladinAttack)
        {
            text.text = "-" + turnPointsController.paladinAttackTP.ToString();
        }

        if (subtractWizardAttack)
        {
            text.text = "-" + turnPointsController.wizardAttackTP.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
