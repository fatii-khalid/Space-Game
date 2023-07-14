using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public int s=0;
    public Text scoreText;
    public Image image;
    public GameObject gameoverscreen;
    public GameObject rocket;
    public movement r;

    public void Start()
    {
        r = GetComponent<movement>();
    }

    public void addScore()
    {
        s += 1;
        scoreText.text = s.ToString();
    }

    public void rocketDestroyed()
    {
        gameoverscreen.SetActive(true);
        if (rocket != null)
        {
            rocket.SetActive(false);
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void fillfuel()
    {
        r.fuel = 1;
    }
}