using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola_cañon : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}
