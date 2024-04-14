using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    // NPC ������ ���
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

        // NPC ������ ����� �Ҵ�Ǿ����� Ȯ��
        if (npcDataList == null)
        {
            Debug.LogError("NPC data list is not assigned in NPCManager.");
        }
    }

    // NPC�� ������ ID�� ���� NPC �����͸� �������� �Լ�
    public NPCData GetNPCData(int npcId)
    {
        foreach (NPCData npcData in npcDataList.npcList)
        {
            if (npcData.npcId == npcId)
            {
                return npcData;
            }
        }
        
        // �ش� ������ ID�� �´� NPC �����Ͱ� ���� ��� ���� ���
        Debug.LogError("NPC data not found for unique ID: " + npcId);
        return null;
    }
}
