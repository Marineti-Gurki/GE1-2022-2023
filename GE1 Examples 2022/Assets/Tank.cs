using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float f = Input.GetAxis("Vertical");
        float s = Input.GetAxis("Horizontal");
        Debug.Log("f: " + f);
        transform.Translate(0, 0, f*speed * Time.deltaTime);
        transform.Translate(s*speed * Time.deltaTime, 0, 0);
    }
}
