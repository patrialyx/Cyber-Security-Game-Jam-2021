﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class PauseBGAudio : MonoBehaviour
{
    /// This method is called on the frame when a script is enabled just before any of the Update methods are called the first time.
    /// 
    /// If scene is "Game", destroy this script.
    public void Start()
    {
        Destroy(GameObject.Find("Music"));
    }

    /// This method is called every frame.
    /// 
    /// If scene is "Game", destroy this script.
    public void Update()
    {

    }

    /// This method is called after all objects are initialized.
    /// 
    /// The background sound for Level 3 will end when it reaches "Game" Scene.
    public void Awake()
    {

    }
}
