using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{

    public static DeathZone instance;
    public Vector3 checkpoint;

    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null){
            instance = this;
        }else{
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        checkpoint = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    public void Die(){
        GameObject.FindGameObjectWithTag("Player").transform.position = checkpoint;
    }

}
