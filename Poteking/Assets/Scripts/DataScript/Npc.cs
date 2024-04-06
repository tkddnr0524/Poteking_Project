using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    public NpcData npcData;

    private void Start()
    {
        if(npcData != null)
        {
            Debug.Log("Npc Name : " + npcData.name);
            Debug.Log("Npc ID : " + npcData.id);
        }
    }
}
