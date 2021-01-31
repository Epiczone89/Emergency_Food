using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using TMPro;

public class PauseMenu : MonoBehaviour
{
    public Button playButton;
    public Button backButton;
 
    // Start is called before the first frame update
    void Start()
    {
        // Adds listener to click
        playButton.onClick.AddListener(playgame);
        backButton.onClick.AddListener(backMenu);
    }

    void playgame()
    {

    }

    void backMenu()
    {

    }
    // Update is called once per frame
    void Update()
    {
        


    }
}
