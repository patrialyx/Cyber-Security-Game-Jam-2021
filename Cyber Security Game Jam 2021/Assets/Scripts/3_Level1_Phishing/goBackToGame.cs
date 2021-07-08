using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goBackToGame : MonoBehaviour
{
    [SerializeField]
    private string sceneToContinue;
    // Start is called before the first frame update
    public void onClick()
    {
        SceneManager.LoadScene(sceneToContinue);
    }
}
