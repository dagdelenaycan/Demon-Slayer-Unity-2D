using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sesseviye : MonoBehaviour
{

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("oyuncu"))
        {

            //Destroy(other.gameObject);
            //count++;
            audioSource.Play();
            //ScoreManager.instance.AddPoint();
        }
    }
}
