using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SplashSceneController : MonoBehaviour
{
    public float onSplashScene = 5f; // 스플래시 화면 보여줄 시간
    
    void Start()
    {
        // 스플래시 화면을 onSplashScene만큼 보여준 후 메인 메뉴 씬 전환
        Invoke("LoadMainMenuScene", onSplashScene);
    }

    void LoadMainMenuScene()
    {
        SceneManager.LoadScene("01.MainMenu");
    }
}
