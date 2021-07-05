using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickCloseButton : MonoBehaviour
{
    [SerializeField] private GameObject gamePart2_dialogue;
    [SerializeField] private GameObject smoke;
    [SerializeField] private GameObject timeControl;
    [SerializeField] private GameObject prevDia;
    [SerializeField] private GameObject nextDia;

    public void onClick()
    {
        GameObject.Find("Character").transform.position = new Vector3(-23.8f, -17.9f, -10.67257f);
        smoke.SetActive(true);
        timeControl.SetActive(true);
        prevDia.SetActive(false);
        nextDia.SetActive(true);
        // GameObject.Find("Character").GetComponent<PasswordController>().enabled = false;
        // GameObject.Find("Character").GetComponent<PasswordController1>().enabled = true;
        gamePart2_dialogue.SetActive(false);
    }
}
