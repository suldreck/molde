﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sPanel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKey)
        {
            menus();
        }

        
       
	}
    void menus()
    {
        Debug.Log("menu "+ SceneManager.GetActiveScene().name);
        switch (SceneManager.GetActiveScene().name)

        {
            case "menu":
                if (Input.GetKeyDown(KeyCode.S) == true)
                {
                    Debug.Log("entro  con la S");
                    Application.Quit();
                }

                if (Input.GetKeyDown(KeyCode.J) == true)
                {
                    Debug.Log("entro  con la j ");
                    SceneManager.LoadScene("oca");
                }

                if (Input.GetKeyDown(KeyCode.O) == true)
                {
                    Debug.Log("entro  con la o ");
                    SceneManager.LoadScene("opciones");
                }
                break;
            case "oca":
                break;
            case "opciones":
                if (Input.GetKeyDown(KeyCode.M) == true)
                {
                    Debug.Log("entro  con la M");
                    SceneManager.LoadScene("menu");
                    Application.Quit();
                }

                if (Input.GetKeyDown(KeyCode.Plus) == true)
                {
                    Debug.Log("entro  con la j ");//Todo opcion de mas jugadores
                }

                if (Input.GetKeyDown(KeyCode.Minus) == true)
                {
                    Debug.Log("entro  con la m ");//Todo opcion menos jugadores
                }
                if (Input.GetKeyDown(KeyCode.I) == true)
                {
                    Debug.Log("entro  con la o ");//Todo opcion menos jugadores
                }
                break;
        }
    }
}