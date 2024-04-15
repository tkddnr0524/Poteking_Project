using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueUIManager : MonoBehaviour
{
    public GameObject dialoguePanel;
    public Text speakerNameText;
    public Text dialogueText;

    // 대화 창을 표시하는 함수
    public void ShowDialogueUI(DialogueLine line)
    {
        // 대화 창을 활성화합니다.
        dialoguePanel.SetActive(true);

        // 화자의 이름과 대화 내용을 업데이트합니다.
        speakerNameText.text = line.speakerName;
        dialogueText.text = line.dialogueText;
    }

    // 대화 창을 숨기는 함수
    public void HideDialogue()
    {
        // 대화 창을 비활성화합니다.
        dialoguePanel.SetActive(false);
    }
}
