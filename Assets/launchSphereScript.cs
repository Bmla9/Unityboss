using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchSphereScript : MonoBehaviour
{
    public float force;
    public float range;
    Rigidbody rb;
    Vector3 direc;

    private void Start()
    {
        // Sets the effective range to launch cubes / spheres.
        transform.localScale = new Vector3(range, range, range);
    }

    private void OnTriggerEnter(Collider other)
    {
        rb = other.GetComponent<Rigidbody>();
        direc = (other.transform.position - transform.position).normalized; // Gets the direction between the launch sphere and the cube / sphere.
        rb.AddForce(direc * force);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, range); // Draws the effective range as a gizmo.
    }
}
