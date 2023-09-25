using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientoaobjeto : MonoBehaviour
{
    int x;
    Vector3 y;
    float z;
    int Velocidad = 1;
    float vel_mov;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Ejercicio 1
        /*
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * 0.1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * 0.1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * 0.1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * 0.1f;
        }
        */
        //Ejercicio 2
        /*
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward* 0.1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -5 * 0.1f, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * 0.1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 5 * 0.1f, 0));
        }
        */

        //Ejercicio 3

        //Mi opcion
        /*
        if (transform.position == new Vector3(0, 0, 0))
        {
            x = 1;
        }
        if (x == 1)
        {
            transform.position += Vector3.right;
        }       

        if (transform.position == new Vector3(100, 0, 0))
        {
            x = 0;
        }
        if (x == 0)
        {
            transform.position += Vector3.left;
        }
        */
        //opcion del profe
        /*
        transform.position += Vector3.right * Velocidad;

        if (transform.position.x >= 40f)
        {
            Velocidad *= -1;
        }
        if(transform.position.x<= -4f)
        {
            Velocidad *= -1;
        }
        */

        //Ejercicio 4


        /*
        //Derecha Izquierda
        
        y = transform.right * Input.GetAxis("Horizontal");
        transform.Translate(y * Time.deltaTime, Space.World);

        //Adelante Atras

        y = transform.forward * Input.GetAxis("Vertical");
        transform.Translate(y * Time.deltaTime, Space.World);
        */


        //Ejercicio 5

        /*
        //Derecha Izquierda Rotacion

        z = Input.GetAxis("Horizontal") *50f * Time.deltaTime;
        transform.Rotate(new Vector3(0,z,0), Space.World);

        //Adelante Atras

        y = transform.forward * Input.GetAxis("Vertical");
        transform.Translate(y * Time.deltaTime * 10f, Space.World);
        */
        /*
        //Girar alrededor de un punto

        transform.RotateAround(new Vector3(0, 2, -5), Vector3.up, giro * Time.deltaTime);
        
        //Girar alrededor de tu padre
        
        transform.RotateAround(transform.parent.position, Vector3.up, giro * Time.deltaTime);
        
        //Girar haciendo referencia al hijo
        
        transform.GetChild(2); //El (2) hace referencia al orden para que hijo quieres afectar
        */

        //Ejercicio 6
        //influye el giro en el movimiento

        transform.Translate(Vector3.right * Velocidad * Time.deltaTime, Space.World);

        //No influye el giro en el movimiento

        //transform.Translate(transform.right * Velocidad * Time.deltaTime, Space.World);

        if (transform.position.x >= 40f)
        {
            Velocidad *= -1;
        }

        if (transform.position.x >= -40f)
        {
            Velocidad *= -1;
        }
    }
}
