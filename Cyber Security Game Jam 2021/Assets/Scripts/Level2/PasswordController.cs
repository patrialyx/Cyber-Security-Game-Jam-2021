/*using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PasswordController : MonoBehaviour
{
    public string password;
    public List<string> pwdStorage;
    public GameObject inputField;
    public TMP_InputField inputFieldColor;

    
    public void Start()
    {
        List<string> pwdStorage = new List<string>();
        inputFieldColor.ActivateInputField();
    }
    public void StorePassword()
    {
        password = inputField.GetComponent<Text>().text;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) 
        {
            if 
            inputFieldColor.image.color = Color.green;

        }
        if (Input.GetKeyUp(KeyCode.Return)) 
        { 
            inputFieldColor.image.color = Color.white;
            pwdStorage.Add(password);
            Debug.Log("added password to storage");
            inputFieldColor.Select();
            inputFieldColor.text = "";
            inputFieldColor.ActivateInputField();
            Debug.Log("selected text box again");
        }
    }
    
 

}
*/