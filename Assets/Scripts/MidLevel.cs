using UnityEngine;
using UnityEngine.SceneManagement;

public class MidLevel : MonoBehaviour
{
    public void nextLevel() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    
    }
}
