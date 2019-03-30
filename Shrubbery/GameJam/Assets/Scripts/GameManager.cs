using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float timer;

    //Kanske ska vara gameobject istället för player
    [SerializeField] private GameObject[] players;
    [SerializeField] private GameObject[] spawnPoints;
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
    }

    public void GameOver()
    {
        int mostCakes = -1;
        int winner = -1;
        for (int currentPlayer = 0; currentPlayer < players.Length; currentPlayer++)
        {
            if (players[currentPlayer].GetComponent<Player>().GetNumberOfCakes1() > mostCakes)
            {
                mostCakes = players[currentPlayer].GetComponent<Player>().GetNumberOfCakes1();
                winner = currentPlayer;
            }
        }

        Debug.Log("Player " + winner + " won!");

    }
}
