using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NJugadores : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        jugadores = 1;

        caja = GameObject.FindObjectOfType<Text>();
        
    }
    Text caja;
    int jugadores;
	// Update is called once per frame
	void Update () {
        if (caja!= null)
        {
            jugadores = int.Parse(caja.text);
            if (jugadores > 4)
                jugadores = 4;
        }
    }
    public void operacion(bool signo)
    {


        if (signo)
        {
            if (jugadores < 4)
                jugadores = jugadores + 1;
        }
        else
        {
            if(jugadores>1)
                jugadores = jugadores - 1;
        }
        caja.text =""+ jugadores;
        //caja.text = "nada";

    }
}
