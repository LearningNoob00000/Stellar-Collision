using UnityEngine;
using UnityEngine.UI;

public class UIMovingObject : MonoBehaviour
{
    public float speed = 5.0f; // Adjust this to control the movement speed.
    public Slider healthSlider; // Reference to your Slider component.
    private int bulletHits = 0;

    private void Start()
    {
        // Initialize the slider value to 1 at the start of the game.
        healthSlider.value = 1.0f;
    }

    private void Update()
    {
        // Move the UI image from right to left.
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            bulletHits++;

            // Decrease the slider value by a fraction.
            float healthDecrement = 1.0f / 10.0f; // 10 hits to reach zero.
            healthSlider.value -= healthDecrement;

            if (bulletHits >= 10)
            {
                // Reset the slider value to 1 and destroy the UI image.
                ResetHealthSlider();
                Destroy(gameObject);
            }
        }
    }

    private void ResetHealthSlider()
    {
        bulletHits = 0;
        healthSlider.value = 1.0f;
    }
}
