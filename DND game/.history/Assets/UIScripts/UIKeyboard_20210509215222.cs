﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIKeyboard : MonoBehaviour
{
    public OptionsMenu optionsMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            Debug.Log("pressed");
            optionsMenu.GameObject.setActive(true);
        }
    }
}
