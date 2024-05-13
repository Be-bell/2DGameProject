using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    [SerializeField] private GameObject setNamePanel;
    [SerializeField] private GameObject setCharacterPanel;

    private Button[] Buttons;

    private void Awake()
    {
        Buttons = GetComponentsInChildren<Button>();
    }

    public void QuitMenu()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void ChangeName()
    {
        setNamePanel.SetActive(true);
        gameObject.SetActive(false);
    }

    public void ChangeCharacter()
    {
        setCharacterPanel.SetActive(true);
        gameObject.SetActive(false);
    }

}