using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    float timer;

    //Kanske ska vara gameobject istället för player
    [SerializeField] private GameObject[] players;
    [SerializeField] private GameObject[] spawnPoints;
    [SerializeField] private GameObject[] scoreTexts;
    // Start is called before the first frame update
    void Start()
    {
        for (int currentPlayer = 0; currentPlayer < players.Length; currentPlayer++)
        {
            Instantiate(players[currentPlayer], spawnPoints[currentPlayer].transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.deltaTime;
        //Debug.Log("Seconds: " + timer%60);
        if (timer >= 3)
        {
            GameOver();
        }

        
        Debug.Log(players[0].GetComponent<Player>().GetNumberOfCakes1());
        Debug.Log(players[1].GetComponent<Player>().GetNumberOfCake2());
        Debug.Log(players[2].GetComponent<Player>().GetNumberOfCake3());
        Debug.Log(players[0].GetComponent<Player>().GetNumberOfCake4());

    }

    public void GameOver()
    {
        

        int[] cakes = {players[0].GetComponent<Player>().GetNumberOfCakes1(), players[1].GetComponent<Player>().GetNumberOfCake2(),
        players[2].GetComponent<Player>().GetNumberOfCake3(), players[3].GetComponent<Player>().GetNumberOfCake3()};

        Array.Sort(cakes);

        Debug.Log("Player " + cakes[0] + " won!");

    }
}
