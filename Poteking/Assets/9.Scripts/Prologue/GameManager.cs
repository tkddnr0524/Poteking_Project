using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject smartPhone; //스마트폰 이미지 넣을 공간
    public GameObject notification1; // 첫번째 알림창 이미지 넣을 공간
    public GameObject notification2; // 두번째 알림창 이미지 넣을 공간

    public GameObject chatObject; //Chat = 대화창 오브젝트가 들어갈 공간
    void Start()
    {
        //게임 시작되면 Chat 오브젝트를 비활성화
        chatObject.SetActive(false);


        //게임이 시작되면 알림창을 비활성화 상태로 설정해놓음
        notification1.SetActive(false);
        notification2.SetActive(false);

        //각각의 알림창에 대해 활성화 딜레이 설정
        Invoke("ActiveNotification1", 2f);
        Invoke("ActiveNotification2", 6f);
        
    }

    void ActiveNotification1()
    {
        //첫번째 알림창 이미지를 활성화 
        {
            notification1.SetActive(true);           
        }
    }

    // 알림창을 클릭 했을 때 
    public void OnNotificationClicked()
    {
        if(chatObject != null)
        {
            //Chat 오브젝트 활성화
            chatObject.SetActive(true);

            // Chat 오브젝트와 모든 자식 오브젝트(대화 말풍선과 텍스트)도 함께 활성화
            foreach (Transform child in chatObject.transform) 
            {
                child.gameObject.SetActive(true);
            }
        }
    }
    void ActiveNotification2()
    {
        //두번째 알림창 이미지를 활성화 
        {
            notification2.SetActive(true);
        }
    }
}
