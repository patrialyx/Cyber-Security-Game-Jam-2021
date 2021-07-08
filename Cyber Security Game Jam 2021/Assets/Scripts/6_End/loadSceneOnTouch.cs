using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadSceneOnTouch : MonoBehaviour
{
    [SerializeField] private string nextScene;
    private void OnTriggerEnter2D(Collider2D other) {
        SceneManager.LoadScene(nextScene);
    }
}
