using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideforce = 5f;
    public float sidePCForce = 20f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        float temp = Input.acceleration.x;
        transform.Translate(temp*sideforce* Time.deltaTime,0,0);

        if (Input.GetKey("d")) {
            rb.AddForce(sidePCForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidePCForce * Time.deltaTime, 0, 0);
        }

        if (transform.position.y < -1.3f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
