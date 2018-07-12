using UnityEngine;

public class Credits : MonoBehaviour {

	public void Quit(){
		Debug.Log ("QUIT!");
		Application.Quit ();
	}

    public void Restart()
    {
        Debug.Log("RESTART!");
        Application.LoadLevel(Application.loadedLevel);
    }
}
