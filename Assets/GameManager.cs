using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    public GameObject CompleteUI;
    public GameObject GameOverBtn;
    public GameObject BgAudio;
    public void CompleteLevel() {
        CompleteUI.SetActive(true);
        LoadNextLevel();
    }
    public void LoadNextLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void EndGame() {

        if (GameHasEnded == false) {
            GameHasEnded = true;
            Debug.Log("Game Over");
            BgAudio.SetActive(false);
            GameOverBtn.SetActive(true);
            
        }
        
    void restart() {

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }
}
