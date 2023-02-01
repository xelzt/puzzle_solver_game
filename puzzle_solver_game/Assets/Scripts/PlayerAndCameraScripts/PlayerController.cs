using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] private Rigidbody _rb;
    [SerializeField] GameObject mKeyMenu;
    [SerializeField] GameObject tabKeyInventory;
    private readonly float Speed = 5;
    private readonly float TurnSpeed = 720;
    private readonly float Fallmultiplier = 2.5f;
    private Vector3 input;
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
        HandleSpecialKeyInput();
    }

    private void FixedUpdate() {
        Move();
        Fall();
    }

    private void GatherInput() 
    {
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
    }

    private void HandleSpecialKeyInput()
    {   
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (mKeyMenu.activeSelf == false)
            {
                mKeyMenu.SetActive(!mKeyMenu.activeSelf);
            }
            else mKeyMenu.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (tabKeyInventory.activeSelf == false)
            {
                tabKeyInventory.SetActive(!tabKeyInventory.activeSelf);
                InventoryManager.Instance.ListItem();
            }
            else tabKeyInventory.SetActive(false);
        }
    }
    private void Look() 
    {
        if (input == Vector3.zero) return;
        var rot = Quaternion.LookRotation(input.ToIso(), Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, TurnSpeed * Time.deltaTime);
    }

    private void Move() 
    {
        _rb.MovePosition(transform.position + input.normalized.magnitude * Speed * Time.deltaTime * transform.forward);
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
            _rb.velocity += Fallmultiplier * Physics.gravity.y * Time.deltaTime * Vector3.up;
        }
    }
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Ground"))
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

        if(input != Vector3.zero && onTheGround == true)
        {
            animator.SetBool("Move", true); 
            animator.SetBool("Idle", false);
        }
        
        if(input == Vector3.zero && onTheGround == true)
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