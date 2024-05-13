
using UnityEngine;

public class ApplyAnimation : SettingPlayer
{

    private static readonly int hashMove = Animator.StringToHash("isMove");
    [SerializeField] private readonly float magnituteThreshold = 0.5f;

    protected override void Awake()
    {
        base.Awake();
        eventController.MoveEvent += MoveAnim;
    }

    private void MoveAnim(Vector2 vector)
    {
        animator.SetBool(hashMove, vector.magnitude > magnituteThreshold);
    }
}
