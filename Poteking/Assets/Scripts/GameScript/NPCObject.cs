using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCObject : MonoBehaviour
{
    // NPC 고유한 ID
    public int npcId;

    // NPC 데이터
    private NPCData npcData;

    
    // NPC 대화 데이터
    public DialogueData dialogueData;

    
   

    private void Start()
    {
       

        // NPC 매니저에서 해당 NPC ID에 대한 NPC 데이터 가져오기
        npcData = NPCManager.Instance.GetNPCData(npcId);

        if (npcData != null)
        {
            // NPC 데이터를 사용하여 설정하기
            Debug.Log("NPC Name: " + npcData.npcName);
            Debug.Log("Is NPC: " + npcData.isNPC);
            // 필요한 설정들을 수행할 수 있습니다.

            // 대화 데이터 설정
            if (npcData.dialogueData != null)
            {
                dialogueData = npcData.dialogueData;
            }
        }
    }
}
