﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public void Play()
    { SceneManager.LoadScene("GameScene"); }

    public void Exit()
    { Application.Quit(); }
}