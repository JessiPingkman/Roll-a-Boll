using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PlayerController01 : MonoBehaviour {

	public Camera cam;
	public NavMeshAgent agent;
	public Rigidbody RB;
	public GameObject winUi;
    public GameObject overUI;
    int count;
    int Life = 100;
    public Text playerLife;
    public Text playerCount;

    void Start()
    {
		RB = GetComponent<Rigidbody> ();
	}

	void Update ()
    {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = cam.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit)) {
				agent.SetDestination (hit.point);
			}
		}
	}

	void OnTriggerEnter(Collider other)
    {
		if (other.tag == "Cube") {
			Destroy (other.gameObject);
			count++;
            SetCount();
		}
        if (other.tag == "Enemy")
        {
            Life -= 20;
            SetCount();
        }
	}

	void SetCount()
    {
		if (count >= 5) {
			winUi.SetActive (true);
		}

        if(Life <= 0)
        {
            overUI.SetActive(true);
        }

        playerCount.text = "Count = " + count.ToString();
        playerLife.text = "Life " + Life.ToString();
    }
}
