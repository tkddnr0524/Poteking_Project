using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConversationManager : MonoBehaviour
{
    public Text conversationText;
    public Image conversationImage; //��ȭâ �̹���
    public ConversationData conversationData; // ��ũ���ͺ� ������Ʈ ����

    private int conversationIndex = 0; // ���� ��ȭ ID
    private int dialogueIndex = 0; // ��ȭ ���� �ε���

    void Start()
    {
        conversationImage.gameObject.SetActive(true);
        DisplayNextDialogue();      
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // ���͸� ���� ������ ���� ��ȭ ������ ���
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
                // ��ȭ ���� ���
                conversationText.text = dialogueList[dialogueIndex].text;
                dialogueIndex++;
            }
            else
            {
                // ��ȭ ������ ��� ����� ��� ��ȭ ID ���� �� ��ȭ ���� �ε��� �ʱ�ȭ
                conversationIndex++;
                dialogueIndex = 0;
            }
        }
        conversationImage.gameObject.SetActive(false);
    }

}
