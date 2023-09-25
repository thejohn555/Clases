using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador_final2 : MonoBehaviour
{
    public float velocidad;
    public float salto;

    private bool saltando;

    RaycastHit hit;
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
        else
        {

            if (Physics.Raycast(transform.position, -transform.up, out hit, 1.2f)&&transform.GetComponent<Rigidbody>().velocity.y<0)
            {
                saltando = false;
            }
        }
        //se mueve si saltas
        //gameObject.GetComponent<Rigidbody>().velocity = new Vector3(Input.GetAxis("Horizontal") * velocidad, gameObject.GetComponent<Rigidbody>().velocity.y, Input.GetAxis("Vertical") * velocidad);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 100f))
            {
                if (hit.transform.tag == "enemigo")
                {
                    hit.transform.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward*15, ForceMode.Impulse);

                    Destroy(hit.transform.gameObject, 2f);
                }
            }
        }

        //Salto por fuerzas

        if (Input.GetKeyDown(KeyCode.Space) && saltando == false)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(transform.up * salto, ForceMode.Impulse);
            saltando = true;
        }

        
    }
    private void OnCollisionEnter(Collision collision)
    {
        /*if (collision.gameObject.tag == "suelo")
        {
            saltando = false;
        }
        */
    }
    
}
