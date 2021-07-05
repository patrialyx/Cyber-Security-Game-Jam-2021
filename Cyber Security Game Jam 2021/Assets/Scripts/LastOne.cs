using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LastOne : MonoBehaviour
{
    // Start is called before the first frame update
    public void onClick()
    {
        SceneManager.LoadScene("Introduction_password_hacking");
    }
}
