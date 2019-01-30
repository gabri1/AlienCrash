using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoveX : MonoBehaviour
{
    [SerializeField] private bool changeDirection = true;
    [SerializeField] public float xDirection = 1;
    [SerializeField] public float xDirectionReverse = -1;
    [SerializeField] private PlayerMover myPlayer;

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
            if(transform.position.x > 18)
            {
                changeDirection = false;
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x - xDirection * Time.deltaTime, transform.position.y, transform.position.z);
            if(transform.position.x < 11.54)
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
                myPlayer.controller.Move(xDirection * 52 * Time.fixedDeltaTime, false, false);
                Debug.Log("Collide e si muove");
            }
            else
            {
                myPlayer.controller.Move(xDirectionReverse * 52 * Time.fixedDeltaTime, false, false);
                Debug.Log("Torna indietro");
            }
        }
    }
}
