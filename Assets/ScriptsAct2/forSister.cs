using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forSister : MonoBehaviour
{
    [SerializeField] GameObject sister;
    [SerializeField] GameObject sister2;
    [SerializeField] GameObject stairs;
    [SerializeField] GameObject stairs2;
    [SerializeField] AudioSource sistir;
    public GameObject worker;
    public GameObject button;
    public GameObject woodik1;
    public GameObject woodik2;
    [SerializeField] AudioSource badman; int a = 0;
    public void otrezh()
    {
            if( a == 0 )
            {
                a++;
                sister2.SetActive(true);
                sistir.Play();
                sister.SetActive(false);
                worker.SetActive(false);
                button.SetActive(false);
                Invoke(nameof(net), 4f);
            }
    }
    public void net()
    {
        stairs.SetActive(true);
        stairs2.SetActive(false);
        woodik1.SetActive(true); woodik2.SetActive(true);
    }
}
