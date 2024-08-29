using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTake1 : MonoBehaviour
{
    [SerializeField] GameObject onTakeBtn1;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() != null)
            onTakeBtn1.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() != null)
            onTakeBtn1.SetActive(false);
    }
}
