using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        gameManager.completeLvl();
        FindObjectOfType<PauseResumeToggleIcons>().HideButton();

    }
}
