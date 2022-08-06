using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushStartButtonToIntro1()
    {
        Initiate.Fade("IntroFirst", Color.black, 1.0f);
        //SceneManager.LoadScene("IntroFirst");
    }
}
