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
    public Text menang1;
    public Text menang2;
    public Text menang3;
    public Text menang4;
    public GameObject replay;
    public GameObject menu;
    private bool kalah1 = false;
    private bool kalah2 = false;
    private bool kalah3 = false;
    private bool kalah4 = false;

    public int maxScore;


    private void Update() {
        if (kalah1 == true && kalah2 == true && kalah3 == true)
        {
            Pause();
            menang4.enabled = true;
            replay.SetActive(true);
            menu.SetActive(true);
        } 
        else if (kalah4 == true && kalah2 == true && kalah3 == true)
        {
            Pause();
            menang1.enabled = true;
            replay.SetActive(true);
            menu.SetActive(true);
        } 
        else if (kalah1 == true && kalah4 == true && kalah3 == true)
        {
            Pause();
            menang2.enabled = true;
            replay.SetActive(true);
            menu.SetActive(true);
        } 
        else if (kalah1 == true && kalah2 == true && kalah4 == true)
        {
            Pause();
            menang3.enabled = true;
            replay.SetActive(true);
            menu.SetActive(true);
        } 
        else
        {
            return;
        }
    }
    
    public void AddPlayer1Score(int decrement)
    {
        player1Score -= decrement;

        if (player1Score <= maxScore)
        {
            paddle1.SetActive(false);
            teks1.enabled = false;
            kalah1 = true;
            menang1.enabled = false;
        }
    }

    public void AddPlayer2Score(int decrement)
    {
        player2Score -= decrement;

        if (player2Score <= maxScore)
        {
            paddle2.SetActive(false);
            teks2.enabled = false;
            kalah2 = true;
            menang2.enabled = false;
        }
    }

    public void AddPlayer3Score(int decrement)
    {
        player3Score -= decrement;

        if (player3Score <= maxScore)
        {
            paddle3.SetActive(false);
            teks3.enabled = false;
            kalah3 = true;
            menang3.enabled = false;
        }
    }

    public void AddPlayer4Score(int decrement)
    {
        player4Score -= decrement;

        if (player4Score <= maxScore)
        {
            paddle4.SetActive(false);
            teks4.enabled = false;
            kalah4 = true;
            menang4.enabled = false;
        }
    }

    public void Pause()
    {
       Time.timeScale = 0f;
    }

    public void ResetGame()
    {
        Time.timeScale = 1f;

        replay.SetActive(false);

        player1Score = 10;
        player2Score = 10;
        player3Score = 10;
        player4Score = 10;

        paddle1.SetActive(true);
        paddle2.SetActive(true);
        paddle3.SetActive(true);
        paddle4.SetActive(true);

        teks1.enabled = true;
        teks2.enabled = true;
        teks3.enabled = true;
        teks4.enabled = true;
    }

    public void mainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
