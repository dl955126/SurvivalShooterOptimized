using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    Transform playerTransform;
    EnemyHealth enemyHealth;
    PlayerHealth playerHealth;
    NavMeshAgent myNavMeshAgent;

    private void Start()
    {
        playerTransform = FindObjectOfType<PlayerMovement>().transform;
        enemyHealth = GetComponent<EnemyHealth>();
        playerHealth = playerTransform.GetComponent<PlayerHealth>();
        myNavMeshAgent = GetComponent<NavMeshAgent>();


    }

    void Update ()
    { 

        if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
            myNavMeshAgent.SetDestination (playerTransform.position);
        }
        else
        {
            myNavMeshAgent.enabled = false;
        }
    }
}
