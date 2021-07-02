using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Key (4)") == null)
        {
            Debug.Log("Password successfully hacked!");
            return;
        }
        if (GameObject.Find("Key") == null ||
              GameObject.Find("Key (1)") == null ||
              GameObject.Find("Key (2)") == null ||
              GameObject.Find("Key (3)") == null)
        {
            Debug.Log("Hacking of password failed!");
            return;
        }
    }
}
