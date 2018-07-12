using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerController : MonoBehaviour {

    public Rigidbody RB;
    public float Speed;
	public GameObject winUi;
    public GameObject overUI;
    int Life = 100;
    int count;
    public Text playerLife;
    public Text playerCount;

    // Use this for initialization
    void Start () {
		RB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = CrossPlatformInputManager.GetAxis("Horizontal");
        float moveVertical = CrossPlatformInputManager.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        RB.AddForce(movement * Speed);

        SetCount();

        playerCount.text = "Count = " + count.ToString();
        playerLife.text = "Life " + Life.ToString();
    }

	void OnTriggerEnter(Collider other){
		if (other.tag == "Cube") {
			Destroy (other.gameObject);
			count++;
            SetCount();
        }
        if (other.tag == "Enemy")
        {
            Life-=20;
        }
	}

	void SetCount(){
		if (count >= 5) {
			winUi.SetActive (true);
		}

        if (Life <= 0)
        {
            overUI.SetActive(true);
        }
	}
}