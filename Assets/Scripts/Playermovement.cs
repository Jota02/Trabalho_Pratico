using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float MotorForce, Steerforce, BrakeForce;
    public WheelCollider Roda_FR_E, Roda_FR_D, Roda_TR_E, Roda_TR_D; 

    void Update()
    {   
        //Detetar o teclado
        float movimentoVertical = Input.GetAxis("Vertical") * MotorForce;
        float movimentoHorizontal = Input.GetAxis("Horizontal") * Steerforce;

        Roda_TR_D.motorTorque = movimentoVertical;
        Roda_TR_E.motorTorque = movimentoVertical;

        Roda_FR_D.steerAngle = movimentoHorizontal;
        Roda_FR_E.steerAngle = movimentoHorizontal;

        //Trava o carro
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Roda_TR_D.brakeTorque = BrakeForce;
            Roda_TR_E.brakeTorque = BrakeForce;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Roda_TR_D.brakeTorque = 0;
            Roda_TR_E.brakeTorque = 0;
        }

        if(Input.GetAxis("Vertical") == 0)
        {
            Roda_TR_D.brakeTorque = BrakeForce;
            Roda_TR_E.brakeTorque = BrakeForce;
        }else
        {
            Roda_TR_D.brakeTorque = 0;
            Roda_TR_E.brakeTorque = 0;
        }

    }
}
