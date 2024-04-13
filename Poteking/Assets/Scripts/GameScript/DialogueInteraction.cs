using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class DialogueInteraction : MonoBehaviour
{
    private DialogueData dialogueData;
    private int currentEntryIndex = 0;
    private int currentLineIndex = 0;

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
            currentLineIndex = 0;

            if (currentEntryIndex >= dialogueData.dialogueList.Count)
            {
                // 대화가 끝났을 때 대화 패널을 비활성화합니다.
                EndDialogue();
                return;
            }
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
        Debug.Log(line.speakerName + ": " + line.dialogueText);
    }

    private void EndDialogue()
    {
        // 대화가 끝날 때 처리할 작업을 여기에 추가할 수 있습니다.
        Debug.Log("대화가 종료되었습니다.");
    }
}