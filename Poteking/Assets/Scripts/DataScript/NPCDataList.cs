using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewNPCDataList", menuName = "ScriptableObjects/NPCDataList")]
public class NPCDataList : ScriptableObject
{
    public List<NPCData> npcList = new List<NPCData>();
}

[System.Serializable]
public class NPCData
{
    public string npcName;
    public int npcId;
    public bool isNPC;
    public DialogueData dialogueData;
}
