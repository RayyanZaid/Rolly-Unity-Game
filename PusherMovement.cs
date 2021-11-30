using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PusherMovement : MonoBehaviour
{

    bool cameBack = false;

    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 position = transform.position; 

        if(position.x >= -1 && position.x <= 1.5) {
            position.x+=0.02f;
        transform.position = position;
        }
        else if(position.x >= 1.5) {
            position.x = -1;
            transform.position = position;
            

        }
       
    }
}
