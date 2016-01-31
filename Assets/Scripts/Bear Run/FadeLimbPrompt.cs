using UnityEngine;
using System.Collections;

public class FadeLimbPrompt : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (GameManager.instance.getLimbs () > 0)
			GetComponent<Animator> ().SetBool ("hasLimbs", true);
	}
}
