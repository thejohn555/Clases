using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vect: MonoBehaviour
{
    public GameObject target;
    public Vector3 Direccion;
    public Vector3 Distancia;
    public Vector3 posicion_inicial;
    // Start is called before the first frame update
    void Start()
    {
        posicion_inicial = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Calculo con mates
        /*
        //Calcular direccion entre dos objetos

        Direccion = transform.position - target.transform.position;

        //Rotar 
        //Sin seguir en el eje y
        Vector3 mod_Dir = new Vector3(Direccion.x, 0, Direccion.z);
        Quaternion rotacion = Quaternion.LookRotation(-mod_Dir, Vector3.up);

        //Sigue todo el rato
        //Quaternion rotacion = Quaternion.LookRotation(-Direccion, Vector3.up);

        transform.rotation = rotacion;
        */
        //Calculo de direccion con Unyti
        transform.LookAt(target.transform);

        //Calculo de distancias

        //Usando el Vector diferencia

        Distancia = transform.position - target.transform.position;
        //Debug.Log("Distancias: " + Distancia.magnitude);//magnitude = al modulo del vector 

        //Usando la funcion 

        //float distF = Vector3.Distance(transform.position, target.transform.position);
        //Debug.Log("DistanciaFun: " + distF);

        

        
    }

    //revisar si hay triger o colision
    //En los triges te lo ejecuta siempre en las colisiones se ejecuta cuando hay una fuerza
    private void OnCollisionEnter(Collision collision)
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        
    }
    private void OnCollisionExit(Collision collision)
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log( other.gameObject.name== "jugador");
    }
    private void OnTriggerStay(Collider other)
    {

    }
    private void OnTriggerExit(Collider other)
    {
        
    }
}
