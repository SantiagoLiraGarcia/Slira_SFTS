using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    private Light Lightbulb;
    public void Start()
    {
        Lightbulb = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
       Input.GetKey(KeyCode.L);
       

        if (Input.GetKeyDown(KeyCode.L))
        {
            Lightbulb.enabled = !Lightbulb.enabled;
        }
      
       

     
    }
}
