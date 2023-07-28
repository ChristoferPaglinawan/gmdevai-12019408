using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject secondObstacle;
    GameObject[] agents;

    private void Start() 
    {
        agents = GameObject.FindGameObjectsWithTag("agent");    
    }

    private void Update() 
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray.origin, ray.direction, out hit))
            {
                Instantiate(obstacle, hit.point, obstacle.transform.rotation);
                foreach(GameObject a in agents)
                {
                    a.GetComponent<AIControl>().DetectNewObstacle(hit.point);
                }
            }
        }
        if(Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray.origin, ray.direction, out hit))
            {
                Instantiate(secondObstacle, hit.point, secondObstacle.transform.rotation);
                foreach(GameObject a in agents)
                {
                    a.GetComponent<AIControl>().FlockTowardsObstacle(hit.point);
                }
            }
        }     
    }
}
