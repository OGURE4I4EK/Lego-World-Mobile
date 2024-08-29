using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeButton : MonoBehaviour
{
    [SerializeField] GameObject photo;
    [SerializeField] GameObject photoInv;
    [SerializeField] GameObject TakeBtn;
    [SerializeField] GameObject OnBtnTake;
    [SerializeField] BoxCollider batman;
    List<string> Inventory = new List<string>();

    private void Start()
    {
        TakeBtn.SetActive(false);
        print("Take Button off");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) PickUp();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() != null)
            TakeBtn.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() != null)
            TakeBtn.SetActive(false);
    }
    public void PickUp()
    {
        Inventory.Add("photo");
        photo.SetActive(false);
        photoInv.SetActive(true);
        TakeBtn.SetActive(false);
        OnBtnTake.SetActive(false);
        batman.enabled = true;
    }
}