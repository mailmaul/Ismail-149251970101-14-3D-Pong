using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    public Text skorPlayer1;
    public Text skorPlayer2;
    public Text skorPlayer3;
    public Text skorPlayer4;

    public ScoreManager manager;

    private void Update()
    {
        skorPlayer1.text = manager.player1Score.ToString();
        skorPlayer2.text = manager.player2Score.ToString();
        skorPlayer3.text = manager.player3Score.ToString();
        skorPlayer4.text = manager.player4Score.ToString();
    }
}
