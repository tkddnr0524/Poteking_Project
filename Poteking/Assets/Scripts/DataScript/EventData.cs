using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EventData", menuName = "EventData/New Event", order = 1)]
public class EventData : ScriptableObject
{
    public string eventName; // �̺�Ʈ �̸�
    public string eventEffect; //����� �̺�Ʈ ȿ��
    public int limit = 1; // �߻� Ƚ�� ����, �⺻���� 1

    // �̺�Ʈ �߻� �� ȣ��Ǵ� �޼���
    public void TriggerEvent()
    {
        if (limit > 0) // �߻� Ƚ�� ������ ���� �ִ� ���
        {
            Debug.Log(eventName + " �߻�!"); // �̺�Ʈ �߻�
            limit--; // �߻� Ƚ�� ���� ����
        }
        else
        {
            Debug.Log(eventName + " �� �̻� �߻� �Ұ�!"); // �߻� Ƚ�� ���ѿ� ������ ���
        }
    }

   
}