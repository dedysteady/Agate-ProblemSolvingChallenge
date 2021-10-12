using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCollider3 : MonoBehaviour
{
    [SerializeField] private GameObject spawnPrefab;
    [SerializeField] private float spawnTime = 10f;

    private float spawnCounter;

    // Start is called before the first frame update
    void Start()
    {
        spawnCounter = spawnTime;        
    }

    // Update is called once per frame
    void Update()
    {
        //nilai counter berkurang terus
        //kalo counter sudah 0, spawnbox & set nilai spawnCounter dengan spawnRate
        spawnCounter -= Time.deltaTime;
        if(spawnCounter < 0.1f)
        {
            SpawnBox(1);
            spawnCounter = spawnTime;
        }
    }

    private void SpawnBox(int countBox)
    {
       
        Vector3 randomPosition = new Vector3(Random.Range(-7.5f, 7.5f), Random.Range(-4.4f, 4.4f));
        Instantiate(spawnPrefab, randomPosition, Quaternion.identity);
        
    }
}