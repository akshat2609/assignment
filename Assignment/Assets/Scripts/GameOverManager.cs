using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameOverUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }    
}
