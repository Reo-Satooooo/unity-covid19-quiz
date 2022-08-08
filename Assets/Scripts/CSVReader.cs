using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
public class CSVReader : MonoBehaviour
{

    TextAsset csvFile; // CSVファイル
    private static List<string[]> csvDatas = new List<string[]>(); // CSVの中身を入れるリスト;      

    //クイズデータを2次元配列にして返す
    public List<string[]> ReadCSV()
    {
        //クイズデータを読み込む
        csvFile = Resources.Load("quizData") as TextAsset; // Resouces下のCSV読み込み
        StringReader reader = new StringReader(csvFile.text);
        while (reader.Peek() != -1) // reader.Peaekが-1になるまで
        {
            string line = reader.ReadLine(); // 一行ずつ読み込み
            csvDatas.Add(line.Split(',')); // , 区切りでリストに追加
        }

        return csvDatas;
    }
}
