using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class springController : MonoBehaviour
{
    public float thrust = 20.0f;
    public Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player")
        {
            _rigidbody.AddForce(new Vector2(0, 50f), ForceMode2D.Impulse);        
        }
    }
    
}
