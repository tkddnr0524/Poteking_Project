using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkAction : MonoBehaviour
{
    public TalkManager talkManager;
    public GameObject talkPanel;
    public Text talkText;
    public GameObject scanObject;
    public bool isAction;
    public int talkIndex;

    public void Action(GameObject scanObj)
    {
        
        scanObject = scanObj;
        ObjectData objectData = scanObject.GetComponent<ObjectData>();
        Talk(objectData.id, objectData.isNPC);
        talkPanel.SetActive(isAction);
    }

    void Talk(int id, bool isNpc)
    {
       string talkData = talkManager.GetTalk(id, talkIndex);
        if (talkData == null)
        {
            isAction = false;
            talkIndex = 0;
            return;
        }

        if (isNpc)
        {
            talkText.text = talkData;
        }
        else
        {
            talkText.text = talkData;

        }

        isAction = true;
        talkIndex++;

    }
}
