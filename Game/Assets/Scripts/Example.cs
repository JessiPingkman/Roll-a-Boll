using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour {

	public Transform target;
	private UnityEngine.AI.NavMeshAgent agent;

	void Start () {
		agent = (UnityEngine.AI.NavMeshAgent)this.GetComponent ("NavMeshAgent");
	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination (target.position);
	}
}
