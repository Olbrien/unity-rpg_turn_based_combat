using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InstantiateLootEvent : MonoBehaviour
{
    public GameObject content;

    public List<string> items;
    public List<Sprite> icons;


    void Start()
    {
        InvokeRepeating("CleanList", 0, 0.9f);
    }


    void Update()
    {
        
    }

    public void AddToList(string theItem, Sprite theSprite)
    {
        items.Add(theItem);
        icons.Add(theSprite);
    }

    void CleanList()
    {
        if (items.Count == 0 && icons.Count == 0)
        {
            return;
        }

        else
        {
            InstantiateContent(items[items.Count - 1], icons[icons.Count - 1]);

            items.RemoveAt(items.Count - 1);
            icons.RemoveAt(icons.Count - 1);
        }
    }


    public void InstantiateContent(string theItem, Sprite theSprite)
    {
        content.GetComponentInChildren<TextMeshPro>().text = theItem;
        var a = content.transform.GetChild(1).GetComponentInChildren<Image>().GetComponentInChildren<Image>().sprite = theSprite;

        var instantiateObject = Instantiate(content, transform.position, Quaternion.identity, transform.parent);
        instantiateObject.transform.SetParent(gameObject.transform);
        instantiateObject.transform.SetSiblingIndex(0);

    }
}
