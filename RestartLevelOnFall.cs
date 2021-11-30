using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //allows for restart


public class RestartLevelOnFall : MonoBehaviour
{
   

    private void OnCollisionEnter(Collision collision) //no Update needed because this is just going to happen once 
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
