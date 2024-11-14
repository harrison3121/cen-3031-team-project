using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int requiredScore = 1000;
    private PlayerCollision playerCollision;


    void Start()
    {
        playerCollision = FindAnyObjectByType<PlayerCollision>();
    }

    void Update()
    {
        if (playerCollision.score >= requiredScore)
        {
            LoadNextLevel();
        }
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
