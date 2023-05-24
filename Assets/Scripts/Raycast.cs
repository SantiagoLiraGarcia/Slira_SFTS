using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void CheckForRaycastHit()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider.tag == "Enemy")
            {
                print(hit.collider.gameObject.name + " Destroyed!");
                Destroy(hit.collider.gameObject);
            }
          
        }
    }
    // Update is called once per frame
    void Update()
      
    {
        float dirX = Input.GetAxis("Mouse X");
        float dirY = Input.GetAxis("Mouse Y");
        transform.Rotate(dirY, -dirX, 0);
        CheckForRaycastHit();
    }

}
