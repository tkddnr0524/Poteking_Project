using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartphoneController : MonoBehaviour
{    
    public GameObject smartphoneScreen; // ����Ʈ�� ȭ���� ��Ÿ���� GameObject
    bool isScreenOn = false; //����Ʈ�� ȭ�� ����
    void Start()
    {
        // ������ �� ȭ���� ������ ����
        smartphoneScreen.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            ToggleSmartphoneScreen();
        }
    }

    // ����Ʈ�� ȭ���� �Ѱų� ���� �Լ�
    public void ToggleSmartphoneScreen()
    {
        //���� ��ũ���� �ݴ� ���¸� ��ũ�� ���¿� ���� -> ���� ȭ�� ������ �ݴ�� ����
        isScreenOn = !isScreenOn;

        //ȭ���� ���¿� ���� ȭ���� �Ѱų� ����.
        smartphoneScreen.SetActive(isScreenOn);
    }
}
