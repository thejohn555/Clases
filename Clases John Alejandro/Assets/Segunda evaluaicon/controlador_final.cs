using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador_final : MonoBehaviour
{
    public float velocidad;
    public float salto;

    private bool saltando;
    // Start is called before the first frame update
    void Start()
    {
        saltando = false;
    }

    // Update is called once per frame
    void Update()
    {

        //Movimiento aplicando fuerzas
        /*
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * Input.GetAxis("Horizontal") * velocidad,ForceMode.Acceleration);
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * Input.GetAxis("Vertical") * velocidad, ForceMode.Acceleration);
        */

        //Modificando el Velociti

        //no se mueve si saltas
        if (saltando == false)
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(Input.GetAxis("Horizontal") * velocidad, gameObject.GetComponent<Rigidbody>().velocity.y, Input.GetAxis("Vertical") * velocidad);
        }
        //se mueve si saltas
        //gameObject.GetComponent<Rigidbody>().velocity = new Vector3(Input.GetAxis("Horizontal") * velocidad, gameObject.GetComponent<Rigidbody>().velocity.y, Input.GetAxis("Vertical") * velocidad);


        //Salto por fuerzas

        if (Input.GetKey(KeyCode.Space) && saltando == false)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(transform.up * salto, ForceMode.Impulse);
            saltando = true;
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "suelo")
        {
            saltando = false;
        }
    }
    
}
