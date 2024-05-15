using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EventData", menuName = "EventData/New Event", order = 1)]
public class EventData : ScriptableObject
{
    public string eventName; // 이벤트 이름
    public string eventEffect; //실행될 이벤트 효과
    public int limit = 1; // 발생 횟수 제한, 기본값은 1

    // 이벤트 발생 시 호출되는 메서드
    public void TriggerEvent()
    {
        if (limit > 0) // 발생 횟수 제한이 남아 있는 경우
        {
            Debug.Log(eventName + " 발생!"); // 이벤트 발생
            limit--; // 발생 횟수 제한 감소
        }
        else
        {
            Debug.Log(eventName + " 더 이상 발생 불가!"); // 발생 횟수 제한에 도달한 경우
        }
    }

   
}