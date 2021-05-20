using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindAllSelectArrow : MonoBehaviour
{

    public GameObject selectArrowPaladin;
    public GameObject selectArrowWizard;
    public GameObject[] selectArrowEnemy;


    void Start()
    {

    }


    void Update()
    {

    }


    public void SelectOnlyPaladinArrowTrue()
    {
        //selectArrowPaladin = GameObject.FindGameObjectWithTag("SelectArrowPaladin");

        selectArrowPaladin.GetComponent<Canvas>().enabled = true;
    }

    public void SelectOnlyPaladinArrowFalse()
    {
        //selectArrowPaladin = GameObject.FindGameObjectWithTag("SelectArrowPaladin");

        selectArrowPaladin.GetComponent<Canvas>().enabled = false;
    }



    public void SelectOnlyWizardArrowTrue()
    {
        //selectArrowWizard = GameObject.FindGameObjectWithTag("SelectArrowWizard");

        selectArrowWizard.GetComponent<Canvas>().enabled = true;
    }

    public void SelectOnlyWizardArrowFalse()
    {
        //selectArrowWizard = GameObject.FindGameObjectWithTag("SelectArrowWizard");

        selectArrowWizard.GetComponent<Canvas>().enabled = false;
    }




    public void SelectOnlyEnemyArrowTrue()
    {
        selectArrowEnemy = GameObject.FindGameObjectsWithTag("SelectArrowEnemy");

        foreach (GameObject arrow in selectArrowEnemy)
        {
            arrow.GetComponent<Canvas>().enabled = true;
        }
    }

    public void SelectOnlyEnemyArrowFalse()
    {
        selectArrowEnemy = GameObject.FindGameObjectsWithTag("SelectArrowEnemy");

        foreach (GameObject arrow in selectArrowEnemy)
        {
            arrow.GetComponent<Canvas>().enabled = false;
        }
    }
       



    public void SelectAllArrowsTrue()
    {
        //selectArrowPaladin = GameObject.FindGameObjectWithTag("SelectArrowPaladin");
        //selectArrowWizard = GameObject.FindGameObjectWithTag("SelectArrowWizard");
        selectArrowEnemy = GameObject.FindGameObjectsWithTag("SelectArrowEnemy");

        selectArrowPaladin.GetComponent<Canvas>().enabled = true;
        selectArrowWizard.GetComponent<Canvas>().enabled = true;

        foreach (GameObject arrow in selectArrowEnemy)
        {
            arrow.GetComponent<Canvas>().enabled = true;
        }
    }

    public void SelectAllArrowsFalse()
    {
        //selectArrowPaladin = GameObject.FindGameObjectWithTag("SelectArrowPaladin");
        //selectArrowWizard = GameObject.FindGameObjectWithTag("SelectArrowWizard");
        selectArrowEnemy = GameObject.FindGameObjectsWithTag("SelectArrowEnemy");

        selectArrowPaladin.GetComponent<Canvas>().enabled = false;
        selectArrowWizard.GetComponent<Canvas>().enabled = false;

        foreach (GameObject arrow in selectArrowEnemy)
        {
            arrow.GetComponent<Canvas>().enabled = false;
        }

        Array.Clear(selectArrowEnemy, 0, selectArrowEnemy.Length);
    }
}
