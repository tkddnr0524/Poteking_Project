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
            Debug.LogWarning("Collider ������Ʈ�� ã�� �� �����ϴ�.");
        }
    }
}