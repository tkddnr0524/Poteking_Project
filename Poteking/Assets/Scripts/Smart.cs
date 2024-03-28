using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Smart : MonoBehaviour
{
    public GameObject firstUI;
    public GameObject secondUI;

    // 첫 번째 UI를 활성화하고 두 번째 UI를 비활성화하는 함수
    public void ShowFirstUI()
    {
        firstUI.SetActive(true);
        secondUI.SetActive(false);
    }

    // 두 번째 UI를 활성화하고 첫 번째 UI를 비활성화하는 함수
    public void ShowSecondUI()
    {
        firstUI.SetActive(false);
        secondUI.SetActive(true);
    }









     /*public GameObject uiImage1; // 첫 번째 UI 이미지 GameObject
    public GameObject uiImage2; // 두 번째 UI 이미지 GameObject

    private bool isImage1Active = true; // 현재 활성화된 이미지 상태를 저장하는 변수

    // 첫 번째 이미지 클릭 시 호출되는 함수
    public void OnImage1Click()
    {
        if (!isImage1Active)
        {
            uiImage1.SetActive(true); // 첫 번째 이미지를 활성화합니다.
            uiImage2.SetActive(false); // 두 번째 이미지를 비활성화합니다.
            isImage1Active = true;
        }
    }

    // 두 번째 이미지 클릭 시 호출되는 함수
    public void OnImage2Click()
    {
        if (isImage1Active)
        {
            uiImage1.SetActive(false); // 첫 번째 이미지를 비활성화합니다.
            uiImage2.SetActive(true); // 두 번째 이미지를 활성화합니다.
            isImage1Active = false;
        }
    }*/
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    /*public GameObject mainMenuPanel; // 메인 메뉴 패널
    public GameObject settingsPanel; // 설정 패널

    // 메인 메뉴 버튼 클릭 시 호출되는 함수
    public void OnMainMenuButtonClick()
    {
        // 메인 메뉴 패널을 활성화하고 설정 패널을 비활성화
        mainMenuPanel.SetActive(true);
        settingsPanel.SetActive(false);
    }

    // 설정 버튼 클릭 시 호출되는 함수
    public void OnSettingsButtonClick()
    {
        // 설정 패널을 활성화하고 메인 메뉴 패널을 비활성화
        settingsPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
    }*/


    /*public GameObject uiPanel1;
    public GameObject uiPanel2;

     // 메인 메뉴 버튼 클릭 시 호출되는 함수
    public void OnuiPanel1ButtonClick()
    {
        // 메인 메뉴 패널을 활성화하고 설정 패널을 비활성화
        uiPanel1.SetActive(true);
        uiPanel2.SetActive(false);
    }

    // 설정 버튼 클릭 시 호출되는 함수
    public void OnuiPanel2ButtonClick()
    {
        // 설정 패널을 활성화하고 메인 메뉴 패널을 비활성화
        uiPanel2.SetActive(true);
        uiPanel1.SetActive(false);
    }



    // Update is called once per frame
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 현재 활성화된 UI 패널을 비활성화하고, 다음 UI 패널을 활성화합니다.
            if (uiPanel1.activeSelf)
            {
                uiPanel1.SetActive(false);
                uiPanel2.SetActive(true);
            }
            else
            {
                uiPanel1.SetActive(true);
                uiPanel2.SetActive(false);
            }
        }

    }*/
}
