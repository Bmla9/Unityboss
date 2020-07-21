using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnScript : MonoBehaviour
{
    
    public GameObject cube;
    public Text cubeCount, sphereCount;
    int cubes, spheres;
    int timer;
    GameObject[] cubesnspheres;

    //I have added some comment
    private void Update()
    {
        if (timer >= 100)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere); // Changed the objects name from plane to sphere.
            sphere.transform.position = new Vector3(3f, 10f, 0f); // Sets the position of the sphere to be above the second platform.
            sphere.AddComponent<Rigidbody>();
            sphere.tag = "someobject";
            spheres++;
            sphereCount.text = spheres.ToString();
            
            Instantiate(cube, new Vector3(-3f, 10f, 0f), transform.rotation, transform);
            cubes++;
            cubeCount.text = cubes.ToString();

            timer = 0; // Resets the timer.
        }
        timer++;

        cubesnspheres = GameObject.FindGameObjectsWithTag("someobject"); // Gets all the cubes and sphers in the scene.
        foreach (GameObject cubensphere in cubesnspheres)
        {
            // If the sphere is further than 50m away from the spawn object it gets destroyed.
            if (Vector3.Distance(transform.position, cubensphere.transform.position) >= 50f)
            {
                Debug.Log($"Removing... {cubensphere}");
                Destroy(cubensphere);
            }
        }
    }
}
