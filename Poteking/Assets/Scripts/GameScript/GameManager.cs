using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class GameManager : MonoBehaviour
{
    public GameObject smartPhone; //����Ʈ�� �̹��� ���� ����
    public GameObject notification1; // ù��° �˸�â �̹��� ���� ����
    public GameObject notification2; // �ι�° �˸�â �̹��� ���� ����
    public GameObject talkImage; //��ȭâ �̹���

    void Start()
    {
        //������ ���۵Ǹ� �˸�â�� ��Ȱ��ȭ ���·� �����س���
        notification1.SetActive(false);
        notification2.SetActive(false);
        talkImage.SetActive(false); 

        //������ �˸�â�� ���� Ȱ��ȭ ������ ����
        Invoke("ActiveNotification1", 2f);
        Invoke("ActiveNotification2", 5f);


        //�˸�â Ŭ�� �̺�Ʈ, Button�� onClick.AddListener(��������Ʈ) �������� �޼��带 �Ҵ� 
        //�޼��忡 ���ڰ� ���� ��� �ٷ� �޼ҵ� �̸����� �Ѱ��ָ� �ȴ�.
        //�� ��° �˸�â�� Ŭ�� �̺�Ʈ ����
        notification2.GetComponent<Button>().onClick.AddListener(OpenTalk);
        
    }

    void ActiveNotification1()
    {
        //ù��° �˸�â �̹����� Ȱ��ȭ 
        {
            notification1.SetActive(true);           
        }
    }

    void ActiveNotification2()
    {
        //�ι�° �˸�â �̹����� Ȱ��ȭ 
        {
            notification2.SetActive(true);
        }
    }

    void OpenTalk() //��ȭâ Ȱ��ȭ �Լ�
    {
        talkImage.SetActive(true);
    }
}
