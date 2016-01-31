using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;

public class BearStop : MonoBehaviour {

	public void ReTarget(Transform arm)
	{
		GetComponent<AICharacterControl> ().SetTarget(arm);
	}
}
