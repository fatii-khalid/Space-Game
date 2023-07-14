using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootspawn : MonoBehaviour
{
    private float timer = 0;
    public float spawnrate = 4;
    public GameObject go;
    public GameObject spawned;
    // Start is called before the first frame update
    void Start()
    {
        //spawned = Instantiate(go, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            Vector3 random = new Vector3(Random.Range(-5, 3), -7, 0);
            spawned = Instantiate(go, random, transform.rotation);
            go.SetActive(true);
            timer = 0;
        }

    }
}
