using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartEndController : MonoBehaviour
{

    public CanvasGroup canvasScreenAnimator;


    bool start = true;
    float theTime;

    void Start()
    {
        canvasScreenAnimator.alpha = 0;
    }


    void Update()
    {
        if (start)
        {
            theTime += (Time.deltaTime * 0.7f);

            canvasScreenAnimator.alpha = theTime;

            if (theTime >= 1)
            {
                canvasScreenAnimator.alpha = 1;
                start = false;                
            }
        }
    }
}
