using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    
    void Start()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }


    void GenerateData()
    {
        //npc
        talkData.Add(1000, new string[] { "�ȳ�?", "�� NPC��" });
        //object
        talkData.Add(100, new string[] { "������Ʈ�� �ִ�." });

    }

    public string GetTalk(int id, int talkIndex)
    {


        if (talkIndex == talkData[id].Length) 
            return null;
        else
            return talkData[id][talkIndex];
    }
}
