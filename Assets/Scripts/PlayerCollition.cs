using UnityEngine;

public class PlayerCollition : MonoBehaviour
{
    public PlayerMovement movement;
    public GameManager gameManager;

    void OnCollisionEnter(Collision CollisionInfo) {
        if (CollisionInfo.collider.tag == "Wall") {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
