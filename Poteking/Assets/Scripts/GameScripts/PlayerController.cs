using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; //플레이어 이동속도
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Animator animator;
    float moveInput;
    public NPCManager npcManager;
    public GameStateManager gameStateManager;
    public DialogueUIController dialogueUIController;
    public IllustratorBox illustratorBox;
    public BackGroundBox backGroundBox;

    private bool isDialogueActive = false;
    public float range = 2.0f;

    private void OnDrawGizmosSelected()
    {
#if UNITY_EDITOR
        Handles.color = Color.red;
        Handles.DrawWireDisc(transform.position, Vector3.forward, range); // 빨강색 원으로 거리 확인
#endif
    }
    private void Start()
    {

        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void Update()
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

        if (Input.GetKeyDown(KeyCode.E))
        {
            /*if (isDialogueActive)
            {
                HideDialogueUI();
            }
            else
            {
                InteractWithNPC();
            }*/
            InteractWithNPC();
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


    void InteractWithNPC()
    {
        //오버랩된 NPC 오브젝트를 가져온다 (TAG 사용)
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, range);
        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag("NPC"))
            {
                //NPC 오브젝트에서 다이얼로그 데이터 가져오기

                Entity_Dialogue.Param npcParam =
                    npcManager.GetParamData(collider.GetComponent<NPCActor>().npcNumber, gameStateManager.gameState);
                if (npcParam != null)
                {
                    //대화실행
                    Debug.Log($"Dialog : {npcParam.Dialog}");


                    dialogueUIController.NPCName.text = npcParam.npcname;
                    dialogueUIController.dialogueText.text = npcParam.Dialog;

                    if (npcParam.background >= 0 && npcParam.background < backGroundBox.backGroundList.Length)
                    {
                        dialogueUIController.backGround.sprite = backGroundBox.backGroundList[npcParam.background];
                    }

                    if (npcParam.leftface >= 0 && npcParam.leftface < illustratorBox.illustratorList.Length)
                    {
                        dialogueUIController.leftFace.sprite = illustratorBox.illustratorList[npcParam.leftface];
                    }

                    // 왼쪽 캐릭터 일러스트 설정
                    if (npcParam.leftface > 0 && npcParam.leftface < illustratorBox.illustratorList.Length)
                    {
                        dialogueUIController.LeftFaceUi(true);
                        dialogueUIController.leftFace.sprite = illustratorBox.illustratorList[npcParam.leftface];
                    }
                    else
                    {
                        // 일러스트를 숨김
                        dialogueUIController.LeftFaceUi(false);
                    }

                    // 오른쪽 캐릭터 일러스트 설정
                    if (npcParam.rightface > 0 && npcParam.rightface < illustratorBox.illustratorList.Length)
                    {
                        dialogueUIController.RightFaceUi(true);
                        dialogueUIController.rightFace.sprite = illustratorBox.illustratorList[npcParam.rightface];
                    }
                    else
                    {
                        // 일러스트를 숨김
                        dialogueUIController.RightFaceUi(false);
                    }


                    //작업수행
                    if (npcParam.changeState > 0)
                    {

                        gameStateManager.gameState = npcParam.changeState;
                    }

                    //대화UI 활성화
                    dialogueUIController.ActiveUI(true);
                    //isDialogueActive = true;



                }
                else
                {
                    Debug.LogWarning("해당하는 데이터가 없습니다. ");

                    //대화UI 비활성화
                    HideDialogueUI();
                }
            }
        }
    }

    private void HideDialogueUI()
    {
        dialogueUIController.ActiveUI(false);
        dialogueUIController.LeftFaceUi(false);
        dialogueUIController.RightFaceUi(false);
        //isDialogueActive = false;
    }
}

