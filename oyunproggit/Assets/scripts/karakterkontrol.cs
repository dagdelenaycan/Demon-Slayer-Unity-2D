using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class karakterkontrol : MonoBehaviour
{

    private Rigidbody2D _rigidbody2D;
    public Vector3 offset;
    Vector2 forward;
    bool faceRight = false;
    public int turnDelay;
    private Animator _animator;
    float moveInput;
    public float can;
    //float Speed;



    private void Awake()
    {

        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        //started = true;
        //grounded = true;
    }

    // void Start()
    //{
    //  playerAnimator = GetComponent<Animator>();
    //}


    // private void FixedUpdate()
    //{
    //  playerAnimator.SetFloat("Speed",Mathf.Abs(moveInput));
    //}


    // Update is called once per frame
    private void Update()
    {

        if (can<=0)
        {
            //Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }

        float Speed = 3f;
        if (Input.GetKey(KeyCode.A))
        {
            // A tuþuna týklandýðý zaman yapýlacak iþlemler.
            this.transform.Translate(-(Speed * Time.deltaTime), 0, 0);
            // Karakterin sola doðru gitmesini saðladýk.
            _animator.SetFloat("Speed", -3f);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            // A tuþuna týklandýðý zaman yapýlacak iþlemler.
            this.transform.Translate((Speed * Time.deltaTime), 0, 0);
            // Karakterin sola doðru gitmesini saðladýk.
            _animator.SetFloat("Speed", 3f);
        }

        else if (Input.GetKey(KeyCode.W))
        {
            // A tuþuna týklandýðý zaman yapýlacak iþlemler.
            this.transform.Translate(0, (Speed * Time.deltaTime), 0);
            // Karakterin sola doðru gitmesini saðladýk.
            _animator.SetFloat("Speed", 3f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            // A tuþuna týklandýðý zaman yapýlacak iþlemler.
            this.transform.Translate(0, -(Speed * Time.deltaTime), 0);
            // Karakterin sola doðru gitmesini saðladýk.
            _animator.SetFloat("Speed", -3f);
        }
        else
        {
            this.transform.Translate(0, 0, 0);
           // _animator.SetBool("Grounded", true);
            //Grounded = true;
            _animator.SetFloat("Speed", 0);

        }

    }
}
