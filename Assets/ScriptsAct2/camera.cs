using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;

    public void sigma()
    {
        canvas1.SetActive(false);
        canvas2.SetActive(true);
    }
    public void sigma2()
    {
        canvas1.SetActive(true);
        canvas2.SetActive(false);
    }
}
