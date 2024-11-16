using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boltiki : MonoBehaviour
{
    float range = 1f;
    public Camera cam;
    public GameObject bolt;
    public RaycastHit hit;
    public void Update()
    {
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            
        }
    }
}

