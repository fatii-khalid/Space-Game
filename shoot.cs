using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position +=  transform.up * 7 * Time.deltaTime;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}