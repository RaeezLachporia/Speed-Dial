using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    public bool Collected = false;
    public GameObject GameMan;
    public GameObject DenyScreen;
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
            if (Collected)
            {
                GameMan.GetComponent<Game_Manager>().Win();   
            }
            else
            {
                DenyScreen.SetActive(true);
            }
        }
    }
}
