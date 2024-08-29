using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyNeed : MonoBehaviour
{
    [SerializeField] GameObject key;
    [SerializeField] AudioSource da;
    [SerializeField] GameObject onTake1;
    [SerializeField] GameObject keyNeeed;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() != null)
        {
                da.Play();
                Invoke(nameof(net), 2f);
                keyNeeed.SetActive(false);
        }
    }
    void net()
    {
        key.SetActive(true);
        onTake1.SetActive(true);
    }
}
