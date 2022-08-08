using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public int questionNumber;

    public GameObject textQuestionNumber = null; // 問題番号
    public GameObject textQuestionStatement = null; // 問題文
    public GameObject buttonElement1 = null; // 解答1
    public GameObject buttonElement2 = null; // 解答2
    public GameObject buttonElement3 = null; // 解答3
    public GameObject textCorrectAnswer = null; //正解
    public GameObject textCommentStatement = null; //解説文

    public GameObject score_object = null; // Textオブジェクト

    private CSVReader csvReader;

    private List<string[]> quizDatas = null;


    // Start is called before the first frame update
    void Start()
    {
        csvReader = GameObject.Find("CSVManager").GetComponent<CSVReader>();
        quizDatas = csvReader.ReadCSV();

        //クイズデータ
        string questionStatement = quizDatas[questionNumber][0];
        string questionElement1 = quizDatas[questionNumber][1];
        string questionElement2 = quizDatas[questionNumber][2];
        string questionElement3 = quizDatas[questionNumber][3];
        string correctAnswer = quizDatas[questionNumber][4];
        string commentStatement = quizDatas[questionNumber][5];

        Text qNumber = textQuestionNumber.GetComponent<Text>();
        qNumber.text = "問題 "+questionNumber;

        Text qStatement = textQuestionStatement.GetComponent<Text>();
        qStatement.text = questionStatement;

        Text qElement1 = buttonElement1.GetComponent<Text>();
        qElement1.text = questionElement1;

        Text qElement2 = buttonElement2.GetComponent<Text>();
        qElement2.text = questionElement2;

        Text qElement3 = buttonElement3.GetComponent<Text>();
        qElement3.text = questionElement3;
    }

    public string[] GetCorrectAnswerData()
    {
        csvReader = GameObject.Find("CSVManager").GetComponent<CSVReader>();
        quizDatas = csvReader.ReadCSV();

        string correctAnswer = quizDatas[questionNumber][4];
        string commentStatement = quizDatas[questionNumber][5];

        string[] correctAnswerData = new string[] {correctAnswer, commentStatement};

        //Debug.Log(correctAnswerData[0]);
        //Debug.Log(correctAnswerData[1]);

        return correctAnswerData;
    }
}
