using UnityEngine;
using System.Collections;

public class RunningPlayer : MonoBehaviour {

	[SerializeField] private GameObject arm;

	private bool armDropped = false;
	private GameObject bear;

	void OnCollisionEnter (Collision collision) 
	{
		if (!armDropped && collision.collider.name == "Bear")
			GameManager.instance.SwitchScene ("Bear");
		else if (collision.collider.name == "NewLevelTrigger")
			GameManager.instance.SwitchScene ("Cliff");
	}

	void DropArm()
	{
		GameObject arm_dropped = Instantiate (arm, transform.position, Quaternion.identity) as GameObject;
		bear = GameObject.Find ("Bear");
		BearStop bs = bear.GetComponent<BearStop> ();
		bs.ReTarget (arm_dropped.transform);
		armDropped = true;
		GameManager.instance.feedBear ();
	}

	void Update() 
	{
		if (Input.GetKeyDown ("l") && GameManager.instance.getLimbs() > 0)
			DropArm ();
	}
}
