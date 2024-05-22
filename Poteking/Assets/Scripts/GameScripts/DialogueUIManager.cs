using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueUIManager : MonoBehaviour
{
    // ��ȭ �� 
    // ��ȭ ���� �ÿ� �� �̵� �Ǵ� ȭ���� �޹�� �̹����� ������ �ٸ� �������� ��ȭ�� �ϴ� ��ó�� ���� 
    public Image talkBackground; // ��� �̹��� ����
    public GameObject dialoguePanel; // ��ȭâ
    public Text speakerNameText; // ��ȭâ�� ��� ���ϴ� ����̸�
    public Text dialogueText; // ��ȭâ�� ��� ��ȭ ����
    public Image leftExpressionImage; // ���ʿ� ��� ĳ���� ǥ�� �̹���
    public Image rightExpressionImage; // �����ʿ� ��� ĳ���� ǥ�� �̹���


    // ��ȭ â�� ǥ���ϴ� �Լ�
    public void ShowDialogueUI(DialogueLine line, bool isLeftSpeaker)
    {
        talkBackground.gameObject.SetActive(true);
        // ��ȭ â�� Ȱ��ȭ�մϴ�.
        dialoguePanel.SetActive(true);

        // ȭ���� �̸��� ��ȭ ������ ������Ʈ�մϴ�.
        speakerNameText.text = line.speakerName;
        dialogueText.text = line.dialogueText;

        // ĳ���� ǥ���� ������Ʈ�մϴ�.
        if (isLeftSpeaker) //���� ĳ���� Ȱ��ȭ, ������ ��Ȱ��ȭ
        {
            
            leftExpressionImage.sprite = line.expression;
            leftExpressionImage.gameObject.SetActive(true);
            rightExpressionImage.gameObject.SetActive(false);
        }
        else  //�ƴ϶�� ������ ĳ���� Ȱ��ȭ, ���� ��Ȱ��ȭ
        {
            rightExpressionImage.sprite = line.expression;
            rightExpressionImage.gameObject.SetActive(true);
            leftExpressionImage.gameObject.SetActive(false);
        }
    }

    // ��ȭâ ��Ȱ��ȭ �Լ�
    public void HideDialogue()
    {
        // ��ȭ â�� ��Ȱ��ȭ�մϴ�.
        dialoguePanel.SetActive(false);
    }
}