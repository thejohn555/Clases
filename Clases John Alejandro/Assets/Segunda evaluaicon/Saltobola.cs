using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saltobola : MonoBehaviour
{
    public bool salto;
    float tiempoacumulado = 0;
    public float tiempo;
    public GameObject Siguientebola;

    // Start is called before the first frame update
    void Start()
    {
        salto = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (salto == true)
        {
            tiempoacumulado += Time.deltaTime;

            if (tiempoacumulado >= tiempo)
            {
                tiempoacumulado = 0;

                salto = false;

                gameObject.GetComponent<Rigidbody>().AddForce(transform.up * 10f, ForceMode.Impulse);

                if(Siguientebola != null)
                {
                    Siguientebola.GetComponent<Saltobola>().salto = true;
                }
                
            }
        }
    }
}
