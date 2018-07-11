using UnityEngine;
using System.Collections;
using System;

public class CameraMovement : MonoBehaviour
{
    private float scrollDistance;
    private float scrollSpeed;
	// Update is called once per frame
    void Start()
    {

        scrollDistance = 10;
        scrollSpeed = 1;
    }
	void Update()
    {
        float mousePosX = Input.mousePosition.x;
        float mousePosY = Input.mousePosition.y;
        
        if (Input.GetAxis("Mouse ScrollWheel") < 0f && gameObject.GetComponent<Camera>().orthographicSize <= 25)
        {
            gameObject.GetComponent<Camera>().orthographicSize++;
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0f && gameObject.GetComponent<Camera>().orthographicSize >= 5)
        {
            gameObject.GetComponent<Camera>().orthographicSize--;
        }

        if (mousePosX < scrollDistance)
        {
            if (Math.Abs(transform.position.x) + Math.Abs(transform.position.z) < 200)
            {
                transform.Translate(-scrollSpeed, 0, 0, Space.World);
            }
            else if (transform.position.x > 0)
            {
                transform.Translate(-scrollSpeed, 0, 0, Space.World);
            }
        }
        if (mousePosX >= Screen.width - scrollDistance)
        {
            if (Math.Abs(transform.position.x) + Math.Abs(transform.position.z) < 200)
            {
                transform.Translate(scrollSpeed, 0, 0, Space.World);
            }
            else if (transform.position.x < 0)
            {
                transform.Translate(scrollSpeed, 0, 0, Space.World);
            }
        }

        if(mousePosY < scrollDistance)
        {
            if (Math.Abs(transform.position.x) + Math.Abs(transform.position.z) < 200)
            {
                transform.Translate(0, 0, -scrollSpeed, Space.World);
            }
            else if (transform.position.z > 0)
            {
                transform.Translate(0, 0, -scrollSpeed, Space.World);
            }
        }
        if(mousePosY >= Screen.height - scrollDistance)
        {
            if (Math.Abs(transform.position.x) + Math.Abs(transform.position.z) < 200)
            {
                transform.Translate(0, 0, scrollSpeed, Space.World);
            }
            else if(transform.position.z < 0)
            {
                transform.Translate(0, 0, scrollSpeed, Space.World);
            }
        }
    }
}
