using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewDialogueData", menuName = "ScriptableObjects/DialogueData")]
public class DialogueData : ScriptableObject
{
    public List<DialogueEntry> dialogueList = new List<DialogueEntry>();
}
[System.Serializable]
public class DialogueEntry
{
    public int dialogueId; // ��ȭ ID
    public List<DialogueLine> dialogueLines = new List<DialogueLine>(); // ��ȭ ���ε��� ����Ʈ
    public DialogueEvent dialogueEvent; // ��ȭ �̺�Ʈ
}

[System.Serializable]
public class DialogueLine
{
    [Multiline]
    public string dialogueText; // ��ȭ ����
    public string speakerName; // ��ȭ�� ���ϴ� NPC�� �̸�
    public Sprite expression; // ��ȭ�� ���ϴ� NPC�� ǥ�� �̹���
    
}

[System.Serializable]
public class DialogueEvent
{
    public int targetNPCID; // �̺�Ʈ ���� ��� NPC�� ID

}
