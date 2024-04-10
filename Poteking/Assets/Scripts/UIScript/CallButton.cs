using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallButton : MonoBehaviour
{
    public GameObject callUI; // ��ȭ�� �̹��� ����
    private bool isOnCall = false; //���� ��ȭ�ΰ� �����ִ��� Ȯ��
    // Start is called before the first frame update
    void Start()
    {
        callUI.SetActive(false); // ���� �� ��ȭ�� ��Ȱ��ȭ
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V)) //V������ ê ����
        {
            callUI.SetActive(false);
        }
    }

    public void OnCallActiveClick()
    {
        isOnCall = !isOnCall;
        callUI.SetActive(isOnCall);
    }
}
