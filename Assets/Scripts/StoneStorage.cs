using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoneStorage : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        // Create one stone for each placeholder spot
        Debug.Log("partida : " + gameObject.GetComponents<PlayerStone>().Length);
        //GameObject[] goArray = SceneManager.GetSceneByName("oca").GetRootGameObjects();
       /* if (goArray!=null)
        {*/
            for (int i = 0; i < this.transform.childCount; i++)
            {
                // Instantiate a new copy of the stone prefab
                GameObject theStone = Instantiate(StonePrefab);
                theStone.GetComponent<PlayerStone>().StartingTile = this.StartingTile;
                theStone.GetComponent<PlayerStone>().MyStoneStorage = this;
                partida = true;
                AddStoneToStorage(theStone, this.transform.GetChild(i));
            }
        //}
       // DontDestroyOnLoad(gameObject);//no destruyas las fichas 
Debug.Log("partida : " + partida);
    }

    public GameObject StonePrefab;
    public Tile StartingTile;
    private bool partida = false;

    public void AddStoneToStorage(GameObject theStone, Transform thePlaceholder = null)
    {
        if (thePlaceholder == null)
        {
            // Find the first empty placeholder.
            for (int i = 0; i < this.transform.childCount; i++)
            {
                Transform p = this.transform.GetChild(i);
                if (p.childCount == 0)
                {
                    // This placeholder is empty!
                    thePlaceholder = p;
                    break;  // Break out of the loop.
                }
            }

            if (thePlaceholder == null)
            {
                Debug.LogError("We're trying to add a stone but we don't have empty places. How did this happen?!?!?");
                return;
            }
        }

        // Parent the stone to the placeholder
        theStone.transform.SetParent(thePlaceholder);

        // Reset the stone's local position to 0,0,0
        theStone.transform.localPosition = Vector3.zero;
    }
}
