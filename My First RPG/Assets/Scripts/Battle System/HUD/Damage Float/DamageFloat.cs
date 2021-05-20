using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DamageFloat : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;

    public GameController gameController;
    public EnemyController enemyController;

    public Canvas parentCanvas;

    bool itsStarting;

    Color32 greenColor;
    Color32 redColor;

    Vector3 initialPosition;

    void Awake()
    {

    }

    public void OnTheStart()
    {
        initialPosition = transform.position;

        itsStarting = true;

        DamageText();

        Invoke("DisableGameObject", 2f);
    }


    void FixedUpdate()
    {
        if (itsStarting)
        {
            transform.Translate(0, Time.deltaTime * 0.7f, 0);
        }
    }

    void DisableGameObject()
    {
        itsStarting = false;
        transform.position = initialPosition;
        parentCanvas.enabled = false;
    }


    public void DamageText()
    {
        if (gameController.damageSaverFromAttacks < 0)
        {
            float saver = gameController.damageSaverFromAttacks;

            saver = -saver;

            greenColor = new Color32(0, 248, 87, 255);

            textMeshPro.color = greenColor;
            textMeshPro.text = "+" + saver.ToString();
        }


        else if (gameController.damageSaverFromAttacks == 0)
        {
            redColor = new Color32(253, 54, 54, 255);

            textMeshPro.color = redColor;
            textMeshPro.text = gameController.damageSaverFromAttacks.ToString();
        }

        else if (gameController.damageSaverFromAttacks > 0)
        {
            redColor = new Color32(253, 54, 54, 255);

            textMeshPro.color = redColor;
            textMeshPro.text = "-" + gameController.damageSaverFromAttacks.ToString();
        }
    }
}
