using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BubbleText : MonoBehaviour
{

    public TextMeshProUGUI bubbleText;

    public int bubbleNumber = 0;

    void Start()
    {
        bubbleText.text = "0";
    }

    
    public void AddBubble()
    {
        bubbleNumber += 1;
        bubbleText.text = bubbleNumber.ToString();
    }
}
