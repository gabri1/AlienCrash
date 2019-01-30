using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{

    [SerializeField] public GameObject Bridge1;
    [SerializeField] float xDirection = 1;
    public bool isMove = false;

    private void OnCollisionEnter(Collision collision)
    {
        isMove = true;

        if (isMove)
        {
            Debug.Log(isMove);
            collision.transform.position = new Vector3(transform.position.x + xDirection * Time.deltaTime, transform.position.y, transform.position.z);
        }
    }
}
