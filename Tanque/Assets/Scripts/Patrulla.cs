using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrulla : MonoBehaviour
{
    Vector3 distancia;
    GameObject pRuta;
    GameObject[] psRutas;
    GameObject jugador;
    public GameObject bala;
    public GameObject salidabala;
    int i;
    int velocidad;
    int rangoAtaque;
    int vida;
    float cadencia;
    float tiempoAcumulado;
    bool atacando;
    bool enemigo;
    Quaternion rotacion;
    NavMeshAgent navAgent;
    // Start is called before the first frame update
    void Start()
    {
        velocidad = 4;
        i = 0;
        vida = 10;
        rangoAtaque=15;
        atacando = false;
        enemigo = false;
        cadencia = 1;
        tiempoAcumulado = 0;
        psRutas = GameObject.FindGameObjectsWithTag("Punto de ruta");
        jugador = GameObject.FindGameObjectWithTag("Jugador");
        navAgent = GetComponent<NavMeshAgent>();
        pRuta = psRutas[i];
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        Ataque();
    }
    private void Movimiento()
    {
        navAgent.SetDestination(pRuta.transform.position);
        
        if (enemigo == false)
        {
            pRuta = psRutas[i];

            

            if (Vector3.Distance(transform.position, pRuta.transform.position) < 1f)
            {
                i++;
                if (i >= psRutas.Length)
                {
                    i = 0;
                }
            }
        }
        else
        {
            pRuta = jugador;

            
        }
    }
    private void Ataque()
    {
        if (Vector3.Distance(transform.position, jugador.transform.position) < rangoAtaque )
        {
            distancia = jugador.transform.position - transform.position;
            if (Vector3.Angle(transform.forward, distancia) < 90f)
            {
                RaycastHit hit;

                if(Physics.Raycast(transform.position, distancia, out hit, rangoAtaque))
                {
                    
                    if (hit.transform.tag == "Jugador")
                    {
                        enemigo = true;

                        if (atacando == false)
                            GameObject.Instantiate(bala, salidabala.transform.position, transform.GetChild(0).rotation);
                        atacando = true;
                    }
                    else
                    {
                        pRuta = psRutas[i];

                        enemigo = false;
                    }
                }
                
            }
            

        }
        else
        {
            pRuta = psRutas[i];

            enemigo = false;
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
