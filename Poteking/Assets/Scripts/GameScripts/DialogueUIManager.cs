using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueUIManager : MonoBehaviour
{
    public GameObject dialoguePanel;
    public Text speakerNameText;
    public Text dialogueText;
    public Image leftExpressionImage; // 왼쪽 캐릭터 표정 이미지를 표시할 UI 요소
    public Image rightExpressionImage; // 오른쪽 캐릭터 표정 이미지를 표시할 UI 요소

    // 대화 창을 표시하는 함수
    public void ShowDialogueUI(DialogueLine line, bool isLeftSpeaker)
    {
        // 대화 창을 활성화합니다.
        dialoguePanel.SetActive(true);

        // 화자의 이름과 대화 내용을 업데이트합니다.
        speakerNameText.text = line.speakerName;
        dialogueText.text = line.dialogueText;

        // 캐릭터 표정을 업데이트합니다.
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

    // 대화 창을 숨기는 함수
    public void HideDialogue()
    {
        // 대화 창을 비활성화합니다.
        dialoguePanel.SetActive(false);
    }
}