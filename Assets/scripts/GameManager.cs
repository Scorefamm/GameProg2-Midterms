using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int bulletIndex;
    public bool isMatching;
    private int kills = 0;
    public TextMeshProUGUI killCount;
    public GameObject GameOverScreen;
    private void Awake()
    {
        // Singleton pattern
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void GetBulletColor(int bulletNum) { bulletIndex = bulletNum; Debug.Log("Getting Bullet Color"); }

    // Checks if bullet is the same color as enemy
    public bool ColorsMatch(int enemyIndex)
    {
        if (enemyIndex == bulletIndex)
            isMatching = true;
        else
            isMatching = false;

        return isMatching;
    }

    // Adds kill count
    public void IncreaseKills() { kills++; Debug.Log("Kills:" + kills); }
    // Adds kill count to game over screen
    void setKillCount() { killCount.text = "Kills: " + kills; }
    // Puts game over screen
    public void GameOver() { GameOverScreen.SetActive(true); setKillCount(); Time.timeScale = 0; }
}
