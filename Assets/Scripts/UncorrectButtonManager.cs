using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UncorrectButtonManager : MonoBehaviour
{
    public int nextQuestionNumber;

    // Start is called before the first frame update
    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            //Popupを表示
            PopupUCManager popupUC = PopupController.Instance.CreatePopupUC();
            //Init(Transform canvas, string textCA, string textCAS)
            popupUC.Init(PopupController.Instance.MainCanvas, "正解：テスト１", "解説：テスト2", nextQuestionNumber);
        });
    }
}
