using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delay : MonoBehaviour
{
    public GameObject lekha1;
    public GameObject lekha2;
    public GameObject buttons;

    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 2) {
            lekha1.SetActive(true);
        }
        if (time > 6) {
            lekha2.SetActive(true);
        }
        if (time > 9) {
            buttons.SetActive(true);
        }
    }
}
