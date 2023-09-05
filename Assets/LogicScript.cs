using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int player_score;
    public Text score_text;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore( int score_to_add)
    {
        player_score += score_to_add;
        score_text.text = player_score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
