using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public GameObject Active;
    public GameObject desActive;
    public GameObject Active1;
    public GameObject desActive1;


    private void OnTriggerEnter(Collider other) {
        switch(other.gameObject.tag)
        {
            case "Carro1":
                Active.SetActive(true);
                break;
            case "Carro2":
                Active1.SetActive(true);
                break;
        }
    }

    private void OnTriggerExit(Collider other) {
        switch(other.gameObject.tag)
        {
            case "Carro1":
                desActive.SetActive(false);
                break;
            case "Carro2":
                desActive1.SetActive(false); 
                break;
        }
    }
}
