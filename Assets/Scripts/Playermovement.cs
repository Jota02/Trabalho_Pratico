using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float mover_z;
    public float mover_y;
    public float velocidade = 3.0f;
    

    // Update is called once per frame
    void Update()
    {
        mover_y = Input.GetAxisRaw("Horizontal");
        mover_z = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(mover_z, mover_y, 0f) *Time.deltaTime *velocidade;
    }
}
