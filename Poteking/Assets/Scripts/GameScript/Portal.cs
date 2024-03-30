using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Portal : MonoBehaviour
{
    public Transform endPortal;

    private bool isColliding = false;
    public TalkAction talkAction; // 대화 상호작용 관련 스크립트
    public Image keyPrompt;



    private void Start()
    {
        // 포탈의 자식으로 있는 UI 이미지를 찾습니다.
        keyPrompt = GetComponentInChildren<Image>();
        keyPrompt.gameObject.SetActive(false);  

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // 대화 중일 때는 포탈과의 상호작용을 막음
            if (!talkAction.isAction)
            {
                isColliding = true;
                keyPrompt.gameObject.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isColliding = false;
            keyPrompt.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        // 대화 중이 아니고 충돌 중일 때 'E' 키를 누르면 플레이어를 순간 이동시킴
        if (!talkAction.isAction && isColliding && Input.GetKeyDown(KeyCode.F))
        {
            TeleportPlayer();
        }
    }

    private void TeleportPlayer()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null && endPortal != null)
        {
            player.transform.position = endPortal.position;
        }
    }
}