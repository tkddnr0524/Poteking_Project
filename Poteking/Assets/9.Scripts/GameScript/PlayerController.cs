using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    ObjectData currentObject;
    public TalkAction talkAction;
    Rigidbody2D rigid;
    public float maxSpeed;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        
    }

    

    void OnTriggerEnter2D(Collider2D scanObject)
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
    }
    private void FixedUpdate()
    {

        if (!talkAction.isAction)
        {
            float h = Input.GetAxisRaw("Horizontal");



            rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);



            if (rigid.velocity.x > maxSpeed)
                rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
            else if (rigid.velocity.x < maxSpeed * (-1))
                rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y);
        }
    }

    void Update()
    {
        if(currentObject != null && Input.GetKeyDown(KeyCode.E))
        {
            talkAction.Action(currentObject.gameObject); 

        }
    }


    
}

