using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Referencia { get; private set; }
    GameObject jugador;
    GameObject Puerta;

    private void Awake()
    {
        if (Referencia == null)
        {
            Referencia = this;
        }
        else
        {
            Debug.Log("cagaste");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Jugador");
        Puerta = GameObject.FindGameObjectWithTag("Puerta");
    }
    public void Llave()
    {
        if (jugador.gameObject.GetComponent<Tanque>().Key > 1)
        {
            Destroy(Puerta);
        }
    }
    public void Win()
    {
        SceneManager.LoadScene("Victoria");
        Cursor.lockState = CursorLockMode.None;
    }
    public void Loss()
    {
        SceneManager.LoadScene("Derrota");
        Cursor.lockState = CursorLockMode.None;
    }
}
