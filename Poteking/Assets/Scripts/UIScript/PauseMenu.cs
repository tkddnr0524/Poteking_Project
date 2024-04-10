using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject soundPanel;

    private bool isPaused = false;

    void Start()
    {
        pauseMenuUI.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                Resume();
            else
                Pause();
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; // ���� �ð��� �ٽ� ����
        isPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; // ���� �ð��� ����
        isPaused = true;
    }

    public void QuitGame()
    {
        Debug.Log("���� ����");
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
