using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
public float acceleration;
public float maxSpeed;
public float rotationSpeed;

private Rigidbody rb;

private void Start()
{
    rb = GetComponent<Rigidbody>();
    rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ; // Impede a rotação indesejada no eixo X e Z

    // Adicionar um Collider ao objeto do carro
    BoxCollider carCollider = gameObject.AddComponent<BoxCollider>();
    carCollider.center = new Vector3(0f, 0.5f, 0f); // Ajuste o centro do Collider conforme necessário
    carCollider.size = new Vector3(1.8f, 1f, 4f); // Ajuste o tamanho do Collider conforme necessário
}

private void FixedUpdate()
{
    // Movimentação para frente e para trás
    float verticalInput = 0f;
    if (Input.GetKey(KeyCode.UpArrow))
    {
        verticalInput = 1f;
    }
    else if (Input.GetKey(KeyCode.DownArrow))
    {
        verticalInput = -1f;
    }
    float speed = verticalInput * acceleration * Time.deltaTime;

    // Limitar a velocidade máxima
    if (speed > maxSpeed)
    {
        speed = maxSpeed;
    }

    // Rotação
    float horizontalInput = 0f;
    if (Input.GetKey(KeyCode.LeftArrow))
    {
        horizontalInput = -1f;
    }
    else if (Input.GetKey(KeyCode.RightArrow))
    {
        horizontalInput = 1f;
    }
    float rotation = horizontalInput * rotationSpeed * Time.deltaTime;

    // Aplicar movimento e rotação ao objeto do carro apenas se uma das teclas das setas ou das teclas AWSD estiver sendo pressionada
    if (verticalInput != 0f || horizontalInput != 0f)
    {
        transform.Translate(0f, 0f, speed);
        transform.Rotate(0f, rotation, 0f);
    }
}



}