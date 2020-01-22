using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PathfindingAgentScript : MonoBehaviour
{
    [SerializeField]
    private Transform[] Target;

    void Start()
    {
        GotoTarget();
    }

    void Update()
    {
        if (GetComponent<NavMeshAgent>().remainingDistance < 1000)
            GotoTarget();
    }

    private void GotoTarget()
    {
        GetComponent<NavMeshAgent>().SetDestination(Target[Random.Range(0, Target.Length)].position);
    }
}