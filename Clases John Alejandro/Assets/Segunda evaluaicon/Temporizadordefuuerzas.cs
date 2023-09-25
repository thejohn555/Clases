using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temporizadordefuuerzas : MonoBehaviour
{
    float tiempoacumulado = 0;
    public float tiempo;
    int movimiento = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempoacumulado += Time.deltaTime;

        if (tiempoacumulado >= tiempo)
        {
            switch (movimiento)
            {
                case 1:

                    gameObject.GetComponent<Rigidbody>().AddForce(transform.up * 10f, ForceMode.Impulse);

                    movimiento = 2;

                    tiempoacumulado = 0;

                    break;
                case 2:

                    gameObject.GetComponent<Rigidbody>().AddForce(transform.right * 10f, ForceMode.Impulse);

                    movimiento = 3;

                    tiempoacumulado = 0;

                    break;
                case 3:

                    gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 10f, ForceMode.Impulse);


                    movimiento = 0;

                    tiempoacumulado = 0;

                    break;
            }
        }
    }
}
