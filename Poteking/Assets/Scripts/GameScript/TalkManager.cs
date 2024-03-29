using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TalkManager : MonoBehaviour
{
    string[][] talkData; // ��ȭ �����͸� ������ ������ �迭

    void Awake() // Awake �޼��忡�� ȣ���ϵ��� ����
    {
        GenerateData();
    }

    void GenerateData()
    {
        // ��ȭ �����͸� ������ �迭�� �ʱ�ȭ
        talkData = new string[][]
        {
            new string[] { "�ȳ�?", "�� NPC��" }, // ID 1000
            new string[] { "������Ʈ�� �ִ�." }   // ID 100
            // �ʿ��� ��ŭ �߰� ����
        };
    }

    public string GetTalk(int id, int talkIndex)
    {
        // ��ȭ ID�� �迭 ���� ���� �ִ��� Ȯ��
        if (id < 0 || id >= talkData.Length)
            return null;

        // ��ȭ �ε����� �迭 ���� ���� �ִ��� Ȯ��
        if (talkIndex < 0 || talkIndex >= talkData[id].Length)
            return null;

        // ��ȭ ��ȯ
        return talkData[id][talkIndex];
    }
}