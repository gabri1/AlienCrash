using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoveX : MonoBehaviour
{
    private bool changeDirection = true;
    public float xDirection = 1;
    public float xDirectionReverse = -1;
    private PlayerMover myPlayer;
    float leftPosition;
    float rightPosition;

    private void Start()
    {
        myPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMover>();
        leftPosition = (transform.position - new Vector3(2.5f, 0, 0)).x;
        rightPosition = (transform.position + new Vector3(2.5f, 0, 0)).x;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        if(changeDirection)
        {
            transform.position = new Vector3(transform.position.x + xDirection * Time.deltaTime, transform.position.y, transform.position.z);
            if(transform.position.x > rightPosition)
            {
                changeDirection = false;
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x - xDirection * Time.deltaTime, transform.position.y, transform.position.z);
            if(transform.position.x < leftPosition)
            {
                changeDirection = true;
            }
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            Debug.Log("Collide");
            Debug.Log(collision.gameObject);
            
            if (changeDirection)
            {
                myPlayer.controller.Move(xDirection * 38f * Time.fixedDeltaTime, false, false);
                Debug.Log("Collide e si muove");
            }
            else
            {
                myPlayer.controller.Move(xDirectionReverse * 38f * Time.fixedDeltaTime, false, false);
                Debug.Log("Torna indietro");
            }
        }
    }
}
