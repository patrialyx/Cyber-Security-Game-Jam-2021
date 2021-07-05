using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour
{
    public Animator transitionAnim;
    public GameObject transitionCanvas;
    public string sceneName;
    public Rigidbody2D character;
    public void NewGame() {
        StartCoroutine(LoadScene());
        // SceneManager.LoadScene("GameRoom1");
    }

    IEnumerator LoadScene(){
        character.gravityScale = 3;
        yield return new WaitForSeconds(2.5f);
        transitionCanvas.SetActive(true);
        transitionAnim.SetTrigger("FadeOut");
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(sceneName);
    }
}
