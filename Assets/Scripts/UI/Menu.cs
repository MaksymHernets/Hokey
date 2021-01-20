using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject buttonMenu;
    public GameObject buttonContinue;
    public GameObject buttonExit;

    public ManagerScene managerScene;

    void Awake()
    {
        buttonMenu.SetActive(true);
    }

    public void buttonMenu_Click()
	{
        buttonContinue.SetActive(true);
        buttonExit.SetActive(true);
        buttonMenu.SetActive(false);

        managerScene.Stoped();
    }

    public void buttonContinue_Click()
    {
        buttonExit.SetActive(false);
        buttonMenu.SetActive(true);
        buttonContinue.SetActive(false);

        managerScene.Continue();
    }

    public void buttonExit_Click()
    {
        Application.Quit();
    }
}
