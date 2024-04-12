using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // ī�޶� ����ٴ� ���(�÷��̾� ��)
    public float smoothSpeed = 0.125f; // ī�޶��� �̵� �ӵ�
    public Vector3 offset; // ī�޶��� ��ġ ���� ��

    private Vector2 minBounds; // ���� �ּ� ��ǥ
    private Vector2 maxBounds; // ���� �ִ� ��ǥ

    void Start()
    {
        // �ʱ� ���� �ּ�, �ִ� ��ǥ ���
        CalculateBounds();
    }

    void FixedUpdate()
    {
        if (target == null)
            return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // �������� ���� ���� ũ�⿡ ���� ī�޶� �̵� ����
        float clampedX = Mathf.Clamp(smoothedPosition.x, minBounds.x, maxBounds.x);
        float clampedY = Mathf.Clamp(smoothedPosition.y, minBounds.y, maxBounds.y);

        transform.position = new Vector3(clampedX, clampedY, transform.position.z);
    }

    void CalculateBounds()
    {
        // ���� ���� �ִ� ��� Sprite�� ��踦 ����Ͽ� ���� �ּ�, �ִ� ��ǥ ���
        SpriteRenderer[] sprites = FindObjectsOfType<SpriteRenderer>();
        if (sprites.Length > 0)
        {
            minBounds = sprites[0].bounds.min;
            maxBounds = sprites[0].bounds.max;

            foreach (SpriteRenderer sprite in sprites)
            {
                minBounds = Vector2.Min(minBounds, sprite.bounds.min);
                maxBounds = Vector2.Max(maxBounds, sprite.bounds.max);
            }
        }
    }
}