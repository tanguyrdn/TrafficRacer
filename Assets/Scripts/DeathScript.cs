using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
    public Transform RespawnPos;
    [SerializeField]
    Scene scene = SceneManager.GetActiveScene(); 


    
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Obstacle")
        {
             if (scene.name == "Road2")
                SceneManager.LoadScene("Road2");
            } else if (scene.name == "Road1")
                SceneManager.LoadScene("Road1");
    }
}
