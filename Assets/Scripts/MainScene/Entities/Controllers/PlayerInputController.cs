using UnityEngine;
using UnityEngine.InputSystem;
/// <summary>
/// PlayerInputController
/// 플레이어의 Input을 받아와서 데이터 전달.
/// </summary>
public class PlayerInputController : EventController
{
    Camera camera;

    private void Awake()
    {
        //base.Awake();
        camera = Camera.main;
    }

    public void OnMove(InputValue _value)
    {
        Vector2 direction = _value.Get<Vector2>().normalized;
        NotifyMoveEvent(direction);
    }

    public void OnLook(InputValue _value)
    {
        Vector2 currentAim = _value.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(currentAim);
        currentAim = (worldPos - (Vector2)transform.position).normalized;

        if(currentAim.magnitude >= .9f)
        {
            NotifyLookEvent(currentAim);
        }
    }

    public void OnInteract(InputValue _value)
    {
        float isTrue = _value.Get<float>();
        NotifyInteractEvent(isTrue);
    }

    //public void OnFire(InputValue _value)
    //{
    //      NotifyAttackEvent();
    //}
}
