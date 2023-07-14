using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnshoot : MonoBehaviour
{
    public float followSpeed = 2f;
    public float yoffset = 1f;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Vector3 newpos = new Vector3(target.position.x, target.position.y + yoffset, -10f);
            transform.position = Vector3.Slerp(transform.position, newpos, followSpeed * Time.deltaTime);
        }
    }
}