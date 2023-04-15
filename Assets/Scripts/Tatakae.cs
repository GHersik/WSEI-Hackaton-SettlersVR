using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Tatakae : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent = null;

    void Awake()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        GameObject _villagePos = GameObject.Find("village");
        _navMeshAgent.SetDestination(_villagePos.transform.position);
    }
}

