using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject GameMan;
    // Start is called before the first frame update
    void Start()
    {
        GameMan = GameObject.FindGameObjectWithTag("Game Manager");  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("PlayerEnter");
            GameMan.GetComponent<Game_Manager>().Collect();
            Destroy(this.gameObject);
        }
    }
}
