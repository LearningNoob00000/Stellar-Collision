using System.Collections;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab; // The prefab for your bullet.
    public float bulletSpeed = 10f; // The speed at which bullets move to the right.
    public GameObject parentObject; // The object to be the parent of the spawned object.

    public float spawnInterval = 1.0f; // Time between each spawn.

    private float timeSinceLastSpawn = 0f;

    private bool speedBoostActive = false; // Flag to track speed boost.

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
            if (speedBoostActive)
            {
                objectRigidbody.velocity = Vector2.right * bulletSpeed * 2; // Apply speed boost.
            }
            else
            {
                objectRigidbody.velocity = Vector2.right * bulletSpeed;
            }
        }

        Destroy(spawnedObject, 7f); // Adjust the time as needed.
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ability1"))
        {
            // Trigger the playerDetect coroutine when Ability1 collides.
            StartCoroutine(playerDetect());
        }
    }

    private IEnumerator playerDetect()
    {
        // Apply speed boost for 8 seconds.
        bulletSpeed = 900;
        speedBoostActive = true;

        yield return new WaitForSeconds(8);

        // Reset the bullet speed to its original value.
        bulletSpeed = 400;
        speedBoostActive = false;
    }
}
