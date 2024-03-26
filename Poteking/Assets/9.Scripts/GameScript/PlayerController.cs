using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{


    Rigidbody2D rigid;
    public float maxSpeed;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        if (rigid.velocity.x > maxSpeed)
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        else if (rigid.velocity.x < maxSpeed * (-1))
            rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y);
    }


    public void OnTriggerStay2D(Collider2D scanObject)
    {
        if (scanObject.CompareTag("Object") && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(scanObject.gameObject.name + "오브젝트와 상호 작용 합니다");
        }
    }
}

