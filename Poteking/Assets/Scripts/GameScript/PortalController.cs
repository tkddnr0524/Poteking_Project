using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    public Transform destinationPortal; //�̵� �� ��Ż
    private bool isPlayerInRange; //�÷��̾ ��Ż ��ó�� �ִ� ����
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            isPlayerInRange = false;
        }
    }
    
    void Update()
    {
        if (isPlayerInRange && (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)))
        {
            TeleportPlayer();
        }
    }

    void TeleportPlayer()
    {
        if (destinationPortal != null)
        {
            // �÷��̾� ��ġ�� ������ ��Ż ��ġ�� �̵�
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                player.transform.position = destinationPortal.position;
            }
        }
    }
   
}
