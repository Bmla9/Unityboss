using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomScript : MonoBehaviour
{
    public Transform launchSphere;
    Vector3 mousePos;

    private void Update()
    {
        // Get the mouse position in the world.
        mousePos = Input.mousePosition;
        mousePos.z = 10f;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos); // Converts mousePos to a world position.

        // Moves the sphere to the mouse position when MB1 is being held.
        if (Input.GetMouseButton(0)) launchSphere.position = mousePos;
        else launchSphere.position = new Vector3(0f, 100f, 0f);
    }
}
