using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTrigger : MonoBehaviour
{
    public int damage;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "iblisdeneme") {
            collision.GetComponent<ibliscan>().TakeDamage(damage);
            //collision.GetComponent<iblishareket>().health-=damage;
            audioSource.Play();
        }
    }
}
