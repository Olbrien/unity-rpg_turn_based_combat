using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatController : MonoBehaviour
{

    public List<Float> floatsScript;
    public List<Float> levelUp;



    void Start()
    {
        
    }


    public void DamageFloatPopUpRightSide(Vector3 position)
    {
        foreach (var damageFloat in floatsScript)
        {
            if (damageFloat.enabled == false)
            {
                damageFloat.enabled = true;
                damageFloat.rightSide = true;

                damageFloat.StartFloatingDamage(position);

                return;
            }
        }
    }

    public void DamageFloatPopUpLeftSide(Vector3 position)
    {
        foreach (var damageFloat in floatsScript)
        {
            if (damageFloat.enabled == false)
            {
                damageFloat.enabled = true;
                damageFloat.leftSide = true;

                damageFloat.StartFloatingDamage(position);

                return;
            }
        }
    }


    public void ExperienceFloatPopUp(int theExperience)
    {
        foreach (var damageFloat in levelUp)
        {
            if (damageFloat.enabled == false)
            {
                damageFloat.enabled = true;

                damageFloat.ShowExperience(theExperience);

                return;
            }
        }
    }

    public void LevelUpFloatPopUp()
    {
        foreach (var damageFloat in levelUp)
        {
            if (damageFloat.enabled == false)
            {
                damageFloat.enabled = true;

                damageFloat.ShowLevelUp();

                return;
            }
        }
    }


}
