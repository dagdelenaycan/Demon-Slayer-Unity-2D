using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kedi : MonoBehaviour
{
    private int count = 0;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            
            Destroy(other.gameObject);
            count++;
            audioSource.Play();
            ScoreManager.instance.AddPoint();
        }
    }
}
