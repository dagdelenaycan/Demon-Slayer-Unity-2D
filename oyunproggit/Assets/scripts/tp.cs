using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tp : MonoBehaviour
{
    public GameObject giyu;
    public GameObject tpcikis;
    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.gameObject.CompareTag("oyuncu"))//eger tagi Player olan obje gelirse
        {
            giyu.transform.position = tpcikis.transform.position;//rabbit olan objenin konumunu , PortalCikis olan objenin konumuna getir. 
        }
    }
}
