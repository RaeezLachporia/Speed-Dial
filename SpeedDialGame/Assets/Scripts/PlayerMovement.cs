using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector2 DirectionFacing;
    public Rigidbody2D Rigid;

    float Vertical;
    float Horizontal;
    // Start is called before the first frame update
    void Start()
    {
        Rigid = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Vertical = Input.GetAxisRaw("Vertical");
        Horizontal = Input.GetAxisRaw("Horizontal");

        DirectionFacing = new Vector2(Horizontal, Vertical);

        Rigid.velocity = new Vector2(DirectionFacing.x * 5, DirectionFacing.y * 5);
    }
}
