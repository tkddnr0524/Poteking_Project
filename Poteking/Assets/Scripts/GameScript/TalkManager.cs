using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TalkManager : MonoBehaviour
{
    string[][] talkData; // 대화 데이터를 저장할 이차원 배열

    void Awake() // Awake 메서드에서 호출하도록 변경
    {
        GenerateData();
    }

    void GenerateData()
    {
        // 대화 데이터를 이차원 배열로 초기화
        talkData = new string[][]
        {
            new string[] { "안녕?", "난 NPC야" }, // ID 1000
            new string[] { "오브젝트가 있다." }   // ID 100
            // 필요한 만큼 추가 가능
        };
    }

    public string GetTalk(int id, int talkIndex)
    {
        // 대화 ID가 배열 범위 내에 있는지 확인
        if (id < 0 || id >= talkData.Length)
            return null;

        // 대화 인덱스가 배열 범위 내에 있는지 확인
        if (talkIndex < 0 || talkIndex >= talkData[id].Length)
            return null;

        // 대화 반환
        return talkData[id][talkIndex];
    }
}