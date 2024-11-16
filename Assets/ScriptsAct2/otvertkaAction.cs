using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class otvertkaAction : MonoBehaviour
{
    float range = 1f;
    public Camera cam;
    public RaycastHit hit;
    [SerializeField] GameObject action;
    [SerializeField] Rigidbody lyuk;
    [SerializeField] Rigidbody keyBlue;
    [SerializeField] GameObject lyuk2;
    [SerializeField] GameObject otverInv;
    [SerializeField] AudioSource o;

    public void Update()
    {
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            if (hit.transform.name == "lyuk")
            {
                action.SetActive(true);
            }
            else if (hit.transform.name != "lyuk")
            {
                action.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.Q)) wakea();
    }
    public void wakea()
    {
        o.Play();
        otverInv.SetActive(false);
        Invoke(nameof(click), 2f);
    }
    public void click()
    {
        lyuk.isKinematic = false;
        keyBlue.isKinematic = false;
        Invoke(nameof(toi), 1f);
    }
    void toi()
    {
        lyuk2.SetActive(false);
    }
}
