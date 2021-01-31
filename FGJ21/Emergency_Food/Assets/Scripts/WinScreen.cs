using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class WinScreen : MonoBehaviour
{
    public Button MenuButton;

    // Start is called before the first frame update
    void Start()
    {
        MenuButton.onClick.AddListener(BackToMenu);
    }

    void BackToMenu()
    {
        // Loads level
        SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
