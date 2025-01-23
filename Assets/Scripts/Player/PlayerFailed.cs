using UnityEngine;

public class PlayerFailed : MonoBehaviour
{
    public GameObject gameOverMenu;

    private void Start()
    {
        gameOverMenu.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Time.timeScale = 0;
            gameOverMenu.SetActive(true);
        }
    }
}
