using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultManager : MonoBehaviour
{
    public void PushGoTitleButton()
    {
        Initiate.Fade("TitleScene", Color.black, 1.0f);
    }

    public void PushTwiterButton()
    {
        // 得点を取得
        naichilab.UnityRoomTweet.Tweet("YOUR-GAMEID", "ツイートサンプルです。", "#COVID19対策模試");
    }
}
