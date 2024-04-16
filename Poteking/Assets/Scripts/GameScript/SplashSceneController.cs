using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashSceneController : MonoBehaviour
{
    private float fadeDuration = 5f; //페이드 아웃에 걸리는 시간
    public AnimationCurve fadeCurve; // 페이드 인/아웃에 사용 할 애니메이션 커브.
    private CanvasGroup canvasGroup;

    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        StartCoroutine(FadeOutAndLoadScene());
    }

    IEnumerator FadeOutAndLoadScene()
    {
        //2초 뒤 페이드 아웃 시작
        yield return new WaitForSeconds(2f);

        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            float alpha = fadeCurve.Evaluate(elapsedTime / fadeDuration);
            canvasGroup.alpha = 1f - alpha; // 페이드 아웃 효과를 위해 투명도를 설정
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("01.MainMenu");
    }
}
