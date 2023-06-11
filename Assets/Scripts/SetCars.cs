using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCars : MonoBehaviour
{
    public Rigidbody[] CarrosRigidBodies;
    public ContagemRegressiva contagem;

    private void Update() {
        for (int i = 0; i < CarrosRigidBodies.Length; i++){
            CarrosRigidBodies[i].isKinematic = contagem.emContagem;
            
        }
    }
}
