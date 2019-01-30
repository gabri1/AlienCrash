using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoveY : MonoBehaviour
{
    public bool up = true;
    public float yDirection;

    public float maxY;
    public float minY;

    private void Awake()
    {

        maxY = (transform.position + new Vector3(0, 3, 0)).y;
        minY = (transform.position - new Vector3(0, 3, 0)).y;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    public void move()
    {
        if (up)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + yDirection * Time.deltaTime, transform.position.z);
            if (transform.position.y > maxY)
            {
                up = false;
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - yDirection * Time.deltaTime, transform.position.z);
            if (transform.position.y < minY)
            {
                up = true;
            }
        }
    }
}
