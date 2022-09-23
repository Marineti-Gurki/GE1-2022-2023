using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myPrefab;
    GameObject g;
    public List<GameObject> listofGs;
    void Start()
    {
        float radius = 1;
        for (int i = 0; i <= 10; i++)
        {
            int numbPrefabs = (int)(2.0f * Mathf.PI * i * radius);
            float theta = Mathf.PI * 2.0f / ((float)numbPrefabs);
            for (int j = 0; j < numbPrefabs; j++)
            {
                float angle = j * theta;
                float x = (radius) * Mathf.Cos(angle) * i;
                float y = (radius) * Mathf.Sin(angle) * i;
                g = Instantiate(myPrefab, new Vector3(x, 0, y), Quaternion.identity);
            }
            listofGs.Add(g);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(0.1f, 0, 0.1f);
        for (int i = 0; i < listofGs.Count - 1; i++)
        {
            listofGs[i].transform.Rotate(0.1f, 0, 0.1f);
        }
    }
}
