using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    float xpos, ypos;
    Vector3 pos2;
    Vector3 defaultPos;

    private void Start()
    {
        // Gets the starting (x, y) coordinates.
        xpos = transform.position.x;
        ypos = transform.position.y;

        // Gets the default pos.
        defaultPos = transform.position;
    }

    private void Update()
    {
        // Gets the mouse input.
        float mouseX = Input.GetAxisRaw("Mouse X") * 10f;
        float mouseY = Input.GetAxisRaw("Mouse Y") * 10f;

        // Checks for any mouse movement / moves the camera.
        if (mouseX + mouseY != 0)
        {
            pos2 = new Vector3(xpos + mouseX, ypos + mouseY, -10f);
            transform.position = Vector3.Lerp(transform.position, pos2, 0.05f * Time.deltaTime);
        }
        else transform.position = Vector3.Lerp(transform.position, defaultPos, 10f * Time.deltaTime);
    }
}
