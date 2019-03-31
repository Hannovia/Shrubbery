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
    // Start is called before the first frame update

    public GameObject timer;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        scoreTexts[0].text = players[0].GetComponent<Player>().GetNumberOfCakes1().ToString();
        scoreTexts[1].text = players[1].GetComponent<Player>().GetNumberOfCake2().ToString();
        scoreTexts[2].text = players[2].GetComponent<Player>().GetNumberOfCake3().ToString();
        scoreTexts[3].text = players[3].GetComponent<Player>().GetNumberOfCake4().ToString();

        if (timer.GetComponent<Timer>().timeLeft < 0)
        {
            GameOver();
        }

     /*   Debug.Log(players[0].GetComponent<Player>().GetNumberOfCakes1());
        Debug.Log(players[1].GetComponent<Player>().GetNumberOfCake2());
        Debug.Log(players[2].GetComponent<Player>().GetNumberOfCake3());
        Debug.Log(players[3].GetComponent<Player>().GetNumberOfCake4());
*/
    }

    public void GameOver()
    {
        

        int[] cakes = {players[0].GetComponent<Player>().GetNumberOfCakes1(), players[1].GetComponent<Player>().GetNumberOfCake2(),
        players[2].GetComponent<Player>().GetNumberOfCake3(), players[3].GetComponent<Player>().GetNumberOfCake3()};

        Array.Sort(cakes);

        Debug.Log("Player " + cakes[0] + " won!");

        SceneManager.LoadScene("ScoresScene");
    }
}
