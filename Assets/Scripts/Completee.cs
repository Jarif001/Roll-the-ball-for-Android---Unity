using UnityEngine;
using UnityEngine.SceneManagement;

public class Completee : MonoBehaviour
{
    public void LoadNextLevel() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
