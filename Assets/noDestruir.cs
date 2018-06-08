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
    void Start () {
    
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
