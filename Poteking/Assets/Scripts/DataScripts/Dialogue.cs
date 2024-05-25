using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Choice
{
    public string text; //�������� �ؽ�Ʈ�Դϴ�. �÷��̾ �� �������� �����ϸ� �а� �� 
    public int nextDialogueID; //�� �������� �������� �� �̾����� ��ȭ�� ID�Դϴ�.
}

[System.Serializable]
public class Dialogue
{
    public int id; //��ȭ�� ���� ID. ��ȭ�� �ĺ��ϴ� �� ���
    public string character; //��ȭ�� �ϴ� ĳ������ �̸�
    public string text; // ��ȭ�� ����
    public List<Choice> choices; // ������ ����Ʈ. �÷��̾ ��ȭ �߿� ���� �� �� �ִ� ���� �������� ��� �ִ�.
    public int nextDialogueID; //�������� ���� ��� ���� ��ȭ�� ID�Դϴ�.(�������� ���� ���� �帧 ��ȭ�� �� ���)
}

//���� �ó�����
//1.ĳ���� NPC1�� �÷��̾�� �λ縦 �Ѵ�
//2.�÷��̾�� �ΰ��� �������� �־����� �ȳ��ϼ���? �Ǵ� �� ���ϼ���?
//3.�÷��̾ ������ ���뿡 ���� �ٸ� ��ȭ�� ����