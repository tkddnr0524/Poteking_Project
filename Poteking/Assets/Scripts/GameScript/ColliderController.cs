using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{
    public void ToggleCollider(bool enable)
    {
        Collider collider = GetComponent<Collider>();
        if (collider != null)
        {
            collider.enabled = enable;
        }
        else
        {
            Debug.LogWarning("Collider 컴포넌트를 찾을 수 없습니다.");
        }
    }
}