using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControllerScript : MonoBehaviour
{
    [SerializeField]
    private float Speed;
    [SerializeField]
    private float RotationSpeed;

    /*[SerializeField]
    [Range(0,500)]
    private float JumpForce;

    private int NbColliderInTrigger = 0;*/

    void Update()
    {
#if UNITY_ANDROID || UNITY_IOS
        float DeltaSpeed = Speed * Time.deltaTime;
        Vector3 CurrentSpeed = GetComponent<Rigidbody>().velocity;
        Vector3 MaxSpeed = Speed * transform.forward;

        GetComponent<Rigidbody>().AddForce(MaxSpeed - CurrentSpeed);
        if (Input.touchCount > 0)
        {
            foreach (Touch t in Input.touches)
            {
                Debug.Log(t.position);
                if (t.position.x > Screen.width / 2)
                {
                    GetComponent<Rigidbody>().AddForce(new Vector3(10, 0, 0));
                }
                else
                {
                    GetComponent<Rigidbody>().AddForce(new Vector3(-10, 0, 0));
                }
            }
        }
#endif
        //float DeltaSpeed = Speed * Time.deltaTime;
        //float DeltaRot = RotationSpeed * Time.deltaTime;

        /*int Axe = 0;
        if (Input.GetKey(KeyCode.Z))
            Axe = 1;
        if (Input.GetKey(KeyCode.S))
            Axe = -1;*/

        /*Vector3 CurrentSpeed = GetComponent<Rigidbody>().velocity;
        Vector3 MaxSpeed = Speed * transform.forward;*/

        //GetComponent<Rigidbody>().AddForce(MaxSpeed - CurrentSpeed);

        /*float Xaxis = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0, Xaxis * DeltaRot, 0));*/


        /*if (Input.GetKeyDown(KeyCode.Space) && NbColliderInTrigger>0 )
            GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpForce, 0));*/


    }

    /*private void OnTriggerEnter(Collider other)
    {
        NbColliderInTrigger++;
    }

    private void OnTriggerExit(Collider other)
    {
        NbColliderInTrigger--;
    }*/
}
