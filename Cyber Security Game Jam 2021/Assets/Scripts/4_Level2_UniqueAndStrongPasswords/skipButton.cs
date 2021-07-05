using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skipButton : MonoBehaviour
{
    [SerializeField] private GameObject dialogue;
    [SerializeField] private GameObject newDialogue;
    [SerializeField] private GameObject ladder;

    public void onClick()
    {
        //set ladder to appear
        ladder.SetActive(true);
        //set dialogue to occur; take the elevator up (non gravitry column)
        newDialogue.SetActive(false);
        dialogue.SetActive(false);
    }
}
