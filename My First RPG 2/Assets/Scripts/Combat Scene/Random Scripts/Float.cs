using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Float : MonoBehaviour
{
    public bool leftSide;
    public bool rightSide;

    public float speed = 1.5f;
    float theTime;
    public bool startFloatingDamage;
    public bool startFloatingExperience;
    public bool startFloatingLevelUp;

    public Transform floatLocation;
    public Canvas thisCanvas;
    public TextMeshProUGUI theText;
    public Animator thisAnimator;

    public GlobalController globalController;

    Vector3 thisPosition;
    Vector3 startPosition = new Vector3 (0,0,0);
    Vector3 worldToLocalPosition;

    Color32 greenColor = new Color32(0, 248, 87, 255);
    Color32 redColor = new Color32(253, 54, 54, 255);
    Color32 yellowColor = new Color32(233, 255, 6, 255);

    float aaa;
    float baa;
    float caa;

    float saver;

    void Start()
    {
        //Debug.Log(Animator.StringToHash("Damage"));   -      375673178
        //Debug.Log(Animator.StringToHash("Experience")); -   1254998739
        //Debug.Log(Animator.StringToHash("LevelUP")); -      -771848603
        //Debug.Log(Animator.StringToHash("ShowUp")); // -     933799643 
    }


    void Update() // Qualquer coisa volta a meter FixedUpdate.
    {
        if (startFloatingDamage && rightSide)
        {
            theTime += Time.deltaTime;

            floatLocation.Translate(Time.deltaTime * 1.5f, -Time.deltaTime * -speed, 0);

            if (theTime >= 2)
            {
                theTime = 0;

                floatLocation.position = startPosition;

                startFloatingDamage = false;
                thisCanvas.enabled = false;

                thisAnimator.SetBool(375673178, false);

                rightSide = false;
                enabled = false;
            }
        }


        if (startFloatingDamage && leftSide)
        {
            theTime += Time.deltaTime;

            floatLocation.Translate(-Time.deltaTime * 1.5f, -Time.deltaTime * -speed, 0);

            if (theTime >= 2)
            {
                theTime = 0;

                floatLocation.position = startPosition;

                startFloatingDamage = false;
                thisCanvas.enabled = false;

                thisAnimator.SetBool(375673178, false);

                leftSide = false;
                enabled = false;
            }
        }


        if (startFloatingExperience)
        {
            theTime += Time.deltaTime;

            if (theTime >= 4.5f)
            {
                theTime = 0;

                startFloatingExperience = false;
                thisCanvas.enabled = false;

                thisAnimator.SetBool(933799643, false);

                leftSide = false;
                enabled = false;
            }
        }

        if (startFloatingLevelUp)
        {
            theTime += Time.deltaTime;

            if (theTime >= 4.5f)
            {
                theTime = 0;

                startFloatingLevelUp = false;
                thisCanvas.enabled = false;

                thisAnimator.SetBool(933799643, false);

                leftSide = false;
                enabled = false;
            }
        }
    }

    public void StartFloatingDamage(Vector3 position)
    {
        DamageText();

        thisCanvas.enabled = true;

        thisPosition = position;

        worldToLocalPosition = floatLocation.InverseTransformPoint(thisPosition);

        aaa = worldToLocalPosition.x;
        baa = worldToLocalPosition.y;
        caa = 0;

        floatLocation.localPosition = new Vector3 (aaa,baa,caa);

        thisAnimator.SetBool(375673178, true);
        
        startFloatingDamage = true;
    }


    void DamageText()
    {
        if (globalController.globalFloatDamage < 0)
        {
            saver = globalController.globalFloatDamage;

            saver = -saver;

            theText.color = greenColor;
            theText.text = "+" + saver.ToString();
        }


        else if (globalController.globalFloatDamage == 0)
        {
            theText.color = redColor;
            theText.text = globalController.globalFloatDamage.ToString();
        }

        else if (globalController.globalFloatDamage > 0)
        {
            theText.color = redColor;
            theText.text = "-" + globalController.globalFloatDamage.ToString();
        }
    }








    public void ShowExperience(int theExperience)
    {
        ExperienceText(theExperience);

        thisCanvas.enabled = true;

        thisAnimator.SetBool(933799643, true);

        startFloatingExperience = true;
    }


    void ExperienceText(int theExperience)
    {
        theText.color = greenColor;
        theText.text = "+" + theExperience.ToString() + "xp";
    }



    public void ShowLevelUp()
    {
        LevelUpText();

        thisCanvas.enabled = true;

        thisAnimator.SetBool(933799643, true);

        startFloatingLevelUp = true;
    }


    void LevelUpText()
    {
        theText.color = yellowColor;
        theText.text = "Level Up!";
    }


}
