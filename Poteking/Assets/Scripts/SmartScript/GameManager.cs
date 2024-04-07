using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class GameManager : MonoBehaviour
{
    public GameObject smartPhone; //스마트폰 이미지 넣을 공간
    public GameObject notification1; // 첫번째 알림창 이미지 넣을 공간
    public GameObject notification2; // 두번째 알림창 이미지 넣을 공간
    public GameObject talkImage; //대화창 이미지

    void Start()
    {
        //게임이 시작되면 알림창을 비활성화 상태로 설정해놓음
        notification1.SetActive(false);
        notification2.SetActive(false);
        talkImage.SetActive(false); 

        //각각의 알림창에 대해 활성화 딜레이 설정
        Invoke("ActiveNotification1", 2f);
        Invoke("ActiveNotification2", 5f);


        //알림창 클릭 이벤트, Button의 onClick.AddListener(델리게이트) 형식으로 메서드를 할당 
        //메서드에 인자가 없는 경우 바로 메소드 이름으로 넘겨주면 된다.
        //두 번째 알림창에 클릭 이벤트 설정
        notification2.GetComponent<Button>().onClick.AddListener(OpenTalk);
        
    }

    void ActiveNotification1()
    {
        //첫번째 알림창 이미지를 활성화 
        {
            notification1.SetActive(true);           
        }
    }

    void ActiveNotification2()
    {
        //두번째 알림창 이미지를 활성화 
        {
            notification2.SetActive(true);
        }
    }

    void OpenTalk() //대화창 활성화 함수
    {
        talkImage.SetActive(true);
    }
}
