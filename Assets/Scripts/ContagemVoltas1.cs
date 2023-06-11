using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ContagemVoltas1 : MonoBehaviour
{
    public int voltas;
    public TextMeshProUGUI TextoVoltas;
    public TextMeshProUGUI TextoVoltasPrevistas;
    [Range(1,20)]public int nMaxVoltas = 1;
    public bool finalizado;


    // Start is called before the first frame update
    private void Start()
    {
        TextoVoltasPrevistas.text = " " + nMaxVoltas.ToString("f0"); 
    }

    void ContagemVoltas(){

        TextoVoltas.text = " " + voltas;
    }

    // Update is called once per frame
    private void Update()
    {
        ContagemVoltas();
    }
}
