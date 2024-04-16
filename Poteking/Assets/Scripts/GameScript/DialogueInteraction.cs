using System.Collections;
using System.Collections.Generic;
using UnityEngine;






public class DialogueInteraction : MonoBehaviour
{
    private DialogueData dialogueData;
    private int currentEntryIndex = 0;
    private int currentLineIndex = 0;
    public DialogueUIManager dialogueUIManager;
    private bool isColliding = false; // ���� �浹 ���¸� ��Ÿ���� ����
    private bool isDialogueActive = false; // ��ȭ �������� ��Ÿ���� ����

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isColliding = true; // �浹 ���¸� true�� ����
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isColliding = false; // �浹�� ��������Ƿ� false�� ����
        }
    }

    private void Start()
    {
        dialogueData = GetComponent<NPCObject>().dialogueData;
    }

    private void Update()
    {
        if (isColliding && Input.GetKeyDown(KeyCode.E) && !isDialogueActive) // �浹 ���̰� ��ȭ ���� �ƴ� ���� ����
        {
            StartDialogue();
        }
        else if (Input.GetKeyDown(KeyCode.E) && isDialogueActive) // ��ȭ ���� ���� ����
        {
            ContinueDialogue();
        }
    }

    private void StartDialogue()
    {
        isDialogueActive = true; // ��ȭ�� ���۵Ǿ����Ƿ� true�� ����
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
        // ��ȭ ������ ȭ�ڿ� ���� ǥ���� ��ġ�� ����
        bool isLeftExpression = line.speakerName == "���Ҹ�";

        // ǥ���� ��ġ�� Ȯ���� �� DialogueUIManager�� ����
        dialogueUIManager.ShowDialogueUI(line, isLeftExpression);
    }

    private void EndDialogue()
    {
        isDialogueActive = false; // ��ȭ�� ����Ǿ����Ƿ� false�� ����
        dialogueUIManager.HideDialogue();
    }
}