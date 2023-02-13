using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class azalma : MonoBehaviour

{
    public GameObject olanyer;
    public bool Azalma;
    public float azalmahiz;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Azalma)
        {
            olanyer.GetComponent<karakterkontrol>().can -= azalmahiz * Time.deltaTime;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "oyuncu")
        {
            Azalma = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "oyuncu")
        {
            Azalma = false;
        }
    }

}
