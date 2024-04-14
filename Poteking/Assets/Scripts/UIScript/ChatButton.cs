using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatButton : MonoBehaviour
{
    public GameObject ChatUI; //ä��â �̹��� ���� ����
    private bool isOnChat = false;
    // Start is called before the first frame update
    void Start()
    {
        ChatUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V)) //V������ ê ����
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
