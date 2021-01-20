using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deffendor : MonoBehaviour
{
    public GameObject Target;
    public float Speed = 1f;

    public delegate void GotWahser();
    public event GotWahser EventGotWahser;

    void Update()
    {
        transform.position = Vector3.Lerp(
            transform.position, 
            new Vector3(Target.transform.position.x , transform.position.y , transform.position.z), 
            Speed * Time.deltaTime);
    }

	private void OnCollisionEnter(Collision collision)
	{
		if ( collision.gameObject.name == "Washer")
		{
            EventGotWahser();
        }
	}
}
