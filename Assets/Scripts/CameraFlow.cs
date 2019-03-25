using UnityEngine;

public class CameraFlow : MonoBehaviour {

    public Transform Player;
    public Vector3 distance;


	
	// Update is called once per frame
	void Update () {
        transform.position = Player.position + distance;
		
	}
}
