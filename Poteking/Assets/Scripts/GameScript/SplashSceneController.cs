using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SplashSceneController : MonoBehaviour
{
    public float onSplashScene = 5f; // ���÷��� ȭ�� ������ �ð�
    
    void Start()
    {
        // ���÷��� ȭ���� onSplashScene��ŭ ������ �� ���� �޴� �� ��ȯ
        Invoke("LoadMainMenuScene", onSplashScene);
    }

    void LoadMainMenuScene()
    {
        SceneManager.LoadScene("01.MainMenu");
    }
}
