using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;


    [Header("Player 1")]
    public GameObject Paddle1;
    public GameObject P1Goal;

    [Header("Player 2")]
    public GameObject Paddle2;
    public GameObject P2Goal;


    [Header("Score UI")]
    public GameObject Player1Points;
    public GameObject Player2Points;

    private int p1Score;
    private int p2Score;

    [Header("Win Screen")]
    public GameObject P1Wins;
    public GameObject P2Wins;


    public void Player1Scored()
    {
        ++p1Score;
        Player1Points.GetComponent<TextMeshProUGUI>().text = p1Score.ToString();
        if(p1Score < 10)
        {
            NextSet();
        }
        else
        {
            P1Wins.GetComponent<TextMeshProUGUI>().text = "Player 1 Wins!!!";
        }
    }
    public void Player2Scored()
    {
        ++p2Score;
        Player2Points.GetComponent<TextMeshProUGUI>().text = p2Score.ToString();
        if (p2Score < 10)
        {
            NextSet();
        }
        else
        {
            P2Wins.GetComponent<TextMeshProUGUI>().text = "Player 2 Wins!!!";
        }

    }

    private void NextSet()
    {
        ball.GetComponent<BallMove>().Reset();
    }

}
