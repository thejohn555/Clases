using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApuntadoVertical : MonoBehaviour
{
    public Transform Cañon;
    float hMouse;
    float vMouse;
    float yReal;
    int hSpeed;
    int vSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        hSpeed = 300;
        vSpeed = 200;
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal();
    }
    void Horizontal()
    {
        hMouse = Input.GetAxis("Mouse X") * hSpeed * Time.deltaTime;
        vMouse = Input.GetAxis("Mouse Y") * vSpeed * Time.deltaTime;
        yReal -= vMouse;
        yReal = Mathf.Clamp(yReal, -45f, 45f);
        transform.Rotate(0f, hMouse, 0f);
        Cañon.localRotation = Quaternion.Euler(yReal, 0f, 0f);
    }
}
