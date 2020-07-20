using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    string currentScene;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;
    }

    private void Update()
    {
        // Reloads the current scene when the key 'r' has been pressed.
        if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene(currentScene);
    }
}
