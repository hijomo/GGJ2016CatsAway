using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;

	struct GameData {
		public int limbs;
		public bool knife;
		public bool booze;
		public bool bear_fed;
		public bool bear_death;
		public bool mob_death;
		public bool pie_death;
		public bool bar_death;
	};

	private GameData gameData;
	private Text debugText;

	// Use this for initialization
	void Awake () {
	
		if (instance == null)
			instance = this;
		else
			Destroy (gameObject);

		DontDestroyOnLoad (gameObject);

		gameData.limbs = 0;
		gameData.knife = false;
		gameData.booze = false;
		gameData.bear_death = false;
		gameData.mob_death = false;
		gameData.pie_death = false;
		gameData.bar_death = false;
	}

	private void OnLevelWasLoaded() {
		//Debug.Log(SceneManager.GetActiveScene().name);
		debugText = GameObject.Find ("GameManagerDebug").GetComponent<Text> ();

		debugText.text = "Knife: " + gameData.knife +
			"\nBooze: " + gameData.booze +
			"\nLimbs: " + gameData.limbs +
			"\nBear Deaths: " + gameData.bear_death +
			"\nMob Deaths: " + gameData.mob_death +
			"\nPie Deaths: " + gameData.pie_death +
			"\nBar Deaths: " + gameData.bar_death;
	}

	public void SwitchScene(string death) {
		switch (SceneManager.GetActiveScene ().name) {
		case "bear_chase":
			if (gameData.bear_death)
				if (gameData.bear_fed) {
					SceneManager.LoadScene ("Cat"); // Game over
					return;
				}
				else if (death == "Bear")
					gameData.knife = true;
				else {
					gameData.booze = true;
					gameData.knife = false;
				}
			SceneManager.LoadScene ("speech");
			gameData.bear_death = true;
			break;
		case "speech":
			SceneManager.LoadScene ("pie");

			if (gameData.mob_death) {
				gameData.knife = true;
				gameData.booze = true;
				if (death == "Mob") {
					gameData.limbs++;
				}
			}

			gameData.mob_death = true;	
			break;
		case "pie":
			SceneManager.LoadScene ("bar");

			if (gameData.pie_death) {
				gameData.booze = true;
				gameData.knife = true;
			}

			gameData.pie_death = true;
			break;
		case "bar":
			SceneManager.LoadScene ("bear_chase");

			if (gameData.bar_death) {
				gameData.knife = false;
				gameData.booze = false;
			} else {
				gameData.knife = true;
			}

			gameData.bar_death = true;
			break;
		default:
			SceneManager.LoadScene ("bear_chase");
			break;
		}
	}

	public int getLimbs()
	{
		return gameData.limbs;
	}

	public bool hasKnife()
	{
		return gameData.knife;
	}

	public bool hasBooze()
	{
		return gameData.booze;
	}

	public void feedBear()
	{
		gameData.bear_fed = true;
	}
}
