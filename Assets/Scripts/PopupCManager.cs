using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupCManager : MonoBehaviour
{
    public int nextQuestionNumber;

    [SerializeField] Button buttonNQ;
    [SerializeField] Text textCorrectAnswer;
    [SerializeField] Text textCorrectAnswerStatement;

    public void Init(Transform canvas, string textCA, string textCAS, int nextQN)
    {
        textCorrectAnswer.text = textCA;
        textCorrectAnswerStatement.text = textCAS;
        nextQuestionNumber = nextQN;

        transform.SetParent(canvas);
        transform.localScale = Vector3.one;

        buttonNQ.onClick.AddListener(() =>
        {
            if (nextQuestionNumber == 6)
            {
                Initiate.Fade("ResultViewScene", Color.black, 1.0f);                
            }
            else
            {
                Initiate.Fade("QuizScene" + nextQuestionNumber, Color.black, 2.0f);
            }
        });

    }

}
