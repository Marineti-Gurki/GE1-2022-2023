using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myPrefab;

    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            float radius = 1;
            float xPos = Mathf.PI * radius * Mathf.Cos(i);
            float yPos = Mathf.PI * radius * Mathf.Sin(i);
            Instantiate(myPrefab, new Vector3(xPos, 0, yPos), Quaternion.identity);
            for (int j = 0; j < i; j++)
            {
                float xPos2 = Mathf.PI * (radius * 3) * Mathf.Cos(j);
                float yPos2 = Mathf.PI * (radius * 3) * Mathf.Sin(j);
                Instantiate(myPrefab, new Vector3(xPos2, 0, yPos2), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.1f, 0, 0.1f);
    }
}
