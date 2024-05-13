using UnityEngine;

using System;
/// <summary>
/// EventController
/// ��� Event�� ����ְ� ȣ�����ִ� ��ü (subject)
/// </summary>
public class EventController : MonoBehaviour
{
    public event Action<Vector2> MoveEvent;
    public event Action<Vector2> LookEvent;
    public event Action<CharacterSO> CharacterEvent;
    public event Action<string> NameEvent;
    public event Action<float> InteractEvent;

    public event Action AttackEvent;

    public void NotifyMoveEvent(Vector2 _direction)
    {
        MoveEvent?.Invoke(_direction);
    }

    public void NotifyLookEvent(Vector2 _direction)
    {
        LookEvent?.Invoke(_direction);
    }

    public void NotifyAttackEvent()
    {
        AttackEvent?.Invoke();
    }

    public void NotifyInteractEvent(float _value)
    {
        InteractEvent?.Invoke(_value);
    }

}
