using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject smartPhone; //����Ʈ�� �̹��� ���� ����
    public GameObject notification1; // ù��° �˸�â �̹��� ���� ����
    public GameObject notification2; // �ι�° �˸�â �̹��� ���� ����

    void Start()
    {
        //������ ���۵Ǹ� �˸�â�� ��Ȱ��ȭ ���·� �����س���
        notification1.SetActive(false);
        notification2.SetActive(false);

        //������ �˸�â�� ���� Ȱ��ȭ ������ ����
        Invoke("ActiveNotification1", 3f);
        Invoke("ActiveNotification2", 6f);
        
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
}
