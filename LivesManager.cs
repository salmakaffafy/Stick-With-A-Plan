using UnityEngine;

public class LivesManager : MonoBehaviour
{
    public int startingLives = 3; 
    private int currentLives;

    public UIManager uiManager;

    void Start()
    {
        InitializeLives();
    }

    void InitializeLives()
    {
        currentLives = startingLives;
        UpdateUI();
    }

    public void LoseLife()
    {
        currentLives--;
        UpdateUI();

        if (currentLives <= 0)
        {
            GameManager.instance.PlayerDied();
        }
    }

    void UpdateUI()
    {
        if (uiManager != null)
        {
            uiManager.UpdateLifeCounter(currentLives);
        }
    }

    public void ResetLives()
    {
        currentLives = startingLives;
        UpdateUI();
    }
}
