using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Washer : MonoBehaviour
{
	public Rigidbody rigidb;
	public bool IsMove = false;

	public delegate void HitBarricad();
	public event HitBarricad HitBarricadEvent;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "BarricadEnemy" )
		{
			collision.gameObject.SetActive(false);
			HitBarricadEvent();
		}
	}

	public void AddForce(float x, float z)
	{
		rigidb.AddForce(new Vector3(x, 0, z));
		IsMove = true;
	}
}
