using UnityEngine;
using System.Collections;

public class SceneSwitchTest : MonoBehaviour {

	public void SwitchScene(string condition) {
		GameManager.instance.SwitchScene (condition);
	}
}
