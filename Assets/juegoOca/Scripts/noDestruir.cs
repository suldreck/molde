using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noDestruir : MonoBehaviour {
    public static noDestruir juegoVariable;
    private void Awake()
    {
        
        if(juegoVariable ==null)
        {juegoVariable=this;
            DontDestroyOnLoad(gameObject);
         }else if(juegoVariable!=this)//no es null pero tampoco es lo q teniamos antes  
            {
            Destroy(gameObject);
            }
    }
    // Use this for initialization
    void Start()
    {
        jugadores = GameObject.FindObjectsOfType<PlayerStone>();
        //hand = GameObject.Find("Player3-StoneStorage ");
        
        //if (hand.GetType() == typeof(PlayerStone))
        //    Debug.Log("Es del mismo tipo que playerstone");
        theStateManager = GameObject.FindObjectOfType<StateManager>();
        for (int i = 0; i < jugadores.Length; i++)
        {
            Debug.Log("  " + i + "" + jugadores[i].name);
        }
        
    }
    StateManager theStateManager;
    PlayerStone [] jugadores;
    public GameObject hand;
    // Update is called once per frame
    void Update () {
		
	}
}
