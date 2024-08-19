using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicManagerScript : MonoBehaviour
{
    public int points;
    public Text scoreText;
    public GameObject gameoverScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd) 
    {
        points += scoreToAdd;
        scoreText.text = points.ToString();
    }

    public void restartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameoverScreen.SetActive(true);
    }
}
