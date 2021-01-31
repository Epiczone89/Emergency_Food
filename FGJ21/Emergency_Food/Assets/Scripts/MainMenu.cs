using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public Button playButton;
    public Button optionsButton;
    public Button speedupButton;
    public Button speeddownButton;
    public Button hungerupButton;
    public Button hungerdownButton;
    public Button carspeedupButton;
    public Button carspeeddownButton;
    public Button creditsButton;
    public Button quitButton;
    public GameObject creditsPanel;
    public GameObject optionsPanel;
    public TextMeshProUGUI SpeedRateText;
    public TextMeshProUGUI HungerRateText;
    public TextMeshProUGUI CarsSpeedRateText;


    // Start is called before the first frame update
    void Start()
    {
        // Adds listener to click
        playButton.onClick.AddListener(playgame);
        // Adds listener to click
        optionsButton.onClick.AddListener(openoptions);
        // Adds listener to click
        creditsButton.onClick.AddListener(opencredits);
        // Closes software
        quitButton.onClick.AddListener(Application.Quit);

        raiseSpeed(0);
        raiseHunger(0);
        raiseCarSpeed(0);

    }

    void playgame()
    {
        // Loads level
        SceneManager.LoadScene(1);
    }

    void openoptions()
    {
        optionsPanel.SetActive(!optionsPanel.activeSelf);
    }

    // Raises Cats speed
    public void raiseSpeed(int _value)
    {
        // Chances hungerRate value
        OptionManager.Instance.speedRate += _value;
        // Chances Cats speed to string
        SpeedRateText.text = "Cat's speed: " + OptionManager.Instance.speedRate.ToString() + "x";
    }

    // Raises Hunger rate
    public void raiseHunger(int _value)
    {
        // Chances hungerRate value
        OptionManager.Instance.hungerRate += _value;
        // Chances hungerRate to string
        HungerRateText.text = "Hunger rate: " + OptionManager.Instance.hungerRate.ToString() + "x";
    }

    // Raises Car speed
    public void raiseCarSpeed(int _value)
    {
        // Chances carsspeedRate value
        OptionManager.Instance.carspeedRate += _value;
        // Chances carspeedRate to string
        CarsSpeedRateText.text = "Cars speed : " + OptionManager.Instance.carspeedRate.ToString() + "x";
    }

    void opencredits()
    {
        // Toggle credits
        creditsPanel.SetActive(!creditsPanel.activeSelf);
    }
}
