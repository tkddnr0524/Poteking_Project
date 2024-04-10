using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // 카메라가 따라다닐 대상(플레이어 등)
    public float smoothSpeed = 0.125f; // 카메라의 이동 속도
    public Vector3 offset; // 카메라의 위치 조정 값

    private Vector2 minBounds; // 맵의 최소 좌표
    private Vector2 maxBounds; // 맵의 최대 좌표

    void Start()
    {
        // 초기 맵의 최소, 최대 좌표 계산
        CalculateBounds();
    }

    void FixedUpdate()
    {
        if (target == null)
            return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // 동적으로 계산된 맵의 크기에 따라 카메라 이동 제한
        float clampedX = Mathf.Clamp(smoothedPosition.x, minBounds.x, maxBounds.x);
        float clampedY = Mathf.Clamp(smoothedPosition.y, minBounds.y, maxBounds.y);

        transform.position = new Vector3(clampedX, clampedY, transform.position.z);
    }

    void CalculateBounds()
    {
        // 현재 씬에 있는 모든 Sprite의 경계를 고려하여 맵의 최소, 최대 좌표 계산
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
