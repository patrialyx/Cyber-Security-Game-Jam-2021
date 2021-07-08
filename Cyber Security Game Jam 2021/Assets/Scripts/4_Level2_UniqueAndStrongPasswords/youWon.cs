using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youWon : MonoBehaviour
{
    [SerializeField] private GameObject dialogue;

    public void onClick()
    {
        //set dialogue to occur; take the elevator up (non gravitry column)
        dialogue.SetActive(false);
    }
}
