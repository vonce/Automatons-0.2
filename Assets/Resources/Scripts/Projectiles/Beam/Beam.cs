using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    private Vector3 startPosition;
    public Vector3 direction;
    public float tick;
    private float nextTick;
    private Color c1 = Color.red;
    private Color c2 = Color.magenta;
    private LineRenderer lineRenderer;
    private List<Collider> inBeam = new List<Collider>();

    void Start()
    {
        nextTick = Time.time + tick;
        lineRenderer = gameObject.GetComponent<LineRenderer>();
        startPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (inBeam.Contains(other) != true && other.gameObject.GetComponentInParent<Status>() != null)
        {
            inBeam.Add(other);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (inBeam.Contains(other) == true)
        {
            inBeam.Remove(other);
        }
    }

    void OnTriggerStay(Collider other)//trigger events
    {
        if (inBeam.Contains(other) != true && other.gameObject.GetComponentInParent<Status>() != null)
        {
            inBeam.Add(other);
        }
    }

    void Update()
    {
        if (nextTick <= Time.time)
        {
            foreach (Collider col in inBeam)
            {
                if (col != null)
                {
                    col.GetComponentInParent<Status>().currentHealth--;
                }
                nextTick = Time.time + tick;
            }
        }
        float lerp = Mathf.PingPong(Time.time, 1f);
        
        Destroy(gameObject, 1f);
        lineRenderer.SetColors(Color.Lerp(c2, c1, lerp), Color.Lerp(c1, c2, lerp));
    }
}
