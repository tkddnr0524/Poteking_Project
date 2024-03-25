using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /* private bool isColliding = false; // 충돌 감지 조건*/

    /*public InteractiveObject InteractiveObject { set { interactiveTarget = value; } }
    private InteractiveObject interactiveTarget;*/
   
        public void OnTriggerStay2D(Collider2D scanObject)
        {
            if (scanObject.CompareTag("Object") && Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("오브젝트와 상호 작용 합니다");
            }
        }
        



    /*private void OnTriggerEnter2D(Collider2D scanObject)  
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
            Debug.Log("오브젝트와 상호 작용 합니다");
        }
        
    }*/
}

