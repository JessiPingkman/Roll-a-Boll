using UnityEngine;

public class Rotate : MonoBehaviour {
	
	void Update () {
		transform.Rotate (new Vector3 (15, 35, 28) * Time.deltaTime);
	}
}
