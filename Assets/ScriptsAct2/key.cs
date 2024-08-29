using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    [SerializeField] BoxCollider lack;
    [SerializeField] BoxCollider lack2;
    [SerializeField] GameObject door;
    [SerializeField] GameObject door2;
    [SerializeField] GameObject scissors;
    [SerializeField] AudioSource scissorsNeed;
    [SerializeField] AudioSource scissorsFall;
    [SerializeField] GameObject keyAction;
    [SerializeField] GameObject keyInv;
    [SerializeField] GameObject onTake2;
    int b = 0;
    public void otkroy()
    {
            if (b == 0)
            {
                b++;
                lack.enabled = false;
                lack2.enabled = true;
                Invoke(nameof(DoSomething), 1f);
                door.SetActive(false); door2.SetActive(true);
                scissorsNeed.Play();
                Invoke(nameof(fallScis), 1f);
                keyAction.SetActive(false);
                keyInv.SetActive(false);
        }
    }

    private void DoSomething()
    {
        lack.enabled = true;
    }
    void fallScis()
    {
        scissorsFall.Play();
        Invoke(nameof(scis),1f);

    }
    void scis()
    {
        scissors.SetActive(true);
        onTake2.SetActive(true);
    }
}
