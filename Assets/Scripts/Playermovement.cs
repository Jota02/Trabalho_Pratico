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
        float verticalInput = Input.GetAxis("Vertical");
        float speed = verticalInput * acceleration * Time.deltaTime;

        // Limitar a velocidade máxima
        if (speed > maxSpeed)
        {
            speed = maxSpeed;
        }

        // Rotação
        float horizontalInput = Input.GetAxis("Horizontal");
        float rotation = horizontalInput * rotationSpeed * Time.deltaTime;

        // Aplicar movimento e rotação ao objeto do carro
        transform.Translate(0f, 0f, speed);
        transform.Rotate(0f, rotation, 0f);
    }
}