using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tag : MonoBehaviour
{
    public GameObject referenciaobjeto;
    public GameObject[] informacion;

    // Start is called before the first frame update
    void Start()
    {
        //Variable publica
        //public GameObject referenciaobjeto;

        //Buscar por nombre
        //Debug.Log(GameObject.Find("ObjetoScena").name);

        //Buscar por el Tag
        //Debug.Log(GameObject.FindGameObjectWithTag("OBJETO").name); //(Un solo objeto aleatorio)
        //informacion = GameObject.FindGameObjectsWithTag("OBJETO");  //(A todos los que tengan ese tag)

        //Transform
        //transform.parent; //Accede al padre
        //transform.GetChild(a);  //Accede al hijo

        //acceder a los componentes
        //gameObject.transform; //Accede al componente transform
        //GameObject.Find("ObjetoScena").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
