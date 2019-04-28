using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockTosser : MonoBehaviour
{
    public GameObject rocks;
    public Transform[] spawnPoints;
    public float minDelay = .01f;
    public float maxDelay = .1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRocks());
    }

    IEnumerator SpawnRocks()
    {
        while (true)
        {
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);

            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];

            GameObject spawnedRocks = Instantiate(rocks, spawnPoint.position, spawnPoint.rotation);
            
            Destroy(spawnedRocks, 5f);
        }
    }
}