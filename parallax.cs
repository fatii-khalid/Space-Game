using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    public Transform objectToFollow;
    public float movementSpeed = 0.5f;

    private Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (objectToFollow != null)
        {
            Vector3 offset = (objectToFollow.position - initialPosition) * movementSpeed;
            transform.position = initialPosition - offset;
        }
        
    }
}