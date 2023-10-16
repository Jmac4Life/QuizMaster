using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionSO question;
    [SerializeField] GameObject[] answerButtons;
    int intCorrectAnswerIndex;
    [SerializeField] Sprite defaultAnswerSprite;
    [SerializeField] Sprite correctAnswerSprite;
    // Start is called before the first frame update
    void Start()
    {
        questionText.text = question.StrGetQuestion();

        for(int i = 0; i < answerButtons.Length; i++)
        {
        TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
        buttonText.text = question.StrGetAnswer(i);
        }

    }

    public void OnAnswerSelected(int intIndex)
    {

        Image buttonImage;   

        if(intIndex == question.IntGetCorrectAnswerIndex())
        {
            questionText.text = "Correct!";
            buttonImage = answerButtons[intIndex].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSprite;
        }
        else
        {
            intCorrectAnswerIndex = question.IntGetCorrectAnswerIndex();
            string strCorrectAnswer = question.StrGetAnswer(intCorrectAnswerIndex);
            questionText.text = "Sorry, the correct answer was;\n" + strCorrectAnswer;
            buttonImage = answerButtons[intCorrectAnswerIndex].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSprite;
        }
    }

}
