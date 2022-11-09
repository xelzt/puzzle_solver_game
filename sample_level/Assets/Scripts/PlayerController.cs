using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _speed = 5;
    [SerializeField] private float _turnSpeed = 360;
    private Vector3 _input;
    private Animator animator;
    private bool onTheGround = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update() {
        GatherInput();
        Look();
        if(Input.GetButtonDown("Jump") && onTheGround)
        {
            _rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            onTheGround = false;
        }

        HandleAnimation();
    }

    private void FixedUpdate() {
        Move();
    }

    private void GatherInput() {
        _input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
    }
    
    private void Move() {
        _rb.MovePosition(transform.position + transform.forward * _input.normalized.magnitude * _speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Ground")
        {
            onTheGround = true;
        }
    }
    
    private void Look()
    {
        var matrix = Matrix4x4.Rotate(Quaternion.Euler(0,45,0));
        var skewedInput = matrix.MultiplyPoint3x4(_input);
        var relative = (transform.position + skewedInput) - transform.position;
        var rot = Quaternion.LookRotation(relative, Vector3.up);
        transform.rotation = rot;   
    }

     private void HandleAnimation()
    {
        if(onTheGround == false)
        {
            animator.SetBool("Idle", false);
            animator.SetBool("Move", false);
            animator.SetBool("Jump", true);
        }
        else
        {
            animator.SetBool("Jump", false);
        }

        if(_input != Vector3.zero && onTheGround == true)
        {
            animator.SetBool("Move", true); 
            animator.SetBool("Idle", false);
        }
        
        if(_input == Vector3.zero && onTheGround == true)
        {
            animator.SetBool("Move", false);
            animator.SetBool("Idle", true);
        }
    }
}
