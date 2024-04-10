using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCObject : MonoBehaviour
{
    // NPC ������ ID
    public int npcId;

    // NPC ������
    private NPCData npcData;

    
    // NPC ��ȭ ������
    public DialogueData dialogueData;

    
   

    private void Start()
    {
       

        // NPC �Ŵ������� �ش� NPC ID�� ���� NPC ������ ��������
        npcData = NPCManager.Instance.GetNPCData(npcId);

        if (npcData != null)
        {
            // NPC �����͸� ����Ͽ� �����ϱ�
            Debug.Log("NPC Name: " + npcData.npcName);
            Debug.Log("Is NPC: " + npcData.isNPC);
            // �ʿ��� �������� ������ �� �ֽ��ϴ�.

            // ��ȭ ������ ����
            if (npcData.dialogueData != null)
            {
                dialogueData = npcData.dialogueData;
            }
        }
    }
}
