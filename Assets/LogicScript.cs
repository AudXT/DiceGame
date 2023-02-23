using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public int rollsLeft;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI rollsText;

    public void AddScore(int value)
    {
        playerScore += value;
        scoreText.text = playerScore.ToString();
    }

    public void UseRoll()
    {
        rollsLeft -= 1;
        rollsText.text = rollsLeft.ToString();
    }
}
