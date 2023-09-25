using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(Physics.Raycast(transform.position, transform.forward,out hit, 100f))
            {
                Debug.Log("El objeto es: " + hit.transform.name);
                Debug.Log("Distancia: " + hit.distance);
                Debug.Log("Puto de impacto: " + hit.point);

            }
        }
    }
}
