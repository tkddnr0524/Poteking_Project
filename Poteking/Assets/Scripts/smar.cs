using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class smar : MonoBehaviour, IPointerClickHandler
{
    
    public GameObject firstUI;
    public GameObject secondUI;


    public void OnPointerClick(PointerEventData eventData)
    {
        // 클릭된 버튼이 어느 UI 이미지에 속하는지 확인합니다.
        if (eventData.pointerPress.transform.IsChildOf(transform)) // 클릭된 버튼이 현재 UI 이미지 안에 있는지 확인합니다.
        {
            // 클릭된 버튼이 첫 번째 UI 이미지 안에 있을 경우
            if (firstUI.activeSelf)
            {
                // 두 번째 UI를 활성화하고 첫 번째 UI를 비활성화합니다.
                secondUI.SetActive(true);
                firstUI.SetActive(false);
            }
            else
            {
                // 첫 번째 UI를 활성화하고 두 번째 UI를 비활성화합니다.
                firstUI.SetActive(true);
                secondUI.SetActive(false);
            }
        }
    }
}
