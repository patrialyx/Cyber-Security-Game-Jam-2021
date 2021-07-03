using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterEmailButtonController : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button Back;
    public GameObject Home;
    public GameObject Email1;
    public GameObject Email2;
    public GameObject Email3;
    public GameObject Email4;
    public GameObject Email5;
    public GameObject CommonButtonsCanvas;

    public void Onenablede()
    {
        //Register Button Events
        button1.onClick.AddListener(() => buttonCallBack(button1));
        button2.onClick.AddListener(() => buttonCallBack(button2));
        button3.onClick.AddListener(() => buttonCallBack(button3));
        button4.onClick.AddListener(() => buttonCallBack(button4));
        button5.onClick.AddListener(() => buttonCallBack(button5));
        Back.onClick.AddListener(() => buttonCallBack(Back));
    }

    public void buttonCallBack(Button buttonPressed)
    {
        if (buttonPressed == button1)
        {
            //Your code for button 1
            Home.SetActive(false);
            Email1.SetActive(true);
            CommonButtonsCanvas.SetActive(true);
            Debug.Log("Clicked: " + button1.name);
        }

        if (buttonPressed == button2)
        {
            //Your code for button 2
            Home.SetActive(false);
            Email2.SetActive(true);
            CommonButtonsCanvas.SetActive(true);
            Debug.Log("Clicked: " + button2.name);
        }

        if (buttonPressed == button3)
        {
            //Your code for button 3
            Home.SetActive(false);
            Email3.SetActive(true);
            CommonButtonsCanvas.SetActive(true);
            Debug.Log("Clicked: " + button3.name);
        }


        if (buttonPressed == button4)
        {
            //Your code for button 4
            Home.SetActive(false);
            Email4.SetActive(true);
            CommonButtonsCanvas.SetActive(true);
            Debug.Log("Clicked: " + button4.name);
        }

        if (buttonPressed == button5)
        {
            //Your code for button 5
            Home.SetActive(false);
            Email5.SetActive(true);
            CommonButtonsCanvas.SetActive(true);
            Debug.Log("Clicked: " + button5.name);
        }

        if (buttonPressed == Back)
        {
            //Your code for button 5
            Debug.Log("Clickanot");
            Email1.SetActive(false);
            Email2.SetActive(false);
            Email3.SetActive(false);
            Email4.SetActive(false);
            Email5.SetActive(false);
            CommonButtonsCanvas.SetActive(false);
            Home.SetActive(true);
            Debug.Log("Clicked: " + button5.name);
        }
    }
}

