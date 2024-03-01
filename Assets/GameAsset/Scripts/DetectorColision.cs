using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectorColision : MonoBehaviour
{
    public GameObject prefabExplosion;
    // Start is called before the first frame update
    void OnCollisionEnter(){
        Instantiate(prefabExplosion, transform.position, prefabExplosion.transform.rotation);
        Destroy(gameObject);

        
    }
}
    // Update is called once per frame

