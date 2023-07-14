using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour
{
    public GameObject rocket;
    public movement logicScript;
    public float speed = 2;
    public score logicScript2;

    // Start is called before the first frame update
    void Start()
    {
        logicScript2 = GameObject.FindGameObjectWithTag("logic").GetComponent<score>();
        GameObject gm = GameObject.FindGameObjectWithTag("go");
        if (gm != null)
        {
            logicScript = gm.GetComponent<movement>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (logicScript != null)
        {
            Vector2 v = new Vector2(logicScript.gameObject.transform.position.x + 1.583f, logicScript.gameObject.transform.position.y - 2.416f);
            transform.position = Vector3.MoveTowards(transform.position, v, speed * Time.deltaTime);
        }
        if (logicScript == null)
        {
            logicScript2.rocketDestroyed();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
        if (logicScript != null)
        {
            logicScript2.addScore();
        } 
    }
}