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
    public GameObject npcNameBox;
    public Text npcName;
    public GameObject choiceBox;
    public Text choice1Text;
    public Text choice2Text;


    public void ActiveUI(bool dialogueState)
    {
        
        if (backGround != null) backGround.gameObject.SetActive(dialogueState);
        if (dialogueBox != null) dialogueBox.SetActive(dialogueState);
        if (dialogueText != null) dialogueText.gameObject.SetActive(dialogueState);
        if (npcNameBox != null) npcNameBox.SetActive(dialogueState);
        if (npcName != null) npcName.gameObject.SetActive(dialogueState);
        
    }

    
    public void LeftFaceUi(bool dialogueState)
    {
        if (leftFace != null) leftFace.gameObject.SetActive(dialogueState);

    }
    public void RightFaceUi(bool dialogueState)
    {
        if (rightFace != null) rightFace.gameObject.SetActive(dialogueState);
    }

    public void ChoiceUi(bool dialogueState)
    {
        if (npcName != null) choiceBox.SetActive(dialogueState);
        if (npcName != null) choice1Text.gameObject.SetActive(dialogueState);
        if (npcName != null) choice2Text.gameObject.SetActive(dialogueState);
    }
}
