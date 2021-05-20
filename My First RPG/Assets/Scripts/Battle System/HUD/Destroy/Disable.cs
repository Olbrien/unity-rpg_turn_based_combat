using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour
{
    public float disableTime = 5;

    private void OnEnable()
    {
        StartCoroutine(DisableCoroutine());
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DisableCoroutine()
    {
        yield return new WaitForSeconds(disableTime);
        this.gameObject.SetActive(false);
    }
}
