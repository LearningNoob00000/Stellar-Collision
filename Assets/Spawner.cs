using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        StartCoroutine(SpawnPrefab());
    }

    private IEnumerator SpawnPrefab()
    {
        int randomIndex = Random.Range(0, 4);
        for (int i = 0; i < 100; i++)
        {
            GameObject spawnedPrefab = Instantiate(prefab, transform.position, Quaternion.identity);
            spawnedPrefab.transform.parent = transform; // Set the spawner as the parent

            yield return new WaitForSeconds(randomIndex);
        }
    }

    void Update()
    {
        // Update logic here if needed
    }
}
