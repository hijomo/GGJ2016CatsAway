using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SpeechController : MonoBehaviour
{
	public List<Sprite> backgroundImages = new List<Sprite> ();

	List<string> promps = new List<string> {
		"prompt 1",
		"prompt 2",
		"prompt 3",
		"prompt 4",
		"prompt 5",
		"prompt 6",
		"prompt 7",
		"prompt 8",
		"prompt 9",
		"prompt 10",
	};

	List<string> positiveResponse = new List<string> {
		"positiveResponse 1",
		"positiveResponse 2",
		"positiveResponse 3",
		"positiveResponse 4",
		"positiveResponse 5",
		"positiveResponse 6",
		"positiveResponse 7",
		"positiveResponse 8",
		"positiveResponse 9",
		"positiveResponse 10",
	};

	List<string> neutralResponse = new List<string> {
		"neutralResponse 1",
		"neutralResponse 2",
		"neutralResponse 3",
		"neutralResponse 4",
		"neutralResponse 5",
		"neutralResponse 6",
		"neutralResponse 7",
		"neutralResponse 8",
		"neutralResponse 9",
		"neutralResponse 10",
	};
	List<string> negativeResponse = new List<string> {
		"negativeResponse 1",
		"negativeResponse 2",
		"negativeResponse 3",
		"negativeResponse 4",
		"negativeResponse 5",
		"negativeResponse 6",
		"negativeResponse 7",
		"negativeResponse 8",
		"negativeResponse 9",
		"negativeResponse 10",
	};

	int speechRound = 0;

	public Image backgroundImage;
	public Sprite catAssassinBackground;
	public Sprite mobBackground;
	string positiveText;
	string negativeText;
	string nutralText;
	int bgImageIterator = 1;

	public Text promptText;

	public Button buttonA;
	public Text buttonAText;
	public Button buttonB;
	public Text buttonBText;
	public Button buttonC;
	public Text buttonCText;

	float publicOpinion = 0f;



	void Start ()
	{
		buttonAText.text = "Positive effect";
		buttonBText.text = "Neutral effect";
		buttonCText.text = "Negative effect";
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.A)) {
			Application.LoadLevel (Application.loadedLevel);

		}
	}
	// cycle through the diffrent background images
	void AdvanceBackgroundImage ()
	{
		backgroundImage.sprite = backgroundImages [bgImageIterator];
		if (bgImageIterator < backgroundImages.Count - 1) {
			bgImageIterator++;
		} else {
			bgImageIterator = 0;
		}

	}

	void changePublicOpinion (float poChange)
	{
		publicOpinion += poChange;
		if (publicOpinion > 0) {
			promptText.text = "people Love your this much: " + publicOpinion;
		} else {
			promptText.text = "people Hate your this much: " + publicOpinion;
		}
		if (publicOpinion > 5f) {
			CatAssassinEnding ();
		}
		if (publicOpinion < -5) {
			MobEnding ();
		}
	}

	// positive option
	public void SpeechBoxAPress ()
	{
		Debug.Log ("Button A has been Pressed");
		AdvanceBackgroundImage ();
		changePublicOpinion (1f);
	}

	//neutral option
	public void SpeechBoxBPress ()
	{
		Debug.Log ("Button B has been Pressed");
		AdvanceBackgroundImage ();
		changePublicOpinion (-0f);
	}

	//negative option
	public void SpeechBoxCPress ()
	{
		Debug.Log ("Button C has been Pressed");
		AdvanceBackgroundImage ();
		changePublicOpinion (-1f);
	}

	void CatAssassinEnding ()
	{
		backgroundImage.sprite = catAssassinBackground;
		buttonA.gameObject.SetActive (false);
		buttonB.gameObject.SetActive (false);
		buttonC.gameObject.SetActive (false);
		promptText.text = "You are too popular. The oligarchy have removed you from the stage.";
	}

	void MobEnding ()
	{
		backgroundImage.sprite = mobBackground;
		buttonA.gameObject.SetActive (false);
		buttonB.gameObject.SetActive (false);
		buttonC.gameObject.SetActive (false);
		promptText.text = "You are torn to peices by the furious mod";
	}
}
	
