using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class restartButton : MonoBehaviour
{
    [SerializeField] private GameObject dialogue;
    [SerializeField] private GameObject door;
    [SerializeField] private GameObject smoke;
    private string path;
    public void onClick()
    {
        // restore the tiles
        door.SetActive(true);
        // delete the password text file and its meta file
        path = Application.dataPath + "/passwordLog.txt";
        if (File.Exists(path))
        {
            File.Delete(path);
            UnityEditor.AssetDatabase.Refresh();
        }
        // deactivate the smoke particles
        smoke.SetActive(false);

        // restore the columns
        GameObject.Find("Gate1").transform.position = new Vector3(1.38223f, 1.027547f, 0f);
        GameObject.Find("Gate1").transform.localScale = new Vector3(1.211593f, 10.4713f, 4.704653f);

        GameObject.Find("Gate2").transform.position = new Vector3(1.44f, -4.52f, 0f);
        GameObject.Find("Gate2").transform.localScale = new Vector3(1.211593f, 10.4713f, 4.704653f);

        // teleport character back to the start
        GameObject.Find("Character").transform.position = new Vector3(-23.8f, -17.9f, -10.67257f);

        dialogue.SetActive(false);
    }
}
