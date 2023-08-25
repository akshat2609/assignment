using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    public Button restartButton;
    public Button quitButton;

    private void Start()
    {
        restartButton.onClick.AddListener(RestartGame);
        quitButton.onClick.AddListener(ReturnToMainMenu);
    }

    
    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    
    void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); 
    }
}
