using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashSceneController : MonoBehaviour
{
    private float splashScreenTime = 4f; //���÷��� ȭ���� ǥ�õ� �ð�
    private float fadeDuration = 3f; //���̵� �ƿ��� �ɸ��� �ð�
    public AnimationCurve fadeCurve; // ���̵� ��/�ƿ��� ��� �� �ִϸ��̼� Ŀ��.
    private CanvasGroup canvasGroup;

    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        StartCoroutine(FadeOutAndLoadScene());
    }

    IEnumerator FadeOutAndLoadScene()
    {
        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            float alpha = fadeCurve.Evaluate(elapsedTime / fadeDuration);
            canvasGroup.alpha = 1f - alpha; // ���̵� �ƿ� ȿ���� ���� ������ ����
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("01.MainMenu");
    }
}
