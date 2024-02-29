using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Contador : MonoBehaviour
{
    public int contador = 0;
    public int puntosPorColumna = 1; 
    
    void OnTriggerExit(){
        contador=contador + puntosPorColumna;
    }
}
