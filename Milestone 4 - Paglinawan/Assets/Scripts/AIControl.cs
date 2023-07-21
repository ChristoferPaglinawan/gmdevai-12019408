using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent agent;

    private void Start() 
    {
        this.agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
}
