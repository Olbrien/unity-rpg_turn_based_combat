using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceSetsController : MonoBehaviour
{

    public Camera uICameraFaceSets;
    public Transform uICameraFaceSetsTransform;

    Vector3 offPosition = new Vector3(-20, 20, 0);
    Vector3 positionOne = new Vector3(-20, 0, 0);
    Vector3 positionTwo = new Vector3(-20, -20, 0);
    Vector3 positionThree = new Vector3(-20, -40, 0);

    void Start()
    {
        
    }

    public void OnClickFaceSetButton()
    {
        if (uICameraFaceSetsTransform.position == offPosition)
        {
            uICameraFaceSetsTransform.position = positionOne;
        }

        else if (uICameraFaceSetsTransform.position == positionOne)
        {
            uICameraFaceSetsTransform.position = positionTwo;
        }

        else if (uICameraFaceSetsTransform.position == positionTwo)
        {
            uICameraFaceSetsTransform.position = positionThree;
        }

        else if (uICameraFaceSetsTransform.position == positionThree)
        {
            uICameraFaceSetsTransform.position = offPosition;
        }
    }


}
