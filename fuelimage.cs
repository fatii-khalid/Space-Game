using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fuelimage : MonoBehaviour
{
    public movement logicScript;
    // Start is called before the first frame update
    void Start()
    {
        GameObject gm = GameObject.FindGameObjectWithTag("go");
        if(gm != null)
        {
            logicScript = gm.GetComponent<movement>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        logicScript.fuel = 1;
        Destroy(gameObject);
    }
}