using UnityEngine;

public class MainUI : MonoBehaviour
{
    [SerializeField] private GameObject MenuPanel;

    public void MenuButton()
    {
        Time.timeScale = 0.0f;
        MenuPanel.SetActive(true);
    }

}