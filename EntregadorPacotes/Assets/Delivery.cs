using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    [SerializeField] Color32 corDoPacote = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 semCorPacote = new Color32 (1, 1, 1, 1);
    [SerializeField] float tempoDestruicao = 0.5f;
    
    bool temPacote;

    SpriteRenderer redenrizadorSprite;

    void Start() {
        redenrizadorSprite = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Aqui tem colisão");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Pacote" && !temPacote)
        {
            Debug.Log("Pacote Recolhido");
            temPacote = true;
            redenrizadorSprite.color = corDoPacote;
            Destroy(other.gameObject, tempoDestruicao);
        }

        if (other.tag == "Entrega" && temPacote)
        {
            Debug.Log("Pacote Entregue");
            temPacote = false;
            redenrizadorSprite.color = semCorPacote;
            Destroy(other.gameObject, tempoDestruicao);
        }
    }
}
