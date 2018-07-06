using UnityEngine;
using UnityEngine.AI;

public class PlayerController01 : MonoBehaviour {

	public Camera cam;
	public NavMeshAgent agent;
	public Rigidbody RB;
	int count;
	public GameObject winUi;

	void Start(){
		RB = GetComponent<Rigidbody> ();
	}

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = cam.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit)) {
				agent.SetDestination (hit.point);
			}
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Cube") {
			Destroy (other.gameObject);
			count++;
			SetCount ();
		}
	}

	void SetCount(){
		if (count >= 5) {
			winUi.SetActive (true);
		}
	}

	void OnGUI(){
		GUI.Box(new Rect (1266, 0, 100, 30), "Count = " + count);
	}
}
