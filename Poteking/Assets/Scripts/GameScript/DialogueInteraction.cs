using System.Collections;
using System.Collections.Generic;
using UnityEngine;






public class DialogueInteraction : MonoBehaviour
{
    private DialogueData dialogueData;
    private int currentEntryIndex = 0;
    private int currentLineIndex = 0;
    public DialogueUIManager dialogueUIManager;
    private bool isColliding = false; // 현재 충돌 상태를 나타내는 변수
    private bool isDialogueActive = false; // 대화 중인지를 나타내는 변수

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isColliding = true; // 충돌 상태를 true로 설정
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isColliding = false; // 충돌이 종료됐으므로 false로 설정
        }
    }

    private void Start()
    {
        dialogueData = GetComponent<NPCObject>().dialogueData;
    }

    private void Update()
    {
        if (isColliding && Input.GetKeyDown(KeyCode.E) && !isDialogueActive) // 충돌 중이고 대화 중이 아닐 때만 실행
        {
            StartDialogue();
        }
        else if (Input.GetKeyDown(KeyCode.E) && isDialogueActive) // 대화 중일 때만 실행
        {
            ContinueDialogue();
        }
    }

    private void StartDialogue()
    {
        isDialogueActive = true; // 대화가 시작되었으므로 true로 설정
        dialogueData = GetComponent<NPCObject>().dialogueData;
        ShowDialogue();
    }

    private void ContinueDialogue()
    {
        currentLineIndex++;

        if (currentLineIndex >= dialogueData.dialogueList[currentEntryIndex].dialogueLines.Count)
        {
            currentEntryIndex++;
            currentLineIndex = 0;
            

            if (currentEntryIndex >= dialogueData.dialogueList.Count)
            {
                currentEntryIndex = dialogueData.dialogueList.Count - 1;
                
            }
            EndDialogue();
            return;
        }

        ShowDialogue();
    }

    private void ShowDialogue()
    {
        DialogueEntry entry = dialogueData.dialogueList[currentEntryIndex];
        DialogueLine line = entry.dialogueLines[currentLineIndex];
        // 대화 라인의 화자에 따라 표정의 위치를 결정
        bool isLeftExpression = line.speakerName == "성소리";

        // 표정의 위치를 확인한 후 DialogueUIManager에 전달
        dialogueUIManager.ShowDialogueUI(line, isLeftExpression);
    }

    private void EndDialogue()
    {
        isDialogueActive = false; // 대화가 종료되었으므로 false로 설정
        dialogueUIManager.HideDialogue();
    }
}