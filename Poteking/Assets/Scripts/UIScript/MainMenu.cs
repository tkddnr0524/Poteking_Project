using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnClickStartBtn()
    {
        SceneManager.LoadScene("02.Chapter_0");
    }

    public void OnClickOptionBtn()
    {
        Debug.Log("�ɼ� â Ȱ��ȭ");
    }

    public void OnClickQuitBtn()
    {
        Application.Quit();
        Debug.Log("���� ������");
    }
}