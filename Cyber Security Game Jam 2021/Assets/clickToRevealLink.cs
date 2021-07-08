using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickToRevealLink : MonoBehaviour
{
    [SerializeField] private GameObject fakeEmailText;
    // Start is called before the first frame update
    public void onClick(){
        fakeEmailText.SetActive(true);
    }
}
