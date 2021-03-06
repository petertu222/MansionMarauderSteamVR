﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    int seconds = 0;
    int minutes = 3;
    int fixedFrames = 60;

    public int playerScore = 0;

    [SerializeField] Text timer;
    [SerializeField] Text score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log(playerScore);
        decrementTime();
        timer.text = "Time: " + minutes + ": " + seconds;
        score.text = "Score: " + playerScore;
    }

    void decrementTime()
    {
        fixedFrames--;
        if(fixedFrames <= 0)
        {
            seconds--;
            fixedFrames = 60;
        }
        if (seconds <= 0)
        {
            minutes--;
            seconds = 59;
        }
        if(minutes < 0)
        {
            Scores.currentScore = playerScore;
            Scores.endGame = true;
            //update highscores
            SceneManager.LoadScene("MainMenu");
        }
    }
}
