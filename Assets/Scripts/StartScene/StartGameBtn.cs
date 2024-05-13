using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGameBtn : MonoBehaviour
{
    private InputField inputName;
    DataManager dataManager;

    private void Awake()
    {
        if(inputName == null)
        {
            inputName = GetComponentInChildren<InputField>();
        }

        dataManager = DataManager.Instance;
    }

    public void StartButton()
    {
        string name = inputName.text;

        if(name.Length>=2 && name.Length<=10)
        {
            dataManager.setName(inputName.text);
            SceneManager.LoadScene("MainScene");
        }
    }
}
