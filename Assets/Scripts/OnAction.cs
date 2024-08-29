using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnAction : MonoBehaviour
{
    [SerializeField] GameObject ActionBtn;
    [SerializeField] GameObject TakeBtn;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() != null)
        {
            ActionBtn.SetActive(true);
            TakeBtn.SetActive(false);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        TakeBtn.SetActive(false);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() != null)
            ActionBtn.SetActive(false);
            TakeBtn.SetActive(false);
    }
}
