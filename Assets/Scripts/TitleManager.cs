using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public void PushStartButtonToIntro1()
    {
        Initiate.Fade("IntroFirst", Color.black, 1.0f);
    }
    public void PushNextButtonToIntro2()
    {
        Initiate.Fade("IntroSecond", Color.black, 1.0f);
    }
}
