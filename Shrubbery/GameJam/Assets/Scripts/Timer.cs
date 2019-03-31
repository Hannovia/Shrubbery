using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text timerText;
    public float timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 60.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        string minutes = ((int)timeLeft / 60).ToString();
        string seconds = (timeLeft % 60).ToString("f0");

        timerText.text = minutes + ":" + seconds;


    }

    public void GameOver()
    {
        

    }
}
