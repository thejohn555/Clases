using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta : MonoBehaviour
{
    GameObject jugador;
    float tiempoAcumulado;
    float cadencia;
    Vector3 direccion;
    Quaternion rotacion;
    int giro;
    int rangoVision;
    int rangoAtaque;
    public int vida;
    bool atacando;
    public GameObject bala;
    public GameObject salidabala;
    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Jugador");
        tiempoAcumulado = 0;
        cadencia = 0.5f;
        giro = 8;
        rangoVision = 30;
        rangoAtaque = 15;
        atacando = false;
        vida = 10;

    }

    // Update is called once per frame
    void Update()
    {
        Mira();
        Ataque();
    }
    private void Mira()
    {
        direccion = jugador.transform.position - transform.position;

        if (Vector3.Distance(transform.position, jugador.transform.position) < rangoVision)
        {
            
            rotacion = Quaternion.LookRotation(direccion.normalized, Vector3.up);

            transform.GetChild(0).rotation = Quaternion.Lerp(transform.GetChild(0).rotation, rotacion, giro * Time.deltaTime);

            direccion.y = 0;

            rotacion = Quaternion.LookRotation(direccion.normalized, Vector3.up);

            transform.rotation = Quaternion.Lerp(transform.rotation, rotacion, giro * Time.deltaTime);
        }
    }
    private void Ataque()
    {
        if (Vector3.Distance(transform.position, jugador.transform.position) < rangoAtaque && atacando == false)
        {
            GameObject.Instantiate(bala, salidabala.transform.position, transform.GetChild(0).rotation);
            atacando = true;
        }
        if (atacando == true)
        {
            
            tiempoAcumulado += Time.deltaTime;

            if (tiempoAcumulado > cadencia)
            {
                atacando = false;

                tiempoAcumulado = 0;
            }
        }
    }
    public void Vida()
    {
        if (vida > 0)
        {
            vida -= 1;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
