using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    private Light Lightbulb;
    // Start is called before the first frame update
    void Start()
    {
        Lightbulb = GetComponent<Light>();
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
                //DestroyWithTag("Enemy");
            }
          
        }
    }
    // Update is called once per frame
    void Update()
    {
        Input.GetKey(KeyCode.Space);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Lightbulb.enabled = !Lightbulb.enabled;
        }
        float dirX = Input.GetAxis("Mouse X");
        float dirY = Input.GetAxis("Mouse Y");
        transform.Rotate(dirY, -dirX, 0);
        CheckForRaycastHit();
    }
    /*void DestroyWithTag(string destroyTag)
    {
        GameObject[] destroyObject;
        destroyObject = GameObject.FindGameObjectsWithTag(destroyTag);
        foreach (GameObject oneObject in destroyObject)
            Destroy(oneObject);
    }*/
}
