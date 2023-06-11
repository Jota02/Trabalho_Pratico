using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ContagemRegressiva : MonoBehaviour
{
    public TextMeshProUGUI Texto;
    public bool emContagem;
    [Range(3,10)] public int numero_voltas = 3;
    public GameObject painel;

    float setcont;
    // Start is called before the first frame update
    private void Start()
    {
        setcont = numero_voltas;
        Texto.text =  " " + setcont.ToString("f0");
    }

    void Contagem()
    {
        Texto.text =  " " + setcont.ToString("f0");
        if(setcont > 0 ){
            setcont = setcont - Time.deltaTime;
            emContagem = true;

            if(setcont <= 0.7f){
                Texto.text =  "Partida".ToUpper();
            }else{
                Texto.text =  " " + setcont.ToString("f0");

            }
        }else{
            emContagem = false;
        }
    }

    void setEnable()
    {
        Texto.enabled = emContagem;
        painel.SetActive(!emContagem);
    }

    // Update is called once per frame
    private void Update()
    {
        setEnable();
        Contagem();
    }
}
