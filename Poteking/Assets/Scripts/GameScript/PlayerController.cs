using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;//플레이어 이동 속

    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Animator animator;
    float moveInput;
    TalkAction moveStop;

    private void Start()
    {
        moveStop = FindObjectOfType<TalkAction>();
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(!moveStop.isAction)
        {
            moveInput = Input.GetAxisRaw("Horizontal");
            if (Input.GetButton("Horizontal"))
            {
                spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == 1;
            }

            if (rigid.velocity.x == 0)
            {
                animator.SetBool("isWalking", false);
            }
            else
            {
                animator.SetBool("isWalking", true);
            }
        }
        else
        {
            // 대화 중이라면 플레이어의 움직임을 멈춤
            moveInput = 0f;
            animator.SetBool("isWalking", false);
        }
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        Vector2 velocity = rigid.velocity;
        velocity.x = moveInput * moveSpeed;
        rigid.velocity = velocity;
    }

}

