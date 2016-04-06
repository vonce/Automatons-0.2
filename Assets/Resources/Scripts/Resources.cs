using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Resources : MonoBehaviour {

	public Text metalText;
    public int power;
    public int metal;

	void Update()
	{
		metal++;
		metalText.text = "Metal: " + metal.ToString();
	}

}
