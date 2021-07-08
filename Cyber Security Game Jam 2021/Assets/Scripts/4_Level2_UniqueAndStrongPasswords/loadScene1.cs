using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private string sceneName;
    public void onClick()
    {

        SceneManager.LoadScene(sceneName);
    }

}
