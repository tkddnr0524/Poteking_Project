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
    public int dialogueId; // 대화 ID
    public List<DialogueLine> dialogueLines = new List<DialogueLine>(); // 대화 라인들의 리스트
    public DialogueEvent dialogueEvent; // 대화 이벤트
}

[System.Serializable]
public class DialogueLine
{
    [Multiline]
    public string dialogueText; // 대화 내용
    public string speakerName; // 대화를 말하는 NPC의 이름
    public Sprite expression; // 대화를 말하는 NPC의 표정 이미지
    
}

[System.Serializable]
public class DialogueEvent
{
    public int targetNPCID; // 이벤트 실행 대상 NPC의 ID

}
