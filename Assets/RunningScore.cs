//written by sam sunnarborg
//11-25-21

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunningScore : MonoBehaviour
{
    //public variables to hold the score value and the text to show
    public Text scoreText;
    public Text highScoreText;

    //initialize both at variables = to zero
    int score = 0;
    int highScore = 0;

    //public variables for time, time text
    public float currentTime;
    public Text currentTimeText;


    // Start is called before the first frame update
    void Start()
    {
        //set highscore to saved int?????????
        //highScore = PlayerPref.GetInt("high score", 0);

        
        //set the score to the string score that is 0 to start EACH round
     scoreText.text = score.ToString() + " POINTS"; 
     highScoreText.text = "HIGHSCORE: " + highScore.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        //advance the timer and change the text
        /*
        if (Timer active == true){
            currentTime = currentTime + Time.deltaTime();
            currentTimeText.text = currentTime.ToString();
        }
        */

        //set highscore if running score is greater than saved value
        /*
        if (score > highScore)
        {
            PlayerPref.SetInt("highscore", score);
        }
        */
    }
}
