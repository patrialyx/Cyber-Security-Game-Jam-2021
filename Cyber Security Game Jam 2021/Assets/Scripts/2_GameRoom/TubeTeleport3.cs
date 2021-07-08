using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TubeTeleport3: MonoBehaviour
{
    private float xPos;
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Player")) {
            xPos = GameObject.Find("Character").transform.position.x; // get player current position
            PlayerPrefs.SetFloat("SavedXPosition", xPos); // save player current position
            SceneManager.LoadScene("Level3"); 
        }
    }
}