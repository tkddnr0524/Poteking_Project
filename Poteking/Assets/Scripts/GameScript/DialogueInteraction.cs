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

    private void Start()
    {
        dialogueData = GetComponent<NPCObject>().dialogueData;

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
            currentLineIndex = -1;

            if (currentEntryIndex >= dialogueData.dialogueList.Count)
            {
                // ��Ʈ�� �ε����� ��ȭ ��Ʈ�� ������ �ʰ��ϸ�
                // ������ ��ȭ ��Ʈ���� ������ ��ȭ ������ ǥ���մϴ�.
                currentEntryIndex = dialogueData.dialogueList.Count - 1;
            }
            EndDialogue();
            return;

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
        //Debug.Log(line.speakerName + ": " + line.dialogueText);
        dialogueUIManager.ShowDialogueUI(line);
    }

    private void EndDialogue()
    {
        // ��ȭ�� ���� �� ó���� �۾��� ���⿡ �߰��� �� �ֽ��ϴ�.
       dialogueUIManager.HideDialogue();
    }
}





/*public class DialogueInteraction : MonoBehaviour
{
    private DialogueData dialogueData;
    private int currentEntryIndex = 0;
    private int currentLineIndex = -1;
    public DialogueUIManager dialogueUIManager;
    private bool isColliding = false; // ���� �浹 ���¸� ��Ÿ���� ����
    private bool isDialogueActive = false; // ��ȭ �������� ��Ÿ���� ����

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isColliding = true; // �浹 ���¸� true�� ����
        }
    }

    private void OnTriggerExit(Collider other)
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
        isDialogueActive = false; // ��ȭ�� ����Ǿ����Ƿ� false�� ����
        dialogueUIManager.HideDialogue();
    }
}*/