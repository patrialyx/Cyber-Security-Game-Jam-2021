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
    [SerializeField] private Image[] SwitchImages;
    public void NewGame() {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene(){
        character_rb2D.gravityScale = 3;
        yield return new WaitForSeconds(2.5f);
        transition_canvas.SetActive(true);
        transition_anim.SetTrigger("FadeOut");
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(sceneName_string);
    }
}
