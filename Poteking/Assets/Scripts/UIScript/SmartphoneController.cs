using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class SmartphoneController : MonoBehaviour
{    
    public GameObject smartphoneScreen; // 스마트폰 화면을 나타내는 GameObject
    bool isScreenOn = false; //스마트폰 화면 상태
    void Start()
    {
        // 시작할 때 화면을 꺼놓는 상태
        smartphoneScreen.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            ToggleSmartphoneScreen();
        }
    }

    // 스마트폰 화면을 켜거나 끄는 함수
    public void ToggleSmartphoneScreen()
    {
        //현재 스크린의 반대 상태를 스크린 상태에 대입 -> 현재 화면 상태의 반대로 설정
        isScreenOn = !isScreenOn;

        //화면의 상태에 따라 화면을 켜거나 끄기.
        smartphoneScreen.SetActive(isScreenOn);
    }
}
