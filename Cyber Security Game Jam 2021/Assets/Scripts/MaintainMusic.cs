using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MaintainMusic : MonoBehaviour
{
    private static MaintainMusic instance = null;
    public static MaintainMusic Instance
    {
        get { return instance; }
    }

    /// This method is called after all objects are initialized.
    /// 
    /// The background sound for Level 3 will end when it reaches "Game" Scene.
    public void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);


    }

}
