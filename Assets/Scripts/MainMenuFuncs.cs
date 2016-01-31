using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuFuncs : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void startBearRun() {
		SceneManager.LoadScene("bear_chase");
	}
}
