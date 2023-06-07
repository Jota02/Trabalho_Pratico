using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement2 : MonoBehaviour
{
    public float velocidade = 5f; // Velocidade de movimento do carro

    public float velocidadeRotacao = 150f; // Velocidade de rotação do carro

    void Update()
    {
        float movimentoVertical = 0f; // Armazena o valor do movimento vertical
        float movimentoHorizontal = 0f; // Armazena o valor do movimento horizontal

        if (Input.GetKey(KeyCode.W))
        {
            movimentoVertical = 1f; // Define o movimento para frente
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movimentoVertical = -1f; // Define o movimento para trás
        }

        if (Input.GetKey(KeyCode.A))
        {
            movimentoHorizontal = -1f; // Define o movimento para a esquerda
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movimentoHorizontal = 1f; // Define o movimento para a direita
        }

        Vector3 movimento = new Vector3(movimentoHorizontal, 0f, movimentoVertical); // Cria um vetor de movimento

    float rotacao = movimentoHorizontal * velocidadeRotacao * Time.deltaTime; // Calcula o valor de rotação

        transform.Translate(movimento * velocidade * Time.deltaTime); // Move o objeto ao longo do vetor de movimento
        transform.Rotate(0f, rotacao, 0f); // Aplica a rotação ao objeto do carro
    
    }

}
