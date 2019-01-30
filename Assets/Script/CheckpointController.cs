using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{

    public Transform checkpoint;
    public DeathZone deathZone;

    void Start()
    {
        deathZone = DeathZone.instance;
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.transform.CompareTag("Player"))
        {
            deathZone.checkpoint = checkpoint.position;
        }
    }
}
