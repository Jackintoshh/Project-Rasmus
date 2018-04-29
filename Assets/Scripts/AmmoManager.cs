using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoManager : MonoBehaviour
{
    public int ammo;


    Text text;
    GameObject player;
    int maxAmmo = 30;
    int currentAmmo = 0;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        text = GetComponent<Text>();
        ammo = PlayerShooting.ammo;
    }


    void Update()
    {
        ammo = PlayerShooting.ammo;
        text.text = "Ammo: " + ammo;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            /*if (ammo < 30)
            {
                currentAmmo = maxAmmo - ammo;

                for (int i = 0; i < currentAmmo; i++)
                {
                */
            PlayerShooting.ammo += maxAmmo;
              //  }
                Destroy(gameObject);
            //}
        }
       
    }
}

