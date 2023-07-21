using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    GameObject[] agents;

    GameObject player;

    private void Start() 
    {
        agents = GameObject.FindGameObjectsWithTag("AI");
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update() 
    {
        foreach (GameObject ai in agents)
        {
            ai.GetComponent<AIControl>().agent.SetDestination(player.transform.position);
        }    
    }
}