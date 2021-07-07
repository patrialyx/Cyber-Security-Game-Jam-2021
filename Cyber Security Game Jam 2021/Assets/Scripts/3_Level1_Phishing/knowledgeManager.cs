using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class knowledgeManager : MonoBehaviour
{
    public static knowledgeManager instance;
    [SerializeField] private GameObject heart;
    [SerializeField] private GameObject heart1;
    [SerializeField] private GameObject heart2;
    private int score = 0;
    private int live = 3;

    [SerializeField] private AudioSource dieSound;
    [SerializeField] private AudioSource keyboardSound;

    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private GameObject congratsCanvas;

    private void Awake(){
        instance = this;
    }
    public void minusLife(){
        live-=1;
        dieSound.Play();
    }

    public void addPoints(){
        score+=1;
    }

    private void Update(){
        Debug.Log("score: "+score);
        Debug.Log("live: "+live);
        if (Input.GetMouseButtonDown(0)){
            keyboardSound.Play();
        }
        switch(live){
            case 0:
                heart2.SetActive(false);
                break;
            case 1:
                heart1.SetActive(false);
                break;
            case 2:
                heart.SetActive(false);
                break;
        }
        if(score>=5)
        {
            congratsCanvas.SetActive(true);
        }
        if(live<=0)
        {
            //game over
            gameOverCanvas.SetActive(true);
            
        }
    }

    public void setScore(){
        score = 0;
    }
    public void setLive(){
        live = 3;
    }

    public void playAudio(AudioSource sound){
        sound.Play();
    }
    
}
