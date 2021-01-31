using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HungerMeter : MonoBehaviour
{
    // Sets hunger aka Health points.
    public float hunger = 100;
    // Reference to hungerText
    public TextMeshProUGUI hungerText;

    // Sets cats lost to -1, but catsUpdate() adds one "cats" at start, making it 0 at the start of the game
    public float cats = -1;
    // Reference to catsText
    public TextMeshProUGUI catsText;

    // Sets timer to 0
    public float timer;
    // Reference to timerText
    public TextMeshProUGUI timerText;
    int minutes;

    // Multiply this variable to Time.deltaTime to decrease hunger over time
    // (Replaces the 0.5f previously in Update() so that it can be affected in PlayerController when player is laying down
    public float hungerSpeed = 0.5f;

    // Reference to PlayerController script
    public PlayerController playerController;

    // Checks if the game has been paused
    bool isPaused = false;

    // Sets hungerText to text and hunger to float
    void hungerUpdate()
    {
        // Updates UI to match hunger
        hungerText.text = "Hunger " + hunger.ToString("00");
    }

    // Sets livesText to text and lives to float
    public void catsUpdate()
    {
        cats++;
        hunger = 100;

        if(cats > 9)
        {
            catsText.text = "Cats lost: " + cats.ToString("00") + " :(";
        }
        else
        {
            // Updates UI to match lives
            catsText.text = "Cats lost: " + cats.ToString("00");
        }
    }

    // Sets timerText to text and time to float
    void timerUpdate()
    {
        // Updates UI to match time played
        timerText.text = "Time played " + minutes.ToString("00")+ ":" + timer.ToString("00");
        
    }

    // Start is called before the first frame update
    void Start()
    {
        hungerUpdate();
        catsUpdate();
        timerUpdate();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPaused)
        {
            // Sets timer to count down hunger from 100
            hunger -= Time.deltaTime * hungerSpeed;
            hungerUpdate();

            // If hunger goes to 0 (or below), kills cat and causes cat to respawn
            if (hunger <= 0)
            {
                playerController.KillCat();
            }

            // Sets timer to count played time
            timer += Time.deltaTime;
            if (timer >= 60)
            {
                minutes++;
                timer = 0;
            }
            timerUpdate();
        }
    }

    public bool PressedPause()
    {
        isPaused = !isPaused;
        return isPaused;
    }
}