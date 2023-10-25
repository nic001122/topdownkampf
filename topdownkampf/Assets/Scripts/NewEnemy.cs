using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering.Universal;

public class NewEnemy : MonoBehaviour
{
    [SerializeField] Transform target;
    public Light2D playerLantern;

    NavMeshAgent agent;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    private void Update()
    {
        if (playerLantern.intensity == 0)
        {
            agent.SetDestination(target.position);
        }
        
    }
}
