using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SpeechController : MonoBehaviour
{
	public List<Sprite> backgroundImages = new List<Sprite> ();
	public Image backgroundImage;
	string positiveText;
	string negativeText;
	string nutralText;
	int bgImageIterator = 0;

	public Text promptText;
	public Text buttonAText;
	public Text buttonBText;
	public Text buttonCText;
	/*
	 * what it the idea,
	 * whne a button is pressed it will increment the camera view one
	 * , and add to the crownd felling based on what is sellected
	 * 
	 */



	void AdvanceBackgroundImage ()
	{
		backgroundImage.sprite = backgroundImages [bgImageIterator];
		if (bgImageIterator < backgroundImages.Count - 1) {
			bgImageIterator++;
		} else {
			bgImageIterator = 0;
		}

	}



	public void SpeechBoxAPress ()
	{
		Debug.Log ("Button A has been Pressed");
		AdvanceBackgroundImage ();
	}

	public void SpeechBoxBPress ()
	{
		Debug.Log ("Button B has been Pressed");
		AdvanceBackgroundImage ();
	}

	public void SpeechBoxCPress ()
	{
		Debug.Log ("Button C has been Pressed");
		AdvanceBackgroundImage ();
	}
}
