using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCollider2 : MonoBehaviour
{
    [SerializeField] private GameObject spawnPrefab;
    [SerializeField] private float spawnTime = 3f;

    private float spawnCounter;

    // Start is called before the first frame update
    void Start()
    {
        spawnCounter = spawnTime;
        SpawnBox(5);
        
    }

    // Update is called once per frame
    void Update()
    {
        //nilai counter berkurang terus
        //kalo counter sudah 0, spawnbox & set nilai spawnCounter dengan spawnRate
        spawnCounter -= Time.deltaTime;
        if(spawnCounter < 0.1f)
        {
            SpawnBox(5);
            spawnCounter = spawnTime;
        }
    }

    private void SpawnBox(int countBox)
    {
        for (int i = 0; i < countBox; i++)
        {
        Vector3 randomPosition = new Vector3(Random.Range(-7.5f, 7.5f), Random.Range(-4.4f, 4.4f));
        Instantiate(spawnPrefab, randomPosition, Quaternion.identity);
        }
    }
}