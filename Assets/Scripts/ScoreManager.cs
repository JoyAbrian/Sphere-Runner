using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public float scoreIncrementInterval = 0.2f;
    private float timer;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreText2;
    public TextMeshProUGUI highScoreText;

    void Start()
    {
        GlobalVariables.score = 0;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= scoreIncrementInterval)
        {
            GlobalVariables.score += 1;
            timer = 0f;
            
            if (GlobalVariables.score > GlobalVariables.highScore)
            {
                GlobalVariables.highScore = GlobalVariables.score;
            }
            UpdateScoreUI();
        }
        HideScoreText2();
    }

    void UpdateScoreUI()
    {
        scoreText2.text = "Score: " + GlobalVariables.score.ToString();

        scoreText.text = GlobalVariables.score.ToString();
        highScoreText.text = GlobalVariables.highScore.ToString();
    }

    public void HideScoreText2()
    {
        if (Time.timeScale != 0)
            scoreText2.gameObject.SetActive(true);
        else
            scoreText2.gameObject.SetActive(false);
    }
}