using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragRotate : MonoBehaviour
{
private Vector2 lastPos;
public float rotationSpeed;

private void Update()
{
    // Handle a single touch
    if (Input.touchCount == 1)
    {
        var touch = Input.GetTouch(0);

        switch(touch.phase)
        {
            case TouchPhase.Began:
                // store the initial touch position
                lastPos = touch.position;
                break;

            case TouchPhase.Moved:
                // get the moved difference and convert it to an angle
                // using the rotationSpeed as sensibility
                var rotationX = (touch.position.x - lastPos.x) * rotationSpeed;
                transform.Rotate(Vector3.up, -rotationX, Space.World);

                lastPos = touch.position;
                break;
        }
    }
}
}
