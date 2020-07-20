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
            Instantiate(cube, transform);
            timer = 0;
        }
        timer++;
    }
}
