using TreeEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int PlayerScore;
    public Text ScoreText;
    public GameObject GameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        PlayerScore = PlayerScore + 1;
        ScoreText.text = PlayerScore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public  void gameOver()
    {
        GameOverScreen.SetActive(true);
    }

}
