using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner4 : MonoBehaviour
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

            Vector3 position = temp.transform.position;
            position.x = Random.Range(-3f, 3f);
            position.y = Random.Range(0f, 4f);
            temp.transform.position = position;

            Collidable col = temp.GetComponent<Collidable>();
            col.manager = manager;

            elapsedTime = 0;
            spawnAlien1 = !spawnAlien1;
        }
    }
}