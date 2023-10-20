using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float fltTimeToCompleteQuestion = 30f;
    [SerializeField] float fltTimeToShowCorrectAnswer = 10f;

    public bool bolLoadNextQuestion;
    public float fltFillFraction;
    public bool isAnswerQuestion;

    float fltTimerValue;
    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        fltTimerValue = 0;
    }

    void UpdateTimer()
    {
        fltTimerValue -= Time.deltaTime;

        if(isAnswerQuestion)
        {
            if(fltTimerValue > 0)
            {
                fltFillFraction = fltTimerValue / fltTimeToCompleteQuestion;
            }
            else
            {
                isAnswerQuestion = false;
                fltTimerValue = fltTimeToShowCorrectAnswer;
            }
        }
        else
        {
            if(fltTimerValue > 0)
            {
                fltFillFraction = fltTimerValue / fltTimeToShowCorrectAnswer;
            }
            else
            {
                isAnswerQuestion = true;
                fltTimerValue = fltTimeToCompleteQuestion;
                bolLoadNextQuestion = true;
            }
        }

        Debug.Log(isAnswerQuestion + ": " + fltTimerValue + " = " + fltFillFraction);
    }

}
