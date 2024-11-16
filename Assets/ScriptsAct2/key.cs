using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
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
                scissorsNeed.Play();
                Invoke(nameof(fallScis), 1f);
                keyAction.SetActive(false);
                keyInv.SetActive(false);
        }
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
