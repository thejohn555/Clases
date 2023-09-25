using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    private Rigidbody rigid;
    public float fuerza;
    // Start is called before the first frame update
    void Start()
    {
        
        rigid = gameObject.GetComponent<Rigidbody>();
    

    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hi");
        rigid.AddForce(Vector3.up * fuerza, ForceMode.Force);
    }
   /*
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("hi");
        rigid.AddForce(Vector3.up * fuerza, ForceMode.Force);
    }
   */
}
