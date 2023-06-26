using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;


public class Chase : MonoBehaviour
{
    bool InRange;
    public GameObject Me;
    public GameObject Player;
    public GameObject Couch;
    
    // Start is called before the first frame update
    void Start()
    {
        InRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (InRange == true)
        {
            Me.GetComponent<AIDestinationSetter>().target = Player.transform;
        }
        else
            Me.GetComponent<AIDestinationSetter>().target = Couch.transform;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            InRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            InRange = false;
        }
    }
}
