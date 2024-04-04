using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform endPortal;

    private bool isColliding = false;
    public TalkAction talkAction; // ��ȭ ��ȣ�ۿ� ���� ��ũ��Ʈ
    public GameObject keyPrompt;

   


    private void Start()
    {
        // ��Ż�� �ڽ����� �ִ� UI �̹����� ã���ϴ�.
        
        keyPrompt.gameObject.SetActive(false);  

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // ��ȭ ���� ���� ��Ż���� ��ȣ�ۿ��� ����
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
        // ��ȭ ���� �ƴϰ� �浹 ���� �� 'E' Ű�� ������ �÷��̾ ���� �̵���Ŵ
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