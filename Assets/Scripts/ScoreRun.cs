using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreRun : MonoBehaviour {

    public float ForceZ=4000f;

    public Rigidbody Sr;

	// Use this for initialization
	void Start () {

        Sr = GetComponent<Rigidbody>();
	}

    // Update is called once per frame

     void Update()
    {
        if(CLS.instance.flagg==1)
        {
            Destroy(Sr);
        }
    }
    void FixedUpdate () {

        Sr.AddForce(0,0,ForceZ * Time.deltaTime);
		
	}
}
