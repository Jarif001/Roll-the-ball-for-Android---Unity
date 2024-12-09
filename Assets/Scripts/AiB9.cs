using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiB9 : MonoBehaviour
{
    public float speed = 2.5f;

   
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 6),0,transform.position.z);
    }
}
