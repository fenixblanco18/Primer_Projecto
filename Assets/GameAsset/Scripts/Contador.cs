using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Contador : MonoBehaviour
{
    public TMP_Text textObject;
    public int contador = 0;
    public int puntosPorColumna = 1; 
    
    void OnTriggerExit(){
        contador=contador + puntosPorColumna;
        textObject.GetComponentInChildren<TextMeshProUGUI>().SetText(contador.ToString());
    }
}
