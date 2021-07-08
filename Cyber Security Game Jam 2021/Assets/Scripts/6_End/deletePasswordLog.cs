using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class deletePasswordLog : MonoBehaviour
{
    private string path;
    private string path1;
    // Start is called before the first frame update
    void Start()
    {
        path = Application.dataPath + "/passwordLog.txt";
        if (File.Exists(path))
        {
            File.Delete(path);
        }
        path1 = Application.dataPath + "/passwordLog.txt.meta";
        if (File.Exists(path1))
        {
            File.Delete(path1);
        }
        Debug.Log("successfully deleted password log");

    }

}
