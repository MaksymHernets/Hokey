using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScene : MonoBehaviour
{
	public Washer washer;
	public Deffendor deffendor;

	public Transform StartPositionWasher;

	public GameObject[] Barricads;

	public ControlWasher controlWasher;

	public Counter counterLevel;
	public Menu menu;

	private int CountBarricade = 0;
	private int MaxBarricade = 3;

	private void Start()
	{
		washer.HitBarricadEvent += HitBarricadEvent_Hand;
		deffendor.EventGotWahser += EventGotWasher_Hand;

		Stoped();
	}

	public void HitBarricadEvent_Hand()
	{
		++CountBarricade;
		ReserWasher();
		if (CountBarricade == MaxBarricade)
		{
			CountBarricade = 0;
			LevelUp();
			ResetBarricads();
		}
	}

	public void EventGotWasher_Hand()
	{
		ReserWasher();
	}

	private void ReserWasher()
	{
		washer.rigidb.isKinematic = true;
		washer.rigidb.isKinematic = false;
		washer.IsMove = true;
		washer.transform.localPosition = StartPositionWasher.localPosition;
		controlWasher.gameObject.SetActive(true);
	}

	private void ResetBarricads()
	{
		for (int i = 0; i < Barricads.Length; ++i)
		{
			Barricads[i].SetActive(true);
		}
	}

	private void LevelUp()
	{
		deffendor.Speed += 1f;
		counterLevel.Increment();
	}

	public void Stoped()
	{
		washer.rigidb.Sleep();
		controlWasher.gameObject.SetActive(false);
	}

	public void Continue()
	{
		washer.rigidb.WakeUp();
		controlWasher.gameObject.SetActive(true);
	}
}
