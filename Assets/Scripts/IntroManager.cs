using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class IntroManager : MonoBehaviour
{
    public void PushNextButtonToIntro2()
    {
        Initiate.Fade("IntroSecond", Color.black, 1.0f);
    }

    public void PushNextButtonToQuiz()
    {
        Initiate.Fade("QuizScene1", Color.black, 1.0f);
    }
}
