using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashSceneFadeOut : MonoBehaviour
{
    Image fadeImage;

    private void Awake()
    {
        fadeImage = GetComponent<Image>();
    }

    private void Start()
    {
        StartCoroutine(FadeOut(4.0f));
    }

    private IEnumerator FadeOut(float duration)
    {
        fadeImage.enabled = true;
        Color color = fadeImage.color;
        float elapsedTime = 0f;

        while (fadeImage.color.a < 1f) //알파 값이 0이 될때까지 반복
        {
            elapsedTime += Time.deltaTime;
            color.a = elapsedTime / duration;
            fadeImage.color = color;
            yield return null; //한 프레임동안 대기한다.
        }

        color.a = 1f;
        fadeImage.color = color;
        SceneManager.LoadScene("01.MainMenu");
    }
}
