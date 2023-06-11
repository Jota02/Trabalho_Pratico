using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointFinal : MonoBehaviour
{
    public GameObject Active;
    public GameObject desActive;
    public ContagemVoltas1 contagem;

    bool contado;

    void incremento(){
        if(!contado && contagem.voltas < contagem.nMaxVoltas){
            contagem.voltas++; 
            contado = true;
        }else if(!contado && contagem.voltas == contagem.nMaxVoltas){
            contagem.finalizado = true;
        }
    }

    private void OnTriggerEnter(Collider other) {
        switch(other.gameObject.tag)
        {
            case "Player":
                incremento();
                Active.SetActive(true);
                break;
        }
    }

    private void OnTriggerExit(Collider other) {
        switch(other.gameObject.tag)
        {
            case "Player":
                desActive.SetActive(false);
                contado = false; 
                break;
        }
    }
}
