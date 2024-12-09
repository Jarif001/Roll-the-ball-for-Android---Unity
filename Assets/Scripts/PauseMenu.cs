using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject BgAudio;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {

            if (GameIsPaused)
            {
                Resume();
            }
            else {
                Pause();
            }
        
        }
    }

    public void Resume() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        BgAudio.SetActive(true);
    }

    public void Pause() {

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        BgAudio.SetActive(false);
    }
    public void LoadMenu() {
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame() {
        Application.Quit();
    }
    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);    
    }

}

