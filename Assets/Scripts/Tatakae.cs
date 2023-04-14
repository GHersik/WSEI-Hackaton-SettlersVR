using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Tatakae : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent = null;
    [SerializeField] GameObject _navMeshSurface;
    [SerializeField] GameObject village;

    private NavMeshSurface _navMesh;

    void Awake()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        _navMeshAgent.SetDestination(village.transform.position);
        _navMesh = _navMeshSurface.GetComponent<NavMeshSurface>();
    }

    //private void Update()
    //{
    //    SetAttackDestination();
    //}

    private void SetAttackDestination()
    {
        _navMeshAgent.SetDestination(village.transform.position);
        //nma.destination = village.transform.position;
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Villager have died");
    }
}

