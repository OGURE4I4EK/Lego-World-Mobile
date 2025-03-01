using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class enemyAIPatrol : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] LayerMask groundLayer, playerLayer;
    [SerializeField] Animator animator;
    [SerializeField] GameObject Player;


    // patrol
    Vector3 destPoint;
    [SerializeField] float range;
    float rangee = 10f;
    public RaycastHit hit;
    public Camera Chelik;

    int status = 0;
    bool isPlayerFind = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Patrol();
    }

    private void Update()
    {
        Shoot();
    }

    IEnumerator ChangeAIPosition()
    {
        while (true)
        {
            if (!agent.pathPending && agent.remainingDistance < 0.1f)
            {
                float timeToStopOnPoint = Random.Range(0.5f, 3f);
                if (status == 1)
                {
                    animator.SetTrigger("Idle");
                    status = 0;
                    print("Idle");

                }

                Invoke(nameof(Patrol), timeToStopOnPoint);
                yield break;
            }
            else
            {
                if (status == 0)
                {
                    animator.SetTrigger("Walk");
                    status = 1;
                    print("Walk");
                }

                yield return null;
            }
        }
    }

    void Patrol()
    {
        SearchForDest();
        StartCoroutine(ChangeAIPosition());
    }

    private void Shoot()
    {
        if (Physics.Raycast(Chelik.transform.position, Chelik.transform.forward, out hit, rangee))
        {
            if (hit.transform.name == "Player" || hit.transform.name == "Main Camrera" ||
                hit.transform.name == "LeftHand Controller" || hit.transform.name == "RightHand Controller")
            {
                if (!isPlayerFind)
                {
                    RunForPlayer();
                    isPlayerFind = true;
                }
            }
            else
            {
                if (isPlayerFind)
                {
                    isPlayerFind = false;
                    Patrol();
                }
            }
        }
    }



    private void SearchForDest()
    {
        NavMeshTriangulation navMeshData = NavMesh.CalculateTriangulation();
        int randomIndex = Random.Range(0, navMeshData.vertices.Length);
        Vector3 randomPoint = navMeshData.vertices[randomIndex];
        agent.SetDestination(randomPoint);
    }

    private void RunForPlayer()
    {
        StopCoroutine(ChangeAIPosition());

        Vector3 PlayerPoint = Player.transform.position;
        animator.SetTrigger("Run");
        agent.speed = 70;
        agent.SetDestination(PlayerPoint);
    }

    void sad()
    {
        SceneManager.LoadScene("Act2");
    }
}
