using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnoroffTV : MonoBehaviour
{
    [SerializeField] GameObject tvOff;
    [SerializeField] GameObject tvOn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "tv on")
        {
            tvOff.SetActive(false);
            tvOn.SetActive(true);
            print("TV On");
        }
        else if (other.gameObject.tag == "tv off")
        {
            tvOn.SetActive(false);
            tvOff.SetActive(true);
            print("TV Off");
        }
    }

    private void Awake()
    {
        tvOff.SetActive(true);
        tvOn.SetActive(false);
    }
}
