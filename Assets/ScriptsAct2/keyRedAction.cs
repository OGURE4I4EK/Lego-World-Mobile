using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class keyRedAction : MonoBehaviour
{
    float range = 2f;
    public Camera cam;
    public RaycastHit hit;
    [SerializeField] GameObject actionBtn;

    public void Update()
    {
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            if (hit.transform.name == "dver3")
            {
                actionBtn.SetActive(true);
            }
            else if (hit.transform.name != "dver3")
            {
                actionBtn.SetActive(false);
            }
        }
    }
}
