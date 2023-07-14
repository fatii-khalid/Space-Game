using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clash : MonoBehaviour
{
    public score logicScript;
    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("logic").GetComponent<score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        logicScript.rocketDestroyed();
    }
}