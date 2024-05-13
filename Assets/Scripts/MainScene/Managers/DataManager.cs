using UnityEngine;

public class DataManager : MonoBehaviour 
{
    public static DataManager Instance;

    public string userName { get; private set; }
    [SerializeField] private CharacterSO defaultSO;

    public CharacterSO characterSO {
        get { return defaultSO; }
        set { defaultSO = value; }
    }

    private void Awake()
    {
        if(Instance != null) 
        { 
            Destroy(Instance);
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);

        if(characterSO == null)
        {
            characterSO = Instantiate(defaultSO);
        }

    }

    public void setName(string _name)
    {
        userName = _name;
    }
}