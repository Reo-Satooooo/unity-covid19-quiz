using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupController : MonoBehaviour
{
    public static PopupController Instance;

    public Transform MainCanvas;

    private void Start()
    {
        if(Instance != null)
        {
            GameObject.Destroy(this.gameObject);
            return;
        }

        Instance = this;
    }

    // 正解のPopupを生成
    public PopupCManager CreatePopupC()
    {
        GameObject popupCGO = Instantiate(Resources.Load("Popup/PopupCorrect") as GameObject);
        return popupCGO.GetComponent<PopupCManager>();
    }

    // 不正解のPopupを生成
    public PopupUCManager CreatePopupUC()
    {
        GameObject popupUCGO = Instantiate(Resources.Load("Popup/PopupUncorrect") as GameObject);
        return popupUCGO.GetComponent<PopupUCManager>();
    }

    // 最終問題の場合の正解のPopupを生成
    public PopupCManager CreatePopupLQC()
    {
        GameObject popupCGO = Instantiate(Resources.Load("Popup/PopupLQCorrect") as GameObject);
        return popupCGO.GetComponent<PopupCManager>();
    }

    // 最終問題の場合の不正解のPopupを生成
    public PopupUCManager CreatePopupLQUC()
    {
        GameObject popupUCGO = Instantiate(Resources.Load("Popup/PopupLQUncorrect") as GameObject);
        return popupUCGO.GetComponent<PopupUCManager>();
    }

}
