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

        while (fadeImage.color.a < 1f) //���� ���� 0�� �ɶ����� �ݺ�
        {
            elapsedTime += Time.deltaTime;
            color.a = elapsedTime / duration;
            fadeImage.color = color;
            yield return null; //�� �����ӵ��� ����Ѵ�.
        }

        color.a = 1f;
        fadeImage.color = color;
        SceneManager.LoadScene("01.MainMenu");
    }
}
