using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectores : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Posicion del objeto
        //Vector3 (X,Y,Z)
        //Mostrar la posicion del objeto
        Debug.Log("Posicion: " + transform.position);
        //Rotacion del objeto
        //Nosotros hacemos las rotaciones por grados pero matematicamente el trabaja con
        //quaterniones para poder solucionar el problema de ejes alineados
        Debug.Log("Rotacion: " + transform.rotation);
        //Mostrar escala
        Debug.Log("Escala; " + transform.localScale);
        //Mover un objeto con respecto al mundo
        transform.position += new Vector3(1,0,0);
        //Espacio Global con vectores prediseñados
        /*
        Vector3.right;      (1,0,0)         Vector3.left        (-1,0,0)
        Vector3.up;         (0,1,0)         Vector3.down        (0,-1,0)
        Vector3.forward;    (0,0,1)         Vector3.back        (0,0,-1)
                                Vector3.zero;       (0,0,0)
        */
        //Espacio local
        /*
        transform.right;                    LEFT->  -transform.right;
        transform.up;                       DOWN->  -transform.up;
        transform.forward;                  BACK->  -transform.forward;

        */

        //Mover un objeto con respecto al objeto
        transform.position += transform.right;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
