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
            //------ Instantiate sphere (primitive) ------//

            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);           // Changed the objects name from plane to sphere.
            sphere.transform.position = new Vector3(3f, 10f, 0f);                           // Sets the position of the sphere to be above the second platform.
            sphere.tag = "someobject";                                                      // Gives the sphere the tag "someobject".
            sphere.AddComponent<Rigidbody>();                                               // Adds a rigidbody to the sphere.
            Rigidbody rb = sphere.GetComponent<Rigidbody>();                                // Not doing this made line 27 to long.
            rb.collisionDetectionMode = CollisionDetectionMode.Continuous;                  // Sets the collision detection mode to continuous.
            sphere.GetComponent<Renderer>().material.color = Color.cyan;                    // Sets the color to Cyan.


            //------ Instantiate cube (prefab) ------//

            Instantiate(cube, new Vector3(-3f, 10f, 0f), transform.rotation, transform);    // Instantiates the prefab :)


            // Sphere / cube counter stuff //
            spheres++;
            cubes++;
            sphereCount.text = spheres.ToString();
            cubeCount.text = cubes.ToString();

            // Reset timer //
            timer = 0;
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
