using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion_Cubos : MonoBehaviour
{
    int Velocidad_rotacion = 55;
    int Velocidad_giro = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.parent.position, Vector3.up, Velocidad_giro * Time.deltaTime);

        transform.Rotate(new Vector3(0, Velocidad_rotacion * Time.deltaTime, 0));//Giran los cubos
        
        if (Input.GetKeyDown(KeyCode.A))//Con esto aumenta la velocidad de rotacion
        {
            Velocidad_rotacion *= 4;
        }

        if (Input.GetKeyUp(KeyCode.A))//Vuelve a la normalidad
        {
            Velocidad_rotacion /= 4;
        }

        if (Input.GetKeyDown(KeyCode.D))//Con esto disminuye la velocidad de rotacion
        {
            Velocidad_rotacion /= 4;
        }

        if (Input.GetKeyUp(KeyCode.D))//Vuelve a la normalidad
        {
            Velocidad_rotacion *= 4;
        }

        if (Input.GetKeyDown(KeyCode.P))//Con esto se para el giro
        {
            Velocidad_giro = 0;
        }

        if (Input.GetKeyUp(KeyCode.P))//Vuelve a la normalidad
        {
            Velocidad_giro = 30;
        }
    }
}
