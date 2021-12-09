//written by sam sunnarborg
//11-25-21

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunningScore : MonoBehaviour
{
    public static RunningScore instance;
    
    //public variables to hold the score value and the text to show
    public Text scoreText;
    public Text highScoreText;
    public bool gameActive = false;

    //initialize both at variables = to zero
    public int score = 0;
    public int highScore = 0;

    //public variables for time, time text
    public float currentTime;

    //multiplier that we can change to decide how many points per unit time
    public float multiplier;

    //we can reference in other scripts
    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        
        //when game starts the timer starts as well.
        gameActive = true;
        //reset timer
        currentTime = 0;
        highScore = PlayerPrefs.GetInt("highscore", 0);


        //set the score to the string score that is 0 to start EACH round
        scoreText.text = score.ToString() + " POINTS"; 
        highScoreText.text = "HIGHSCORE: " + highScore.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        //advance the timer and change the text
        if(gameActive == true)
        { 
            currentTime = currentTime + Time.deltaTime;
        }
        //the score variable is equal to the time multiplied by multiplier
        score = Mathf.RoundToInt(currentTime * multiplier);
        //display
        scoreText.text = score.ToString() + " POINTS";
        highScoreText.text = "HIGHSCORE: " + highScore.ToString();


        //set highscore if running score is greater than saved value
        if (score > highScore)
        {
            PlayerPrefs.SetInt("highscore", score);
        }

        //if score is negative, just set to zero
        if(score < 0)
        {
            score = 0;
        }
    }

    //code to get rid of points when hit obstacle
    public void RemovePoints()
    {
        currentTime -= 2;
        scoreText.text = score.ToString() + " POINTS";
    }
    

}
