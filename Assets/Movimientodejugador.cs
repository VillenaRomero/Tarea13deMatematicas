using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientodejugador : MonoBehaviour
{
    public float velocidad = 5.0f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical);

        rb.MovePosition(transform.position + movimiento * velocidad * Time.deltaTime);
    }
}
