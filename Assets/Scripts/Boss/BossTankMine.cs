using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTankMine : MonoBehaviour
{
    public GameObject explosion;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);

            Instantiate(explosion, transform.position, transform.rotation);

            PlayerHealthController.sharedInstance.DealWithDamage();

            AudioManager.sharedInstance.PlaySFX(3);
        }
    }

    public void Explode()
    {
        Destroy(gameObject);

        AudioManager.sharedInstance.PlaySFX(3);

        Instantiate(explosion, transform.position, transform.rotation);
    }
}
