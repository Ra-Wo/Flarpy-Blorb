using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManagerScript : MonoBehaviour
{
    public int PlayerScore = 0;
    public Text PlayerScoreText;
    public GameObject GameOverScreen;

    public AudioSource ScoreSound;

    public void AddScore(int scoreToAdd = 1)
    {
        PlayerScore += scoreToAdd;
        PlayerScoreText.text = PlayerScore.ToString();
        ScoreSound.Play();
    }

    public void RestartGame()
    {
        PlayerScore = 0;
        PlayerScoreText.text = PlayerScore.ToString();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
