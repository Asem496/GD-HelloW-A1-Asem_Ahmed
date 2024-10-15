using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bewegen : MonoBehaviour
{
    // Rigidbody als variabele
    private Rigidbody rb;

    // Bewegingssnelheid
    public float speed = 5f;

    // Start wordt eenmalig aangeroepen voor het eerste frame
    void Start()
    {
        // Haal de Rigidbody-component op
        rb = GetComponent<Rigidbody>();

        // Schakel de zwaartekracht tijdelijk uit voor testen (indien nodig)
        rb.useGravity = true;  // Je kunt dit op true laten zodat zwaartekracht actief is
    }

    // Update wordt eenmaal per frame aangeroepen
    void Update()
    {
        // Input variabelen voor WASD
        float moveHorizontal = 0f;
        float moveVertical = 0f;

        // WASD toetsen controleren voor beweging op de X- en Z-as
        if (Input.GetKey(KeyCode.W))
        {
            moveVertical = 1f;  // Vooruit (Z-as)
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveVertical = -1f;  // Achteruit (Z-as)
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveHorizontal = -1f;  // Links (X-as)
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveHorizontal = 1f;  // Rechts (X-as)
        }

        // Beweging vector berekenen (X voor links/rechts, Z voor voor/achter)
        Vector3 movement = new Vector3(moveHorizontal, rb.velocity.y/speed, moveVertical) * speed;

        // Pas velocity direct toe op Rigidbody zonder rotatie te beïnvloeden
        rb.velocity = movement;

    }
}
