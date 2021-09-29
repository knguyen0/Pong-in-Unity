using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _playerScore;
    private int _computerScore;
    public Ball ball;
    public Text playerScoreText;
    public Text computerScoreText;
    public Paddle playerPaddle;
    public Paddle ComputerPaddle;

    public void PlayerScores()
    {
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();
        ResetRound();
    }

    public void ComputerScores()
    {
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();
        ResetRound();

    }

    private void ResetRound()
    {
        this.playerPaddle.ResetPosition();
        this.ComputerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
}
