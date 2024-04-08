using UnityEngine;
using System;
using System.Collections.Generic;

[Serializable]
public class ConversationData : ScriptableObject
{
    [Serializable]
    public class Conversation //��ȭ Ŭ����
    {
        public string conversationID;
        public List<ConversationItem> dialogue;
    }

    public List<Conversation> conversations = new List<Conversation>();
}

[Serializable]
public class ConversationItem
{
    public string text;
}
