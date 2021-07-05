using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickCloseButton1 : MonoBehaviour
{
    [SerializeField] private GameObject dialogue;

    public void onClick()
    {
        dialogue.SetActive(false);
    }
}
