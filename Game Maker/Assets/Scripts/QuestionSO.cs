using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject 
{
    [TextArea(2,6)]
    [SerializeField] string strQuestion = "Enter new question text here";
    [SerializeField] string[] strAnswers = new string[4];
    [SerializeField] int intCorrectAnswerIndex;

    public string StrGetQuestion()
    {
        return strQuestion;
    }

    public string StrGetAnswer(int intIndex)
    {
        return strAnswers[intIndex];
    }

    public int IntGetCorrectAnswerIndex()
    {
        return intCorrectAnswerIndex;
    }
}
