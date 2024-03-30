using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;//�÷��̾� �̵� ��

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
            // ��ȭ ���̶�� �÷��̾��� �������� ����
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

