using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPointFinal : MonoBehaviour
{
    [SerializeField] private string nomeLevel;
    public GameObject Active;
    public GameObject desActive;
    public GameObject Active1;
    public GameObject desActive1;
    public ContagemVoltas1 contagem;
    public ContagemVoltas2 contagem1;
    public GameObject carro1;
    public GameObject carro2;

    bool contado;
    bool contado1;

    void incremento(){
        
        if(carro1){
            if(!contado && contagem.voltas < contagem.nMaxVoltas){
                contagem.voltas++; 
                contado = true;
            }else if(!contado && contagem.voltas == contagem.nMaxVoltas){
                contagem.finalizado = true;
            }
        }else if(carro2){
            if(!contado1 && contagem1.voltas1 < contagem1.nMaxVoltas1){
                contagem1.voltas1++; 
                contado1 = true;
            }else if(!contado1 && contagem1.voltas1 == contagem1.nMaxVoltas1){
                contagem1.finalizado1 = true;
            }
        }

        if(contagem.finalizado && contagem1.finalizado1){
            FinalizarJogo();
        }
    }

    private void OnTriggerEnter(Collider other) {
        switch(other.gameObject.tag)
        {
            case "Carro1":
                incremento();
                Active.SetActive(true);
                break;
            case "Carro2":
                incremento();
                Active1.SetActive(true);
                break;
        }
    }

    private void OnTriggerExit(Collider other) {
        switch(other.gameObject.tag)
        {
            case "Carro1":
                desActive.SetActive(false);
                contado = false; 
                break;
            case "Carro2":
                desActive1.SetActive(false);
                contado1 = false; 
                break;
        }
    }

    void FinalizarJogo() {
        Time.timeScale = 0; // Pausa o tempo do jogo
        SceneManager.LoadScene(nomeLevel);
        Debug.Log("Jogo finalizado!");
    }
}
