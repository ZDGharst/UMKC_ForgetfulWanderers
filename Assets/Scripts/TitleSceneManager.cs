﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour
{
    public Button onePlayerButton;
    public Button twoPlayerButton;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void start1PGame()
    {
        ComputerOpponent.isActive = true;
        SceneManager.LoadScene(1);
    }

    public void start2PGame()
    {
        ComputerOpponent.isActive = false;
        SceneManager.LoadScene(1);
    }
}
