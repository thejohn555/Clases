using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiempos : MonoBehaviour
{
    bool activado = false;
    float tiempoacumulado = 0;
    public float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("tiempo en segundos de cada frame/update" + Time.deltaTime);

        //Debug.Log("tiempo transcurrido desde el inicio" + Time.time);

        if(Input.GetKey(KeyCode.Space)&& activado == false)
        {
            activado = true;
            Debug.Log("Inicio contador");

        }
        if (activado == true)
        {
            tiempoacumulado += Time.deltaTime;

            if (tiempoacumulado >= tiempo)
            {
                activado = false;
                tiempoacumulado = 0;
                Debug.Log("Fin contador");

            }
        }
    }
}
