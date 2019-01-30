using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollider : MonoBehaviour
{
    private DeathZone deathZone;

    void Start()
    {
        deathZone = DeathZone.instance;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            deathZone.Die();
            Debug.Log("Die!");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            deathZone.Die();
            Destroy(transform.gameObject);
        }
    }
}
