using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad;
    public float giro;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position
        //Movimiento Derecha Referencia Global

        //transform.position += Vector3.right * velocidad;

        //Movimiento Derecha Referencia Local

        //transform.position += transform.right * velocidad;

        //transform.position += new Vector3(1, 0, 1) * velocidad;

        //transform.Translate()
        //Movimiento Derecha Referencia Local, ya que por defecto SPACE.SELF
        //transform.Translate(Vector3.right * velocidad);

        //Moviemiento Erroneo, no se mueve correctamente
        //transform.Translate(transform.right * velocidad);

        //transform.rotation
        //transform.rotation *= Quaternion.Euler(new Vector3(5 * velocidad, 0, 0));

        //transform.rotation
        //transform.Rotate(new Vector3(5* velocidad, 0, 0));

        //Combinar
        //Que ocurre? -> Se mueve hacia la derecha pero el giro no afecta al eje
        //transform.position += transform.right * velocidad;
        //transform.Rotate(new Vector3(5 * velocidad, 0, 0));

        //Que ocurre? -> Se mueve hacia su derecha que es afectada por el giro
        //transform.position += transform.right * velocidad;
        //transform.Rotate(new Vector3(0, 5 * velocidad, 0));

        //Que ocurre? -> Se mueve hacia la derecha pero el giro no afecta al eje
        //transform.position += Vector3.right * velocidad;
        //transform.Rotate(new Vector3(0, 5 * velocidad, 0));

        //Que ocurre? -> Los movimientos se contrarrestran y no se mueve
        //transform.position += Vector3.right * velocidad;
        //transform.position += Vector3.left * velocidad;


        //transform.Translate()
        //Movimiento a la derecha referencia global en el vector direccion, Space.Self Indica el espacio local
        //Tiene en cuenta la rotacion del objeto

        //transform.Translate(Vector3.right * velocidad, Space.Self);

        //Movimiento a la derecha referencia global en el vector direccion, Space.World Indica el espacio global
        //No tiene en cuenta la rotacion del objeto

        //transform.Translate(Vector3.right * velocidad, Space.World);

        //Movimiento a la derecha referencia local en el vector direccion, Space.World Indica el espacio global
        //tiene en cuenta la rotacion del objeto

        //transform.Translate(transform.right* velocidad, Space.World);

        //Movimiento erroneo, No se mueve ni a la derecha del mundo ni del objeto

        //transform.Translate(transform.right * velocidad, Space.Self);

        //Time.deltaTime es el tiempo de el tiempo de ejecucion del Update

        //transform.Translate(transform.right * velocidad * Time.deltaTime, Space.World);

        /*
        Time.timeScale = 1; //Normal
        Time.timeScale = 0; //Se para
        Time.timeScale = 2; //Va el doble
        Time.timeScale = 0.5; //Va a la mitad de velocidad
        Time.unscaledDeltaTime //No le afecta el Time.timeScale
        */

        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
