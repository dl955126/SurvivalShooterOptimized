using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{
    public EnemyHealth enemy;
    public EnemyManager enemyManager;
    [SerializeField] int enemyAmount;

    Queue<EnemyHealth> remainingEnemies = new Queue<EnemyHealth>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < enemyAmount; i++)
        {
            var e = Instantiate(enemy);
            e.SetPool(this);
            e.gameObject.SetActive(false);
        
        }
        
    }

    public void SpawnEnemies(Vector3 location)
    {
        if(remainingEnemies.Count > 0)
        {
            var current = remainingEnemies.Dequeue();
            current.gameObject.SetActive(true);
            current.transform.position = location;
        }
    }

    public void AddToQueue(EnemyHealth enemy)
    {
        remainingEnemies.Enqueue(enemy);
    }
}
