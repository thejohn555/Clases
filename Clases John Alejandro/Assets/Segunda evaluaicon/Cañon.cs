using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    public GameObject referencia;
    GameObject objetocreado;
    public float fuerzacañon;
    float tiempoacumulado;
    public float cadencia;
    bool disparando;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Space)&& disparando==false)
        {
            disparando = true;

            objetocreado = GameObject.Instantiate(referencia,transform.GetChild(0).transform.position, Quaternion.identity);

            objetocreado.GetComponent<Rigidbody>().AddForce(transform.up * fuerzacañon, ForceMode.Impulse);

        }
        if (disparando == true)
        {
            tiempoacumulado += Time.deltaTime;

            if (tiempoacumulado >= cadencia)
            {
                tiempoacumulado = 0;
                disparando = false;
            }
        }
    }
}
