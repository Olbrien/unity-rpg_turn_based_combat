using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EventsChatController : MonoBehaviour
{
    public int maxMessage = 25;

    int currentMessageOne = 0;
    int currentMessageTwo = 0;

    public List<GameObject> textList;
    public List<GameObject> textListTwo;

    public GameObject chatPanel, textObject;

    [Space(10)]

    public GameObject chatPanelTwo;
    public GameObject textObjectTwo;

    public List<Message> messageList = new List<Message>();

    [Space(10)]
    public List<Message> messageListTwo = new List<Message>();

    void Start()
    {
        
    }


    void Update()
    {

    }


    public void SendMessageToChatFromOtherScripts(string text)
    {
        SendMessageToChat(text);
    }


    public void SendMessageToChat(string text)
    {
        Message newMessage = new Message();

        newMessage.text = text;


        foreach (var textListList in textList)
        {
            if (textListList.activeSelf == false)
            {
                textListList.SetActive(true);                                

                var aa = textListList.GetComponent<RectTransform>();
                aa.SetAsLastSibling();

                currentMessageOne += 1;

                if (currentMessageOne == maxMessage)
                {
                    textList[0].SetActive(false);
                    currentMessageOne = 0;
                }

                textList[currentMessageOne].SetActive(false);

                newMessage.textObject = textListList.GetComponent<TextMeshPro>();
                newMessage.textObject.text = newMessage.text;

                //messageList.Add(newMessage);

                break;
            }
        }
    }




    public void SendMessageToChatFromOtherScriptsTwo(string text)
    {
        SendMessageToChatTwo(text);
    }


    public void SendMessageToChatTwo(string text)
    {
        Message newMessageTwo = new Message();

        newMessageTwo.text = text;


        foreach (var textListList in textListTwo)
        {
            if (textListList.activeSelf == false)
            {
                textListList.SetActive(true);

                var aa = textListList.GetComponent<RectTransform>();
                aa.SetAsLastSibling();

                currentMessageTwo += 1;

                if (currentMessageTwo == maxMessage)
                {
                    textListTwo[0].SetActive(false);
                    currentMessageTwo = 0;
                }

                textListTwo[currentMessageTwo].SetActive(false);

                newMessageTwo.textObject = textListList.GetComponent<TextMeshPro>();
                newMessageTwo.textObject.text = newMessageTwo.text;

                //messageList.Add(newMessage);

                break;
            }
        }
    }
}

[System.Serializable]
public class Message
{
    public string text;
    public TextMeshPro textObject;
}