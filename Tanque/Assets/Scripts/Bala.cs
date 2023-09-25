using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    float velocidad;
    public AudioClip Disparo;
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.Referencia.Sonido(Disparo);
        velocidad = 20;
        Destroy(this.gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(transform.forward * velocidad * Time.deltaTime, Space.World);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag== "Jugador")
        {
            other.GetComponent<Tanque>().Vida();
        }
        if (other.tag == "Torreta")
        {
            other.GetComponent<Torreta>().Vida();
        }
        if (other.tag == "Patrulla")
        {
            other.GetComponent<Patrulla>().Vida();
        }
        if (other.tag == "Guardian")
        {
            other.GetComponent<Guardian>().Vida();
        }

        Destroy(this.gameObject);

    }
    
}
