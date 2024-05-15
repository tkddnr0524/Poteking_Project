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
        if(!isPaused && Input.GetKeyDown(KeyCode.Escape))//������°� �ƴϰ� ESC�� ������ ���� 
        {
            Pause();
        }
    }

    public void Resume() //���� �簳 �Լ�
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; // ���� �ð��� �ٽ� ����
        isPaused = false;
    }

    void Pause() //���� ���� �Լ�
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

}
