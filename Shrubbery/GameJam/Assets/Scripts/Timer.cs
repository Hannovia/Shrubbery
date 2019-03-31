using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public Text timerText;
    private float timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 120.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        string minutes = ((int)timeLeft / 60).ToString();
        string seconds = (timeLeft % 60).ToString("f0");

        timerText.text = minutes + ":" + seconds;

        if(timeLeft < 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene("ScoresScene");
    }
}
