using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject soundPanel;

    public bool isPaused = false;

    void Start()
    {
        pauseMenuUI.SetActive(false);
    }
    void Update()
    {
        if (isPaused && Input.GetKeyDown(KeyCode.Escape)) //퍼즈 상태고 ESC키를 누르면 
        {
            Resume(); //게임 재개
        }
        else if(!isPaused && Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();//게임 정지
        }
    }

    public void Resume() //게임 재개 함수
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; // 게임 시간을 다시 시작
        isPaused = false;
    }

    void Pause() //게임 정지 함수
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; // 게임 시간을 멈춤
        isPaused = true;
    }

    public void QuitGame()
    {
        Debug.Log("게임 종료");
        Application.Quit();
    }

    public void OpenSettings()
    {
        soundPanel.SetActive(true);
    }

    public void QuitSettingMenu()
    {
        soundPanel.SetActive(false);
    }
}
