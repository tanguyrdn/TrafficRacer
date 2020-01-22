using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    [SerializeField]
    private int Damage;       
    [SerializeField]    
    private float Lifetime;

    void Start()
    {
        Destroy(gameObject, Lifetime);

        if (Lifetime <= 0)
            Debug.Log("Balle Inutile");
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        if (collision.gameObject.tag == "Ennemis")
        {
            collision.gameObject.GetComponentInParent<LifeScript>().UpdateLife(-Damage);
        }

    }
}
