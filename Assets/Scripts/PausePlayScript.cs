using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PausePlayScript : MonoBehaviour
{
    private bool isPaused = false;
    public Text pauseText; // Reference to the UI Text element

    void Start()
    {
        pauseText.gameObject.SetActive(false); // Make sure the text is hidden at the start
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Press 'Esc' to toggle pause/play
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        if (isPaused)
        {
            Time.timeScale = 1f; // Resume the game
            pauseText.gameObject.SetActive(false); // Hide the "Paused" text
            isPaused = false;
        }
        else
        {
            Time.timeScale = 0f; // Pause the game
            pauseText.gameObject.SetActive(true); // Show the "Paused" text
            isPaused = true;
        }
    }
}

