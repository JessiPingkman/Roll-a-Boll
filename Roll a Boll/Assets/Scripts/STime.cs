using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class STime : MonoBehaviour {

    public float timer = 5;

    void Update() {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
    }
}
