using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InteractiveAction : MonoBehaviour
{
    ObjectData currentObject;
    public TalkAction talkAction;

    private void Awake()
    {
        /* talkAction = GetComponent<TalkAction>();*/
        talkAction = FindObjectOfType<TalkAction>();
    }


    void OnTriggerEnter2D(Collider2D scanObject)
    {
        ObjectData isObject = scanObject.GetComponent<ObjectData>();
        if (isObject != null)
        {
            if (!talkAction.isAction)
            {

                currentObject = isObject;
                Debug.Log(scanObject.name + "와 충돌하였습니다");
            }

        }


    }

    private void OnTriggerExit2D(Collider2D scanObject)
    {
        ObjectData isObject = scanObject.GetComponent<ObjectData>();
        if (isObject != null && isObject == currentObject)
        {
            currentObject = null;
            Debug.Log(scanObject.name + "와 충돌이 끝났습니다");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentObject != null && Input.GetKeyDown(KeyCode.F))
        {
            talkAction.Action(currentObject.gameObject);
            {
                Debug.Log("액션실행");
            }
            Debug.Log("상호작용");
        }
    }
}
