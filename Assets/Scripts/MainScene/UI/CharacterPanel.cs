using UnityEngine;
using UnityEngine.UI;

public class CharacterPanel : MonoBehaviour 
{
    private DataManager dataManager;
    [SerializeField] private CharacterSO character1;
    [SerializeField] private CharacterSO character2;

    private void Awake()
    {
        if (dataManager == null)
        {
            dataManager = DataManager.Instance;
        }
    }

    public void SetCharacter1()
    {
        dataManager.characterSO = Instantiate(character1);
        gameObject.SetActive(false);
    }

    public void SetCharacter2()
    {
        dataManager.characterSO = Instantiate(character2);
        gameObject.SetActive(false);
    }

    public void Cancel()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1.0f;
    }

    
}