using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Choice
{
    public string text; //선택지의 텍스트입니다. 플레이어가 이 선택지를 선택하면 읽게 될 
    public int nextDialogueID; //이 선택지를 선택했을 때 이어지는 대화의 ID입니다.
}

[System.Serializable]
public class Dialogue
{
    public int id; //대화의 고유 ID. 대화를 식별하는 데 사용
    public string character; //대화를 하는 캐릭터의 이름
    public string text; // 대화의 내용
    public List<Choice> choices; // 선택지 리스트. 플레이어가 대화 중에 선택 할 수 있는 여러 선택지를 담고 있다.
    public int nextDialogueID; //선택지가 없는 경우 다음 대화의 ID입니다.(선택지가 없는 단일 흐름 대화일 때 사용)
}

//예시 시나리오
//1.캐릭터 NPC1이 플레이어에게 인사를 한다
//2.플레이어에게 두가지 선택지가 주어진다 안녕하세요? 또는 뭐 원하세요?
//3.플레이어가 선택한 내용에 따라 다른 대화로 진행