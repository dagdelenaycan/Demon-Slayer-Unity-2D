using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kılıc : MonoBehaviour
{

    private Animator _animator;
    bool ates = false;
    //public int damage;


    private void Awake()
    {
        _animator = GetComponent<Animator>();

    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.F))
        {
            _animator.SetBool("ates", true);
            
        }
        else
        {
            _animator.SetBool("ates", false);
        }

    }
}
