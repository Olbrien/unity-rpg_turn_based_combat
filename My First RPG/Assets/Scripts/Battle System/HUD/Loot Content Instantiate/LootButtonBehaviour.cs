using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LootButtonBehaviour : MonoBehaviour
{

    public Animator fadeOut;
    public GameObject iconName;
    public GameObject itemName;
    ItemsController itemController;
    EventsChatController eventsChatController;

    void Start()
    {
        itemController = FindObjectOfType<ItemsController>();
        eventsChatController = FindObjectOfType<EventsChatController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DestroyObject()
    {
        StartCoroutine(DestroyObjectCorountine());
    }

    IEnumerator DestroyObjectCorountine()
    {
        fadeOut.SetBool("FadeOut", true);
        yield return new WaitForSeconds(1f);
        Destroy(transform.parent.gameObject);
    }

    public void DestroyObjectInstant()
    {
        Destroy(transform.parent.gameObject);
    }


    public void CollectObject()
    {
        var nameOfObject = iconName.GetComponent<Image>().sprite.name;

        itemController.AddOneItem(nameOfObject);

        eventsChatController.SendMessageToChatTwo("You got a " + itemName.GetComponent<TextMeshProUGUI>().text + ".");

        DestroyObjectInstant();
    }

}
