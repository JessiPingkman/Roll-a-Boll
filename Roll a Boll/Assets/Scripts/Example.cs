using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Example : MonoBehaviour {

    public Transform target;
    private NavMeshAgent agent; 

	void Start () {
        agent = (NavMeshAgent)this.GetComponent("NavMeshAgent");
	}
	
	// Update is called once per frame
	void Update () {
        agent.SetDestination(target.position);
	}
}
