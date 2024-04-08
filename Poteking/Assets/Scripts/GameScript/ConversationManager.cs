using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConversationManager : MonoBehaviour
{
    public Text conversationText;
    public Image conversationImage; //대화창 이미지
    public ConversationData conversationData; // 스크립터블 오브젝트 연결

    private int conversationIndex = 0; // 현재 대화 ID
    private int dialogueIndex = 0; // 대화 내용 인덱스

    void Start()
    {
        conversationImage.gameObject.SetActive(true);
        DisplayNextDialogue();      
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // 엔터를 누를 때마다 다음 대화 내용을 출력
            DisplayNextDialogue();
        }
    }

    void DisplayNextDialogue()
    {
        if (conversationIndex < conversationData.conversations.Count)
        {
            ConversationData.Conversation currentConversation = conversationData.conversations[conversationIndex];
            List<ConversationItem> dialogueList = currentConversation.dialogue;
            if (dialogueIndex < dialogueList.Count)
            {
                // 대화 내용 출력
                conversationText.text = dialogueList[dialogueIndex].text;
                dialogueIndex++;
            }
            else
            {
                // 대화 내용을 모두 출력한 경우 대화 ID 증가 및 대화 내용 인덱스 초기화
                conversationIndex++;
                dialogueIndex = 0;
            }
        }
        conversationImage.gameObject.SetActive(false);
    }

}
