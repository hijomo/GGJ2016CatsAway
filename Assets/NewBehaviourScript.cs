using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{
	string positiveText;
	string negativeText;
	string nutralText;

	/*
	 * what it the idea,
	 * whne a button is pressed it will increment the camera view one, and addto the crownd felling
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
