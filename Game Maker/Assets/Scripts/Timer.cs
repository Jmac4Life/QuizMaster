using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float fltTimeToCompleteQuestion = 30f;
    [SerializeField] float fltTimeToShowCorrectAnswer = 10f;

    public bool isAnswerQuestion = false;

    float fltTimerValue;
    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        fltTimerValue -= Time.deltaTime;

        if(isAnswerQuestion)
        {
            if(fltTimerValue <= 0)
            {
                isAnswerQuestion = false;
                fltTimerValue = fltTimeToShowCorrectAnswer;
            }
        }
        else
        {
            if(fltTimerValue <= 0)
            {
                isAnswerQuestion = true;
                fltTimerValue = fltTimeToCompleteQuestion;
            }
        }

        Debug.Log(fltTimerValue);
    }

}
