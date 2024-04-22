using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Transform obstacleParent; 
    public GameObject obstaclePrefab; 

    private int currentLevel;
    private bool levelComplete;

    void Start()
    {
        InitializeLevel();
    }

    public void InitializeLevel()
    {
        currentLevel = 1;
        levelComplete = false;
        SetupLevel(currentLevel);
    }

    void SetupLevel(int level)
    {
        ClearObstacles();

        SpawnObstaclesForLevel(level);

    }

    void ClearObstacles()
    {
        foreach (Transform child in obstacleParent)
        {
            Destroy(child.gameObject);
        }
    }

    void SpawnObstaclesForLevel(int level)
    {
  
        for (int i = 0; i < 5; i++) 
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-5f, 5f), Random.Range(-3f, 3f), 0f); 
            Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity, obstacleParent);
        }
    }

    public void LevelComplete()
    {
        levelComplete = true;

        Debug.Log("Level Complete!");
    }

    public void ResetLevel()
    {
        SetupLevel(currentLevel);
        levelComplete = false;
    }
}
