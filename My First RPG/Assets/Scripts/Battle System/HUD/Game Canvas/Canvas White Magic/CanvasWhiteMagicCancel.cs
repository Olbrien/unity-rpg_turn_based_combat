using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasWhiteMagicCancel : MonoBehaviour
{
    public GameObject actionButtonsPaladinGO;
    public GameObject cancelActionCanvasGO;
    public GameObject cancelWhiteMagicGO;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnEnable()
    {
        actionButtonsPaladinGO.SetActive(false);
        cancelActionCanvasGO.SetActive(true);
        cancelWhiteMagicGO.SetActive(true);
    }
    

    public void CloseWhiteMagic()
    {
        this.gameObject.SetActive(false);
        actionButtonsPaladinGO.SetActive(true);
        cancelWhiteMagicGO.SetActive(false);
        cancelActionCanvasGO.SetActive(false);
    }
}
