using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class SelectorHandler:MonoBehaviour
{
    [SerializeField]
    private Button[] objButtonList;
    private int[] userSelectedList;
    private int[] modelAnswerList;
    private int[] emptyArray;
    [SerializeField]
    private Button maliciousButton;
    [SerializeField]
    public Button legitButton;
    [SerializeField]
    private GameObject legitCanvas;
    [SerializeField]
    private GameObject maliciousCanvas;
    [SerializeField]
    private GameObject maliciousWarning;
    [SerializeField]
    private GameObject maliciousCorrect;
    [SerializeField]
    private GameObject maliciousKindaCorrect;
    [SerializeField]
    private Button closeButton;
    // [SerializeField]
    // private Button backButton;
    [SerializeField]
    private GameObject BackButtonsCanvas;
    [SerializeField]
    private GameObject CloseButtonsCanvas;

    public void Start()
    {
        Debug.Log("Script started");

        userSelectedList =  new int[] {0,0,0,0,0,0,0,0,0,0,0};
        modelAnswerList = new int[] {0,0,0,0,0,0,0,1,1,0,1};
        emptyArray = new int[] {0,0,0,0,0,0,0,0,0,0,0};
    }

    public void OnEnabled()
    {
        objButtonList[0].onClick.AddListener(() => buttonCallBack(objButtonList[0]));
    }

    public void OnEnabled1()
    {
        objButtonList[1].onClick.AddListener(() => buttonCallBack(objButtonList[1]));
    }
    public void OnEnabled2()
    {
        objButtonList[2].onClick.AddListener(() => buttonCallBack(objButtonList[2]));
    }
    public void OnEnabled3()
    {
        objButtonList[3].onClick.AddListener(() => buttonCallBack(objButtonList[3]));
    }
    public void OnEnabled4()
    {
        objButtonList[4].onClick.AddListener(() => buttonCallBack(objButtonList[4]));
    }
    public void OnEnabled5()
    {
        objButtonList[5].onClick.AddListener(() => buttonCallBack(objButtonList[5]));
    }
    public void OnEnabled6()
    {
        objButtonList[6].onClick.AddListener(() => buttonCallBack(objButtonList[6]));
    }public void OnEnabled7()
    {
        objButtonList[7].onClick.AddListener(() => buttonCallBack(objButtonList[7]));
    }
    public void OnEnabled8()
    {
        objButtonList[8].onClick.AddListener(() => buttonCallBack(objButtonList[8]));
    }
    public void OnEnabled9()
    {
        objButtonList[9].onClick.AddListener(() => buttonCallBack(objButtonList[9]));
    }
    public void OnEnabled10()
    {
        objButtonList[10].onClick.AddListener(() => buttonCallBack(objButtonList[10]));
    }
    public void Malicious()
    {
        Debug.Log("malicious");
        maliciousButton.onClick.AddListener(() => buttonCallBack1(maliciousButton));
    }
    public void Legit()
    {
        Debug.Log("legit");
        legitButton.onClick.AddListener(() => buttonCallBack1(legitButton));
    }

    public void close()
    {
        closeButton.onClick.AddListener(() => buttonCallBack2());
    }
    
    // public void disableBackButton(){
    //     Debug.Log("apple");
    //     backButton.onClick.AddListener(() => buttonCallBack3());
    // }

    public void buttonCallBack(Button buttonPressed)
    {
        
        Debug.Log("buttonpressed-"+buttonPressed.ToString());
        
        for(int i=0;i<objButtonList.Length;i++){
            if(buttonPressed==objButtonList[i])
            {
                if (userSelectedList[i]==1)
                {
                    ColorBlock cb = buttonPressed.colors;
                    cb.selectedColor = Color.clear;
                    cb.normalColor = cb.selectedColor;
                    buttonPressed.colors = cb;
                    userSelectedList[i] = 0;
                }
                else
                {
                    ColorBlock cb = buttonPressed.colors;
                    cb.selectedColor = Color.red;
                    cb.normalColor = cb.selectedColor;
                    buttonPressed.colors = cb;
                    userSelectedList[i] = 1;
                }
            }
        }
       
    }
    public void buttonCallBack1(Button buttonPressed)
    {
        Debug.Log("buttoncallback1"+buttonPressed.ToString());
        CloseButtonsCanvas.SetActive(true);
        if (buttonPressed == legitButton)
        {
            BackButtonsCanvas.SetActive(true);
            legitCanvas.SetActive(true);
        }
        if (buttonPressed == maliciousButton)
        {
            maliciousCanvas.SetActive(true);
            if (checkEquality(userSelectedList, emptyArray))
            {
                maliciousWarning.SetActive(true);
            }
            else if (checkEquality(userSelectedList, modelAnswerList))
            {
                BackButtonsCanvas.SetActive(true);
                maliciousCorrect.SetActive(true);
            }
            else
            {
                BackButtonsCanvas.SetActive(true);
                maliciousKindaCorrect.SetActive(true);
            }
        }
    }

    public void buttonCallBack2()
    {
        legitCanvas.SetActive(false);
        maliciousWarning.SetActive(false);
        maliciousCorrect.SetActive(false);
        maliciousKindaCorrect.SetActive(false);
        CloseButtonsCanvas.SetActive(false);
    }

    // public void buttonCallBack3(){
    //     BackButtonsCanvas.SetActive(false);
    // }
    public static bool checkEquality<T>(T[] first, T[] second) {
        return Enumerable.SequenceEqual(first, second);
    }
}