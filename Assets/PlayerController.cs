using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private BulletSpawner bulletspawner;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ability1"))
        {
            StartCoroutine(GetAbility());
        }
    }

    private IEnumerator GetAbility()
    {
        bulletspawner.bulletSpeed = 850f;
        yield return new WaitForSeconds(5);
        bulletspawner.bulletSpeed = 400f;
    }
}