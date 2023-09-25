using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Guardian : MonoBehaviour
{
    Vector3 distancia;
    Vector3 pPartida;
    Quaternion pPartidaG;
    NavMeshAgent navAgent;
    GameObject jugador;
    public GameObject bala;
    public GameObject salidabala;
    int rangoVision;
    int rangoAtaque;
    int vida;
    int giro;
    float tiempoAcumulado;
    float cadencia;
    bool atacando;
    // Start is called before the first frame update
    void Start()
    {
        pPartida = transform.position;
        navAgent = GetComponent<NavMeshAgent>();
        jugador = GameObject.FindGameObjectWithTag("Jugador");
        rangoVision = 50;
        rangoAtaque = 15;
        vida = 10;
        tiempoAcumulado = 0;
        cadencia = 1;
        atacando = false;
        pPartidaG = gameObject.transform.rotation;

    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        Ataque();
    }
    private void Movimiento()
    {
        if (Vector3.Distance(transform.position, jugador.transform.position) < rangoVision)
        {
            distancia = jugador.transform.position - transform.position;

            RaycastHit hit;

            if (Physics.Raycast(transform.position, distancia, out hit, rangoVision))
            {

                if (hit.transform.tag == "Jugador")
                {
                    navAgent.isStopped = false;

                    navAgent.SetDestination(jugador.transform.position);
                }
                else
                {
                    navAgent.SetDestination(pPartida);
                    transform.rotation = Quaternion.Lerp(transform.rotation, pPartidaG, giro * Time.deltaTime);
                    if (Vector3.Distance(transform.position, pPartida) < 2)
                    {
                        navAgent.isStopped = true;
                    }
                }
            }
        }
        else
        {
            navAgent.SetDestination(pPartida);
            transform.rotation = Quaternion.Lerp(transform.rotation, pPartidaG, giro * Time.deltaTime);
            if (Vector3.Distance(transform.position, pPartida) < 2)
            {
                navAgent.isStopped = true;
            }
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
