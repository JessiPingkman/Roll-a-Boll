using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class STime : MonoBehaviour {

    public Text timeText;
    float timer;
	
	void Update () {
		if(timer > 0) {
            timer -= Time.deltaTime;
        }
        if (timer < 0) {
            Debug.Log("Lose!");
        }
	}
}
