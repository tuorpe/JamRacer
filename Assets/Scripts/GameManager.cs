using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    [Header("Game State Variables")]
    [SerializeField] public bool isPlaying = false;
    [SerializeField] public bool isPaused = false;
    [SerializeField] public bool isGameOver = false;
    [SerializeField] public bool isMainMenu = true;
    [SerializeField] public bool isInGameMenu = false;

    [Header("Player Stats")]
    [SerializeField] public float gameTime = 0f;
    [SerializeField] public int score = 0;
    [SerializeField] public int lives = 3;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
