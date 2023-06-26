using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_Player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GameMan;
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
            GameMan.GetComponent<Game_Manager>().Die();
        }
    }
}
