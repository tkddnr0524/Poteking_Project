using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class DialogueManager : MonoBehaviour
{
    public Text speakerNameText;
    public Text dialogueText;
    public Image expressionImage;
    public GameObject dialoguePanel;

    private List<DialogueEntry> dialogueEntries;
    private int currentEntryIndex;
    private int currentLineIndex;

    public void StartDialogue(DialogueData dialogueData)
    {
        // 대화 시작 시 dialogueEntries 초기화
        dialogueEntries = dialogueData.dialogueList;
        currentEntryIndex = 0;
        currentLineIndex = 0;
        ShowDialogue();
    }

    public void ContinueDialogue()
    {
        currentLineIndex++;
        if (currentLineIndex >= dialogueEntries[currentEntryIndex].dialogueLines.Count)
        {
            currentEntryIndex++;
            currentLineIndex = 0;
            if (currentEntryIndex >= dialogueEntries.Count)
            {
                EndDialogue();
                return;
            }
        }
        ShowDialogue();
    }

    private void ShowDialogue()
    {
        DialogueEntry entry = dialogueEntries[currentEntryIndex];
        DialogueLine line = entry.dialogueLines[currentLineIndex];
        speakerNameText.text = line.speakerName;
        dialogueText.text = line.dialogueText;
        expressionImage.sprite = line.expression;
        dialoguePanel.SetActive(true);
    }

    public void EndDialogue()
    {
        dialoguePanel.SetActive(false);
    }
}