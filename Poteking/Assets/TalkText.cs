using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TalkText : MonoBehaviour
{
    public TextData textData;
    public Image textImage; //�ؽ�Ʈâ �̹���
    public Text npcText;
    private int currentIndex = 0;//���� �ؽ�Ʈ �ε���

    void Update()
    {
       //�浹�� �����Ǿ��� ����Ű�� �Է� ������ �ؽ�Ʈ�� ������Ʈ.
       if(Input.GetKeyDown(KeyCode.Return) && textImage.gameObject.activeSelf)
        {
            if(currentIndex < textData.text.Length)
            {
                npcText.text = textData.text[currentIndex];
                currentIndex++;//�ε��� ����
            }
            else
            {
                //��� �ؽ�Ʈ�� ��������� �̹����� ��Ȱ��ȭ.
                textImage.gameObject.SetActive(false);            
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            //�浹�� �����Ǹ� �ؽ�Ʈ �̹����� Ȱ��ȭ�ϰ� ù ��° �ؽ�Ʈ�� ���
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
