using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
	public GameObject Counter;
	public GameObject Menu;

	public GameObject buttonStart;
	public GameObject buttonExit;

	public ManagerScene managerScene;

	public void ButtonStart_Click()
	{
		buttonStart.SetActive(false);
		buttonExit.SetActive(false);
		Menu.SetActive(true);
		Counter.SetActive(true);

		managerScene.Continue();

		gameObject.SetActive(false);
	}

	public void ButtonExit_Click()
	{
		Application.Quit();
	}
}
