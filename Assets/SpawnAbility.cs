using System.Collections;
using UnityEngine;

public class SpawnAbility : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float moveSpeed = 5.0f; // Adjust this speed to control the movement speed

    private void Start()
    {
        StartCoroutine(StartScene());
    }

    private IEnumerator StartScene()
    {
        for (int i = 0; i < 10; i++)
        {
            SpawnPrefabAtParentPosition();
            yield return new WaitForSeconds(5);
        }
    }

    public void SpawnPrefabAtParentPosition()
    {
        if (prefabToSpawn != null)
        {
            GameObject spawnedPrefab = Instantiate(prefabToSpawn, transform.position, Quaternion.identity, transform);
            Rigidbody2D rb = spawnedPrefab.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                // Apply a leftward force to move the prefab from right to left
                rb.velocity = new Vector2(-moveSpeed, 0);
            }
            else
            {
                Debug.LogError("The spawned prefab should have a Rigidbody2D component for movement.");
            }
        }
    }
}
