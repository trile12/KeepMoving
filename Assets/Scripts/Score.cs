
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text TextScore;
    public Text Ruby;


	
	// Update is called once per frame
	void Update () {

        TextScore.text = player.position.z.ToString("0");
        Ruby.text = FindObjectOfType<CLS>().Score.ToString("");	
	}
}
