using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpeechController : MonoBehaviour
{
	public List<Sprite> backgroundImages = new List<Sprite> ();

	List<string> promps = new List<string> {
		"prompt 1",
		"I’ve gathered you today, here in the very heart of our town to speak frankly in these trying times…",
		"This yearly address, a respected tradition and ritual among our people, we must confront the hard realities of the times. Our country can and will flourish once more! It is high time we…",
		"For too long have we been subjected to the...",
		"And with this in mind, it is time to rise up and claim our place in this world, foreign threats loom and we can no longer sit idle!",
		"Our economy has been in tumult this year, yet...",
		"Taxes must be immediately adressed as well!",
		"prompt 8",
		"prompt 9",
		"prompt 10"
	};

	List<string> positiveResponses = new List<string> {
		"positiveResponse 1",
		"I must congratulate each and every one of you on your dedication to our great country...",
		"Gave power back to the people, for it is indeed all of us who",
		"Tyranny of the Wealthy elite",
		"our flag will rise victorious over all who oppose our glory! No other shall be above Moskistan...",
		"due to the great effort of our workers the yearly quotas were surpassed so the ration of chocolate shall be doubled!...",
		"As a token of appreciation, and a gesture of my infinite magnanimity, taxes shall be reigned in…",
		"positiveResponse 8",
		"positiveResponse 9",
		"positiveResponse 10"
	};

	List<string> neutralResponses = new List<string> {
		"neutralResponse 1",
		"Our contry has sufferend in these recent times, but we persevere...",
		"Work harder to restore the glory of our past!",
		"Whims of our changing fortunes",
		"we have always been at war with Espayesia, in support of our Naguastan allys, we shall proudly continue this effort...",
		" your fellow citizens have met the required production goals, and this pleases me…",
		"Taxes shall remain at their current levels throughout this year…",
		"neutralResponse 8",
		"neutralResponse 9",
		"neutralResponse 10"
	};
	List<string> negativeResponses = new List<string> {
		"negativeResponse 1",
		"I can no longer hide my disgust. Our once proud kingdom has fallen into disarray. You have no one to blame but yourselves...",
		"Finally allow our corporations to thrive by ridding ourselves of pointless environmental protectionism.",
		"Tyranny of you, the unwashed Masses",
		"Surely many of you will die in the coming conflicts, but that is a risk I am willing to take..",
		"You lazy and entitled slobs have fallen short of my demands, and as such the gin ration shall be cut…",
		"An increase in taxes is inevitable, Your meager contributions will be put to a much better use in our war efforts, and to fund my new mansion...",
		"negativeResponse 8",
		"negativeResponse 9",
		"negativeResponse 10"
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
		promptText.text = "";
		buttonAText.text = "Hardworking people of this country, you are the ones who make me proud to be a fellow citizen….";
		buttonBText.text = "People of Mostkiastan…";
		buttonCText.text = "Slaves, Rabble, indebted servants, and assorted filth…";
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.A)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
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
	//fill the the next rounds text options
	void SetUpNextRound ()
	{
		speechRound++;
		if (speechRound >= 7) {
			CatAssassinEnding ();
			return;
		}
		if (publicOpinion < -5f) {
			MobEnding ();
			return;
		}
		promptText.text = promps [speechRound];
		buttonCText.text = negativeResponses [speechRound];
		buttonBText.text = neutralResponses [speechRound];
		buttonAText.text = positiveResponses [speechRound];
	}

	void changePublicOpinion (float poChange)
	{
		publicOpinion += poChange;
//		if (publicOpinion > 0) {
//			promptText.text = "people Love your this much: " + publicOpinion;
//		} else {
//			promptText.text = "people Hate your this much: " + publicOpinion;
//		}
//		if (publicOpinion > 5f) {
//			CatAssassinEnding ();
//		}
//		if (publicOpinion < -5) {
//			MobEnding ();
//		}
	}

	// positive option
	public void SpeechBoxAPress ()
	{
		Debug.Log ("Button A has been Pressed");
		AdvanceBackgroundImage ();
		changePublicOpinion (1f);
		SetUpNextRound ();
	}

	//neutral option
	public void SpeechBoxBPress ()
	{
		Debug.Log ("Button B has been Pressed");
		AdvanceBackgroundImage ();
		changePublicOpinion (-0f);
		SetUpNextRound ();
	}

	//negative option
	public void SpeechBoxCPress ()
	{
		Debug.Log ("Button C has been Pressed");
		AdvanceBackgroundImage ();
		changePublicOpinion (-1f);
		SetUpNextRound ();
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
	
