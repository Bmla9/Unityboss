using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject cube;  
    int timer = 0;

    //I have added some comment
    private void Update()
    {
        if (timer >= 100)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere); // Changed the objects name from plane to sphere.
            sphere.transform.position = new Vector3(3f, 10f, 0f); // Sets the position of the sphere to be above the second platform.
            sphere.AddComponent<Rigidbody>();
            
            Instantiate(cube, new Vector3(-3f, 10f, 0f), transform.rotation, transform);
            timer = 0; // Resets the timer.
        }
        timer++;
    }
}
