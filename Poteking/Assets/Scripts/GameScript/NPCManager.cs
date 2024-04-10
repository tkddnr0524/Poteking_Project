using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    // NPC 데이터 목록
    public NPCDataList npcDataList;

    // Singleton instance
    private static NPCManager instance;
    public static NPCManager Instance { get { return instance; } }

    private void Awake()
    {
        // Singleton pattern
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }

        // NPC 데이터 목록이 할당되었는지 확인
        if (npcDataList == null)
        {
            Debug.LogError("NPC data list is not assigned in NPCManager.");
        }
    }

    // NPC의 고유한 ID를 통해 NPC 데이터를 가져오는 함수
    public NPCData GetNPCData(int npcId)
    {
        foreach (NPCData npcData in npcDataList.npcList)
        {
            if (npcData.npcId == npcId)
            {
                return npcData;
            }
        }
        
        // 해당 고유한 ID에 맞는 NPC 데이터가 없을 경우 에러 출력
        Debug.LogError("NPC data not found for unique ID: " + npcId);
        return null;
    }
}
