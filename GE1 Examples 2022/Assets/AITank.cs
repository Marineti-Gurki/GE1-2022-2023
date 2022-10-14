using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AITank : MonoBehaviour
{

    public float radius = 10;
    public int numWaypoints = 6;
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
            float theta = Mathf.PI * 2.0f / (float)numWaypoints;

            for (int i = 0; i < numWaypoints; i++)
            {
                Vector3 pos = new Vector3(Mathf.Sin(theta * i) * radius, 0, Mathf.Cos(theta * i) * radius);
                pos = transform.TransformPoint(pos);
                Gizmos.DrawWireSphere(pos, 1);
            }
        }
    }

    // Use this for initialization
    void Awake()
    {
        // Task 2
        // Put code here to calculate the waypoints in a loop and 
        // Add them to the waypoints List
        float theta = Mathf.PI * 2.0f / (float)numWaypoints;

        for (int i = 0; i < numWaypoints; i++)
        {
            Vector3 pos = new Vector3(Mathf.Sin(theta * i) * radius, 0, Mathf.Cos(theta * i) * radius);
            pos = transform.TransformPoint(pos);
            waypoints.Add(pos);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Task 3
        // Put code here to move the tank towards the next waypoint
        // When the tank reaches a waypoint you should advance to the next one

        Vector3 AItankPos = transform.position;
        Vector3 toNextPosition = waypoints[current] - AItankPos;
        float dist = toNextPosition.magnitude;
        if (dist < 1)
        {
            current = (current + 1) % waypoints.Count;
        }

        Vector3 direction = toNextPosition / dist;
        transform.position = Vector3.Lerp(transform.position, waypoints[current], Time.deltaTime);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(toNextPosition, Vector3.up), 180 * Time.deltaTime);


        // Task 4
        // Put code here to check if the player is in front of or behine the tank
        Vector3 toPlayer = player.position - transform.position;
        float dot = Vector3.Dot(transform.forward, toPlayer);
        float angle = Mathf.Acos(dot) * Mathf.Rad2Deg;
        if (angle < 45)
        {
            Debug.Log("Inside of fov");
            // GameManager.Log("Hello from th AI tank");
        }
        if (dot > 0)
        {
            Debug.Log("Front");
        }
        else
        {
            Debug.Log("Behind");
        }
        // Task 5
        // Put code here to calculate if the player is inside the field of view and in range
        // You can print stuff to the screen using:

    }
}
