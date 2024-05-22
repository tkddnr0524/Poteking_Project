using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueUIManager : MonoBehaviour
{
    // 대화 씬 
    // 대화 진입 시에 씬 이동 또는 화면을 뒷배경 이미지로 가려서 다른 공간에서 대화를 하는 것처럼 구현 
    public Image talkBackground; // 배경 이미지 공간
    public GameObject dialoguePanel; // 대화창
    public Text speakerNameText; // 대화창에 띄울 말하는 사람이름
    public Text dialogueText; // 대화창에 띄울 대화 내용
    public Image leftExpressionImage; // 왼쪽에 띄울 캐릭터 표정 이미지
    public Image rightExpressionImage; // 오른쪽에 띄울 캐릭터 표정 이미지


    // 대화 창을 표시하는 함수
    public void ShowDialogueUI(DialogueLine line, bool isLeftSpeaker)
    {
        talkBackground.gameObject.SetActive(true);
        // 대화 창을 활성화합니다.
        dialoguePanel.SetActive(true);

        // 화자의 이름과 대화 내용을 업데이트합니다.
        speakerNameText.text = line.speakerName;
        dialogueText.text = line.dialogueText;

        // 캐릭터 표정을 업데이트합니다.
        if (isLeftSpeaker) //왼쪽 캐릭터 활성화, 오른쪽 비활성화
        {
            
            leftExpressionImage.sprite = line.expression;
            leftExpressionImage.gameObject.SetActive(true);
            rightExpressionImage.gameObject.SetActive(false);
        }
        else  //아니라면 오른쪽 캐릭터 활성화, 왼쪽 비활성화
        {
            rightExpressionImage.sprite = line.expression;
            rightExpressionImage.gameObject.SetActive(true);
            leftExpressionImage.gameObject.SetActive(false);
        }
    }

    // 대화창 비활성화 함수
    public void HideDialogue()
    {
        // 대화 창을 비활성화합니다.
        dialoguePanel.SetActive(false);
    }
}