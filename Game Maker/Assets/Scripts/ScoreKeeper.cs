using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int intCorrectAnswer = 0;
    int intQuestionsSeen = 0;

    public int GetCorrectAnswers()
    {
        return intCorrectAnswer;
    }

    public void IncrementCorrectAnswers()
    {
        intCorrectAnswer++;
    }

    public int GetQuestionSeen()
    {
        return intQuestionsSeen;
    }

    public void IncrementQuestionsSeen()
    {
        intQuestionsSeen++;
    }

    public int CalculateScore()
    {
        return Mathf.RoundToInt(intCorrectAnswer / (float)intQuestionsSeen * 100);
    }
}
