using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraFollow : MonoBehaviour
{
    public CinemachineVirtualCamera cinemachineVirtualCamera;

    // Start is called before the first frame update
    void Start()
    {
        cinemachineVirtualCamera.Follow = GameObject.FindGameObjectWithTag("Player").transform;
    }
}
