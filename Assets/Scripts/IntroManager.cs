using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class IntroManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushNextButtonToIntro2()
    {
        //UnityEngine.Debug.Log("テスト");
        Initiate.Fade("IntroSecond", Color.black, 1.0f);
        //SceneManager.LoadScene("IntroSecond");
    }

    //public void PushNextButtonToQuiz()
    //{
    //    SceneManager.LoadScene("");
    //}
}
