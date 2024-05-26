using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject warningUI;

    public bool isPaused = false;

    void Start()
    {
        pauseMenuUI.SetActive(false);
        warningUI.SetActive(false);
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

    public void LoadWarningUI() //���� �޴����� ���θ޴� ��ư Ŭ�� �� ȣ�� �� �Լ� / ���â Ȱ��ȭ
    {
        pauseMenuUI.SetActive(false);
        warningUI.SetActive(true);
    }

    public void LoadPauseMenu() //���â���� �ƴϿ並 Ŭ�� ���� �� ȣ�� �� �Լ�
    {
        //�ٽ� ���� �޴��� ���ƿ��� �Լ�
        pauseMenuUI.SetActive(true);
        warningUI.SetActive(false);
    }
    public void LoadMainMenu() //���� �޴����� ���θ޴� ��ư ���� �� ���� ������ �� ȣ�� �� �Լ� / ���� �޴� �ε� ��
    {
        Time.timeScale = 1f; //�� ��ȯ �ϱ� �� ������� ���� �ð��� �ٽ� ����
        SceneManager.LoadScene("01.MainMenu");
    }
}
