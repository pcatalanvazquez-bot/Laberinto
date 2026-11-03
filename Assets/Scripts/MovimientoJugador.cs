using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 5f;

    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movimientoEjeZ = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
        movimientoEjeX = -Input.GetAxis("Vertical") * velocidad * Time.deltaTime;
        transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjeZ);
    }
}