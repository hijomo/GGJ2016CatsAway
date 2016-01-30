using UnityEngine;
using System.Collections;

public class SpeechController : MonoBehaviour
{

	string positiveText;
	string negativeText;
	string nutralText;

	/*
	 * what it the idea,
	 * whne a button is pressed it will increment the camera view one
	 * , and add to the crownd felling based on what is sellected
	 * 
	 */

	public void SpeechBoxAPress ()
	{
		Debug.Log ("Button A has been Pressed");
	}

	public void SpeechBoxBPress ()
	{
		Debug.Log ("Button B has been Pressed");
	}

	public void SpeechBoxCPress ()
	{
		Debug.Log ("Button C has been Pressed");
	}
}
