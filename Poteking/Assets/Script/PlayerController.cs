using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     private bool isColliding = false; // �浹 ���� ����

    /*public InteractiveObject InteractiveObject { set { interactiveTarget = value; } }
    private InteractiveObject interactiveTarget;*/
    
    private void OnTriggerEnter2D(Collider2D scanObject)  
    {
        if (scanObject.CompareTag("Object"))
        {
            isColliding = true;
        }
    }

    private void OnTriggerExit2D(Collider2D scanObject)  
    {
        if (scanObject.CompareTag("Object"))
        {
            isColliding = false;
        }
    }

    private void FixedUpdate()
    {
        if (isColliding && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("������Ʈ�� ��ȣ �ۿ� �մϴ�");
        }
    }
}
