﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stage3GameOver : MonoBehaviour
{
    GameObject player;
    public GameObject GameOverCanvas;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
       
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y == -20)
        {
            GameOverCanvas.SetActive(true);
            StartCoroutine("Gameoover");
        }
    }

    private IEnumerator Gameoover()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("StageChoice");
    }
   

    }