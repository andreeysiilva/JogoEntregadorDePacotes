using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float velocidadeDirecao = 1f;
    [SerializeField] float velocidadeMovimento = 20f;
    [SerializeField] float velocidadeLenta = 15f;
    [SerializeField] float turbo = 30f;
    
    


    // A atualização é chamada uma vez por quadro
    void Update()
    {
        float controleDirecao = Input.GetAxis("Horizontal") * velocidadeDirecao * Time.deltaTime;
        float controleMovimento = Input.GetAxis("Vertical") * velocidadeMovimento * Time.deltaTime;
        transform.Rotate(0, 0, -controleDirecao);
        transform.Translate(0, controleMovimento, 0);
    }

    void OnCollisionEnter2D(Collision2D other) {
        velocidadeMovimento = velocidadeLenta;
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Turbo")
        {
            velocidadeMovimento = turbo;
        }
    }
}
