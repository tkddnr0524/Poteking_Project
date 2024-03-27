using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectData : MonoBehaviour
{

    public int objectId;
    public bool isNPC;

    TalkManager talkManagerCall;


    void Start()
    {
        talkManagerCall = FindObjectOfType<TalkManager>();

        StartDialogue();
    }
    void StartDialogue()
    {

       talkManagerCall.Action(gameObject);
    }

   
}
