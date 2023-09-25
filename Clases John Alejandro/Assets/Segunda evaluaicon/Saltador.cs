using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saltador : MonoBehaviour
{
    public float fuerzasalto;
    public Vector3 direccion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Jugador")
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(direccion * fuerzasalto, ForceMode.Impulse);
        }

        
    }
} 
