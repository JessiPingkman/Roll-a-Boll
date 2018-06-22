using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerComtroller : MonoBehaviour {

    public float speed = 6f;
    public Rigidbody rb;
    public Text CountText, WinText;
    private int count;

    void Start() {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCount();
    }

    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Cube") {
            Destroy(other.gameObject);
            count++;
            SetCount();
        }
    }
    void SetCount() {
        CountText.text = "Count: " + count.ToString();
        if(count >= 13) {
            WinText.text = "YOU WIN!";
        }
    }
}
