using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerComtroller : MonoBehaviour {

    public float speed = 6f;
    public Rigidbody rb;
    public Text CountText;
    private int count;
    public GameObject completeLevelUI;
    public STime time;
    int Life = 100;

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
        if(count >= 12) {
            completeLevelUI.SetActive(true);
        }
    }

    void onCollisionEnter(Collider shift) {
        if (shift.tag == "pipka") {
            Life--;
        }
    }

    void OnGUI() {
        GUI.Box(new Rect(0, 0, 100, 30), "Life = " + Life);
        GUI.Box(new Rect(105, 0, 120, 30), "Time = " + time.timer);
    }
}
