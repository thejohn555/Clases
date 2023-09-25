using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform target;
    Vector3 offset;
    //public Transform cañon;

    // Start is called before the first frame update
    void Start()
    {
        //target = GameObject.FindGameObjectWithTag("Jugador").transform;

        offset = transform.position - target.position;


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 orbit = - Vector3.forward * offset.magnitude;
        orbit = Quaternion.Euler(0, target.eulerAngles.y, 0) * orbit;

        transform.position = target.position + orbit + new Vector3(0, 3f, 0);

        //transform.rotation = Quaternion.Euler(target.rotation.x, transform.rotation.y, target.rotation.z);
        //transform.rotation = target.rotation;
        transform.LookAt(target);
    }
}
