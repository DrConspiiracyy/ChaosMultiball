using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int score;

    void Start()
    {
        scoreText.text = "Score: " + score; 
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}