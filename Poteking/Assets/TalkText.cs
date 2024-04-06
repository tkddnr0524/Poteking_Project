using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TalkText : MonoBehaviour
{
    public TextData textData;
    public Image textImage; //텍스트창 이미지
    public Text npcText;
    private int currentIndex = 0;//현재 텍스트 인덱스

    void Update()
    {
       //충돌이 감지되었고 엔터키를 입력 받으면 텍스트를 업데이트.
       if(Input.GetKeyDown(KeyCode.Return) && textImage.gameObject.activeSelf)
        {
            if(currentIndex < textData.text.Length)
            {
                npcText.text = textData.text[currentIndex];
                currentIndex++;//인덱스 증가
            }
            else
            {
                //모든 텍스트를 출력했으면 이미지를 비활성화.
                textImage.gameObject.SetActive(false);            
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            //충돌이 감지되면 텍스트 이미지를 활성화하고 첫 번째 텍스트를 출력
            textImage.gameObject.SetActive(true);
            npcText.text = textData.text[currentIndex];
            currentIndex++;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        textImage.gameObject.SetActive(false);
        currentIndex = 0;
    }


}
