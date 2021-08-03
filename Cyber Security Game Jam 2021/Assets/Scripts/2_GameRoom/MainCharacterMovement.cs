using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterMovement : MonoBehaviour
{
    public float MovementSpeed = 10;
    public float JumpForce = 10;
    private Rigidbody2D _rigidbody;

    [SerializeField]
    private float leftLimit;
    [SerializeField]
    private float rightLimit;
    [SerializeField]
    private float bottomLimit; 
    [SerializeField]
    private float topLimit; 

    private bool isGrounded;

    [SerializeField]
    public Transform Ground;
    public float checkRadius;
    public LayerMask whatIsGround;
    public LayerMask whatIsLadder;
    public float distance;
    private float inputVertical;


    private Animator anim;
    private bool isClimbing;

    private void Start()
    {
        anim = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update() 
    {
        
        isGrounded = Physics2D.OverlapCircle(Ground.position, checkRadius, whatIsGround);

        var movement = Input.GetAxis("Horizontal");

        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        Vector3 characterScale = transform.eulerAngles;

        if (movement < 0){
            characterScale.y = 180;
            // Debug.Log("moevement: "+movement);
            // transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            // Debug.Log("localscale:"+transform.position);
            // // transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y);
            // // transform.eulerAngles = new Vector3(0,180,0);
            // // transform.rotation = Quaternion.Euler(transform.rotationx)
            // // transform.localEulerAngles = transform.eulerAngles + new Vector3(0,180,0);
        }
        else if (movement > 0){
            characterScale.y = 0;
            // transform.eulerAngles = new Vector3(0,0,0);

            // Debug.Log("moevement: "+movement);
            // transform.position = new Vector3(-transform.position.x, transform.position.y, transform.position.z);

            // Debug.Log("localscale:"+transform.position);
            // // transform.position = transform.position+new Vector3(0, 180, 0);
            // // transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y);
            // // transform.eulerAngles = new Vector3(0,0,0);
            // // transform.localEulerAngles = transform.eulerAngles + new Vector3(0,180,0);

        }
        transform.eulerAngles = characterScale;
        // Debug.Log("eulerAngles:"+transform.eulerAngles);

        // else if (movement > 0){
        //     // transform.localScale = new Vector3(1,1,1);
        //     transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);

            // transform.eulerAngles = new Vector3(0,0,180);
        // }
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;


        // if (leftLimit < transform.position.x && transform.position.x < rightLimit)
        // {
        //     transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        // }
        // else if (transform.position.x <= leftLimit && movement > 0)
        // {
        //     transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        // }
        // else if (transform.position.x >= rightLimit && movement < 0)
        // {
        //     transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        // }

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001)
        {
            anim.SetTrigger("takeOff");
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

        if (isGrounded == false){
            anim.SetBool("isJumping", true);
        }
        else{
            anim.SetBool("isJumping", false);
        }

        if (movement == 0){
            anim.SetBool("isRunning", false);
        }
        else{
            anim.SetBool("isRunning", true);
        }
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, distance, whatIsLadder);

        if (hitInfo.collider!=null){
            if(Input.GetKeyDown(KeyCode.UpArrow)){
                isClimbing = true;
            }
        } else{
            isClimbing = false;
        }
        if (isClimbing == true){
            Debug.Log("is climb is true");
            inputVertical = Input.GetAxis("Vertical");
            _rigidbody.velocity = new Vector2(_rigidbody.position.x, inputVertical*MovementSpeed);
            _rigidbody.gravityScale = 0;
        }else{
            _rigidbody.gravityScale = 1;
        }

        

        

    }
}