using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPrefab;
    public float delaySpawn = 2f;
    public float intervalSpawn = 2f;
    public float speed = 2f;
    void Start()
    {
        InvokeRepeating("SpawnSphere", delaySpawn, intervalSpawn);
    }

    // Update is called once per frame
    private void SpawnSphere()
    {
        Instantiate(enemyPrefab, transform);   
    }
}
