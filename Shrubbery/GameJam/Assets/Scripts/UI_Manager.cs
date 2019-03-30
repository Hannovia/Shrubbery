using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour, IPointerEnterHandler
{

    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    public UnityEngine.UI.Button resumeButton;

    private void Start()
    {
        resumeButton.OnSelect(null);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("StartButton"))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
                resumeButton.OnSelect(null);
            }
        }

      

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        resumeButton.OnSelect(null);
        Debug.Log("y u no work");
      

    }



    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");

        
    }

  
}

