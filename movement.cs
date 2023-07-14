using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
    public Image image;
    public float fallSpeed = 5;
    public float moveSpeed = 5;
    public Rigidbody2D rb;
    private bool rkp;
    private bool lkp;
    public float rs = 300;
    public score logicScript;
    public GameObject fire;
    public GameObject fire2;
    public bool rocketMove;
    public float fuel = 1;
    public float fuelconsumption = 0.1f;
    private float moveup;
    private float movedown;
    public GameObject prefab;
    public Transform launchoffset;
    public Transform launchoffset2;
    private bool firing = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        logicScript = GameObject.FindGameObjectWithTag("logic").GetComponent<score>();
        rocketMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        image.fillAmount = fuel;
        if (Input.GetKeyDown(KeyCode.RightArrow) && rocketMove && fuel>0)
        {
            rkp = true;
            transform.Rotate(new Vector3(0, 0, 1), rs * Time.deltaTime);
            rb.velocity = transform.up * moveSpeed;
            fire.SetActive(true);
            fuel = fuel - fuelconsumption * Time.fixedDeltaTime;
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow) && rocketMove && fuel > 0)
        {
             rkp = false;
             fire.SetActive(false);
        }
        if (rkp && rocketMove && fuel > 0)
        {
            transform.Rotate(new Vector3(0, 0, 1), rs * Time.deltaTime);
            rb.velocity = transform.up * moveSpeed;
            fire.SetActive(true);
            fuel = fuel - fuelconsumption * Time.fixedDeltaTime;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && rocketMove && fuel > 0)
        {
            lkp = true;
            transform.Rotate(new Vector3(0, 0, 1), -rs * Time.deltaTime);
            rb.velocity = transform.up * moveSpeed;
            fire2.SetActive(true);
            fuel = fuel - fuelconsumption * Time.fixedDeltaTime;
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow) && rocketMove && fuel > 0)
        {
            lkp = false;
            fire2.SetActive(false);
        }
        if (lkp && rocketMove && fuel > 0)
        {
            transform.Rotate(new Vector3(0, 0, 1), -rs * Time.deltaTime);
            rb.velocity = transform.up * moveSpeed;
            fire2.SetActive(true);
            fuel = fuel - fuelconsumption * Time.fixedDeltaTime;
        }
       
        moveup = Input.GetAxis("Vertical");
        movedown = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            firing = true;
        }
        else
        {
            firing = false;
        }
        if (firing)
        {
            Instantiate(prefab, launchoffset.position, transform.rotation);
            Instantiate(prefab, launchoffset2.position, transform.rotation);
        }

    }
    
}