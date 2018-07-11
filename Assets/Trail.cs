using UnityEngine;
using System.Collections;

public class Trail : MonoBehaviour
{
    public float trailMagnitude;
	// Update is called once per frame
	void Update ()
    {
        transform.localPosition = trailMagnitude * GetComponentInParent<Bullet>().direction;
	}
}
