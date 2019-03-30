using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlay : MonoBehaviour
{

    public static bool AButtonPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("AButton"))
        {
            SceneManager.LoadScene("Main");
        }
    }

    void Exit()
    {
        SceneManager.LoadScene("Main Menu");
    }

    
}
