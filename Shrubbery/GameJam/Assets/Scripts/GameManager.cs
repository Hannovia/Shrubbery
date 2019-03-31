using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   

    //Kanske ska vara gameobject istället för player
    [SerializeField] private GameObject[] players;

    [SerializeField] private Text[] scoreTexts;

    public GameObject gameOverPanel;
    public Text gameOverText;
    // Start is called before the first frame update

    public GameObject timer;

    void Start()
    {
        gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        scoreTexts[0].text = players[0].GetComponent<Player>().GetNumberOfCakes().ToString();
        scoreTexts[1].text = players[1].GetComponent<Player>().GetNumberOfCakes().ToString();
        scoreTexts[2].text = players[2].GetComponent<Player>().GetNumberOfCakes().ToString();
        scoreTexts[3].text = players[3].GetComponent<Player>().GetNumberOfCakes().ToString();

        if (timer.GetComponent<Timer>().timeLeft < 0)
        {
            GameOver();
        }

        Debug.Log(players[0].GetComponent<Player>().GetNumberOfCakes());
        Debug.Log(players[1].GetComponent<Player>().GetNumberOfCakes());
        Debug.Log(players[2].GetComponent<Player>().GetNumberOfCakes());
        Debug.Log(players[3].GetComponent<Player>().GetNumberOfCakes());

    }

    public void GameOver()
    {

        GameObject currentWinner = null;

        int mostCakes = -1;

        for(int currentPlayer = 0; currentPlayer < players.Length; currentPlayer++)
        {
            if(players[currentPlayer].GetComponent<Player>().GetNumberOfCakes() > mostCakes)
            {
                currentWinner = players[currentPlayer];
                mostCakes = players[currentPlayer].GetComponent<Player>().GetNumberOfCakes();
            }
        }
        gameOverPanel.SetActive(true);
        gameOverText.text = "Winner: " + currentWinner.ToString();

   
    }
}
