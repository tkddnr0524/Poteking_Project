using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class MiniGameController : MonoBehaviour
{
    public Slider slider; //슬라이더 UI;
    public int speed;
    public float minPos;
    public float maxPos;
    public RectTransform pass;

    private void Start()
    {
        AreaCheck();
    }
    void AreaCheck()
    {
        slider.value = 0;
        minPos = pass.anchoredPosition.x; //최소값 position.x 
        maxPos = pass.sizeDelta.x + minPos; //   width + posiotion.x
        StartCoroutine(MiniGamePlay());
    }

    IEnumerator MiniGamePlay()
    {
        yield return null;
        while (!(Input.GetKeyDown(KeyCode.Space) || slider.value == slider.maxValue))
        {
            slider.value += Time.deltaTime * speed;
            yield return null;
        }
        if(slider.value >= minPos && slider.value <= maxPos)
        {
            Debug.Log("성공");
        }
    }

}
