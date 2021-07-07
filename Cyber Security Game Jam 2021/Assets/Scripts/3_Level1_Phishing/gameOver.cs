using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject heart1;
    [SerializeField] private GameObject heart2;
    [SerializeField] private GameObject heart3;
    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private GameObject gbutton1;
    [SerializeField] private GameObject gbutton2;
    [SerializeField] private GameObject gbutton3;
    [SerializeField] private GameObject gbutton4;
    [SerializeField] private GameObject gbutton5;
    [SerializeField] private GameObject canva1;
    [SerializeField] private GameObject canva2;
    [SerializeField] private GameObject canva3;
    [SerializeField] private GameObject canva4;
    [SerializeField] private GameObject canva5;
    [SerializeField] private GameObject backButtonCanvas;
    [SerializeField] private GameObject closeButtonCanvas;
    [SerializeField] private GameObject homeCanvas;
    [SerializeField] private AudioSource magicSound;
    public void onClick(){
            magicSound.Play();
            knowledgeManager.instance.setScore();
            knowledgeManager.instance.setLive();
            heart1.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(true);
            gbutton1.SetActive(true);
            gbutton2.SetActive(true);
            gbutton3.SetActive(true);
            gbutton4.SetActive(true);
            gbutton5.SetActive(true);
            canva1.SetActive(false);
            canva2.SetActive(false);
            canva3.SetActive(false);
            canva4.SetActive(false);
            canva5.SetActive(false);
            backButtonCanvas.SetActive(false);
            closeButtonCanvas.SetActive(false);
            homeCanvas.SetActive(true);
            gameOverCanvas.SetActive(false);
    }
}
