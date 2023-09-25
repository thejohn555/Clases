using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidad;
    public float fuerzasalto;
    Vector3 movimiento;
    float altura;
    bool saltando = false;
    public int Ndesalto;
    bool planeando;
    Vector3 posicion_inicial;
    // Start is called before the first frame update
    void Start()
    {
        posicion_inicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        //Salto simple
        /*
        //durante el salto

        if (saltando == true)
        {
            altura -= 9.8f * Time.deltaTime * 0.1f;
            if (transform.position.y <= -1.2f)
            {
                altura = 0;
                saltando = false;
                transform.position = new Vector3(transform.position.x, -1.2f, transform.position.z);
            }
        }
        
        //salto

        if(Input.GetKey(KeyCode.Space) && saltando == false)
        {
            altura = fuerzasalto;
            saltando = true;

        }
        */
        //Salto Doble
        //durante el salto
        /*
        if (saltando == true)
        {
            altura -= 9.8f * Time.deltaTime * 0.1f;
            if (transform.position.y <= -1.2f)
            {
                altura = 0;
                saltando = false;
                transform.position = new Vector3(transform.position.x, -1.2f, transform.position.z);
                Ndesalto = 0;
            }
        }
       

        //salto

        if (Input.GetKeyDown(KeyCode.Space) && Ndesalto<2)
        {
            altura = fuerzasalto;
            saltando = true;
            Ndesalto++;
        }

        //Giro del personaje
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        //Instrucciones de movimiento

        movimiento = new Vector3(Input.GetAxis("Horizontal") * velocidad * Time.deltaTime, altura, 0);

        transform.Translate(movimiento, Space.World);
        */
        //Movimiento con Character controler

        //Mientras estamos Saltando y en el aire

        //Salto simple
        /*

        if(saltando==true||gameObject.GetComponent<CharacterController>().isGrounded == false)
        {
            altura -= 9.8f*Time.deltaTime*0.1f;

            //Condicion de tocar el suelo
            if (gameObject.GetComponent<CharacterController>().isGrounded == true)
            {
                altura = 0;
                saltando = false;
            }
        }

        //Control de salto
        if(Input.GetKeyDown(KeyCode.Space) && saltando == false)
        {
            altura = fuerzasalto;
            saltando = true;
        }
        */

        //Dash (no funcional)

        if (Input.GetKeyDown(KeyCode.E))
        {
            movimiento = new Vector3(Input.GetAxis("Horizontal") * velocidad * Time.deltaTime, altura, 0);
            gameObject.GetComponent<CharacterController>().Move(movimiento);
        }

        //Salto doble
       
        if (saltando == true || gameObject.GetComponent<CharacterController>().isGrounded == false)
        {
            if (planeando == true)
            {
                altura -= 5.9f * Time.deltaTime * 0.1f;
            }
            else
            {
                if (altura < 0)
                {
                    altura -= 5.9f * Time.deltaTime * 0.0005f;
                }
                else
                {
                    altura -= 5.9f * Time.deltaTime * 0.1f;
                }
            }
            
            altura -= 5.9f * Time.deltaTime * 0.1f;

            //Condicion de tocar el suelo
            if (gameObject.GetComponent<CharacterController>().isGrounded == true)
            {
                altura = 0;
                saltando = false;
                Ndesalto = 0;
            }
        }

        //Control de salto
        if (Input.GetKeyDown(KeyCode.Space) && Ndesalto < 2)
        {
            altura = fuerzasalto;
            saltando = true;
            Ndesalto++;
        }

        //Girar personaje segun su movimiento

        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);


            //Dash mas o menos funcional
            if (Input.GetKeyDown(KeyCode.E))
            {
                movimiento = new Vector3(Input.GetAxis("Horizontal") + 30* velocidad * Time.deltaTime, altura, 0);
                gameObject.GetComponent<CharacterController>().Move(movimiento);
            }
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);


            //Dash mas o menos funcional

            if (Input.GetKeyDown(KeyCode.E))
            {
                movimiento = new Vector3(Input.GetAxis("Horizontal") - 30 * velocidad * Time.deltaTime, altura, 0);
                gameObject.GetComponent<CharacterController>().Move(movimiento);
            }
        }
        //Esprint
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            velocidad *= 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            velocidad /= 2;
        }
        //Instruccion de movimiento

        movimiento = new Vector3(Input.GetAxis("Horizontal") * velocidad * Time.deltaTime, altura, 0);

        gameObject.GetComponent<CharacterController>().Move(movimiento);

        //Agacharse
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y / 2, transform.localScale.z);
        }

        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y * 2, transform.localScale.z);
        }        
       
        //reseteo de posicion

        if(transform.position.y <= -10)
        {

            gameObject.GetComponent<CharacterController>().enabled = false;

            transform.position = posicion_inicial;

            gameObject.GetComponent<CharacterController>().enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            planeando = true;
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            planeando = false;
        }
    }
}
