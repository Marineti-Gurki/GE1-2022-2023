using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject myPrefab;
    public List<GameObject> listofGs;
    [SerializeField]
    int speed = 300;
    void Start()
    {

        float radius = 2;
        for (int i = 0; i <= 10; i++)
        {
            int numbPrefabs = (int)(2.0f * Mathf.PI * i * radius);
            float theta = Mathf.PI * 2.0f / ((float)numbPrefabs);
            for (int j = 0; j < numbPrefabs; j++)
            {
                float angle = j * theta;
                float x = (radius) * Mathf.Cos(angle) * i;
                float y = (radius) * Mathf.Sin(angle) * i;


                GameObject g = Instantiate(myPrefab, new Vector3(x, 0, y), Quaternion.identity);
                g.GetComponent<Renderer>().material.color = Color.HSVToRGB(j / (float)numbPrefabs, 1, 1);
                listofGs.Add(g);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, 0, 1);

        for (int i = 0; i < listofGs.Count; i++)
        {
            listofGs[i].transform.Rotate(speed * Time.deltaTime, 0, speed * Time.deltaTime);
        }

    }
}
