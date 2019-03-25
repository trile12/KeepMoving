
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject spawner;

    public void Awake()
    {
        spawner = GameObject.Find("EnemiSpawn");
    }

    public void EndGame()
    {
        Debug.Log("Game Over");

        Destroy(spawner);

      
     
    }
    //public void Destroy()
    //{
    //    Destroy(gameObject);
    //}
    


}
