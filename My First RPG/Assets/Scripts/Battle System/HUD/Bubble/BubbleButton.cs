using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class BubbleButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public TextMeshPro bubbleTxt;
    public Animator bubbleAnimator;

    public GameController gameController;
    public Paladin paladin;
    public Wizard wizard;
    public TurnPointsController turnPointsController;

    public RectTransform rectTransform;

    public int randomNumber;
    public int randomNumberAnimation;

    bool mouseDown;
    float timer;


    private void OnEnable()
    {
        randomNumber = Random.Range((Mathf.Max(paladin.bubbleNumber, wizard.bubbleNumber)), (paladin.bubbleNumber + wizard.bubbleNumber + 1));

        bubbleTxt.text = "+" + randomNumber.ToString();

        AnimationRandom();

        Invoke("DisableThisGameObject", 30f);

    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (mouseDown)
        {
            if (timer < 0.1f)
            {
                return;
            }
            ClickTimer();
        }
    }


    void DisableThisGameObject()
    {
        this.transform.parent.gameObject.SetActive(false);
    }

    IEnumerator DisableThisGameObjectAfterShrink()
    {
        yield return new WaitForSeconds(2f);
        this.transform.parent.gameObject.SetActive(false);
    }

    void ClickTimer()
    {

        timer = 0;

        if (randomNumber > 0)
        {
            if (randomNumber >= 1)
            {
                turnPointsController.AddTurnPointsButtonBubble(1);
            }

            randomNumber -= 1;

            bubbleTxt.text = "+" + randomNumber.ToString();
        }

        if (randomNumber <= 0)
        {
            randomNumber = 0;

            bubbleAnimator.SetTrigger("Shrink");

            bubbleTxt.text = "+" + randomNumber.ToString();

            StartCoroutine(DisableThisGameObjectAfterShrink());
        }
    }
       




    void AnimationRandom()
    {
        randomNumberAnimation = Random.Range(1, 10);

        switch (randomNumberAnimation)
        {
            case 1:
                bubbleAnimator.SetTrigger("BubbleMovementOne");
                break;
            case 2:
                bubbleAnimator.SetTrigger("BubbleMovementTwo");
                break;
            case 3:
                bubbleAnimator.SetTrigger("BubbleMovementThree");
                break;
            case 4:
                bubbleAnimator.SetTrigger("BubbleMovementFour");
                break;
            case 5:
                bubbleAnimator.SetTrigger("BubbleMovementFive");
                break;
            case 6:
                bubbleAnimator.SetTrigger("BubbleMovementSix");
                break;
            case 7:
                bubbleAnimator.SetTrigger("BubbleMovementSeven");
                break;
            case 8:
                bubbleAnimator.SetTrigger("BubbleMovementEight");
                break;
            case 9:
                bubbleAnimator.SetTrigger("BubbleMovementNine");
                break;
        }

    }


    public void OnPointerUp(PointerEventData eventData)
    {
        mouseDown = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        mouseDown = true;
    }

    private void OnDisable()
    {
        rectTransform.localScale = new Vector3(1, 1, 1);
    }
}
