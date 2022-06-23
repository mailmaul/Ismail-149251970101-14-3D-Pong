using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int player1Score;
    public int player2Score;
    public int player3Score;
    public int player4Score;
    public GameObject paddle1;
    public GameObject paddle2;
    public GameObject paddle3;
    public GameObject paddle4;
    public Text teks1;
    public Text teks2;
    public Text teks3;
    public Text teks4;

    public int maxScore;

    public Ball ball;
    
    public void AddPlayer1Score(int decrement)
    {
        player1Score -= decrement;

        if (player1Score <= maxScore)
        {
            Destroy(paddle1);
            Destroy(teks1);
            GameOver();
        }
    }

    public void AddPlayer2Score(int decrement)
    {
        player2Score -= decrement;

        if (player2Score <= maxScore)
        {
            Destroy(paddle2);
            Destroy(teks2);
            GameOver();
        }
    }

    public void AddPlayer3Score(int decrement)
    {
        player3Score -= decrement;

        if (player3Score <= maxScore)
        {
            Destroy(paddle3);
            Destroy(teks3);
            GameOver();
        }
    }

    public void AddPlayer4Score(int decrement)
    {
        player4Score -= decrement;

        if (player4Score <= maxScore)
        {
            Destroy(paddle4);
            Destroy(teks4);
            GameOver();
        }
    }

    public void GameOver()
    {
        //SceneManager.LoadScene("MainMenu");
    }
}
