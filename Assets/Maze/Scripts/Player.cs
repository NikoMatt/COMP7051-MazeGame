﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    private bool toggle = true;
    public static int winCondition = 0;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() { 
        if (Input.GetButton("Phase"))
            toggle = !toggle;

        if (toggle)
            gameObject.layer = 9;
        else
            gameObject.layer = 10;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Enemy.loseCondition++;
            SceneManager.LoadScene(0);
        }

        if (collision.gameObject.tag == "Goal")
        {
            winCondition++;
            SceneManager.LoadScene(0);
            Debug.Log("Hit Hit Hit");
        }
    }
}