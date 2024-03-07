using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salto_personaje : MonoBehaviour
{

    public float velocidadMovimiento = 10f; 
    public float fuerzaSalto = 3f; 
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
     
        float movimientoHorizontal = Input.GetAxis("Horizontal"); 
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, 0f) * velocidadMovimiento;
        rb.AddForce(movimiento);

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Saltar();
        }
    }

    private void Saltar()
    {
        rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
    }
}
