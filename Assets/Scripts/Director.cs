﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSDirector : System.Object
{

    // singlton instance
    private static SSDirector _instance;

    public IsceneController currentSceneController { get; set; }
    public bool running { get; set; }

    //get instance anytime anywhere!
    public static SSDirector getInstance()
    {
        if (_instance == null)
        {
            _instance = new SSDirector();
        }
        return _instance;
    }

    public int getFPS()
    {
        return Application.targetFrameRate;
    }

    public void setFPS(int fps)
    {
        Application.targetFrameRate = fps;
    }
}
