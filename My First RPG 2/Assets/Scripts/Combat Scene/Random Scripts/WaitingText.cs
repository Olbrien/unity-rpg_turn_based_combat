using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaitingText : MonoBehaviour
{
    public bool waiting = true;
    int section;
    float timer;

    string one = "Waiting.";
    string two = "Waiting..";
    string three = "Waiting...";

    public TextMeshProUGUI thisText;


    void Start()
    {
       
    }

    void Update()
    {
        if (waiting)
        {
            timer += Time.deltaTime; 

            if (timer >= 0 && timer < 0.3f && section == 0)
            {
                thisText.text = one;
                section += 1;
            }

            else if (timer >= 0.3f && timer < 0.6f && section == 1)
            {
                thisText.text = two;
                section += 1;
            }

            else if (timer >= 0.6f && timer < 0.9f && section == 2)
            {
                thisText.text = three;
                section += 1;
            }

            else if (timer >= 0.9f && section == 3)
            {
                timer = 0;
                section = 0;
            }
        }
    }

    public void StartWaitingText()
    {
        section = 0;
        timer = 0;
        waiting = true;
    }

    public void StopWaitingText()
    {
        section = 0;
        timer = 0;
        waiting = false;
    }

}
