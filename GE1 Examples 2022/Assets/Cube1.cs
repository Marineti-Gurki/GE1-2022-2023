using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1 : MonoBehaviour
{
    // Start is called before the first frame update
<<<<<<< Updated upstream
    void Start()
    {
        
=======
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
<<<<<<< Updated upstream

                
                GameObject g = Instantiate(myPrefab, new Vector3(x, 0, y), Quaternion.identity);
=======
                GameObject g = Instantiate(myPrefab, new Vector3(x, 0, y), Quaternion.identity);
                g.GetComponent<Renderer>().material.color = Color.HSVToRGB(j / (float)numbPrefabs, 1, 1);

>>>>>>> Stashed changes
                listofGs.Add(g);
            }
        }
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        transform.Translate(0, 0, 1);
=======
        // g.transform.Rotate(0.1f, 0, 0.1f);
        // transform.Rotate(0.1f, 0, 0.1f);
        for (int i = 0; i < listofGs.Count; i++)
        {
            listofGs[i].transform.Rotate(300*Time.deltaTime, 0, 300*Time.deltaTime);
        }
>>>>>>> Stashed changes
=======
        for (int i = 0; i < listofGs.Count; i++)
        {
            listofGs[i].transform.Rotate(speed * Time.deltaTime, 0, speed * Time.deltaTime);
        }

>>>>>>> Stashed changes
    }
}
