
using UnityEngine;
/// <summary>
/// Movement
/// 실제 움직임 구현
/// </summary>
public class Movement : SettingPlayer
{
    private Rigidbody2D body;
    private SpriteRenderer spriteRenderer;

    private Vector2 movement;

    protected override void Awake()
    {
        base.Awake();
        body = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        
    }

    private void Start()
    {
        eventController.MoveEvent += GetMoveDirection;
    }


    private void GetMoveDirection(Vector2 _direction)
    {
        movement = _direction;
    }


    private void FixedUpdate()
    {
        ApplyMovement(movement, characterSO);
        FlipRenderer(movement);
    }

    private void ApplyMovement(Vector2 _direction, CharacterSO _so)
    {
        // 5는 추후에 스피드 나오면 바꿔줄것.
        _direction *= _so.speed;
        body.velocity = _direction;
    }

    private void FlipRenderer(Vector2 _direction)
    {
        if (_direction.x == 0)
        {
            return;
        }
        spriteRenderer.flipX = (_direction.x < 0);
    }

}
