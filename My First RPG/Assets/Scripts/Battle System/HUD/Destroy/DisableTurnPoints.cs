using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableTurnPoints : MonoBehaviour
{

    void OnEnable()
    {
        Invoke("DisableThisGameObject", 1.2f);
    }


    void Update()
    {
        
    }

    void DisableThisGameObject()
    {
        this.gameObject.SetActive(false);
    }
}
