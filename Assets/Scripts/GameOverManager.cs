﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    


    Animator anim;
    


    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");

            

            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(1);
            }
            
            
        }
    }
}
