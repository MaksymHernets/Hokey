using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class Vector3Extension
{
	public static float AngleRelative(Vector3 vec1, Vector3 vec2)
	{
		Vector3 diference = vec2 - vec1;
		float sign = (vec2.y > vec1.y) ? -1.0f : 1.0f;
		return Vector3.Angle(Vector3.right, diference) * sign;
	}
}
