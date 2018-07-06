using UnityEngine;

public class PlayerCollision : MonoBehaviour {



	void OnCollisonEnter(Collision collisionInfo){
		if (collisionInfo.collider.tag == "Walls") {
			Debug.Log ("Enemy");
		}
	}
}
