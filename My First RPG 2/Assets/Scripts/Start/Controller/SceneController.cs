using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public bool sceneZeroToOne;    

    void Start()
    {
        if (sceneZeroToOne)
        {
            StartCoroutine(LoadAsynchronously(1));
        }
    }


    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {      
            yield return null;
        }
    }

    public void StartAdventure()
    {
        StartCoroutine(LoadAsynchronously(2));
    }


}
