﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Door : MonoBehaviour
{
    public int levelToLoad;
    private SceneSwitcher sceneSwitcher;
    // Start is called before the first frame update
    void Start()
    {
        sceneSwitcher = GameObject.Find("SceneSwitcher").GetComponent<SceneSwitcher>();

    }

    // Update is called once per frame
    void Update()
    {
       if(Collision.gameObject.CompareTag("Player"))
        {
            sceneSwitcher.LoadLevel(levelToLoad);
        }
    }
}
