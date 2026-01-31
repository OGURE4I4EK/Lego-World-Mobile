using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class scissorsTake : MonoBehaviour
{
    float range = 2f;
    public Camera cam;
    public RaycastHit hit;
    [SerializeField] GameObject take;

    public void Update()
    {
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            if (hit.transform.name == "scissors")
            {
                take.SetActive(true);
            }
            else if (hit.transform.name != "scissors")
            {
                take.SetActive(false);
            }
        }
    }
}