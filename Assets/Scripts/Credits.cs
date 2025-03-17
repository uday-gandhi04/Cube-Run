using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Quit!!");
        Application.Quit();
    }

    int homeScreenIndex = 1;
    public void Restart()
    {
        SceneManager.LoadScene(homeScreenIndex);
    }

}
