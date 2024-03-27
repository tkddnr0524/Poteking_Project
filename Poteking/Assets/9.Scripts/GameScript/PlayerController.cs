using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMove : MonoBehaviour
{

    public TalkManager talkManager;
    Rigidbody2D rigid;
    public float maxSpeed;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        talkManager = FindObjectOfType<TalkManager>();
    }

    public void OnTriggerStay2D(Collider2D scanObject)
    {

        Debug.Log("충돌");
        if (scanObject.CompareTag("Object") && Input.GetKeyDown(KeyCode.Space))
        {
            talkManager.Action(scanObject.gameObject);
            Debug.Log("작동");
        }
    }
    private void FixedUpdate()
    {
        
        if (!talkManager.isAction)
        {
            float h = Input.GetAxisRaw("Horizontal");
           


            rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);



            if (rigid.velocity.x > maxSpeed)
                rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
            else if (rigid.velocity.x < maxSpeed * (-1))
                rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y);
        }
    }


    
}

