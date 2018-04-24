using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoManager : MonoBehaviour
{
    public static int ammo;


    Text text;


    void Awake()
    {
        text = GetComponent<Text>();
        ammo = PlayerShooting.ammo;
    }


    void Update()
    {
        text.text = "Ammo: " + ammo + "/30";
    }
}

