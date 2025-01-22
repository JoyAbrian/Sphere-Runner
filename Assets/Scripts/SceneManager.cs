using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public static void LoadScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}