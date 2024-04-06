using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "NewTalkData", menuName = "TalkData", order = 51)]
public class TextData : ScriptableObject
{
    public string[] text;
}
