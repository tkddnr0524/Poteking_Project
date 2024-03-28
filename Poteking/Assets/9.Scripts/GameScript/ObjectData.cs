using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectData : MonoBehaviour
{

    public int id;
    public bool isNPC;

    TalkAction talkActionCall;


    void Start()
    {
        talkActionCall = FindObjectOfType<TalkAction>();

        //StartDialogue();
    }
    void StartDialogue()
    {

        talkActionCall.Action(gameObject);


    }


}
