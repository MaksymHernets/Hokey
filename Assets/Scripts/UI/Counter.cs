using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
	public Text Textname;
	public Text Textcount;

    private int count = 1;

	public void SetName(string name)
	{
		//todo
	}

	public void Increment()
	{
		++count;
		Textcount.text = count.ToString();
	}

	public void Clear()
	{
		count = 0;
		Textcount.text = count.ToString();
	}
}
