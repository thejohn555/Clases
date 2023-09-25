using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addforce : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            rigid.AddForce(Vector3.up * fuerza, ForceMode.Force);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            rigid.AddForce(Vector3.up * fuerza, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            rigid.AddForce(Vector3.up * fuerza, ForceMode.Acceleration);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            rigid.AddForce(Vector3.up * fuerza, ForceMode.VelocityChange);
        }

        Debug.Log(rigid.velocity);

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            rigid.AddTorque(Vector3.up * fuerza, ForceMode.Force);
        }
        Debug.Log(rigid.angularVelocity);

    }
}
