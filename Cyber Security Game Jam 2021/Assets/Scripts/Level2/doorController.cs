using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class doorController : MonoBehaviour
{
    
    public GameObject pwdInputField;
    public GameObject inputFieldTMP;
    public TMP_Text errMsg;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player")
        {
            pwdInputField.SetActive(true);
            inputFieldTMP.SetActive(true);
            errMsg.text ="";
        }
    }
}
