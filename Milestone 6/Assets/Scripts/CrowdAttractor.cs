using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdAttractor : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject secondObstacle;
    GameObject[] agents;
    Vector3 objectPosition;

    private void Start() 
    {
        agents = GameObject.FindGameObjectsWithTag("agent");

        
    }

    private void Update() 
    {
        objectPosition = transform.position;

        foreach(GameObject a in agents)
        {
            a.GetComponent<AIControl>().FlockTowardsObstacle(objectPosition);
        }

    }
}
