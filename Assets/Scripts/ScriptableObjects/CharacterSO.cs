using UnityEditor.Animations;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultCharacterSO", menuName = "2DGameSO/Character/Default", order = 0)]
public class CharacterSO : ScriptableObject
{
    [Header("Character Info")]
    public Sprite sprite;
    public AnimatorController controller;

    [Header("Stats Info")]
    public int speed;
    public float MaxHealth;
}
