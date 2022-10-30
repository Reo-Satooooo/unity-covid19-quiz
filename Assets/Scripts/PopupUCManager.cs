using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupUCManager : MonoBehaviour
{
    public int nextQuestionNumber;

    [SerializeField] Button buttonNQ;
    [SerializeField] Text textUncorrectAnswer;
    [SerializeField] Text textUncorrectAnswerStatement;

    public void Init(Transform canvas, string textUCA, string textUCAS, int nextQN)
    {
        textUncorrectAnswer.text = textUCA;
        textUncorrectAnswerStatement.text = textUCAS;
        nextQuestionNumber = nextQN;

        transform.SetParent(canvas);
        transform.localScale = Vector3.one;

        buttonNQ.onClick.AddListener(() =>
        {
            // 最終問題の場合
            if (nextQuestionNumber == 6)
            {
                Initiate.Fade("ResultViewScene", Color.black, 1.0f);                
            }
            // 最終問題以外の場合
            else
            {
                Initiate.Fade("QuizScene" + nextQuestionNumber, Color.black, 2.0f);
            }
        });

    }
}
