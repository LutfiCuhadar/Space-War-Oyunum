using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerInGame : MonoBehaviour
{
    public GameObject inGameScreen, pauseScreen;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PauseButton()
    {
        Time.timeScale = 0;
        inGameScreen.SetActive(false);
        pauseScreen.SetActive(true);
    }

    public void PlayButton()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
        inGameScreen.SetActive(true);
    }

    public void RePlayButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
        DataManager.Instance.enemyKilled = 0;
    }

    public void HomeButton()
    {
        Time.timeScale = 1;
        DataManager.Instance.SaveData();
        SceneManager.LoadScene(0);
    }


}
