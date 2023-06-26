using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class Enemy_Manager : MonoBehaviour
{
    public GameObject Player;
    public Rigidbody2D Rigid;
    public Vector2 Heading;
    public bool Alerted = false;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Rigid = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Alerted == true)
        {
            Chase();
        }      
    }

    public void TurnAround()
    {
        
    }

    public void FixedUpdate()
    {
        Rigid.velocity = transform.up * 3;
    }

    public void Chase()
    {
        Vector2 Direction = Player.transform.position - this.transform.position;
        float PlayerAngle = Mathf.Atan2(Player.transform.position.y, Player.transform.position.x) * Mathf.Rad2Deg - 90f;
        Quaternion q = Quaternion.Euler(new Vector3(0, 0, PlayerAngle));
        this.transform.localRotation = Quaternion.Slerp(this.transform.localRotation, q, 2);
    }

    
}
