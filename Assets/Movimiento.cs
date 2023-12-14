using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = transform.forward;
        float velocidad = 15f * Input.GetAxis("Vertical");
        transform.position = transform.position + direccion * velocidad * Time.deltaTime;

        float velocidadGiro = 45f * Input.GetAxis("Horizontal");
        transform.Rotate(0f, velocidadGiro * Time.deltaTime, 0f);
    }
}
