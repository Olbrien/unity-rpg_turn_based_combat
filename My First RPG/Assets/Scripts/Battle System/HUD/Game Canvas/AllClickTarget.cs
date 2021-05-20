using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllClickTarget : MonoBehaviour
{

    public List<Image> allClickEnemies;
    public Image clickPaladin;
    public Image clickWizard;

    void Start()
    {
        
    }



    void Update()
    {
        
    }

    public void AllClicksEnemiesEnabled()
    {
        foreach (Image enemy in allClickEnemies)
        {
            enemy.raycastTarget = true;
        }
    }


    public void AllClicksEnemiesDisabled()
    {
        foreach (Image enemy in allClickEnemies)
        {
            enemy.raycastTarget = false;
        }
    }




    public void AllClicksPaladinEnabled()
    {
        clickPaladin.raycastTarget = true;
    }


    public void AllClicksPaladinDisabled()
    {
        clickPaladin.raycastTarget = false;
    }



    public void AllClicksWizardEnabled()
    {
        clickWizard.raycastTarget = true;
    }


    public void AllClicksWizardDisabled()
    {
        clickWizard.raycastTarget = false;
    }

}
