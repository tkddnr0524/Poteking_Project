using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuFadeIn : MonoBehaviour
{
    Image fadeImage;

    private void Awake()
    {
        fadeImage = GetComponent<Image>();
    }

    private void Start()
    {
        StartCoroutine(FadeIn(4.0f));
    }

    private IEnumerator FadeIn(float duration)
    {
        fadeImage.enabled = true;
        Color color = fadeImage.color;
        float elapsedTime = 0f;

        while (fadeImage.color.a > 0f) //알파 값이 0이 될때까지 반복
        {
            elapsedTime += Time.deltaTime;
            color.a = 1f - (elapsedTime / duration);
            fadeImage.color = color;
            yield return null;
        }

        color.a = 0f;
        fadeImage.color = color;
        fadeImage.enabled = false;
    }
}
