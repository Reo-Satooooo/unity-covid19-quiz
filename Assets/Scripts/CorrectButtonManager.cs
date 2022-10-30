using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorrectButtonManager : MonoBehaviour
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
            quizManager.SaveAnswer(questionNumber,1);
            //Popupを表示

            // 最終問題の場合
            if (nextQuestionNumber == 6)
            {
                PopupCManager popupLQC = PopupController.Instance.CreatePopupLQC();
                //Init(Transform canvas, string textCA, string textCAS)
                popupLQC.Init(PopupController.Instance.MainCanvas, correctAnswerData[0], "【解説】" + correctAnswerData[1], nextQuestionNumber);
            }
            // 最終問題以外の場合
            else
            {
                PopupCManager popupC = PopupController.Instance.CreatePopupC();
                //Init(Transform canvas, string textCA, string textCAS)
                popupC.Init(PopupController.Instance.MainCanvas, correctAnswerData[0], "【解説】" + correctAnswerData[1], nextQuestionNumber);
            }
        });
    }
}
