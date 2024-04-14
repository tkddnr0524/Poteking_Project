using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatButton : MonoBehaviour
{
    public GameObject ChatUI; //채팅창 이미지 넣을 공간
    private bool isOnChat = false;
    // Start is called before the first frame update
    void Start()
    {
        ChatUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V)) //V누르면 챗 종료
        {
            ChatUI.SetActive(false);
        }
    }
    public void OnChatActiveClick()
    {
        isOnChat = !isOnChat;
        ChatUI.SetActive(isOnChat);
    }
}
