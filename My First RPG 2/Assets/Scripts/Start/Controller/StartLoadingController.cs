using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLoadingController : MonoBehaviour
{

    bool start = true;

    public Sky sky;
    public EntireGameControllerCollector entireGameControllerCollector;


    void Update()
    {
        if (start)
        {
            sky.Skies[entireGameControllerCollector.selectedLevel].enabled = true;
            start = false;
        }
    }
}
