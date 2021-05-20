using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakingCamera : MonoBehaviour
{
    public Transform mainCamera;
    public Transform backgroundCamera;
    Vector3 origPos = new Vector3(0f, 0f, -10f);
    Vector3 tempVec;

    bool shakeCamera;
    float timer;
    float theTime;


    void Start()
    {

    }

    void FixedUpdate()
    {
        ShakeCameraUpdate();
    }

    public void ShakeCamera()
    {
        shakeCamera = true;
    }

    void ShakeCameraUpdate()
    {
        if (shakeCamera)
        {
            theTime += Time.deltaTime;

            if (theTime < 0.15f)
            {
                for (timer = 0.0f; timer < 0.02f; timer += Time.deltaTime * 2.0f)
                {
                    // Create a temporary vector2 with the camera's original position modified by a random distance from the origin.
                    tempVec = origPos + Random.insideUnitSphere * 0.07f;

                    // Apply the temporary vector.
                    mainCamera.localPosition = tempVec;
                    backgroundCamera.localPosition = tempVec;
                }
            }

            else if (theTime >= 0.15f)
            {
                // Return back to the original position.
                mainCamera.localPosition = origPos;
                backgroundCamera.localPosition = origPos;

                shakeCamera = false;
                theTime = 0;
                timer = 0;
            }
        }
    }

}
