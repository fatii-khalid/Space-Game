using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
    public float speed = 3;
    //GameObject go;
    float limit = 10;
    public score logicScript;
    public movement logicScript2;
    public float destroyspeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("logic").GetComponent<score>();
        GameObject gm = GameObject.FindGameObjectWithTag("go");
        if (gm != null)
        {
            logicScript2 = gm.GetComponent<movement>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.up * speed * Time.deltaTime;
        if (transform.position.y > limit)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        speed = 0;
        Destroy(gameObject, destroyspeed);
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        speed = 3;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //logicScript.addScore();
        logicScript2.fuel = 1;
    }
}