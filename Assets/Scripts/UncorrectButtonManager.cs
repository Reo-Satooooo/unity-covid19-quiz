using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UncorrectButtonManager : MonoBehaviour
{
    public int nextQuestionNumber;
    private int questionNumber;
    private QuizManager quizManager;
    private string[] correctAnswerData;

    // Start is called before the first frame update
    void Start()
    {
        //クイズデータを取得
        quizManager = GameObject.Find("QuizManager").GetComponent<QuizManager>();
        correctAnswerData = quizManager.GetCorrectAnswerData();

        Button button = GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            questionNumber = quizManager.GetQuestionNumber();
            quizManager.SaveAnswer(questionNumber, 0);

            //Popupを表示
            PopupUCManager popupUC = PopupController.Instance.CreatePopupUC();
            //Init(Transform canvas, string textCA, string textCAS)
            popupUC.Init(PopupController.Instance.MainCanvas, correctAnswerData[0], "【解説】" + correctAnswerData[1], nextQuestionNumber);
        });
    }
}
