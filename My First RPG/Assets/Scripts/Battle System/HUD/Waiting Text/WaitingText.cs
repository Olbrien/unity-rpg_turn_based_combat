using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaitingText : MonoBehaviour
{

    public TextMeshProUGUI textMesh;


    void Start()
    {
        
    }


    void Update()
    {

    }

    private void OnEnable()
    {
        StartCoroutine(WaitingTextCoroutine());
    }

    IEnumerator WaitingTextCoroutine()
    {
        while (true)
        {
            textMesh.text = "Waiting.";
            yield return new WaitForSeconds(0.3f);
            textMesh.text = "Waiting..";
            yield return new WaitForSeconds(0.3f);
            textMesh.text = "Waiting...";
            yield return new WaitForSeconds(0.3f);
        }
    }

    private void OnDisable()
    {
        StopCoroutine(WaitingTextCoroutine());
    }
}
