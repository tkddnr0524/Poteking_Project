using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClickText : MonoBehaviour
{

    public TextMeshProUGUI notificationText; //클릭 텍스트를 넣을 공간
    // Start is called before the first frame update
    void Start()
    {
        notificationText.text = "대화창 열기"; //텍스트 내용으로 대화창 열기 출력  
    }

    
}
