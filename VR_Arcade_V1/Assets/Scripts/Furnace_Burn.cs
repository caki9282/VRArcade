using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furnace_Burn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coal"))
        {
            Destroy(other.gameObject); // Destroy coal
            Int_statics.Fuel++;
            Debug.Log(Int_statics.Fuel);
        }
        else
        {
            Destroy(other.gameObject); // Destroy coal
            Int_statics.Fuel+=10;
            Debug.Log(Int_statics.Fuel);
        }
    }
}
