using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadingText : MonoBehaviour
{

    public TextMeshPro textMesh;


    void Start()
    {

    }


    void Update()
    {

    }

    private void OnEnable()
    {
        StartCoroutine(LoadingTextCoroutine());
    }

    IEnumerator LoadingTextCoroutine()
    {
        while (true)
        {
            textMesh.text = "Loading.";
            yield return new WaitForSeconds(0.3f);
            textMesh.text = "Loading..";
            yield return new WaitForSeconds(0.3f);
            textMesh.text = "Loading...";
            yield return new WaitForSeconds(0.3f);
        }
    }

    private void OnDisable()
    {
        StopCoroutine(LoadingTextCoroutine());
    }
}
