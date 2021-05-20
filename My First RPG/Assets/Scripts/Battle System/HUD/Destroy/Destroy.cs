using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public int destroyTime;

    void Start()
    {
        Destroy(transform.root.gameObject, destroyTime);
    }


    void Update()
    {
        
    }
}
