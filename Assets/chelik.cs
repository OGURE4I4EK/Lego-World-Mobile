using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class chelik : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<NavMeshAgent>() != null)
        {
            SceneManager.LoadScene("Act2New");
        }
    }
}
