using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    ObjectData currentObject;
    public TalkAction talkAction;

    Rigidbody2D rigid;
    public float moveSpeed = 5f; // 플레이어의 이동 속도
    private float moveInput;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();    
    }

    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");

        /*if (currentObject != null && Input.GetKeyDown(KeyCode.E))
        {
            talkAction.Action(currentObject.gameObject);
        }*/
    }

    private void FixedUpdate()
    {
        //이동 
        rigid.velocity = new Vector2(moveInput * moveSpeed, rigid.velocity.y);

        // 플레이어 이동 방향
        if(moveInput > 0) //오른쪽으로 갈때
        {
            transform.localScale = new Vector3(1,1,1); 
        }
        else if (moveInput < 0) //왼쪽으로 갈때
        {
            transform.localScale = new Vector3(-1, 1, 1); 
        }



        /*if (!talkAction.isAction)
        {
        }*/
    }

   /* void OnTriggerEnter2D(Collider2D scanObject)
    {
        ObjectData isObject = scanObject.GetComponent<ObjectData>();
        if(isObject != null)
        {
            currentObject = isObject;
            Debug.Log(scanObject.name + "와 충돌하였습니다");
        }
    }

    private void OnTriggerExit2D(Collider2D scanObject)
    {
        ObjectData isObject = scanObject.GetComponent<ObjectData>();
        if(isObject != null && isObject == currentObject)
        {
            currentObject = null;
            Debug.Log(scanObject.name + "와 충돌이 끝났습니다");
        }
    }*/

    

    


    
}

