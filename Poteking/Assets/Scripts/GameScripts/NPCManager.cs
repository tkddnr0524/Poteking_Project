using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public Entity_Dialogue entity_Dialogue;

    public void Start()
    {

    }

    public Entity_Dialogue.Param GetParamData(int npc, int gamestate)                 //npc ��ȣ�� ���� ���� ������ ���̾�α� Ŭ������ �޾ƿ� 
    {
        foreach (Entity_Dialogue.Param param in entity_Dialogue.sheets[0].list)
        {
            if (param.npc == npc && param.gamestate == gamestate)
            {
                return param;
            }
        }
        //�ش� �����Ͱ� ���� ��� null ��ȯ 
        return null;
    }
}
