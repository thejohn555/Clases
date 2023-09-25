using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanque : MonoBehaviour
{
    int Velocidad;
    int vgiro;
    public int Key;
    public int muni;
    public int vida;
    Vector3 mov;
    Rigidbody rigidbody;
    bool atacando;
    public GameObject bala;
    public GameObject salidabala;
    float tiempoAcumulado;
    float cadencia;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        atacando = false;
        tiempoAcumulado = 0;
        cadencia = 0.5f;
        Velocidad = 6;
        vgiro = 100;
        vida = 10;
        muni = 34;
        Key = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        Ataque();
    }
    private void Movimiento()
    {
        mov = new Vector3(rigidbody.velocity.x, rigidbody.velocity.y, rigidbody.velocity.z);

        rigidbody.velocity = mov ;

        transform.Translate(transform.forward * Velocidad * Input.GetAxisRaw("Vertical") * Time.deltaTime, Space.World);

        transform.Rotate(new Vector3(0, Input.GetAxisRaw("Horizontal") * Time.deltaTime * vgiro, 0));

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (Velocidad <= 10)
            {
                Velocidad += 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Velocidad > 0)
            {
                Velocidad -= 1;
            }
        }
    }
    private void Ataque()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && atacando == false && muni>0)
        {
            muni--;
            GameObject.Instantiate(bala, salidabala.transform.position, transform.GetChild(1).rotation);
            
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
            GameManager.Referencia.Loss();
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            Key++;  
            GameManager.Referencia.Llave();
            Destroy(other);
        }

        if (other.tag == "Muni")
        {
            muni += 5;
            if (muni > 40)
            {
                muni = 40;
            }
            Destroy(other.gameObject);
        }
        if (other.tag == "Estrella")
        {
            GameManager.Referencia.Win();
        }
        
    }
}
