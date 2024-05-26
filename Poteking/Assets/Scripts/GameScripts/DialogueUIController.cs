using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueUIController : MonoBehaviour
{
    //²ô°í Å³ UI¿ä¼Ò
    public Image backGround;
    public Image leftFace;
    public Image rightFace;
    public GameObject dialogueBox;
    public Text dialogueText;
    public GameObject NPCNameBox;
    public Text NPCName;
    

    public void ActiveUI(bool dialogueState)
    {
        
        if (backGround != null) backGround.gameObject.SetActive(dialogueState);
        if (dialogueBox != null) dialogueBox.SetActive(dialogueState);
        if (dialogueText != null) dialogueText.gameObject.SetActive(dialogueState);
        if (NPCNameBox != null) NPCNameBox.SetActive(dialogueState);
        if (NPCName != null) NPCName.gameObject.SetActive(dialogueState);
    }

    
    public void LeftFaceUi(bool dialogueState)
    {
        if (leftFace != null) leftFace.gameObject.SetActive(dialogueState);

    }
    public void RightFaceUi(bool dialogueState)
    {
        if (rightFace != null) rightFace.gameObject.SetActive(dialogueState);
    }

}
