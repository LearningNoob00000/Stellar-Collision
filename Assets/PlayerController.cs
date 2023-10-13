using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public GameObject prefab;
    void Start()
    {
        StartCoroutine(SpawnPrefab());
    }

    private IEnumerator SpawnPrefab()
    {
       
        for (int i = 0; i < 100; i++)
        {
            GameObject spawnedPrefab = Instantiate(prefab, transform.position, Quaternion.identity);
            spawnedPrefab.transform.parent = transform; // Set the spawner as the parent

            yield return new WaitForSeconds(.1f);
        }
    }
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0.0f) * moveSpeed * Time.deltaTime;

        transform.Translate(movement);

        // Optional: You can clamp the position to keep the GameObject within certain boundaries if needed.
        // For example, to keep the GameObject within a screen boundary:
        // Vector3 clampedPosition = transform.position;
        // clampedPosition.x = Mathf.Clamp(clampedPosition.x, minX, maxX);
        // clampedPosition.y = Mathf.Clamp(clampedPosition.y, minY, maxY);
        // transform.position = clampedPosition;
    }
}
