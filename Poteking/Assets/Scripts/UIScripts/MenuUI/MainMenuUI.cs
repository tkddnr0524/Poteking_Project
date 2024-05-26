using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public void OnClickStartBtn()
    {
        SceneManager.LoadScene("02.Chapter_0");
    }

    public void OnClickQuitBtn()
    {
        Application.Quit();
        Debug.Log("게임 나가기");
    }
}



