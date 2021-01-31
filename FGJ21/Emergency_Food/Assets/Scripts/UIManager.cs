using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    public Button QuitButton;
    public Button ContinueButton;
    PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
        QuitButton.onClick.AddListener(QuitMenu);
        ContinueButton.onClick.AddListener(ContinueGame);
    }

    void QuitMenu()
    {
        // Loads level
        SceneManager.LoadScene(0);
    }

    void ContinueGame()
    {
        playerController.TriggerPause();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
