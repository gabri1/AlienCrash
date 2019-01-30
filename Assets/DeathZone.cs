using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{

    public static DeathZone instance;
    public Transform checkpoint;

    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null){
            instance = this;
        }else{
            Destroy(this.gameObject);
        }
    }

    public void Die(){
        GameObject.Find("Player").transform.position = checkpoint.position;
    }

}
