using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revealObj : MonoBehaviour
{
    [SerializeField] private GameObject obj; 
    
    private void OnTriggerEnter2D(Collider2D other) {
        obj.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D other) {
        obj.SetActive(false);
    }
}
