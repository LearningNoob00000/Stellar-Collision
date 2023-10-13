using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab; // The prefab for your bullet.
    public float bulletSpeed = 10f; // The speed at which bullets move to the right.
    public GameObject parentObject; // The object to be the parent of the spawned object.

    public float spawnInterval = 1.0f; // Time between each spawn.

    private float timeSinceLastSpawn = 0f;

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnObject();
            timeSinceLastSpawn = 0f;
        }
    }

    void SpawnObject()
    {
        Vector3 spawnPosition = transform.position;
        GameObject spawnedObject = Instantiate(bulletPrefab, spawnPosition, Quaternion.identity);
        spawnedObject.transform.SetParent(parentObject.transform);

        Rigidbody2D objectRigidbody = spawnedObject.GetComponent<Rigidbody2D>();

        if (objectRigidbody)
        {
            objectRigidbody.velocity = Vector2.right * bulletSpeed;
        }

        Destroy(spawnedObject, 5f); // Adjust the time as needed.
    }
}
