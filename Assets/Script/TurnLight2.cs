using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLight2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
        }
    }
}
