using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.Match;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float timerValue = 60;
    public float timerMins = 5;

    public float timeRemaining;
    public bool timerIsRunning = false;

    public GameObject icon1;
    public GameObject icon2;
    public GameObject icon3;
    public GameObject icon4;


    public Text timeText;


    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = timerMins * timerValue;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if(timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else if(icon1.activeInHierarchy && icon1.GetComponent<UIVariables>().completed == true && icon2.activeInHierarchy && icon2.GetComponent<UIVariables>().completed == true)
            {
                if (icon3.activeInHierarchy)
                {
                    if (icon3.GetComponent<UIVariables>().completed == true)
                    {
                        if (icon4.activeInHierarchy)
                        {
                            if (icon4.GetComponent<UIVariables>().completed == true)
                            {
                                timerIsRunning = false;
                                Debug.Log("YOU WIN");
                            }
                        }
                        else
                        {
                            timerIsRunning = false;
                            Debug.Log("YOU WIN");
                        }
                    }
                }
                else
                {
                    timerIsRunning = false;
                    Debug.Log("YOU WIN");
                }
            }
            else
            {
                Debug.Log("Game Over - Timer Ran Out");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
