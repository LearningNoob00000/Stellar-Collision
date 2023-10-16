using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5.0f; // Adjust this to control the movement speed.

    private void Update()
    {
        // Move the UI image from right to left.
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // Destroy this game object and log the collision.
            Debug.Log("Collision with Bullet");
            Destroy(gameObject);
        }
    }
}



