using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerController control;

	void OnCollisonEnter(Collision collisionInfo){
		if (collisionInfo.collider.tag == "Walls") {
			Debug.Log ("Walls");
		}
	}
}
