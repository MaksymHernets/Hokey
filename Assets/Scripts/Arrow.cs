using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Transform target;

    public Transform arrow;
    public Transform ImageArrow;

    private float Max = 3f;
    public void SetArrow(float angle, float size)
	{
        gameObject.transform.localPosition = target.transform.localPosition;
        arrow.localEulerAngles = new Vector3(0f , angle , 0f);
        if (size > Max) { size = Max; }
        ImageArrow.localPosition = new Vector3(size * 0.5f, 0.06f, 0f);
        ImageArrow.localScale = new Vector3(size * 0.1f, 0.1f, 1f);
    }
}
