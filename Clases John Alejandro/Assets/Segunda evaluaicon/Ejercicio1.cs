using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public GameObject jugador;
    public float RangoVision;
    public float Velocidad;
    private Vector3 direcM;
    private Vector3 posicioninicail;

    // Start is called before the first frame update
    void Start()
    {
        posicioninicail = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, jugador.transform.position)<= RangoVision)
        {
            //En rango
            direcM = transform.position - jugador.transform.position;
            Quaternion rot = Quaternion.LookRotation(-direcM, Vector3.up);
            transform.rotation = rot;

            transform.Translate(Vector3.forward * Velocidad * Time.deltaTime, Space.Self);
        }
        else
        {
            //Fuera de rango
            direcM = transform.position - posicioninicail;
            Quaternion rot = Quaternion.LookRotation(-direcM, Vector3.up);
            transform.rotation = rot;

            if(Vector3.Distance(transform.position,posicioninicail)>= 0.5f)
            {
                transform.Translate(Vector3.forward * Velocidad * Time.deltaTime, Space.Self);
            }
        }
    }
}
