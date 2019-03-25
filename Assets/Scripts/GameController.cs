using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public static GameController ints;
  

    // Use this for initialization
    void Start () {
        _MakeInts();
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void _MakeInts()
    {
        if(ints==null)
        {
            ints = this;
        }
    }
    
    public void AgainButton()
    {
        Application.LoadLevel("Scene1");
    }

  
}
