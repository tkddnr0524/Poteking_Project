using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class DialogueInteraction : MonoBehaviour
{
    private DialogueData dialogueData;
    private int currentEntryIndex = 0;
    private int currentLineIndex = -1;
    public DialogueUIManager dialogueUIManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            // 대화 시작 시 처음 대화 엔트리의 첫 번째 대화 라인을 표시합니다.
            StartDialogue();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            // 대화가 끝날 때 대화 패널을 비활성화합니다.
            EndDialogue();
        }
    }

    private void Start()
    {
        dialogueData = GetComponent<NPCObject>().dialogueData;

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // 사용자가 E 키를 누를 때 다음 대화 라인을 표시합니다.
            ContinueDialogue();
        }
    }

    private void StartDialogue()
    {
        // 대화 데이터를 가져옵니다.
        dialogueData = GetComponent<NPCObject>().dialogueData;

        // 대화 엔트리의 첫 번째 대화 라인을 표시합니다.
        ShowDialogue();
    }

    private void ContinueDialogue()
    {
        
        currentLineIndex++;
       
        if (currentLineIndex >= dialogueData.dialogueList[currentEntryIndex].dialogueLines.Count)
        {
            currentEntryIndex++;
            currentLineIndex = -1;

            if (currentEntryIndex >= dialogueData.dialogueList.Count)
            {
                // 엔트리 인덱스가 대화 엔트리 개수를 초과하면
                // 마지막 대화 엔트리의 마지막 대화 라인을 표시합니다.
                currentEntryIndex = dialogueData.dialogueList.Count - 1;
            }
            EndDialogue();
            return;

        }

        // 다음 대화 라인을 표시합니다.
        ShowDialogue();
    }

    private void ShowDialogue()
    {
        DialogueEntry entry = dialogueData.dialogueList[currentEntryIndex];
        DialogueLine line = entry.dialogueLines[currentLineIndex];

        // 대화 패널에 대화 라인을 표시합니다.
        // 이 부분은 게임에서 어떻게 표시할지에 따라 다를 수 있습니다.
        //Debug.Log(line.speakerName + ": " + line.dialogueText);
        dialogueUIManager.ShowDialogueUI(line);
    }

    private void EndDialogue()
    {
        // 대화가 끝날 때 처리할 작업을 여기에 추가할 수 있습니다.
       dialogueUIManager.HideDialogue();
    }
}





/*public class DialogueInteraction : MonoBehaviour
{
    private DialogueData dialogueData;
    private int currentEntryIndex = 0;
    private int currentLineIndex = -1;
    public DialogueUIManager dialogueUIManager;
    private bool isColliding = false; // 현재 충돌 상태를 나타내는 변수
    private bool isDialogueActive = false; // 대화 중인지를 나타내는 변수

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isColliding = true; // 충돌 상태를 true로 설정
        }
    }

    private void OnTriggerExit(Collider other)
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
            currentLineIndex = -1;

            if (currentEntryIndex >= dialogueData.dialogueList.Count)
            {
                currentEntryIndex = dialogueData.dialogueList.Count - 1;
                EndDialogue();
                return;
            }
        }

        ShowDialogue();
    }

    private void ShowDialogue()
    {
        DialogueEntry entry = dialogueData.dialogueList[currentEntryIndex];
        DialogueLine line = entry.dialogueLines[currentLineIndex];
        dialogueUIManager.ShowDialogueUI(line);
    }

    private void EndDialogue()
    {
        isDialogueActive = false; // 대화가 종료되었으므로 false로 설정
        dialogueUIManager.HideDialogue();
    }
}*/