using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject smartPhone; //����Ʈ�� �̹��� ���� ����
    public GameObject notification1; // ù��° �˸�â �̹��� ���� ����
    public GameObject notification2; // �ι�° �˸�â �̹��� ���� ����

    public GameObject chatObject; //Chat = ��ȭâ ������Ʈ�� �� ����
    void Start()
    {
        //���� ���۵Ǹ� Chat ������Ʈ�� ��Ȱ��ȭ
        chatObject.SetActive(false);


        //������ ���۵Ǹ� �˸�â�� ��Ȱ��ȭ ���·� �����س���
        notification1.SetActive(false);
        notification2.SetActive(false);

        //������ �˸�â�� ���� Ȱ��ȭ ������ ����
        Invoke("ActiveNotification1", 2f);
        Invoke("ActiveNotification2", 6f);
        
    }

    void ActiveNotification1()
    {
        //ù��° �˸�â �̹����� Ȱ��ȭ 
        {
            notification1.SetActive(true);           
        }
    }

    // �˸�â�� Ŭ�� ���� �� 
    public void OnNotificationClicked()
    {
        if(chatObject != null)
        {
            //Chat ������Ʈ Ȱ��ȭ
            chatObject.SetActive(true);

            // Chat ������Ʈ�� ��� �ڽ� ������Ʈ(��ȭ ��ǳ���� �ؽ�Ʈ)�� �Բ� Ȱ��ȭ
            foreach (Transform child in chatObject.transform) 
            {
                child.gameObject.SetActive(true);
            }
        }
    }
    void ActiveNotification2()
    {
        //�ι�° �˸�â �̹����� Ȱ��ȭ 
        {
            notification2.SetActive(true);
        }
    }
}
