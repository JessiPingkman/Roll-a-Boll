using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour {

    public Rigidbody RB;
    public float Speed;
	int count;
	public GameObject winUi;

	// Use this for initialization
	void Start () {
		RB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		RB.AddForce(movement * Speed);
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
		GUI.Box(new Rect(0, 0, 100, 30), "Count = " + count);
	}
}