using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    [SerializeField]
    private GameObject PrefabBullet;

    [SerializeField]
    private Transform[] StartPosBullets;

    [SerializeField]
    private float ShootPower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_ANDROID || UNITY_IOS
        if (Input.GetButtonDown("Shoot"))
        {
            GameObject bullet = Instantiate(PrefabBullet);
            bullet.transform.position = StartPosBullets[0].position;
            bullet.GetComponent<Rigidbody>().AddForce(StartPosBullets[0].forward * ShootPower);

            GameObject bull = Instantiate(PrefabBullet);
            bull.transform.position = StartPosBullets[1].position;
            bull.GetComponent<Rigidbody>().AddForce(StartPosBullets[1].forward * ShootPower);
        }
#endif
    }
}
