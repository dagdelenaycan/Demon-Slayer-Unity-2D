using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ibliscan : MonoBehaviour
{
    public int health = 1;
    //AudioSource audioSource;

    

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
            //audioSource = GetComponent<AudioSource>();
            //audioSource.Play();

        }

    }
}
