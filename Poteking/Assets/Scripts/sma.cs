using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sma : MonoBehaviour
{
    public GameObject smartUI; // 나타낼 이미지 UI
    public GameObject phoneUI;
    public GameObject talkUI;
    public GameObject mapUI;
    public GameObject callUI;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;

    // 버튼 클릭 이벤트를 처리하는 함수
    public void OnButton1Click()
    {
        // 이미지 UI를 활성화합니다.
        smartUI.SetActive(!smartUI.activeSelf);
        
        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(true);
        button3.gameObject.SetActive(true);
        button4.gameObject.SetActive(true);

    }

    public void OnButton2Click()
    {
        smartUI.SetActive(!smartUI.activeSelf);
        mapUI.SetActive(!mapUI.activeSelf);
        button2.gameObject.SetActive(false);
        button3.gameObject.SetActive(false);
        button4.gameObject.SetActive(false);
        button5.gameObject.SetActive(true);
    }

    public void OnButton5Click()
    {
        button1.gameObject.SetActive(true);
        button2.gameObject.SetActive(false);
        button3.gameObject.SetActive(false);
        button4.gameObject.SetActive(false);
        button5.gameObject.SetActive(false);

        mapUI.gameObject.SetActive(false);
        talkUI.gameObject.SetActive(false);
        callUI.gameObject.SetActive(false);
        smartUI.gameObject.SetActive(false);
    }


    /*// UI가 활성화될 때 호출되는 함수
    public void OnImageUIActivated()
    {
        // 이미지 UI가 활성화되었을 때 버튼을 숨깁니다.
        button1.gameObject.SetActive(false);
    }

    // UI가 비활성화될 때 호출되는 함수
    public void OnImageUIDeactivated()
    {
        // 이미지 UI가 비활성화되었을 때 버튼을 다시 표시합니다.
        button1.gameObject.SetActive(true);
    }*/


}
