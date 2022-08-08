using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public GameObject questionNumber = null; // 問題番号
    public GameObject questionStatement = null; // 問題文
    public GameObject element1 = null; // 解答1
    public GameObject element2 = null; // 解答2
    public GameObject element3 = null; // 解答3
    public GameObject correctAnswer = null; //正解
    public GameObject answerStatement = null; //解説文

    public GameObject score_object = null; // Textオブジェクト

    private CSVReader csvReader;

    private List<string[]> quizDatas = null;


    // Start is called before the first frame update
    void Start()
    {
        csvReader = GameObject.Find("CSVManager").GetComponent<CSVReader>();
        quizDatas = csvReader.ReadCSV();

        Debug.Log(quizDatas[0][0]);
        Debug.Log(quizDatas[0][1]);
        Debug.Log(quizDatas[0][2]);

        Text score_text = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = "000000";

        //UnityEngine.Debug.Log(quizDatas[0][0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 正解ボタンをタップ
    public void PushElementButtonCorrect()
    {
        
    }

    // 不正解ボタンをタップ
    public void PushElementButtonUncorrect()
    {
        
    }

}
