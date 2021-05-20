using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakingCamera : MonoBehaviour
{

    public void ShakeCamera()
    {
        StartCoroutine(ShakeCameraCoroutine());
    }

    IEnumerator ShakeCameraCoroutine()
    {
        Vector3 origPos = new Vector3(Camera.main.transform.localPosition.x, 0f, -10f);
        for (float t = 0.0f; t < 0.2f; t += Time.deltaTime * 2.0f)
        {
            // Create a temporary vector2 with the camera's original position modified by a random distance from the origin.
            Vector3 tempVec = origPos + Random.insideUnitSphere * 0.05f;

            // Apply the temporary vector.
            Camera.main.transform.localPosition = tempVec;

            // Yield until next frame.
            yield return null;
        }

        // Return back to the original position.
        Camera.main.transform.localPosition = origPos;
    }
}
