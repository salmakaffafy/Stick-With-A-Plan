using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; 

    public UIManager uiManager;
    public LevelManager levelManager;
    public LivesManager livesManager;
    public ScoreManager scoreManager;
    public BounceTriggerManager bounceTriggerManager;
    public CharacterManager characterManager;

    private int playerLives;
    private int currentLevel;
    private int currentScore;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        InitializeGame();
    }

    void InitializeGame()
    {
        playerLives = 3;
        currentLevel = 1;
        currentScore = 0;

        uiManager.InitializeUI();
        levelManager.InitializeLevel();
        scoreManager.InitializeScore();
        CharacterManager.InitializeCharacter;
 
    }

    public void PlayerDied()
    {
        playerLives--;
        if (playerLives <= 0)
        {
            Debug.Log("Game Over");
        }
        else
        {
            levelManager.ResetLevel();
        }
    }


}
