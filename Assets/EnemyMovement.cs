using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2.0f;   // Speed of leftward movement
    public float maxYOffset = 0.5f; // Maximum up/down movement

    private Vector3 initialPosition;
    private float direction = 1.0f; // 1 for moving up, -1 for moving down
    private float currentYOffset = 0.0f;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        // Move left
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Move up and down within limits
        currentYOffset += direction * speed * Time.deltaTime;
        currentYOffset = Mathf.Clamp(currentYOffset, -maxYOffset, maxYOffset);

        // Apply the vertical movement
        Vector3 newPosition = transform.position;
        newPosition.y = initialPosition.y + currentYOffset;
        transform.position = newPosition;

        // Reverse direction if necessary
        if (currentYOffset >= maxYOffset || currentYOffset <= -maxYOffset)
        {
            direction *= -1.0f;
        }
    }

    // This method is called when a trigger collider is entered.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            // Check if the collision is with an object tagged as "Bullet"
            // If so, destroy this enemy
            Destroy(gameObject);
        }
    }
}
