
using UnityEngine;
/// <summary>
/// Movement
/// ���� ������ ����
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
        // 5�� ���Ŀ� ���ǵ� ������ �ٲ��ٰ�.
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
