using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueUIManager : MonoBehaviour
{
    public GameObject dialoguePanel;
    public Text speakerNameText;
    public Text dialogueText;

    // ��ȭ â�� ǥ���ϴ� �Լ�
    public void ShowDialogueUI(DialogueLine line)
    {
        // ��ȭ â�� Ȱ��ȭ�մϴ�.
        dialoguePanel.SetActive(true);

        // ȭ���� �̸��� ��ȭ ������ ������Ʈ�մϴ�.
        speakerNameText.text = line.speakerName;
        dialogueText.text = line.dialogueText;
    }

    // ��ȭ â�� ����� �Լ�
    public void HideDialogue()
    {
        // ��ȭ â�� ��Ȱ��ȭ�մϴ�.
        dialoguePanel.SetActive(false);
    }
}
