using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancias : MonoBehaviour
{
    public GameObject referencia;
    GameObject objetocreado;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            objetocreado = GameObject.Instantiate(referencia, transform.position, Quaternion.identity);

            objetocreado.transform.localScale = new Vector3(5, 5, 5);
        }
    }
}
