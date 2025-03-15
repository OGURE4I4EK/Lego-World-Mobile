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
                Invoke(nameof(da), 4f);
            }
    }
    void da()
    {
        badman.Play();
        Invoke(nameof(net), 2f);
    }
    public void net()
    {
        stairs.SetActive(true);
        stairs2.SetActive(false);
    }
}
