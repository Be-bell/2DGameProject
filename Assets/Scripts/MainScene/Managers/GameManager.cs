using UnityEngine;

public class GameManager : EventController
{
    public static GameManager Instance;

    public Transform Player { get; private set; }
    [SerializeField] public string playerTag { get; } = "Player";

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }


        Instance = this;
        DontDestroyOnLoad(gameObject);

        Player = GameObject.FindGameObjectWithTag(playerTag).transform;
    }
}