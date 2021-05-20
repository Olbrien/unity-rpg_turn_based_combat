using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartingAnimationController : MonoBehaviour
{
    public bool startingAnimation;
    public bool startingAnimationDelay;
    public bool endingAnimation;
    public float speedImperialAdventureText;

    float theTime;

    public bool canvasGroupAnimation;
    public CanvasGroup playerCanvasGroup;
    public CanvasGroup enemyCanvasGroup;
    public CanvasGroup buttonsCanvasGroup;
    public GraphicRaycaster buttonsGraphicRaycaster;
    public CanvasGroup topLeftTextCanvasGroup;
    public CanvasGroup backgroundCanvasGroup;

    public bool loadingAdventure;


    public CanvasGroup imperialAdventureCanvas;
    Vector3 imperialAdventureTextStartPosition;

    public SceneController sceneController;
    public Canvas loadingCanvas;
    public Loading loading;
    


    void Awake()
    {
        playerCanvasGroup.alpha = 0;
        buttonsCanvasGroup.alpha = 0;
        enemyCanvasGroup.alpha = 0;
        topLeftTextCanvasGroup.alpha = 0;
        buttonsGraphicRaycaster.enabled = false;
    }


    void Update()
    {
        if (startingAnimationDelay)
        {
            theTime += Time.deltaTime;

            if (theTime >= 1) { startingAnimationDelay = false; theTime = 0; startingAnimation = true; }
        }

        if (startingAnimation)
        {
            imperialAdventureCanvas.alpha += Time.deltaTime * 0.3f;

            if (imperialAdventureCanvas.alpha >= 1)
            {
                theTime += Time.deltaTime;

                if (theTime > 2)
                {
                    startingAnimation = false;
                    endingAnimation = true;
                    theTime = 0;
                }
            }
        }

        if (endingAnimation)
        {
            imperialAdventureCanvas.alpha -= Time.deltaTime * 0.5f;

            if (imperialAdventureCanvas.alpha <= 0f)
            {
                canvasGroupAnimation = true;
                endingAnimation = false;
            }
        }


        if (canvasGroupAnimation)
        {
            playerCanvasGroup.alpha += Time.deltaTime * 0.6f;
            enemyCanvasGroup.alpha += Time.deltaTime * 0.6f;
            buttonsCanvasGroup.alpha += Time.deltaTime * 0.6f;
            topLeftTextCanvasGroup.alpha += Time.deltaTime * 0.6f;

            if (playerCanvasGroup.alpha >= 1f && enemyCanvasGroup.alpha >= 1f && buttonsCanvasGroup.alpha >= 1f &&
                topLeftTextCanvasGroup.alpha >= 1f)
            {
                buttonsGraphicRaycaster.enabled = true;
                canvasGroupAnimation = false;
            }
        }

        if (loadingAdventure)
        {    
            playerCanvasGroup.alpha -= Time.deltaTime * 0.6f;
            enemyCanvasGroup.alpha -= Time.deltaTime * 0.6f;
            buttonsCanvasGroup.alpha -= Time.deltaTime * 0.6f;
            topLeftTextCanvasGroup.alpha -= Time.deltaTime * 0.6f;            

            buttonsGraphicRaycaster.enabled = false;

            if (playerCanvasGroup.alpha <= 0f && enemyCanvasGroup.alpha <= 0f && buttonsCanvasGroup.alpha <= 0f &&
                topLeftTextCanvasGroup.alpha <= 0f)
            {
                theTime += Time.deltaTime;

                if (theTime >= 0.5f)
                {
                    backgroundCanvasGroup.alpha -= Time.deltaTime * 0.4f;

                    if (backgroundCanvasGroup.alpha <= 0f)
                    { 
                        loadingAdventure = false;
                        loading.StartLoadingText();
                        loadingCanvas.enabled = true;
                        sceneController.StartAdventure();

                        theTime = 0;
                    }
                }
            }
        }
    }
}
