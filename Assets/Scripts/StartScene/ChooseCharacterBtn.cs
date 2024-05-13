using UnityEngine;
using UnityEngine.UI;

public class ChooseCharacterBtn : MonoBehaviour
{
    private Image characterImage;
    private DataManager dataManager;
    [SerializeField] private GameObject choosePanel;
    [SerializeField] private CharacterSO SO1;
    [SerializeField] private CharacterSO SO2;

    private void Awake()
    {
        characterImage = GetComponent<Image>();
    }

    private void Start()
    {
        dataManager = DataManager.Instance;
    }

    private void Update()
    {
        characterImage.sprite = dataManager.characterSO.sprite;
    }

    public void ChooseButton()
    {
        choosePanel.SetActive(true);
    }

    public void ChooseCharacter1()
    {
        if(SO1 !=  null)
        {
            dataManager.characterSO = Instantiate(SO1);
        }

        choosePanel.SetActive(false);
    }

    public void ChooseCharacter2()
    {
        if (SO2 != null)
        {
            dataManager.characterSO = Instantiate(SO2);
        }

        choosePanel.SetActive(false);
    }
}
