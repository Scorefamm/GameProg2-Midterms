using UnityEngine;

public class RedDestroy : MonoBehaviour
{
    private int index = 0;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enemy Got Shot");
        if (other.CompareTag("Bullet"))
        {
            if (GameManager.instance.ColorsMatch(index))
            {
                //Enemy Destroy
                Destroy(other.gameObject);
                GameManager.instance.IncreaseKills();
                Destroy(gameObject);
            }
            else
                Destroy(other.gameObject);
        }
        // Puts game over screen once enemy hits player
        if (other.CompareTag("Player"))
        {
            GameManager.instance.GameOver();
            Destroy(gameObject);
        }
    }
}