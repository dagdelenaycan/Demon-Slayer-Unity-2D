using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iblishareket : MonoBehaviour

{
    public Transform giyu;
    public bool Hareketizni;
    public float karakterhiz;
    private Animator _animator;
    public bool yürü;
    //public int damage;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Awake()
    {

        //_rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        //started = true;
        //grounded = true;
    }

    // Update is called once per frame
    void Update()
    {


        if (Hareketizni)
        {
            karakterkovalama();
            //olanyer.GetComponent<karakterkontrol>().can -= azalmahiz * Time.deltaTime;
            

        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        karakterhiz = 1f;
        if (col.tag == "oyuncu")
        {
            Hareketizni = true;
            _animator.SetBool("yürü", true);
        }
        
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "oyuncu")
        {
            Hareketizni = false;
            _animator.SetBool("yürü", false);
        }
    }
    void karakterkovalama()
    {
        transform.position = Vector3.MoveTowards(transform.position, giyu.position, karakterhiz * Time.deltaTime);
    }
   
    
}
