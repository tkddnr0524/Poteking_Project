using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class sma : MonoBehaviour
{
    public GameObject smartUI; // 나타낼 이미지 UI
    public GameObject phoneUI;
    public GameObject chatUI;
    public GameObject callUI;
    public GameObject mapUI;
    
    public Button phoneButton;
    public Button chatButton;
    public Button callButton;
    public Button mapButton;
    public Button buttonX;
    public Button buttonMapX;

    public Image image1;
    public Image image2;
    public Image image3;

    private PauseMenu pauseMenu;
    private Camera mapCamera;

    void Start()
    {
        // PauseMenu 스크립트의 인스턴스를 찾아 할당
        pauseMenu = FindObjectOfType<PauseMenu>();

        //맵(서브) 카메라 오브젝트 찾기
        mapCamera = GameObject.Find("MapCamera").GetComponent<Camera>();
    }

    public void Update()
    {

        if(Input.GetKeyDown(KeyCode.P) && pauseMenu.isPaused == false)
        {
            OnPhoneButtonClick();
            //chatButton.Select();
        }

        //if(Input.GetKeyDown(KeyCode.KeypadEnter) && pauseMenu.isPaused == false)


        /*GameObject selectedButton = EventSystem.current.currentSelectedGameObject;
        if (selectedButton != null && selectedButton.transform.IsChildOf(transform))
        {
            image1.gameObject.SetActive(true);
        }
        else
        {
            // 이미지 UI 비활성화
            image1.gameObject.SetActive(false);
        }*/

    }

    // 버튼 클릭 이벤트를 처리하는 함수
    public void OnPhoneButtonClick()
    {
        // 이미지 UI를 활성화합니다.
        smartUI.SetActive(!smartUI.activeSelf);

        phoneButton.gameObject.SetActive(false);
        chatButton.gameObject.SetActive(true);
        callButton.gameObject.SetActive(true);
        mapButton.gameObject.SetActive(true);

        //chatButton.Select();

    }

    public void OnChatButtonClick()
    {
        smartUI.SetActive(!smartUI.activeSelf);
        chatUI.SetActive(!mapUI.activeSelf);
        chatButton.gameObject.SetActive(false);
        callButton.gameObject.SetActive(false);
        mapButton.gameObject.SetActive(false);
        buttonX.gameObject.SetActive(true);

        buttonX.Select();
    }

    public void OnCallButtonClick()
    {
        smartUI.SetActive(!smartUI.activeSelf);
        callUI.SetActive(!callUI.activeSelf);
        chatButton.gameObject.SetActive(false);
        callButton.gameObject.SetActive(false);
        mapButton.gameObject.SetActive(false);
        buttonX.gameObject.SetActive(true);

        buttonX.Select();
    }

    public void OnMapButtonClick()
    {
        smartUI.SetActive(!smartUI.activeSelf);
        //mapUI.SetActive(!mapUI.activeSelf);
        chatButton.gameObject.SetActive(false);
        callButton.gameObject.SetActive(false);
        mapButton.gameObject.SetActive(false);
        //buttonX.gameObject.SetActive(true);
        mapCamera.enabled= !mapCamera.enabled;

        Time.timeScale = 0f;

        buttonMapX.gameObject.SetActive(true);

        buttonX.Select();
    }

    public void OnButtonMapXClick()
    {
        Time.timeScale = 1f;
        phoneButton.gameObject.SetActive(true);
        mapCamera.enabled = !mapCamera.enabled;
        buttonMapX.gameObject.SetActive(false);
    }
    

    public void OnButtonXClick()
    {
        phoneButton.gameObject.SetActive(true);
        chatButton.gameObject.SetActive(false);
        callButton.gameObject.SetActive(false);
        mapButton.gameObject.SetActive(false);
        buttonX.gameObject.SetActive(false);

        mapUI.gameObject.SetActive(false);
        chatUI.gameObject.SetActive(false);
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
