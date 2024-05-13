using UnityEngine;
using UnityEngine.UI;

public class SettingPlayer : MonoBehaviour
{
    protected EventController eventController { get; private set; }
    protected DataManager dataManager { get; private set; }

    protected Animator animator { get; private set; }
    protected CharacterSO characterSO { get; private set; }

    protected Text nameTxt; 

    protected virtual void Awake()
    {
        if(dataManager == null)
        {
            dataManager = DataManager.Instance;
        }

        animator = GetComponentInChildren<Animator>();
        eventController = GetComponent<EventController>();
        nameTxt = GetComponentInChildren<Text>();
    }

    private void Update()
    {
        Setting();
        ApplyName(dataManager.userName);
    }

    private void Setting()
    {
        characterSO = dataManager.characterSO;

        if (characterSO != null)
        {
            animator.runtimeAnimatorController = characterSO.controller;
        }
    }

    private void ApplyName(string _name)
    {
        if (_name != null)
        {
            nameTxt.text = _name;
        }
    }
}
