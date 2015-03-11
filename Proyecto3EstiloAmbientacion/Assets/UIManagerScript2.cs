using UnityEngine;
using System.Collections;

public class UIManagerScript2: MonoBehaviour {

	public void StartGame()
	{
		Application.LoadLevel("scene_01");
	}

	public void ExitGame()
	{
		Application.Quit ();
	}
}
