using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGoal : MonoBehaviour
{

    private SpawnManager spawnscript;

    private void Start()
    {
        spawnscript = FindObjectOfType<SpawnManager>();
    }
    private void OnCollisionEnter(Collision other)
    {
        if ((other.gameObject.CompareTag("Enemy")))
        {
            Destroy(other.gameObject);
            spawnscript.enemysInScene--;
        }

    }
}
