using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController2D))]
public class Enemy : MonoBehaviour
{
    public float speed = 10f;
    public Transform groundDetection;
    public CharacterController2D enemy;
    public float maxTime = 5;
    private DeathZone deathZone;
    private float time = 0;
    private bool right = true;

    private void Start()
    {
        deathZone = DeathZone.instance;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (right)
        {
            enemy.Move(1 * speed * Time.fixedDeltaTime, false, false);
        }
        else
        {
            enemy.Move(-1 * speed * Time.fixedDeltaTime, false, false);
        }

        if (time >= maxTime)
        {
            right = !right;
            time = 0;
        }
        else
        {
            time += Time.fixedDeltaTime;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Destroy(transform.gameObject);
            Debug.Log("TRIGGER");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            deathZone.Die();
        }
    }
}