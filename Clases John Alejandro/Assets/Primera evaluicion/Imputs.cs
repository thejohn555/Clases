using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imputs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Forma de ingresar una tecla en Unity

        //Ingreso de un boton que esta prediseñado
        if (Input.GetButton("jump") == true)
        {
            Debug.Log("SALTANDO");
        }

        //Ingreso de una tecla especifica
        if (Input.GetKey(KeyCode.Space) == true)
        {
            Debug.Log("MANTENGO PULSADO ESPACIO");
        }
        //Eventos al insertar una tecla

        //Al pulsar la tecla
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Debug.Log("PRESIONO EL ESPACIO");
        }

        //Al soltar la tecla
        if (Input.GetKeyUp(KeyCode.Space) == true)
        {
            Debug.Log("SUELTO EL ESPACIO");
        }

        //Mientras se mantiene
        if (Input.GetKey(KeyCode.Space) == true)
        {
            Debug.Log("MANTENGO PULSADO ESPACIO");
        }

        //GetAxis
        Debug.Log(Input.GetAxis("horizontal"));
        Input.GetAxis("vertical");

        //Pisicion del raton
        Debug.Log(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
