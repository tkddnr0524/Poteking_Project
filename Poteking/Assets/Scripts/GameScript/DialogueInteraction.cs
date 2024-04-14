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
            // ��ȭ ���� �� ó�� ��ȭ ��Ʈ���� ù ��° ��ȭ ������ ǥ���մϴ�.
            StartDialogue();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            // ��ȭ�� ���� �� ��ȭ �г��� ��Ȱ��ȭ�մϴ�.
            EndDialogue();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // ����ڰ� E Ű�� ���� �� ���� ��ȭ ������ ǥ���մϴ�.
            ContinueDialogue();
        }
    }

    private void StartDialogue()
    {
        // ��ȭ �����͸� �����ɴϴ�.
        dialogueData = GetComponent<NPCObject>().dialogueData;

        // ��ȭ ��Ʈ���� ù ��° ��ȭ ������ ǥ���մϴ�.
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
                // ��ȭ�� ������ �� ��ȭ �г��� ��Ȱ��ȭ�մϴ�.
                EndDialogue();
                return;
            }
        }

        // ���� ��ȭ ������ ǥ���մϴ�.
        ShowDialogue();
    }

    private void ShowDialogue()
    {
        DialogueEntry entry = dialogueData.dialogueList[currentEntryIndex];
        DialogueLine line = entry.dialogueLines[currentLineIndex];

        // ��ȭ �гο� ��ȭ ������ ǥ���մϴ�.
        // �� �κ��� ���ӿ��� ��� ǥ�������� ���� �ٸ� �� �ֽ��ϴ�.
        Debug.Log(line.speakerName + ": " + line.dialogueText);
    }

    private void EndDialogue()
    {
        // ��ȭ�� ���� �� ó���� �۾��� ���⿡ �߰��� �� �ֽ��ϴ�.
        Debug.Log("��ȭ�� ����Ǿ����ϴ�.");
    }
}