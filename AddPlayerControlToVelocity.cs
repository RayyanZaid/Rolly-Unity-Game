using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlToVelocity : MonoBehaviour
{
    
    public Vector3 vector3;
    public KeyCode keyp; //key for player to move forward
    public KeyCode keyn; //key for player to move backward
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() //FIXED makes it so it's called 100 times per second
    {
        if(Input.GetKey(keyp)) {
            GetComponent<Rigidbody>().velocity += vector3;    
        }
        if(Input.GetKey(keyn)) {
            GetComponent<Rigidbody>().velocity -= vector3;    
        }
        

    }
}
