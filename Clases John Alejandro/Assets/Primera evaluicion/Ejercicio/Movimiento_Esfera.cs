using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Esfera : MonoBehaviour
{
    int Velocidad=1;
    Vector3 Direccion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Direccion*Time.deltaTime;

        if (transform.position.x <= -5f && transform.position.z >= 5f)//esto me comprueba cuando llega a la esquina (-5,0,5)
        {
            Direccion = Vector3.right * 5 ;//Esto hace que se mueva a la derecha
        }
        if (transform.position.x >= 5f && transform.position.z >= 5f)//esto me comprueba cuando llega a la esquina (5,0,5)
        {
            Direccion = Vector3.back * 5 ;//Esto hace que se mueva acia atras
        }
        if (transform.position.x >= 5f && transform.position.z <= -5f)//esto me comprueba cuando llega a la esquina (5,0,-5)
        {
            Direccion = Vector3.left * 5 ;//Esto hace que se mueva a la izquierda
        }
        if (transform.position.x <= -5f && transform.position.z <= -5f)//esto me comprueba cuando llega a la esquina (-5,0,-5)
        {
            Direccion = Vector3.forward * 5 ;//Esto hace que se mueva acia lante
        }
    }
}
