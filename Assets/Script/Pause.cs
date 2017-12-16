using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

    public bool IsPaused;
 
    public GameObject PauseText;
    public GameObject RestartImg;
    public GameObject Img_Home;

    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (IsPaused)
        {
          
            PauseText.SetActive(true);
            Img_Home.SetActive(true);
            RestartImg.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
          
            PauseText.SetActive(false);
            Img_Home.SetActive(false);
            RestartImg.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            IsPaused = !IsPaused;
        }
    }
    public void continueButton()
    {
        IsPaused = !IsPaused;
    }
}