using GameJolt.UI;
using GameJolt.API;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class trophiejugar : MonoBehaviour
{
    void Awake()
    {
        Trophies.TryUnlock(216228);
    }
}

