using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // ĳ���͸� ����ٴϰ� �� ��� (ĳ������ Transform)

    public float smoothSpeed = 0.125f; // ī�޶� �̵� �ӵ�
    public Vector3 offset; // ī�޶�� ��� ������ �Ÿ��� �����ϱ� ���� ������

    public Vector2 minBounds; // ���� �ּ� ���
    public Vector2 maxBounds; // ���� �ִ� ���

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // ĳ���Ͱ� ���� ��踦 ����� ���ϵ��� ����
        float clampedX = Mathf.Clamp(transform.position.x, minBounds.x, maxBounds.x);
        float clampedY = Mathf.Clamp(transform.position.y, minBounds.y, maxBounds.y);
        transform.position = new Vector3(clampedX, clampedY, transform.position.z);
    }
}