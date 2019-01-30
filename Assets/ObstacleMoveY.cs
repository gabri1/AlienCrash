using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoveY : MonoBehaviour
{
    public bool changeDirection = true;
    public float yDirection;
    // Update is called once per frame
    void Update()
    {
        move();
    }

    public void move()
    {
        if (changeDirection)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + yDirection * Time.deltaTime, transform.position.z);
            if (transform.position.y > 10)
            {
                changeDirection = false;
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - yDirection * Time.deltaTime, transform.position.z);
            if (transform.position.y < 2.5)
            {
                changeDirection = true;
            }
        }
    }
}
