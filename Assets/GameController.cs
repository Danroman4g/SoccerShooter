using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Text ScoreText;
    public Text TimerText;
    public int MatchTime = 120;
    public float StartTime = 0;
    private int Score = 0;
    private bool MatchActive = false;



    // Start is called before the first frame update
    void Start()
    {
        TimerText.text = "Time : " + GetTimeDisplay(MatchTime);
        StartTime = Time.time;
        MatchActive = true;


    }

    public void IncrementScore()
    {
        if (MatchActive)
        {
            Score++;
            ScoreText.text = "Score : " + Score.ToString();

            Debug.Log("GOOOAL");
            Debug.Log("Score is : " + Score.ToString());
        }
    }



    void Update()
    {
        if(Time.time - StartTime < MatchTime)
        {

            float elapsedTime = Time.time - StartTime;

            SetTimeDisplay(MatchTime - elapsedTime);

        }
        else
        {
            SetTimeDisplay(0);
            MatchActive = false;
            ScoreText.color = Color.red;
            TimerText.color = Color.red;

        }

    }
    private void SetTimeDisplay(float TimeDisplay)
    {
        TimerText.text = "Time : " + GetTimeDisplay(TimeDisplay);

    }

    private string GetTimeDisplay(float TimeToShow)
    {
        int SecondsToShow = Mathf.CeilToInt(TimeToShow); 
        int Seconds = SecondsToShow % 60;
        string SecondsDisplay = (Seconds < 10) ? "0" + Seconds.ToString() : Seconds.ToString();
        int Minutes = (SecondsToShow - Seconds) / 60;
        return Minutes.ToString() + ":" + Seconds.ToString();

    }


}
