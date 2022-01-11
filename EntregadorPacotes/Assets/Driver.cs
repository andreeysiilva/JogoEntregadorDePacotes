using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float velocidadeDirecao = 1f;
    [SerializeField] float velocidadeMovimento = 0.01f;


    // O início é chamado antes da primeira atualização do quadro
    void Start()
    {
        
    }

    // A atualização é chamada uma vez por quadro
    void Update()
    {
        float controleDirecao = Input.GetAxis("Horizontal") * velocidadeDirecao * Time.deltaTime;
        float controleMovimento = Input.GetAxis("Vertical") * velocidadeMovimento * Time.deltaTime;
        transform.Rotate(0, 0, -controleDirecao);
        transform.Translate(0, controleMovimento, 0);
    }
}
