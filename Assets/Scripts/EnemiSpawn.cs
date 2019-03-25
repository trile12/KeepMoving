using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiSpawn : MonoBehaviour {

    public GameObject[] spawEnemies;

    public Transform spawPos;
    int randomInt;

    // Use this for initialization
    void Start () {

        StartCoroutine(_Spawner());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator _Spawner()
    {

        yield return new WaitForSeconds(2.5f);

        SpawnRandom();

        StartCoroutine(_Spawner());
    }



    void SpawnRandom()
    {
        randomInt = Random.Range(0, spawEnemies.Length);
        Instantiate(spawEnemies[randomInt], spawPos.position, spawPos.rotation);

    }
}
