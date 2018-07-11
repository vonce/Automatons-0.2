using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealBeam : MonoBehaviour
{
    private Vector3 startPosition;
    public Vector3 direction;
    public float tick;
    private float nextTick;
    private Color c1 = Color.cyan;
    private Color c2 = Color.blue;
    private LineRenderer lineRenderer;

    void Start()
    {
        nextTick = Time.time + tick;
        lineRenderer = gameObject.GetComponent<LineRenderer>();
        startPosition = transform.position;
    }

    void OnTriggerStay(Collider other)//trigger events
    {
        if ((nextTick <= Time.time) && (other.gameObject.GetComponentInParent<Status>() != null))
        {
            if (other.gameObject.GetComponentInParent<Status>().currentHealth < other.gameObject.GetComponentInParent<Status>().maxHealth)
            {
                other.gameObject.GetComponentInParent<Status>().currentHealth++;
            }
            nextTick = Time.time + tick;
        }
    }

    void Update()
    {
        float lerp = Mathf.PingPong(Time.time, 1f);

        Destroy(gameObject, .5f);
        lineRenderer.SetColors(Color.Lerp(c2, c1, lerp), Color.Lerp(c1, c2, lerp));
    }
}
