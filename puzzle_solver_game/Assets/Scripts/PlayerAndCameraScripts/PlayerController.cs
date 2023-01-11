using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] private Rigidbody _rb;
    [SerializeField] GameObject mKeyMenu;
    private float _speed = 5;
    private float _turnSpeed = 720;
    private float Fallmultiplier = 2.5f;
    private Vector3 _input;
    private Animator animator;
    private bool onTheGround = false;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update() {
        GatherInput();
        Jump();
        Look();
        HandleAnimation();
        mPressed();
    }

    private void FixedUpdate() {
        Move();
        Fall();
    }

    private void GatherInput() 
    {
        _input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
    }

    private void mPressed()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            mKeyMenu.SetActive(true);
        }
    }
        private void Look() 
    {
        if (_input == Vector3.zero) return;
        var rot = Quaternion.LookRotation(_input.ToIso(), Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, _turnSpeed * Time.deltaTime);
    }

    private void Move() 
    {
        _rb.MovePosition(transform.position + transform.forward * _input.normalized.magnitude * _speed * Time.deltaTime);
    }

    private void Jump()
    {
        if(Input.GetButtonDown("Jump") && onTheGround)
        {
            _rb.AddForce(new Vector3(0, 6, 0), ForceMode.Impulse);
            onTheGround = false;
        }
    }

    private void Fall()
    {
        if (_rb.velocity.y < 0)
        {
            _rb.velocity += Vector3.up * Physics.gravity.y * Fallmultiplier * Time.deltaTime;
        }
    }
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Ground")
        {
            onTheGround = true;
        }
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
public static class Helpers 
{
    private static Matrix4x4 _isoMatrix = Matrix4x4.Rotate(Quaternion.Euler(0, 45, 0));
    public static Vector3 ToIso(this Vector3 input) => _isoMatrix.MultiplyPoint3x4(input);
}