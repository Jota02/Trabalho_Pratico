using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ContagemVoltas2 : MonoBehaviour
{
    public int voltas1;
    public TextMeshProUGUI TextoVoltas1;
    public TextMeshProUGUI TextoVoltasPrevistas1;
    [Range(1,20)]public int nMaxVoltas1 = 1;
    public bool finalizado1;


    // Start is called before the first frame update
    private void Start()
    {
        TextoVoltasPrevistas1.text = " " + nMaxVoltas1.ToString("f0"); 
    }

    void ContagemVoltas(){

        TextoVoltas1.text = " " + voltas1;
    }

    // Update is called once per frame
    private void Update()
    {
        ContagemVoltas();
    }
}
