using UnityEngine;
using UnityEngine.UI;

public class PauseResumeToggleIcons : MonoBehaviour
{
    public Button toggleButton;       // Assign your button in the Inspector
    public GameObject pauseIcon;      // Assign the Pause icon GameObject
    public GameObject playIcon;       // Assign the Play icon GameObject

    private bool isPaused = false;

    void Start()
    {
        // Set up the button click listener
        toggleButton.onClick.AddListener(TogglePauseResume);

        // Initialize icon states
        pauseIcon.SetActive(true);
        playIcon.SetActive(false);
    }

    void TogglePauseResume()
    {
        if (isPaused)
        {
            // Resume the game
            Time.timeScale = 1f;       // Normal game speed
            pauseIcon.SetActive(true);
            playIcon.SetActive(false);
        }
        else
        {
            // Pause the game
            Time.timeScale = 0f;       // Stop the game
            pauseIcon.SetActive(false);
            playIcon.SetActive(true);
        }

        isPaused = !isPaused;          // Toggle the state
    }
    public void HideButton()
    {
        toggleButton.gameObject.SetActive(false);
    }

}
