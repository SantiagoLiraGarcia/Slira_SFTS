using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Alien1Prefab;
    public GameObject Alien2Prefab;
    public float spawnCycle = 1.5f;

    GameManager manager;
    float elapsedTime;
    bool spawnAlien1 = true;

    
    // Start is called before the first frame update
    void Start()
    {
        manager = GetComponent<GameManager>(); 
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > spawnCycle)
        {
            GameObject temp;
             if (spawnAlien1)
                 temp = Instantiate(Alien1Prefab) as GameObject;
             else
                 temp = Instantiate(Alien2Prefab) as GameObject;
            
            /*Vector3 position = temp.transform.position;
            {
                position.x = Random.Range(-15f, 15f);
                position.y = Random.Range(1f, 5f);
                position.z = Random.Range(-15f, 15f);
                temp.transform.position = position;
            }*/
            
            Collidable col = temp.GetComponent<Collidable>();
            col.manager = manager;

            elapsedTime = 0;
            spawnAlien1 = !spawnAlien1;
        }
    }
}
