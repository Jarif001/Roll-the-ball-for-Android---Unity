using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    public void ContinueScene() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    
    }
}
