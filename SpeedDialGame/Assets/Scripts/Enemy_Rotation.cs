using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Enemy_Rotation : MonoBehaviour
{
    public AIPath Route;
    Vector2 RotationSet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookForward();
    }

    public void LookForward()
    {
        RotationSet = Route.desiredVelocity;
        transform.right = RotationSet;
    }
}
