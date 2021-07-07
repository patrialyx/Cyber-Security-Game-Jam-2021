using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class restartButton : MonoBehaviour
{
    [SerializeField] 
    private string sceneName;
    private string path;
    public void onClick()
    {
        path = Application.dataPath + "/passwordLog.txt";
        if (File.Exists(path))
        {
            File.Delete(path);
        }
        SceneManager.LoadScene(sceneName);
    }
}
