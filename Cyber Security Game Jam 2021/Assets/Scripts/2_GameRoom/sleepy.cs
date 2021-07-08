using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class sleepy : MonoBehaviour
{
    [SerializeField] private GameObject word;

    private void OnTriggerEnter2D(Collider2D other) {
        word.SetActive(true);
    }
}
