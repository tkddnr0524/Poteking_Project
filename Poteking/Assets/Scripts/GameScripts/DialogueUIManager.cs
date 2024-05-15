using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueUIManager : MonoBehaviour
{
    public GameObject dialoguePanel;
    public Text speakerNameText;
    public Text dialogueText;
    public Image leftExpressionImage; // ���� ĳ���� ǥ�� �̹����� ǥ���� UI ���
    public Image rightExpressionImage; // ������ ĳ���� ǥ�� �̹����� ǥ���� UI ���

    // ��ȭ â�� ǥ���ϴ� �Լ�
    public void ShowDialogueUI(DialogueLine line, bool isLeftSpeaker)
    {
        // ��ȭ â�� Ȱ��ȭ�մϴ�.
        dialoguePanel.SetActive(true);

        // ȭ���� �̸��� ��ȭ ������ ������Ʈ�մϴ�.
        speakerNameText.text = line.speakerName;
        dialogueText.text = line.dialogueText;

        // ĳ���� ǥ���� ������Ʈ�մϴ�.
        if (isLeftSpeaker)
        {
            leftExpressionImage.sprite = line.expression;
            leftExpressionImage.gameObject.SetActive(true);
            rightExpressionImage.gameObject.SetActive(false);
        }
        else
        {
            rightExpressionImage.sprite = line.expression;
            rightExpressionImage.gameObject.SetActive(true);
            leftExpressionImage.gameObject.SetActive(false);
        }
    }

    // ��ȭ â�� ����� �Լ�
    public void HideDialogue()
    {
        // ��ȭ â�� ��Ȱ��ȭ�մϴ�.
        dialoguePanel.SetActive(false);
    }
}