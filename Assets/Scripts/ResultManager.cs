using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResultManager : MonoBehaviour
{
    private const int qNumberMax = 5;
    private int[] scoreArray = new int[qNumberMax];
    private int score = 0;
    private string textScore = null;
    private string feedBackComment = null;

    public GameObject textResult = null; // 問題番号
    public GameObject textResultComment = null; // 問題文

    private void Start()
    {
        // 解答集計
        for(int qNumber = 1; qNumber <= qNumberMax; qNumber++)
        {
            int answerFlag = PlayerPrefs.GetInt(qNumber.ToString());

            if (answerFlag == 1)
            {
                score++;
            }
            scoreArray.SetValue(qNumber,answerFlag);
        }

        // フィードバックコメントの取得
        if(score == qNumberMax)
        {
            feedBackComment = "よくできました！引き続き感染対策を心がけてください！";
        }
        else if(score >= qNumberMax * 0.6){
            feedBackComment = "感染対策に見落としがあるかもしれません。正しい知識を学び、感染対策を心がけてください！";
        }
        else
        {
            feedBackComment = "感染対策ができていないかもしれません。正しい知識を学び、感染対策を心がけてください！";
        }

        textScore = "正解数 " + score + "/" + qNumberMax;

        Text tResult = textResult.GetComponent<Text>();
        tResult.text = textScore;

        Text tResultComment = textResultComment.GetComponent<Text>();
        tResultComment.text = feedBackComment;

    }

    public void PushGoTitleButton()
    {
        Initiate.Fade("TitleScene", Color.black, 1.0f);
    }

    public void PushTwiterButton()
    {
        // 得点を取得

        naichilab.UnityRoomTweet.Tweet("unity-covid19-quiz",textScore + " " + feedBackComment, "COVID19対策クイズ");
    }
}
