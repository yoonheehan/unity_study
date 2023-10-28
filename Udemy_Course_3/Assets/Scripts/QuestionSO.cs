using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName ="New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2,6)]
    [SerializeField] string question = "What is the correct syntax for creating a new integer variable with an initial value of 12?";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex = 0;

    public string GetQuestion()
    {
        return question;
    }

    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }

    public string GetAnswer(int index)
    {
        return answers[index];
    }

}
