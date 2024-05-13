using UnityEngine;
using UnityEngine.UI;

public class NamePanel : MonoBehaviour
{
    private DataManager dataManager;
    private InputField inputName;
    [SerializeField] private GameObject OKBtn;

    private void Awake()
    {
        if(dataManager == null)
        {
            dataManager = DataManager.Instance;
            inputName = GetComponentInChildren<InputField>();
        }
    }

    public void SetNameButton()
    {
        string settingName = inputName.text;
        if(settingName.Length >= 2 && settingName.Length <= 10) 
        {
            dataManager.setName(settingName);
            OKBtn.SetActive(true);
        }
    }

    public void OKButton()
    {
        gameObject.SetActive(false);
        OKBtn.SetActive(false);
        Time.timeScale = 1.0f;
    }
}