
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public void loadHome()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void WhooshIntro()
    {
        FindObjectOfType<AudioManager>().Play("WhooshIntro");
    }

    public void CrashIntro()
    {
        FindObjectOfType<AudioManager>().Play("CrashIntro");
    }

    public void Background()
    {
        FindObjectOfType<AudioManager>().Play("Background");
    }

}
