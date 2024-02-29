using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    public Text textObject;
    public int contador = 0;
    public int puntosPorColumna = 1; 
    
    void OnTriggerExit(){
        contador=contador + puntosPorColumna;
        textObject.GetComponentInChildren<TextMeshProUGUI>().SetText(contador.ToString());
    }
}
