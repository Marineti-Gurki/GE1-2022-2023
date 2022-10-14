using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AITank : MonoBehaviour
{

    public float radius = 10;
    public int numWaypoints = 5;
    public int current = 0;
    List<Vector3> waypoints = new List<Vector3>();
    public float speed = 10;
    public Transform player;

    public void OnDrawGizmos()
    {
        if (!Application.isPlaying)
        {
            // Task 1
            // Put code here to draw the gizmos
            // Use sin and cos to calculate the positions of the waypoints 
            // You can draw gizmos using

            Gizmos.color = Color.green;
            int rings = 3;
            int somethingelse = 10;
            float theta = Mathf.PI * 2.0f / (float)somethingelse;
            for (int ring = 1; ring < rings; ring++)
            {
                int count = Mathf.RoundToInt(Mathf.PI * 2.0f * ring);
                for (int i = 0; i < count; i++)
                {
                    Vector3 pos = new Vector3(Mathf.Sin(theta * i) * radius, 0, Mathf.Cos(theta * i) * radius);
                    pos = transform.TransformPoint(pos);

                    Gizmos.DrawWireSphere(pos, 1);
                }
            }
        }
    }

    // Use this for initialization
    void Awake()
    {
        // Task 2
        // Put code here to calculate the waypoints in a loop and 
        // Add them to the waypoints List
    }

    // Update is called once per frame
    void Update()
    {
        // Task 3
        // Put code here to move the tank towards the next waypoint
        // When the tank reaches a waypoint you should advance to the next one


        // Task 4
        // Put code here to check if the player is in front of or behine the tank
        // Task 5
        // Put code here to calculate if the player is inside the field of view and in range
        // You can print stuff to the screen using:
        GameManager.Log("Hello from th AI tank");
    }
}
