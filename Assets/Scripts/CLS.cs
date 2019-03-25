using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CLS : MonoBehaviour {

    public MovePlayer PlayerMoving;
    public int Score = 0;
    public GameObject obj;

   

    public float flagg = 0;

    public static CLS instance;

    [SerializeField]
    private Button instructionButton;




    void Awake()
    {
        _MakeInstance();

    }


     void Start()
    {
       
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    void _MakeInstance()
    {
        if(instance==null)
        {
            instance = this;
        }
    }
 
   
     void OnCollisionEnter(Collision collision)
    {
       
        if (collision.collider.tag == "Enemi")
        {
            flagg = 1;
            Debug.Log("Hit Enemi");
            FindObjectOfType<GameManager>().EndGame();
           
            instructionButton.gameObject.SetActive(true);
            // Restart();
        }                

    }
        void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Ruby")
        {
            Debug.Log("Hit Ruby");
            Score += 1;
            
            obj = GameObject.FindWithTag("Ruby");
            Destroy(other.gameObject);           
        }
    }


    

 


 

}
