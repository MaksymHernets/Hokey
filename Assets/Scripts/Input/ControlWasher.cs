using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlWasher : MonoBehaviour
{
	public Washer player;
	public Arrow arrow;

	private Vector3 PositionBegin;
	private Vector3 PositionEnd;

	private float MinDis = 40f;

	private void Start()
	{

	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			PositionBegin = Input.mousePosition;
		}
		else if (Input.GetKeyUp(KeyCode.Mouse0))
		{
			arrow.SetArrow(0f, 0f);
			PositionEnd = Input.mousePosition;
			float x = PositionEnd.x - PositionBegin.x;
			float z = PositionEnd.y - PositionBegin.y;
			float dis = Mathf.Sqrt(x * x + z * z);
			if (dis > MinDis)
			{
				player.AddForce(x, z);
				gameObject.SetActive(false);
			}
			
		}
		else if (Input.GetKey(KeyCode.Mouse0))
		{
			PositionEnd = Input.mousePosition;
			float angle = Vector3Extension.AngleRelative(PositionBegin, PositionEnd);
			float distance = Vector3.Distance(PositionEnd, PositionBegin); 
			arrow.SetArrow(angle, distance*0.01f);
		}
	}

	
}
