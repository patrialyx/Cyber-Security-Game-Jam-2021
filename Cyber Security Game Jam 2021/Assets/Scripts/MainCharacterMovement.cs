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

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update() 
    {
        var movement = Input.GetAxis("Horizontal");
        Debug.Log("movement"+ movement.ToString());
        Debug.Log("leftlimit"+ leftLimit.ToString());
        Debug.Log("rightlimit"+ rightLimit.ToString());
        Debug.Log("transform"+ transform.position.x.ToString());

        if (leftLimit < transform.position.x && transform.position.x < rightLimit)
        {
            transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        }
        else if (transform.position.x <= leftLimit && movement > 0)
        {
            transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        }
        else if (transform.position.x >= rightLimit && movement < 0)
        {
            transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        }

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

    }
}