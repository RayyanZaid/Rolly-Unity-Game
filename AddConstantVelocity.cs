using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddConstantVelocity : MonoBehaviour
{
    
    public Vector3 vector3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() //FIXED makes it so it's called 100 times per second
    {
        //need to coordinate with RigidBody script (physics)
        GetComponent<Rigidbody>().velocity += vector3;

    }
}
