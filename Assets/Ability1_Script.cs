using System.Collections;
using UnityEngine;

public class Ability1_Script : MonoBehaviour
{
    public float speed = 5.0f; // Adjust this to control the movement speed.
    public float distance = 10.0f; // Adjust this to set the total distance to move.
    private BulletSpawner player;
    private Vector3 initialPosition;

   
    private void Update()
    {
        // Move the UI image from right to left.
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

   
}
