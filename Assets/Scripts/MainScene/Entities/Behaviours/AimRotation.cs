using System;
using UnityEngine;

public class AimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer mainRenderer;

    private EventController eventController;
    private Vector2 aimDirection = Vector2.right;

    private void Awake()
    {
        eventController = GetComponent<EventController>();

        eventController.LookEvent += GetAimDirection;
    }

    private void GetAimDirection(Vector2 _direction)
    {
        aimDirection = _direction;
    }

    //private void FixedUpdate()
    //{
    //    FlipRenderer();
    //}

    //private void FlipRenderer()
    //{
    //    float RotateAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;

    //    mainRenderer.flipX = Mathf.Abs(RotateAngle) >= 90.0f;
    //}
}