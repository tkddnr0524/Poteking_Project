using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallButton : MonoBehaviour
{
    public GameObject callUI; // 전화부 이미지 공간
    private bool isOnCall = false; //현재 전화부가 켜져있는지 확인
    // Start is called before the first frame update
    void Start()
    {
        callUI.SetActive(false); // 시작 시 전화부 비활성화
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V)) //V누르면 챗 종료
        {
            callUI.SetActive(false);
        }
    }

    public void OnCallActiveClick()
    {
        isOnCall = !isOnCall;
        callUI.SetActive(isOnCall);
    }
}
