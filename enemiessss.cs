using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemiessss : MonoBehaviour
{
    public GameObject go;
    private float timer = 0;
    public float spawnrate = 2;
    public GameObject go2;
    public GameObject rocket;

    // Start is called before the first frame update
    void Start()
    {
        
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
            if (rocket != null)
            {
                Vector2 v = new Vector2(Random.Range(-9.92f, 11.4f), 7.65f);
                Instantiate(go, v, transform.rotation);
            }
            timer = 0;
        }

    }
}