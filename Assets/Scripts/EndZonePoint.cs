using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndZonePoint : MonoBehaviour
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

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            
            Destroy(other.gameObject);
            IncreaseScore();
        }
    }



}