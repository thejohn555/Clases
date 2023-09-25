using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador : MonoBehaviour
{
    Vector3 posInicial;

    public float velocidad;
    public float fuerzasalto;
    Vector3 movimiento;
    float altura;
    bool saltando = false;
    int Ndesalto = 0;
    public GameObject Camara;
    int Llave= 0;
    public GameObject Pared;
    

    // Start is called before the first frame update
    void Start()
    {
       
        posInicial = transform.position;
        //Camara.GetComponent<Light>().color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && saltando == false)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(transform.up * fuerzasalto, ForceMode.Impulse);

            saltando = true;

            Debug.Log("hi");

        }

        //Instrucciones de movimiento

        movimiento = new Vector3(Input.GetAxis("Horizontal") * velocidad * Time.deltaTime, 0, Input.GetAxis("Vertical") * velocidad * Time.deltaTime);

        transform.Translate(movimiento, Space.World);

    }
    private void OnTriggerEnter(Collider other)
    {
        //Simple

        //saltando = false;

        if (other.gameObject.tag == "Kill")
        {
            transform.position = posInicial;
        }
        if (other.gameObject.tag == "Vida")
        {
            Debug.Log("ganas vida");

            Destroy(other.gameObject);
        }
        if (other.gameObject.name == "Azul")
        {
            Camara.GetComponent<Light>().color = Color.blue;
        }
        if (other.gameObject.name == "Rojo")
        {
            Camara.GetComponent<Light>().color = Color.red;
        }
        if (other.gameObject.tag == "Llave")
        {

            Llave++;

            Destroy(other.gameObject);
        }
        if (other.gameObject.name == "PowerUp")
        {
            fuerzasalto *= 2.5f;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        //Mejorado

        saltando = false;

       

            if (other.gameObject.name == "Activador")
        {
           

            if (Input.GetKeyDown(KeyCode.E))
            {
                Llave--;

                Destroy(Pared.gameObject);
            }

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "PowerUp")
        {
            fuerzasalto /= 2.5f;
        }
    }
}
