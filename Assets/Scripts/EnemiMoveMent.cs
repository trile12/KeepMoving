using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiMoveMent : MonoBehaviour {


    public float speed = 3f;
    public Vector3 temp;

    // Use this for initialization
    void Start () {

        temp = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        if (CLS.instance.flagg ==0)
        {
            EnemiMove();
        }
        _Destroy();
	}

    void EnemiMove()
    {
        
        temp.z -= speed * Time.deltaTime;
        transform.position = temp;
    
    }

    void _Destroy()
    {
        if(temp.z<-50f)
        {
            Destroy(gameObject);
        }
    }
}
