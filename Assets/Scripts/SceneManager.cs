using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public static void LoadScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        Time.timeScale = 1;
    }

    public static void QuitGame()
    {
        Application.Quit();
    }
}