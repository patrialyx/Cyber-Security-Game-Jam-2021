using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        FlyingBrownie flyingbrownie = collision.collider.GetComponent<FlyingBrownie>();
        if (flyingbrownie != null)
        {
            Destroy(gameObject);
        }
    }

}
