using System.Collections;
using UnityEngine;

public class bulletscript : MonoBehaviour
{
    private BulletSpawner spawner; // Reference to the BulletSpawner component.

    private void Start()
    {
        // Attempt to find the BulletSpawner component in the same GameObject.
        spawner = GetComponent<BulletSpawner>();
        if (spawner == null)
        {
            // If the BulletSpawner component is not on the same GameObject,
            // you can attempt to find it in the scene or by other means.
            // For example, you can use FindObjectOfType or a public reference.
            spawner = FindObjectOfType<BulletSpawner>();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Destroy this object when it collides with anything.
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Ability1"))
        {
            Destroy(gameObject);

            if (spawner != null)
            {
                StartCoroutine(playerDetect());
            }
        }
    }

    private IEnumerator playerDetect()
    {
        if (spawner != null)
        {
            spawner.bulletSpeed = 900;
            spawner.spawnInterval = .5f;
            yield return new WaitForSeconds(8);
            spawner.bulletSpeed = 400;
            spawner.spawnInterval = 1.32f;
        }
    }
}
