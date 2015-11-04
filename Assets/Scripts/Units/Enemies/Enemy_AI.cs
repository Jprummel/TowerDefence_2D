using UnityEngine;
using System.Collections;

public class Enemy_AI : MonoBehaviour
{

    NavMeshAgent agent;
    public Transform playerBase;
    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(playerBase.position);
    }
}
