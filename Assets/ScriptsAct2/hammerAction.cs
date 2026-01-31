using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class hammerAction : MonoBehaviour
{
    float range = 2f;
    public Camera cam;
    public RaycastHit hit;
    public Image hamInv;
    public GameObject box;
    public GameObject cutbox;
    public AudioSource zvuk;
    [SerializeField] GameObject actionBtn;

    public void Update()
    {
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            if (hamInv.enabled == true)
            {
                Debug.Log(hit.transform.name);
                if (hit.transform.CompareTag("box"))
                {
                    actionBtn.SetActive(true);
                    box = hit.collider.gameObject;
                    Transform cutboxT = box.transform.Find("cutbox");
                    cutbox = cutboxT.gameObject;
                }
                else if (hit.transform.tag != "box")
                    actionBtn.SetActive(false);
            }
            
        }
    }
    public void cut()
    {
        cutbox.transform.SetParent(null);
        box.SetActive(false);
        cutbox.SetActive(true);
        zvuk.Play();
    }
}
