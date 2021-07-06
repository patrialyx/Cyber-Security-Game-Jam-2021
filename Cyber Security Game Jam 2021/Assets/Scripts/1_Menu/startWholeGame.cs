using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class startWholeGame : MonoBehaviour
{
    [SerializeField] private Animator transition_anim;
    [SerializeField] private GameObject transition_canvas;
    [SerializeField] private string sceneName_string;
    [SerializeField] private Rigidbody2D character_rb2D;

    [SerializeField] private GameObject buttonSprite; 
    [SerializeField] private AudioSource clickSound; 
    

    private SpriteRenderer buttonColor;

    private void Start() {
        buttonColor = buttonSprite.GetComponent<SpriteRenderer>();
    }

    public void onMouseDown()
    {
        clickSound.Play(0);
    }
    public void NewGame() {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene(){
        buttonColor.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        yield return new WaitForSeconds(0.2f);
        buttonColor.color = new Color(0.7f, 0.7f, 0.7f, 1f);
        character_rb2D.gravityScale = 3;
        yield return new WaitForSeconds(2f);
        transition_canvas.SetActive(true);
        transition_anim.SetTrigger("FadeOut");
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(sceneName_string);
    }
}
